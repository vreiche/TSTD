using UnityEngine;
using System.Collections;
public class Boss : MonoBehaviour {
	public Transform target;
	public int moveSpeed;
	public int rotationSpeed;
	private bool withinrange;
	public float jump;
	public bool pingPong;
	public float leftKnockback;
	public float upKnockback;

	public Color colorA;
	public Color colorB;
	public float colorChangeSpeed;
	public Material colorMaterial;

	public int waitNum;
	public int health;
	private GameObject gate;

	//public int maxDistance;
	private Transform myTransform;
	void Awake() {
		myTransform = transform;
	}
	// Use this for initialization
	void Start () {
		gate = GameObject.Find("Gate");
		health = 100;
		GameObject go = GameObject.FindGameObjectWithTag("Player");
		target = go.transform;
		pingPong = false;
		//withinrange = false;
		//maxDistance = 2;
	}

	void Update () 
	{
		if (pingPong == true) {
			Color color = Color.Lerp (colorA, colorB, Mathf.PingPong (Time.time * colorChangeSpeed, 1));
			colorMaterial.SetColor ("_Color", color);
		}
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

	void OnTriggerEnter2D(Collider2D other) {
		//Destroy player on collision
		if (other.gameObject.tag == "Player") {
			withinrange = true;
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		//Destroy player on collision
		if (coll.gameObject.tag == "Missle") {
			health = health - 25;
			pingPong = true;
			StartCoroutine(wait ());
			GetComponent<Rigidbody2D>().AddForce(new Vector2(leftKnockback, upKnockback), ForceMode2D.Impulse);
		}
		if (health <= 0) 
		{
			Destroy(gameObject);
			Destroy (gate);
		}
	}

	IEnumerator wait() {

			print (Time.time);
			yield return new WaitForSeconds (1);
			print (Time.time);
			pingPong=false;
		}
	}





