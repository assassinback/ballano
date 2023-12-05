using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DestroySound1 : MonoBehaviour {

	// Use this for initialization
	public Button bt;
	void Start () {
		bt.onClick.AddListener(task);
	}
	public void task()
	{
		Destroy(GameObject.Find("Audio Source"));
	}
	// Update is called once per frame
	void Update () {
		
	}
}
