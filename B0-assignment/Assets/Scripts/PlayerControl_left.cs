using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerControl_left: MonoBehaviour {
	
	public float speed;
	public Text countText;
	public Text winText;
	public float jump;
	
	private int count;
	private int jumpTimes = 0;
	private bool start_move = true;
	
	void Start ()
	{
		count = 0;
		SetCountText (); 
		winText.text = "";
	}
	
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.LeftShift) & jumpTimes<=1 & start_move)
		{
			this.GetComponent<Rigidbody>().AddForce(new Vector3(0, jump, 0));
			jumpTimes = jumpTimes + 1;
		}
		if (Input.GetKey (KeyCode.W))
		{
			this.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, speed));
		}
		if (Input.GetKey (KeyCode.A))
		{
			this.GetComponent<Rigidbody>().AddForce(new Vector3(-speed, 0, 0));
		}      
		if (Input.GetKey (KeyCode.S))
		{      
			this.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -speed)); 
		}
		
		if (Input.GetKey (KeyCode.D))
		{     
			this.GetComponent<Rigidbody>().AddForce(new Vector3(speed, 0, 0));  
		}

		SetCountText ();
	}
	
	void FixedUpdate () 
	{
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Pick Up")) 
		{
			other.gameObject.SetActive (false);
			count = count + 10; 
 
		}
	}
	
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag ("Ground")) {
			jumpTimes = 0;
		}
		if (other.gameObject.CompareTag ("P2")) {
			bool higher = (this.transform.position.y > other.gameObject.transform.position.y);
			if (higher) 
			{count = count +1;
			}
			else count = count - 1;
		}
		if (other.gameObject.CompareTag ("Wall")) {
			count = count - 1;
		}
	}
	
	void SetCountText ()
	{
		countText.text = "Minimon 1: " + count.ToString ();
		if (count >= 10000)
			winText.text = "Minimon1 Win!";
		if (this.transform.position.y < -10) {
			winText.text = "Minimon 2 Win!";
		}
	}
	
}