using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResetTimer : MonoBehaviour {

	// Use this for initialization
	public Text timer;
	public static int time = 3600;
	string timeString;
	public int x=60;
	public PlayerLives live;
	int mins;
	int seconds;
	timex tim;
	public GameObject canvas;
	void Start () {
		//Lives.timeText = Mathf.Floor(Time.time);
		//timer.gameObject.transform.parent = null;
		//DontDestroyOnLoad(canvas);
		//DontDestroyOnLoad(this.gameObject);
		DontDestroyOnLoad(timer.gameObject);
		// if(timer!=null){
		string json=ResourceHelper.ReadFromPersistentData("time.json");
		tim = ResourceHelper.DecodeObject<timex> (json);
		print (tim.t);
		time = time-(int)tim.t;
		// }
		StartCoroutine(Timer(1.0f));
		
		//
		//

	}
//	void OnDestroy()
//	{
//		float p = tim.t;
//		tim = new timex {
//			t = p + Time.time
//		};
//		ResourceHelper.SaveToPersistentData ("time.json",tim);
//	}
	// Update is called once per frame
	void Update () {
		// mins = time/60;
		// seconds = mins%60;
		// if(Time.time)
	}

	private IEnumerator Timer(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
			time -=1;

			//timeString = Mathf.Floor(Time.time/60)+":"+Mathf.Floor(Time.time%60);
			mins=time/60;
			seconds = time % 60;
			timeString = mins + ":" + seconds;
			if (time == 0)
				time = 3600;
			try{
			timer.text= timeString;
			}
			catch(System.Exception) {
			}
			if (Mathf.Floor (Time.time+tim.t) % 3600 == 0&&Time.time>0) {
				string json = ResourceHelper.ReadFromPersistentData ("lives.json");
				live = ResourceHelper.DecodeObject<PlayerLives> (json);
				live.lives += 10;
				int i = live.lives;
				live = new PlayerLives {
					lives = i,
					isLoaded = true
				};
				ResourceHelper.SaveToPersistentData ("lives.json",live);
				tim = new timex {
					t = 0f
				};
				ResourceHelper.SaveToPersistentData ("time.json",tim);
			}
        }
    }
}
