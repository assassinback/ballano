using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveXaxis : MonoBehaviour {

	// Use this for initialization
	public int i=0;
	//	public float height=10000f;
	//	public float speed=20f;
	public Transform tr;
	public Transform tr1;
	public float speed=3;
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
		if (transform.position.x >= 3) {
			rb.velocity=new Vector3(-3,0,0);
		}
		else if(transform.position.x<=-3)
		{
			rb.velocity=new Vector3(3,0,0);
		}
	}
}
