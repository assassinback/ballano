using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
public class timething : MonoBehaviour {

	// Use this for initialization
	public bool lifes=false;
	public int i=0;
	public int time=43200;
	public Text text1;
	public ulong tr;
	public ulong tr1;
	public Button button;
	//public int time=100;
	void Start () {
        //PlayerPrefs.SetInt("livesinfi", 0);
		string hasPlayed = PlayerPrefs.GetString("LastOne");
		button.onClick.AddListener(onclik);
		try{

		time=43200;
		if(hasPlayed == null){
			PlayerPrefs.SetString("LastOne",DateTime.Now.Ticks.ToString());
			tr=ulong.Parse(PlayerPrefs.GetString("LastOne"));
		}
		else{
			print(true);
			tr=ulong.Parse(PlayerPrefs.GetString("LastOne"));
            }
            if (PlayerPrefs.GetInt("livesinfi") == 1)
            {
                text1.text = "infi";
            }
            // if(PlayerPrefs.HasKey("LastOne")==false)
            // {
            // 	//tr=ulong.Parse(PlayerPrefs.GetString("LastOne"));


            // 	//PlayerPrefs.SetString("LastOne",DateTime.Now.Ticks.ToString());
            // 	PlayerPrefs.SetString("LastOne",DateTime.Now.Ticks.ToString());

            // }
            // else
            // {
            // 	print("true");
            // 	tr=ulong.Parse(PlayerPrefs.GetString("LastOne"));
            // 	//tr=ulong.Parse(PlayerPrefs.GetString("LastOne"));
            // }
        }
		catch(System.Exception)
		{
			PlayerPrefs.SetString("LastOne",DateTime.Now.Ticks.ToString());
		}
		//Debug.Log(tr);
	}
	public void onclik()
	{
		if(lifes==true)
		{
            if (PlayerPrefs.GetInt("livesinfi") == 0)
            {
                PlayerPrefs.SetInt("lives", PlayerPrefs.GetInt("lives") + 50);
                lifes = false;
                time = 43200;
            }
            else
            {
                text1.text = "infi";
            }
		}
	}
	// Update is called once per frame
	void Update () {

		tr1=(ulong)DateTime.Now.Ticks;
		ulong x=(ulong)(tr1-tr)/TimeSpan.TicksPerMillisecond;
		//float y=(float)((3000-x)/1000);
		Debug.Log(x);
		if(i==0)
		{
			time=time-((int)(x/1000));
			StartCoroutine(Timer(1.0f));
			i=1;
		}
		//text1.text=x/1000+"";
		//PlayerPrefs.SetString("LastOne",tr.ToString());
		if(x>=43200000)
		{
			//  string json = ResourceHelper.ReadFromPersistentData ("lives.json");
			// 	PlayerLives live = ResourceHelper.DecodeObject<PlayerLives> (json);
			// 	live.lives += 10;
			// 	int i = live.lives;
			// 	live = new PlayerLives {
			// 		lives = i,
			// 		isLoaded = true
			// 	};
			// 	ResourceHelper.SaveToPersistentData ("lives.json",live);
				lifes=true;
				PlayerPrefs.SetString("LastOne",DateTime.Now.Ticks.ToString());
				tr=ulong.Parse(PlayerPrefs.GetString("LastOne"));
		}
	}
	IEnumerator Timer(float waitTime)
	{
		while(true){
            yield return new WaitForSeconds(waitTime);
            try
            {
                if (PlayerPrefs.GetInt("livesinfi") == 0)
                {
                    text1.text = "COLLECT IN: ";
                    text1.text += time / 3600 + ":";
                    text1.text += (time / 60) % 60 + ":";
                    text1.text += time % 60 + "";
                    //text1.text+=time+"";
                    time -= 1;
                    if (time <= 0)
                    {
                        text1.text = "Collect now";
                        //time=43200;
                    }
                }
            }
            catch (System.Exception) { }
		}

		
	}
}


