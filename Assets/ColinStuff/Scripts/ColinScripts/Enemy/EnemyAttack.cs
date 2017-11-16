using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

    private VariableData data;

    void Start()
    {
        data = FindObjectOfType<VariableData>();
    }

    // Update is called once per frame
    void Update () {
        Ray ray = new Ray(this.transform.position, this.transform.forward);
        RaycastHit hit;
        Debug.DrawRay(ray.origin, ray.direction, Color.red);

        if (Physics.Raycast(ray, out hit, 1f))
        {
            if (hit.collider.gameObject.tag == "Player")
            {
                hit.collider.GetComponent<PlayerHealth>().LoseHealth(data.GetEnemyDamage());
            }
        }
    }
}
