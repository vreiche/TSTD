﻿using UnityEngine;
using System.Collections;

public class ButtonNextLevel : MonoBehaviour {

	public void NextLevelButton(int index)
	{
		Application.LoadLevel(index);
	}
	
	public void NextLevelButton(string levelName)
	{
		Application.LoadLevel(levelName);
	}
	public void Quit() {
	Application.Quit();
	}

	public void MoreMoney(){
		GameControl.control.money += 10;
	}
}