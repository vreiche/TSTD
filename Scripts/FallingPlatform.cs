using UnityEngine;
using System.Collections;

public class FallingPlatform : MonoBehaviour {
	bool isFalling = false;
	float downSpeed = 0;
	void OnTriggerEnter2D(Collider2D collider)
	{
		if(collider.gameObject.name == "Player")
		{
		
			isFalling = true;
				Destroy(gameObject, 10);
			
		}
	}
	void Update()
	{
		if (isFalling)
		{
			downSpeed += Time.deltaTime/30;
			transform.position = new Vector2(transform.position.x,transform.position.y - downSpeed);
		}
	}
}

