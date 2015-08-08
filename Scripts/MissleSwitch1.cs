using UnityEngine;
using System.Collections;

public class MissleSwitch : MonoBehaviour {
	public GameObject Clone;
	public bool clonecall;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		if (clonecall == true && Input.GetKeyDown ("f")) {

			Instantiate(Clone,new Vector2 (transform.position.x, transform.position.y), Quaternion.identity);
			clonecall = false;
			StartCoroutine(wait());
		

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



IEnumerator wait() {
	print(Time.time);
	yield return new WaitForSeconds(3);
	print(Time.time);
		clonecall = true;
}

}
