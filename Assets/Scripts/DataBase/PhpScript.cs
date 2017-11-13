using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhpScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(DoPHP());
	}

    IEnumerator DoPHP()
    {
        WWW request = new WWW("http://22950.hosts.ma-cloud.nl/bewijzenmap/unityphp/phpscript.php?pos=[15,224,352]&playerID=25");
        yield return request;
        Debug.Log("Request returned");
    }
}
