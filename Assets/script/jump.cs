using UnityEngine;
using System.Collections;

public class jump : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<Rigidbody> ().velocity = Vector3.zero;
			GetComponent<Rigidbody> ().AddForce (Vector3.up*300);
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			GetComponent<Rigidbody> ().velocity = Vector3.zero;
			GetComponent<Rigidbody> ().AddForce (Vector3.right*200);
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			GetComponent<Rigidbody> ().velocity = Vector3.zero;
			GetComponent<Rigidbody> ().AddForce (Vector3.left*200);
		}
	}
}