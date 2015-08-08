//using UnityEngine;
//using System.Collections;
//
//public class TouchableL : MonoBehaviour {
//
//
//	// Update is called once per frame
//	void Update () {
//				
//				if (Input.touchCount == 1) {
//			
//						Vector3 wp = Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position);
//						Vector2 touchPos = new Vector2 (wp.x, wp.y);
//						if (collider2D == Physics2D.OverlapPoint (touchPos)) {
//								PlayerController1.goLeft ();
//								//Debug.Log ("Touched Left");
//
//						}
//				}
//
//				if (Input.touchCount == 0) {
//
//						PlayerController1.moveLeft = false;
//				}
//		}
//
//	void FixedUpdate(){
//
//	}
//			}