using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadLevelZero : MonoBehaviour {

	// Use this for initialization
	public float delay = 1f;
	void Start () {
		StartCoroutine(LoadLevelAfterDelay(delay));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator LoadLevelAfterDelay(float delay){
		yield return new WaitForSeconds(delay);
		SceneManager.LoadScene("Start");
		
	}
}
