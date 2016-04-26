using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RaftMove : MonoBehaviour 
{
	public float speed = 8f;
	static public bool rotate;
	public Text countText;
	public Text winText;

	private Rigidbody rb;
	private int count; 

	void Start()
	{

		rb = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText ();
		winText.text = "";
	}

	//Make player move and rotate
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.RightArrow) && rotate == true) 
			{
				transform.RotateAround (transform.position, transform.up, 90f);
				rotate = false;
			}
		if (Input.GetKeyDown (KeyCode.LeftArrow) && rotate == false) 
		{
			transform.RotateAround (transform.position, transform.up, 90f);
			rotate = true;
		}

		var move = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		GetComponent<Rigidbody> ().position += move * speed * Time.deltaTime;

		if (Input.GetAxis ("Horizontal") != 0 || Input.GetAxis ("Vertical") !=0)
			transform.forward = new Vector3 (Input.GetAxis ("Vertical"), 0, Input.GetAxis ("Horizontal"));
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("PickUp"))
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText();
		}
	}

	void SetCountText()
	{
		countText.text = "Count:" + count.ToString ();
		if (count > 5) 
		{
			winText.text = "You've been saved!";
		}
	}
}
