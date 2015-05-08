using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class jump : MonoBehaviour {
	
	public AudioClip jumping;
	public GameObject gameover;
	public AudioClip over;
	public AudioClip point_effect;
	//public AudioClip backsound;
	// Use this for initialization
	public static bool game_over=false;
	
	public Text score;
	void Start () {
		score.text = "0";
	}
	
	// Update is called once per frame
	void Update () {
		if (!game_over) {
			if (Input.GetKey (KeyCode.Space)) {
				audio.clip = jumping;
				audio.Play ();
				GetComponent<Rigidbody> ().velocity = Vector3.zero;
				GetComponent<Rigidbody> ().AddForce (Vector3.up * 300);
			}
			if (Input.GetKey (KeyCode.RightArrow)) {
				//audio.clip = move;
				//audio.Play();
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
		
		if (other.gameObject.tag == "point") {
			audio.clip = point_effect;//music over mulai
			audio.Play();
			int point = int.Parse (score.text) + 10;
			score.text = point.ToString ();
			Destroy (other.gameObject);

		}
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
