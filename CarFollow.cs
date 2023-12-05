using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarFollow : MonoBehaviour {

	// Use this for initialization
	public Transform target;
	public float smoothspeed=0.125f;
	public Vector3 offset;
	void Start () {
		//offset = transform.position - target.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 desiredpos = target.position + offset;
		Vector3 smoothedpos = Vector3.Lerp (transform.position,desiredpos,smoothspeed);
		transform.position = smoothedpos;
		//transform.position = target.position+offset;
		//this.transform.parent=target;
		//this.transform.localPosition=new Vector3(this.transform.localPosition.x+0.1f,this.transform.localPosition.y,-1);
		this.transform.localPosition=new Vector3(transform.localPosition.x,0,-1);
	}
}
