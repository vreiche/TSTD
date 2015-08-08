using UnityEngine;
using System.Collections;


public class keyScript : MonoBehaviour {

	public GameObject Door;
	void OnTriggerEnter2D(Collider2D collider){
		if(collider.gameObject.name == "Player"){
			Destroy (gameObject);
			Door.SetActive(false);
		}
	}

}
