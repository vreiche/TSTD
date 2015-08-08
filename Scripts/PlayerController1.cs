using UnityEngine;
using System.Collections;

public class PlayerController1 : MonoBehaviour {


	//public GUIText countText;
	public float jump;
	public float speed;
	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	public bool moveLeft;
	public bool MoveRight;
	
	void Start () {
		moveLeft = false;
		MoveRight = false;
	}

	public void goRight () {
		MoveRight = true;
		moveLeft = false;
		GetComponent<Rigidbody2D>().AddForce(new Vector2(speed * Time.deltaTime, 0));
		}

	public void goLeft () {
		moveLeft = true;
		MoveRight = false;
		transform.Translate (Vector2.right * -speed * Time.deltaTime);
		}

	void Update () {
		if (Input.GetKeyDown ("right")) {
			goRight ();
					
			}

		if (Input.GetKeyDown ("left")) {
			goLeft ();
			
//			rigidbody2D.AddForce(new Vector2(-5, 0), ForceMode2D.Impulse);
//			transform.Translate (Vector2.right * -speed * Time.deltaTime);
		}

		if (Input.GetKeyDown ("space")){
			Jump();		
				
			}
	}
		public void Jump()
		{
			if(grounded)
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
		}


	void FixedUpdate(){

		grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
		}

	void OnCollisionEnter2D(Collision2D other) {
		//Destroy player on collision
		if (other.gameObject.tag == "Enemy") {	
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
