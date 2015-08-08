using UnityEngine;
using System.Collections;

public class PlayerControllerOld2 : MonoBehaviour {
	//public GUIText countText;
	public float jump;
	public float speed;
	static bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	float hInput = 0;
	//private Animator anim;

	//public float money;
	//public float moneyInAccount;

	//Counting coin pickup, Translating to money.
	/*void Start(){
		SetCountText ();
	}

	void OnTriggerEnter(Collider other) {
		
		if(other.gameObject.tag == "PickUp") {
			other.gameObject.SetActive(false);
			moneyInAccount = moneyInAccount + 1;
			SetCountText ();
		}
	}
	
	void SetCountText () {
		countText.text = "Money: " + moneyInAccount.ToString ();

	}*/
	void Start () {
		//anim = GetComponent<Animator>();
		
	}
	void Update () {
					
		if (grounded && Input.GetKeyDown ("space")){
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
		}

			//Debug.Log ("grounded/jump");

	
}

	void FixedUpdate(){



		grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

		float moveHorizontal = Input.GetAxis ("Horizontal");

		
		Vector2 movement = new Vector2 (moveHorizontal,0.0f);
										//movement *
		GetComponent<Rigidbody2D>().AddRelativeForce (movement * speed * Time.deltaTime);
		//rigidbody2D.velocity = (movement * speed * Time.deltaTime);
		//transform.Translate(Input.acceleration.x, 0.0f, Input.acceleration.z);
	}

	void OnCollisionEnter2D(Collision2D other) {
		//Destroy player on collision
		if (other.gameObject.tag == "Enemy") {	
			Application.LoadLevel(Application.loadedLevel);
		}
	}

	void OnTriggerEnter2D(Collider2D other2) {
		//Destroy player on collision
		if (other2.gameObject.tag == "ZoomTrigger") {	
			CameraController.zoomFunction();
		}
	}

}
