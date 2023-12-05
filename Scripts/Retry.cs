using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Retry : MonoBehaviour {

	// Use this for initialization
	public static string PreviousScene = "";
	void Start () {
		DontDestroyOnLoad ();	
	}
	void DontDestroyOnLoad()
	{

	}
	void OnDestroy()
	{
		PreviousScene = SceneManager.GetActiveScene().name;
	}
	// Update is called once per frame
	void Update () {
		
	}

	public void LoadScene(string sceneName)
	{
        if (PlayerPrefs.GetInt("lives") >= 0 && PlayerPrefs.GetInt("livesinfi") == 0)
        {
            SceneManager.LoadScene(sceneName);
        }
        else if(PlayerPrefs.GetInt("livesinfi") == 1)
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            GameObject x = Resources.Load("Canvas") as GameObject;
            Instantiate(x);
            //GameObject.Find("nolives").SetActive(true);
        }
	}
}
