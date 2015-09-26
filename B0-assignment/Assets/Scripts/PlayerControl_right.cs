using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerControl_right : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text winText;
	public float jump;

	private int count;
	private Rigidbody rb;
	private int jumpTimes = 0;
	private bool start_move = true;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText (); 
		winText.text = "";
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.RightShift) & jumpTimes<=1 & start_move)
		{
			this.GetComponent<Rigidbody>().AddForce(new Vector3(0, jump, 0));
			jumpTimes = jumpTimes + 1;
		}
		SetCountText ();
	}

	void FixedUpdate () 
	{
		if (start_move) {
			float moveHorizontal = Input.GetAxis ("Horizontal");
			float moveVertical = Input.GetAxis ("Vertical");

			Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
			rb.AddForce (movement * speed);
		}
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
		if (other.gameObject.CompareTag ("P1")) {
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
		countText.text = "Minimon 2: " + count.ToString ();
		if (count >= 1000000)
			winText.text = "Minimon2 Win!";
		if (this.transform.position.y < -10) {
			winText.text = "Minimon 1 Win!";
		}
	}

}

