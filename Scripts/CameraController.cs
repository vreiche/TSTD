using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;
	public static bool zoomIn;
	public Camera camera;

	
	
	// Use this for initialization
	void Start () {
		zoomIn = false;

		offset = transform.position; 
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}

	public static void zoomFunction()
	{
		if (zoomIn == true) 
		{
			Camera.current.depth.Equals(60);
			Camera.current.fieldOfView.Equals(60);
			
			zoomIn = false;
		}


		if (zoomIn == false) 
		{
			Camera.current.depth.Equals(0);
			Camera.current.fieldOfView.Equals(0);
			
			zoomIn = true;
		}
	}
}
