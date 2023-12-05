using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movexaxis6th : MonoBehaviour {

	// Use this for initialization
	public Rigidbody2D rb;
	void Start () {
		//Debug.Log (System.DateTime.Now.Minute);
		rb = GetComponent<Rigidbody2D>();
		rb.velocity=new Vector3(3,0,0);
	}
	void OnTriggerEnter2D(Collider2D col)
	{

	}
	// Update is called once per frame
	void Update () {
		//		Vector3 pos = transform.position;
		//		float newY = Mathf.Sin (100*speed);
		//		transform.position = new Vector3 (transform.position.x, newY* height, transform.position.z) ;
		if (transform.position.x <= -3f) {
			rb.velocity=new Vector3(3,0,0);
		}
		else if(transform.position.x>=-0.66)
		{
			rb.velocity=new Vector3(-3,0,0);
		}
	}
}
