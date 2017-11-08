using UnityEngine;
using System.Collections;

public class GhostStun : MonoBehaviour {

	bool lightCheck;
	Flashlight flash;
	public GameObject ghost;

	// Use this for initialization
	void Start () {
		//lightCheck = GetComponent<Flashlight>().lightOn;
		flash =  gameObject.GetComponentInChildren<light>().GetComponentInChildren<Flashlight>();

		print("Obj:"+flash);
		flash.setLightOn();
		print("Start"+flash.isLightOn());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		print(other.gameObject.name);
		print("Collider" + flash);

		if (other.gameObject.name == "Ghost" && flash == true){
			print("Ghost is stunned!");


			other.GetComponent<GhostAI>().moveSpeed = 0f;
			StartCoroutine(Wait(5));

		}


	}

	IEnumerator Wait(float time){
		yield return new waitForSeconds(time);
		ghost.GetComponent<GhostAI>().moveSpeed = 5f;
		print("Ghost is unstunned");
	}

}
