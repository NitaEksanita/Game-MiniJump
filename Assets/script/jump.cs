using UnityEngine;
using System.Collections;

public class jump : MonoBehaviour {
<<<<<<< HEAD

	public AudioClip jumping;
	public GameObject gameover;
	public AudioClip over;
	// Use this for initialization
	public static bool game_over=false;


	
	// Update is called once per frame
	void Update () {
		if (!game_over) {
			if (Input.GetKey (KeyCode.Space)) {
				audio.clip = jumping;
				audio.Play ();
				GetComponent<Rigidbody> ().velocity = Vector3.zero;
				GetComponent<Rigidbody> ().AddForce (Vector3.up * 400);
			}
			if (Input.GetKey (KeyCode.RightArrow)) {

				GetComponent<Rigidbody> ().velocity = Vector3.zero;
				GetComponent<Rigidbody> ().AddForce (Vector3.right * 200);
			}
			if (Input.GetKey (KeyCode.LeftArrow)) {

				GetComponent<Rigidbody> ().velocity = Vector3.zero;
				GetComponent<Rigidbody> ().AddForce (Vector3.left * 200);
			}
		}
	}
	void OnCollisionEnter (Collision other){
		//tersentuh
		if (other.gameObject.tag == "plane")
			other.gameObject.audio.Play ();


		if (other.gameObject.tag == "over") {//jika gameover
			GameObject offer = Instantiate (gameover) as GameObject;

			GameObject.Find("bg2").audio.Stop();//gameover stop backsound
			audio.clip = over;//music over mulai
			audio.Play();

			game_over=true;//berhenti saat game over
		}
	}
	void OnCollisionExit (Collision other){
		//tdk tersentuh
		if (other.gameObject.tag == "plane" && Input.GetKeyDown (KeyCode.Space))
		other.gameObject.audio.Stop();
		
	}
	
}
=======
	
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
>>>>>>> 2b4569aa9a886ca6040c920188e59bbfd373be25
