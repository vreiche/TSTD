using UnityEngine;
using System.Collections;

public class NextScene : MonoBehaviour {

	public int level;
	protected string currentLevel;
	protected int worldIndex;
	protected int levelIndex;



	void OnTriggerEnter2D(Collider2D other) {
		//This if statement is so that enemies do not trigger the event. 
		//We could easily add a destroy enemies line here also if we want the fire to kill them.
		if (other.gameObject.name== "Player") {	
		
			Application.LoadLevel(level);
		UnlockLevels();   //unlock next level funxtion
		}
	}
	protected void  UnlockLevels (){
		//set the playerprefs value of next level to 1 to unlock
		for(int i = 0; i < LockLevel.worlds; i++){
			for(int j = 1; j < LockLevel.levels; j++){               
				if(currentLevel == "Level"+(i+1).ToString() +"." +j.ToString()){
					worldIndex  = (i+1);
					levelIndex  = (j+1);
					PlayerPrefs.SetInt("level"+worldIndex.ToString() +":" +levelIndex.ToString(),1);
				}
			}
		}
	}
	public void NextLevelButton(int index)
	{
		Application.LoadLevel(1);
		UnlockLevels();   //unlock next level funxtion
	}
}
