using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowball : MonoBehaviour {

	private int untilDespawn;
	public Rigidbody rb;
	public float force;

	// Use this for initialization
	void Start () {
		untilDespawn = 50;
		rb = GetComponent<Rigidbody> ();
	}
	void FixedUpdate()
	{
		if (untilDespawn < 0)
			rb.AddForce (transform.forward * force);
	}
	void OnCollisionEnter (Collision other)
	{
		Destroy (gameObject);
	}

	// Update is called once per frame
	void OnDestroy () {
	}
}