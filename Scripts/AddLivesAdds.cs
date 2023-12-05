using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
public class AddLivesAdds : MonoBehaviour {
	
	// Use this for initialization
	public Button bt;
	void Start () {

		bt = GetComponent<Button> ();
		bt.onClick.AddListener (clik);
		Advertisement.Initialize("2727470",true);
        if(PlayerPrefs.GetInt("livesinfi")==1)
        {
            Destroy(this.gameObject);
        }
	}
	public void clik()
	{
		if (Advertisement.IsReady ()) {
			Advertisement.Show ("rewardedVideo", new ShowOptions (){ resultCallback = chek });
		}
	}
	public void chek(ShowResult show)
	{
		switch (show) {
		case ShowResult.Finished:
			string json = ResourceHelper.ReadFromPersistentData ("lives.json");
			PlayerLives p = ResourceHelper.DecodeObject<PlayerLives> (json);
			int x = p.lives+10;
			p = new PlayerLives {
				lives = x,
				isLoaded = true
			};
			ResourceHelper.SaveToPersistentData ("lives.json", p);
			break;
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
