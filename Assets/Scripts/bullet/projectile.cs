using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    private string nameHit;
    private Rigidbody _rigidbody;

    private InsertShot insert;

    private Vector3 beginPos;
    private Vector3 endPos;
    private Vector3[] official;
    private SphereCollider _collider;

    void Awake()
    {
        insert = new InsertShot();
        beginPos = transform.position;
        _rigidbody = GetComponent<Rigidbody>();
        _collider = GetComponent<SphereCollider>();
        official = GetPositions();
        Destroy(gameObject, 2f);
    }

    void FixedUpdate()
    {
        Vector3 velocity = transform.forward * _speed * Time.fixedDeltaTime;
        _rigidbody.MovePosition(_rigidbody.position + velocity);
        endPos = transform.position;
       
    }

    private void OnCollisionEnter(Collision collide)
    {
        nameHit = collide.gameObject.name;
        endPos = transform.position;
        StartCoroutine(insert.DoPHP(nameHit,beginPos,endPos,transform.rotation.eulerAngles,12345,gameObject));
    }

    public Vector3[] GetPositions()
    {
        Vector3[] positions = new Vector3[2];
        positions[0] = beginPos;
        positions[1] = endPos;
        return positions;
    }
}