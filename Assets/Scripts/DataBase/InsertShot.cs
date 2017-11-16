using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsertShot : MonoBehaviour {

    public IEnumerator DoPHP(string obj_name,Vector3 beg, Vector3 end, Vector3 rot,int playerID,GameObject bullet)
    {
        WWW request = new WWW("http://22545.hosts.ma-cloud.nl/bewijzenmap/p2.1/gpr/dataBaseScripts/insert.php?" +
            "obj" + obj_name +
            "posxbeg=" + beg.x.ToString() +
            "&posybeg=" + beg.y.ToString() +
            "&poszbeg=" + beg.z.ToString() +
            "&posxend=" + end.x.ToString() +
            "&posyend=" + end.y.ToString() +
            "&poszend=" + end.z.ToString() +
            "&rotx=" + rot.x.ToString() +
            "&roty=" + rot.y.ToString() +
            "&rotz=" + rot.z.ToString() +
            "&player_id=" + playerID.ToString());
        yield return request;
        Debug.Log("shot inserted");
        Destroy(bullet);
    }
}
