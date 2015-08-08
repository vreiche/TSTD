using UnityEngine;
using System.Collections;

public class CloningOutput : MonoBehaviour {
	public GameObject Clone;
	public bool clonecall;
	private int cloneCount;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		if (clonecall == true && Input.GetKeyDown ("f") && cloneCount == 0) {

			Instantiate(Clone,new Vector2 (transform.position.x, transform.position.y -2), Quaternion.identity);
			cloneCount++;

				}
	}


	void OnTriggerEnter2D(Collider2D other) {
		//Destroy player on collision
		if (other.gameObject.tag == ("Player")) {	

						Debug.Log ("Called for clone");
						clonecall = true;
				}
	}



	void OnTriggerExit2D(Collider2D other) {
		//Destroy player on collision
		if (other.gameObject.tag == ("Player")) {	
			
						Debug.Log ("Clonecall false");
						clonecall = false;
				}
		
	}

}
