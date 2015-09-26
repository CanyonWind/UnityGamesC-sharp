using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Button : MonoBehaviour {

//	public Button playButton;
//	public Button resetButton;

	void Start(){
		Time.timeScale = 0;
//		playButton = playButton.GetComponent<Button> ();
//		resetButton = resetButton.GetComponent<Button> ();
	}
	public void playgame () {
		Time.timeScale = 1;
		this.enabled = false;
	}
	public void reset(){
		Application.LoadLevel("MainScene");
	}

}
