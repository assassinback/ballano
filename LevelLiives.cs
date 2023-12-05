using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelLiives : MonoBehaviour {

	// Use this for initialization
	public Text levelLives;
	public PlayerLives live;
	void Start () {
		levelLives = this.gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        //string json = ResourceHelper.ReadFromPersistentData ("lives.json");
        //live = ResourceHelper.DecodeObject<PlayerLives> (json);
        //levelLives.text = live.lives.ToString();
        levelLives.text = PlayerPrefs.GetInt("lives") + "";
	}
}
