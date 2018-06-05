using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sledMovement : MonoBehaviour {

	public static int moveSpeed = 1;
	public Vector3 userDirection = Vector3.right;
	public float sledTurning;
	private bool reload;

	public GameObject snowball;
	Rigidbody rb;
	private bool reload_time;

	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody> ();
		reload_time = true;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (userDirection * moveSpeed * Time.deltaTime);

		if (Input.GetKey (KeyCode.LeftArrow) && (Input.GetKey (KeyCode.A))) {
			//Move Left

			//transform.Translate(-Vector3.right * moveSpeed * Time.deltaTime, 0f, 0f);
			transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 0f);
		}
		if (Input.GetKey (KeyCode.RightArrow) && (Input.GetKey (KeyCode.D))) {

			//Move Right

			//transform.Translate(Vector3.right * moveSpeed * Time.deltaTime, 0f, 0f);
			transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 0f);
		}
		if (Input.GetKey (KeyCode.UpArrow))
		{
			//if (reload) 
			{

				GameObject g = Instantiate (snowball, transform.position + new Vector3(0, 20, 0), transform.rotation);
				g.GetComponent<Rigidbody> ().AddForce(transform.forward * 1000);	
				reload = false;
				Invoke("reload", 1);
			}
		}
		if(Input.GetKeyDown(KeyCode.Space))
		{
			GetComponent<Rigidbody>().velocity = Vector3.up * moveSpeed;
		}
	}


}

