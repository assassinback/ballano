using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class Ads : MonoBehaviour {

	// Use this for initialization
	public adds ad;
	void Start () {
		Advertisement.Initialize("2727470",true);
		//if(!ResourceHelper.ExistsInPersistentData("adds.json"))
		//{
		//	ad = new adds {
		//		mark = 0
		//	};
		//	ResourceHelper.SaveToPersistentData ("adds.json", ad);
		//	Debug.Log ("np here");
		//}
		//else
		//{
		//	string json = ResourceHelper.ReadFromPersistentData ("adds.json");
		//	ad = ResourceHelper.DecodeObject<adds> (json);	
		//}
		DontDestroyOnLoad (this.gameObject);
	}
	void DontDestroyOnLoad ()
	{
		
	}
	// Update is called once per frame
	void Update () {
		
	}

	public void OnBtnClick(){
		Debug.Log ("adds");
        //ad.mark++;
        int Showadd=PlayerPrefs.GetInt("ads");
		//ResourceHelper.SaveToPersistentData ("adds.json", ad);
		if (Showadd >= 25&&(PlayerPrefs.GetInt("livesinfi")==0&& PlayerPrefs.GetInt("noads") == 0)) {
			if (Advertisement.IsReady ()) {
				Advertisement.Show ("video", new ShowOptions (){ resultCallback = check });
			}
            PlayerPrefs.SetInt("ads", 0);
			//ResourceHelper.SaveToPersistentData ("adds.json", ad);
		}
	}
	public void check(ShowResult show)
	{
		
	}

}

public class adds
{
	public int mark{ get; set;}
}