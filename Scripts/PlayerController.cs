using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed = 10, jumpVelocity = 10;
	public LayerMask playerMask;
	Transform myTrans, tagGround;
	Rigidbody2D myBody;

	public bool isGrounded = false;
	float hInput = 0;
	
	void Start ()
	{
		myBody = this.GetComponent<Rigidbody2D>();
		myTrans = this.transform;
		tagGround = GameObject.Find (this.name + "/GroundCheck").transform;
	}
	
	void FixedUpdate ()
	{
		isGrounded = Physics2D.Linecast (myTrans.position, tagGround.position, playerMask);
		
		//#if !UNITY_ANDROID && !UNITY_IPHONE && !UNITY_BLACKBERRY && !UNITY_WINRT
		Move(Input.GetAxisRaw("Horizontal"));
		if(Input.GetButtonDown("Jump"))
			Jump();
		//#else
		//Move (hInput);
		//#endif
	}
	void Move(float horizontalInput)
	{	   
		if(!isGrounded)
			return;
		
		Vector2 moveVel = myBody.velocity;
		moveVel.x = horizontalInput * speed;
		myBody.velocity = moveVel;
	}
	
	public void Jump()
	{
		if(isGrounded)
			myBody.velocity += jumpVelocity * Vector2.up;
	}
	public void StartMoving(float horizontalInput)
	{
		hInput = horizontalInput;
	}
}
