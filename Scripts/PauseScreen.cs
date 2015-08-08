/*using UnityEngine;
using System.Collections;

public class PauseScreen : MonoBehaviour {
	//refrence for the pause menu panel in the hierarchy
	public GameObject pauseMenuPanel;
	//animator reference
	private Animator anim;
	//variable for checking if the game is paused 
	private bool isPaused = false;
	// Use this for initialization
	bool isLocked;

	void Start () {

		//unpause the game on start
		Time.timeScale = 1;
		//get the animator component
		anim = pauseMenuPanel.GetComponent<Animator>();
		//disable it on start to stop it from playing the default animation
		anim.enabled = false;
	}
	
	// Update is called once per frame
	public void Update () {
		//pause the game on escape key press and when the game is not already paused
		if(Input.GetKeyUp(KeyCode.Escape) && !isPaused){
			PauseGame();

		}

		//unpause the game if its paused and the escape key is pressed
		else if(Input.GetKeyUp(KeyCode.Escape) && isPaused){
			UnpauseGame();


		}
	}

	
	//function to pause the game
	public void PauseGame(){
		//enable the animator component
		anim.enabled = true;
		//play the Slidein animation
		anim.Play("PauseMenu");
		//set the isPaused flag to true to indicate that the game is paused
		isPaused = true;
		//freeze the timescale
		Time.timeScale = 0;

	}
	//function to unpause the game
	public void UnpauseGame(){
		//set the isPaused flag to false to indicate that the game is not paused
		isPaused = false;
		//play the SlideOut animation
		anim.Play("PauseMenu 0");
		//set back the time scale to normal time scale
		Time.timeScale = 1;

	}

		
		//Make Change Graphics Quality button
	/*	if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2, 250, 50), "Change Graphics Quality"))
		{
			
			if (showGraphicsDropDown == false)
				showGraphicsDropDown = true;
			else
				showGraphicsDropDown = false;
		}
		
		//Create the Graphics settings buttons, these won't show automatically, they will be called when
		//the user clicks on the "Change Graphics Quality" Button, and then dissapear when they click on it again...
		if (showGraphicsDropDown == true)
		{
			if (GUI.Button(new Rect(Screen.width / 2 + 150, Screen.height / 2, 250, 50), "Fastest"))
				QualitySettings.SetQualityLevel(0);
			if (GUI.Button(new Rect(Screen.width / 2 + 150, Screen.height / 2 + 50, 250, 50), "Fast"))
				QualitySettings.SetQualityLevel(1);
			if (GUI.Button(new Rect(Screen.width / 2 + 150, Screen.height / 2 + 100, 250, 50), "Simple"))
				QualitySettings.SetQualityLevel(2);
			if (GUI.Button(new Rect(Screen.width / 2 + 150, Screen.height / 2 + 150, 250, 50), "Good"))
				QualitySettings.SetQualityLevel(3);
			if (GUI.Button(new Rect(Screen.width / 2 + 150, Screen.height / 2 + 200, 250, 50), "Beautiful"))
				QualitySettings.SetQualityLevel(4);
			if (GUI.Button(new Rect(Screen.width / 2 + 150, Screen.height / 2 + 250, 250, 50), "Fantastic"))
				QualitySettings.SetQualityLevel(5);
			
			if (Input.GetKeyDown(KeyCode.Escape))
				showGraphicsDropDown = false;
		}
		
		//Make quit game button
		if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 50, 250, 50), "Quit Game"))
			Application.Quit();*/
		
	

