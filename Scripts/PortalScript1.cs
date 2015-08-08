using UnityEngine;
using System.Collections;

public class PortalScript : MonoBehaviour 
{

	public int code;
	public float yposition;

	void Update()
	{

	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject.name == "Player");
		foreach(PortalScript tp in FindObjectsOfType<PortalScript>())
		{
			if(tp.code==code && tp != this)
			{
				Vector2 position=tp.gameObject.transform.position;
				position.y=yposition;
				collider.gameObject.transform.position=position;

			}

		}
	}
}

