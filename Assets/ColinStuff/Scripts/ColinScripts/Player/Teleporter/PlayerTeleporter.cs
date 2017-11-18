using UnityEngine;
using System.Collections;

public class PlayerTeleporter : MonoBehaviour {
	public Transform target;
    private TimerCountDown timer;

    void  Start (){
        timer = FindObjectOfType<TimerCountDown>();
    }

	void  OnTriggerEnter ( Collider col  ){

		if(col.gameObject.tag == "teleport") {
            timer.currentTime = 0;
			this.transform.position = target.position;
		}
	}
}