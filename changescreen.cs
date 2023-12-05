using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changescreen : MonoBehaviour {

	// Use this for initialization
	public GameObject disc;
	public GameObject myCam;
	public GameObject wallend;
	public int i=0;
	void Start () {
		disc = GameObject.Find ("disc");
		myCam = GameObject.Find ("Main Camera");
		if (GameObject.Find ("wall end1") != null) {
			wallend = GameObject.Find ("wall end1");
		}
		if (GameObject.Find ("wall end3") != null) {
			wallend = GameObject.Find ("wall end3");
		}
		if (GameObject.Find ("wall end2") != null) {
			wallend = GameObject.Find ("wall end2");
		}
		if (GameObject.Find ("wall end4") != null) {
			wallend = GameObject.Find ("wall end4");
		}
		if (GameObject.Find ("wall1 end") != null) {
			wallend = GameObject.Find ("wall1 end");
		}
		if (GameObject.Find ("wall2 end") != null) {
			wallend = GameObject.Find ("wall2 end");
		}
		if (GameObject.Find ("wall3 end") != null) {
			wallend = GameObject.Find ("wall3 end");
		}
		if (GameObject.Find ("wall4 end") != null) {
			wallend = GameObject.Find ("wall4 end");
		}
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		
	}
	// Update is called once per frame
	void Update () {
		if (disc.transform.position.x >= 0 && wallend.transform.position.x - 8.47f >= myCam.transform.position.x) {
			myCam.transform.position = new Vector3 (disc.transform.position.x, myCam.transform.position.y, -1);
		} else if (disc.transform.position.x <= 0) {
			myCam.transform.position = new Vector3 (0, myCam.transform.position.y, -1);
		} else if (disc.transform.position.x <= myCam.transform.position.x &&wallend.transform.position.x - 8.47f <= myCam.transform.position.x) {
			myCam.transform.position = new Vector3 (disc.transform.position.x, myCam.transform.position.y, -1);
		}
		
	}
}
