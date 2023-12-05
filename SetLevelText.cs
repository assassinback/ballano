using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SetLevelText : MonoBehaviour {

	// Use this for initialization
	public Text level;
	public Text levelNum;
	public Text levelText;
	void Start () {
		level = FindInActiveObjectByTag("LevelTitle").GetComponent<Text>();
		levelNum = FindInActiveObjectByTag("LevelNum").GetComponent<Text>();
		levelText = FindInActiveObjectByTag("LevelText").GetComponent<Text>();
		levelText.text = level.text + " "+levelNum.text;
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
