using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {

	public static GameControl control;
	
	public float money;
	
	
	// Use this for initialization
	void Awake () {
		if(control == null)
		{
			DontDestroyOnLoad(gameObject);
			control = this;
		}
		else if(control != this)
		{
			Destroy (gameObject);
		}
	}
	

	void OnGui(){
		GUI.Label(new Rect(10,10,100,30), "Money: " + money);
	}

}
