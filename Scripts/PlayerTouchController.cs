using UnityEngine;
using System.Collections;

public class PlayerTouchController : MonoBehaviour {
	//public GUIText countText;
	public float jump;
	public float speed;
	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;
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
	
	void Update () {
		
		
		if (grounded && Input.GetKeyDown ("space")){
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
			//Debug.Log ("grounded/jump");
		}
	}
	
	void FixedUpdate(){
		//why not use Physics2D.OverlapArea? it uses square dimensions
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		
		float moveHorizontal = Input.GetAxis ("Horizontal");
		
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, 0.0f);
		
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
}