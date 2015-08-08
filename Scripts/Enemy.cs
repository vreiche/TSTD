using UnityEngine;
using System.Collections;
public class Enemy : MonoBehaviour {
	public Transform target;
	public int moveSpeed;
	public int rotationSpeed;
	private bool withinrange;

	//public int maxDistance;
	private Transform myTransform;
	void Awake() {
		myTransform = transform;
	}
	// Use this for initialization
	void Start () {
		GameObject go = GameObject.FindGameObjectWithTag("Player");
		target = go.transform;
		//withinrange = false;
		//maxDistance = 2;
	}
	// Update is called once per frame
	void FixedUpdate () {
		Debug.DrawLine(target.position, myTransform.position, Color.yellow);
		//Look at target
		//Move towards target



		//if (withinrange == true && target.position.x < myTransform.position.x) myTransform.position -= myTransform.right * moveSpeed * Time.deltaTime; // player is left of enemy, move left
		//else if (withinrange == true && target.position.x > myTransform.position.x) myTransform.position += myTransform.right * moveSpeed * Time.deltaTime; // player is right of enemy, move rig
		if (target.position.x < myTransform.position.x) myTransform.position -= myTransform.right * moveSpeed * Time.deltaTime; // player is left of enemy, move left
		else if (target.position.x > myTransform.position.x) myTransform.position += myTransform.right * moveSpeed * Time.deltaTime; // player is right of enemy, move rig
	}

	/*void OnTriggerEnter2D(Collider2D other) {
		//Destroy player on collision
		if (other.gameObject.tag == "Player") {
			withinrange = true;
		}
	}


	void OnTriggerExit2D(Collider2D other) {
		//Destroy player on collision
		if (other.gameObject.tag == "Player") {
			withinrange = false;
		}
	}
*/

}
