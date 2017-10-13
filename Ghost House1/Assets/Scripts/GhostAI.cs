using UnityEngine;
using System.Collections;

public class GhostAI : MonoBehaviour {

	public float moveSpeed;
	public Transform target;
	public int damage;

	void OnTriggerStay(Collider other)
	{
		if(other.gameObject.name == "Player")
		{
			// Ghost looks at player
			transform.LookAt(target);
			// Ghost moves towards player
			transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
		}
	}


	// Use this for initialization
	//void Start () {
	
	//}
	
	// Update is called once per frame
	//void Update () {
	
	//}
}
