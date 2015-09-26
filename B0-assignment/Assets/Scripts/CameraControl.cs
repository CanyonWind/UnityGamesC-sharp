using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CameraControl : MonoBehaviour {

	public GameObject p1;
	public GameObject p2;
	public int Limited_seconds;
	public Text Timer;
	public Text winText;

	private Vector3 offset;
	private float startTime;
	private float Still_have;

	// Use this for initialization
	void Start () {
		offset = transform.position - (p1.transform.position+p2.transform.position)/2;
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = (p1.transform.position+p2.transform.position)/2 + offset;
	}

	void Update()
	{
		float guiTime = Time.time - startTime;
		Still_have = Limited_seconds - (int) guiTime;
		if (Still_have >= 0) {
			int minutes_S = (int)Mathf.Floor ((int)Still_have / 60);
			int seconds_S = (int)Still_have % 60;
			string text = System.String.Format ("Time Left: {0:00}:{1:00}", minutes_S, seconds_S);
			Timer.text = text;

			if (Still_have < 10) {
				Timer.color = Color.red;
			}
		} else {
			winText.text = "Time Up";
			Timer.text = "Time Left: 00:00";
			Time.timeScale = 0;
		}
		if (Time.timeScale == 0) {
			// camera rotation
		}
	}
}
