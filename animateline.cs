using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateline : MonoBehaviour {

	// Use this for initialization
	LineRenderer line;
	float counter;
	float lineDrawSpeed=3f;
	float dist;
	public Transform origin;
	public Transform destination;
	void Start () {
		line=this.GetComponent<LineRenderer>();
		line.SetPosition(0,origin.position);
		line.SetWidth(0.2f,0.2f);
		dist=Vector3.Distance(origin.position,destination.position);

	}
	
	// Update is called once per frame
	void Update () {
	
		counter+=0.1f/lineDrawSpeed;
		float x=Mathf.Lerp(0,dist,counter);
		Vector3 pointB=destination.position;
		Vector3 pointA=origin.position;	
		Vector3 pointalongline=x*Vector3.Normalize(pointB-pointA)+pointA;
		line.SetPosition(1,pointalongline);
	
	}
	
}
