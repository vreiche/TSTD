using UnityEngine;
using System.Collections;
public class Companion2 : MonoBehaviour {
	public Transform target;
	public int moveSpeed;
	public int rotationSpeed;
	private Vector2 JumpForce = new Vector2 (0,800);


	//public int maxDistance;
	private Transform myTransform;
	void Awake() {
		myTransform = transform;
	}
	// Use this for initialization
	void Start () {
		GameObject go = GameObject.FindWithTag("Player");
		target = go.transform;
		//maxDistance = 2;
	}
	// Update is called once per frame
	void FixedUpdate () {



		Debug.DrawLine(target.position, myTransform.position, Color.yellow);
		//Look at target
		//Move towards target
		if (target.position.x < myTransform.position.x) myTransform.position -= myTransform.right * moveSpeed * Time.deltaTime; // player is left of enemy, move left
		else if (target.position.x > myTransform.position.x) myTransform.position += myTransform.right * moveSpeed * Time.deltaTime; // player is right of enemy, move rig

		if (target.position.y < myTransform.position.y) myTransform.position -= myTransform.up * moveSpeed * Time.deltaTime; // player is left of enemy, move left
		else if (target.position.y > myTransform.position.y) myTransform.position += myTransform.up * moveSpeed * Time.deltaTime; // player is right of enemy
}






	void OnTriggerEnter2D(Collider2D collider)
	{
		
		if (collider.gameObject.name == "Player")
			GetComponent<Rigidbody2D>().AddForce (JumpForce);
	}

}