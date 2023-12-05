using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movebothaxisv2 : MonoBehaviour {

	// Use this for initialization
	public Rigidbody2D rb;
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		rb.velocity=new Vector3(3,3,0);
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x <= 8.25) {
			rb.velocity=new Vector3(3,3,0);
		}
		else if(transform.position.x>=10.5)
		{
			rb.velocity=new Vector3(-3,-3,0);
		}
	}
}
