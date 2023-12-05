using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DestroyAdds : MonoBehaviour {

	// Use this for initialization
	public Button bt;
	void Start () {
		bt = GetComponent<Button> ();
		bt.onClick.AddListener (des);
	}
	public void des()
	{
		Destroy (GameObject.Find ("adds").gameObject);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
