using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DestroySound : MonoBehaviour {

	// Use this for initialization
	public Button bt;
	void Start () {
		bt.onClick.AddListener(task);
	}
	public void task()
	{
		if (bt.name == "Home") {
			Destroy (GameObject.Find ("TimeThings"));

		}
		Destroy(GameObject.Find("Audio Source1"));
	}
	// Update is called once per frame
	void Update () {
		
	}
}
