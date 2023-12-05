using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SetLives : MonoBehaviour {

	// Use this for initialization
	public Text livesText;
	PlayerLives data;
	public PlayerLives live;
	timex ti;
	void Start () {
		//if (ResourceHelper.ExistsInPersistentData ("lives.json")) {

		//} else {
		//	live = new PlayerLives {
		//		lives = 50,
		//		isLoaded = true
		//	};
		//	ResourceHelper.SaveToPersistentData ("lives.json", live);
		//}
		//string json = ResourceHelper.ReadFromPersistentData("lives.json");
		//data = ResourceHelper.DecodeObject<PlayerLives>(json);

		//if(data.isLoaded == true){
		//	livesText.text = data.lives.ToString();
		//}
        if(PlayerPrefs.GetInt("first")==0)
        {
            PlayerPrefs.SetInt("first", 1);
            PlayerPrefs.SetInt("lives", 50);
        }
		//if (ResourceHelper.ExistsInPersistentData ("time.json")) {
		//} else {
		//	ti = new timex {
		//		t=0f					
		//	};
		//	ResourceHelper.SaveToPersistentData ("time.json", ti);
		//}
		
	}
	
	// Update is called once per frame
	void Update () {
        //string json = ResourceHelper.ReadFromPersistentData("lives.json");
        //data = ResourceHelper.DecodeObject<PlayerLives>(json);
        if (PlayerPrefs.GetInt("livesinfi") == 0)
        {
            livesText.text = PlayerPrefs.GetInt("lives")+"";
        }
        else
        {
            livesText.text = "infi";
        }
	}
}
public class timex{
	public float t{get;set;}

}