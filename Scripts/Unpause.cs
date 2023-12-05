using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Unpause : MonoBehaviour {

	// Use this for initialization
	public Button button;
	public Button button1;
	void Start () {
		// button = FindInActiveObjectByTag("Pause").GetComponent<Button>();
		// button1 = FindInActiveObjectByTag("Resume").GetComponent<Button>();
		button.onClick.AddListener (clicked);
		button1.onClick.AddListener (clicked);

	}
	void clicked()
	{
		if (Time.timeScale == 1) {
			Time.timeScale = 0;
		} else{
			Time.timeScale = 1;
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
	GameObject FindInActiveObjectByTag(string tag)
{

    Transform[] objs = Resources.FindObjectsOfTypeAll<Transform>() as Transform[];
    for (int i = 0; i < objs.Length; i++)
    {
        if (objs[i].hideFlags == HideFlags.None)
        {
            if (objs[i].CompareTag(tag))
            {
                return objs[i].gameObject;
            }
        }
    }
    return null;
}
}
