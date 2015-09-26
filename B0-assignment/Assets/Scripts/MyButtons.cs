using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MyButtons : MonoBehaviour {

	public Button PlayButton;
	public Button PauseButton;
	public Button ExitButton;
	public Canvas PauseCanvas;


	void Start () {
		PauseCanvas = PauseCanvas.GetComponent<Canvas> ();
		PlayButton = PlayButton.GetComponent<Button> ();
		PauseButton = PauseButton.GetComponent<Button> ();
		ExitButton = ExitButton.GetComponent<Button> ();
		PauseCanvas.enabled = false;
	}

	public void playgame () {
		Time.timeScale = 1;
		PauseCanvas.enabled = false;
		PlayButton.enabled = false;
		PauseButton.enabled = true;
		ExitButton.enabled = true;
	}

	public void pausemage(){
		Time.timeScale = 0;
		PauseCanvas.enabled = true;
		PlayButton.enabled = true;
		PauseButton.enabled = false;
		ExitButton.enabled= true;
	}

	public void quitgame(){
		Application.Quit ();
		PauseCanvas.enabled = true;
		PlayButton.enabled = true;
		PauseButton.enabled = true;
		ExitButton.enabled = false;
	}
}
