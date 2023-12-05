using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TryButtonClick : MonoBehaviour {
	public Button bt;
	// Use this for initialization
	public Button bt1; 
	public AudioSource audio;
	//public AudioSource audio1;
	void Start () {
		bt1 = bt.GetComponent<Button> ();
		bt1.onClick.AddListener (Task);
		// audio = this.GetComponent<AudioSource> ();

	}
	void Task()
	{
		Destroy(GameObject.Find("Audio Source"));
		//GameObject.Find("Audio Source1").SetActive(true);
		// GameObject gobject = FindInActiveObjectByName("Audio Source1");
		// DontDestroyOnLoad (gobject);
		// gobject.SetActive(true);
		// gobject.GetComponent<AudioSource>().enabled=true;
		// gobject.GetComponent<AudioSource> ().mute = false;
		
		//Destroy (GameObject.Find ("Audio Source"));
		if (bt1.image.sprite.name != "locked level") {
			if (bt1.name == "level1"&& bt1.image.sprite.name=="level 1") {
				SceneManager.LoadScene("Level1");
			}
			else if (bt1.name == "level2"&& bt1.image.sprite.name=="level 2") {
				SceneManager.LoadScene("Level2");
			}
			else if (bt1.name == "level3"&& bt1.image.sprite.name=="level 3") {
				SceneManager.LoadScene("Level3");
			}
			else if (bt1.name == "level4"&& bt1.image.sprite.name=="level 4") {
				SceneManager.LoadScene("Level4");
			}
			else if (bt1.name == "level5"&& bt1.image.sprite.name=="level 5") {
				SceneManager.LoadScene("Level5");
			}
			else if (bt1.name == "level6"&& bt1.image.sprite.name=="level 6") {
				SceneManager.LoadScene("Level6");
			}
			else if (bt1.name == "level7"&& bt1.image.sprite.name=="level 7") {
				SceneManager.LoadScene("Level7");
			}
			else if (bt1.name == "level8"&& bt1.image.sprite.name=="level 8") {
				SceneManager.LoadScene("Level8");
			}
			else if (bt1.name == "level9"&& bt1.image.sprite.name=="level 9") {
				SceneManager.LoadScene("Level9");
			}
			else if (bt1.name == "level10"&& bt1.image.sprite.name=="level 10") {
				SceneManager.LoadScene("Level10");
			}
			else if (bt1.name == "level11"&& bt1.image.sprite.name=="leevl 11") {
				Debug.Log ("working");
				SceneManager.LoadScene("Level11");

			}
			else if (bt1.name == "level12"&& bt1.image.sprite.name=="level 12") {
				SceneManager.LoadScene("Level12");
			}
			else if (bt1.name == "level13"&& bt1.image.sprite.name=="level13") {
				SceneManager.LoadScene("Level13");
			}
			else if (bt1.name == "level14"&& bt1.image.sprite.name=="level14") {
				SceneManager.LoadScene("Level14");
			}
			else if (bt1.name == "level15"&& bt1.image.sprite.name=="level15") {
				SceneManager.LoadScene("Level15");
			}
			else if (bt1.name == "level16"&& bt1.image.sprite.name=="level16") {
				SceneManager.LoadScene("Level16");
			}
			else if (bt1.name == "level17"&& bt1.image.sprite.name=="level17") {
				SceneManager.LoadScene("Level17");
			}
			else if (bt1.name == "level18"&& bt1.image.sprite.name=="level18") {
				SceneManager.LoadScene("Level18");
			}
			else if (bt1.name == "level19"&& bt1.image.sprite.name=="level19") {
				SceneManager.LoadScene("Level19");
			}
			else if (bt1.name == "level20"&& bt1.image.sprite.name=="level20") {
				SceneManager.LoadScene("Level20");
			}
			else if (bt1.name == "level21"&& bt1.image.sprite.name=="level21") {
				SceneManager.LoadScene("Level21");
			}
			else if (bt1.name == "level22"&& bt1.image.sprite.name=="level22") {
				SceneManager.LoadScene("Level22");
			}
			else if (bt1.name == "level23"&& bt1.image.sprite.name=="level23") {
				Debug.Log ("working");
				SceneManager.LoadScene("Level23");

			}
			else if (bt1.name == "level24"&& bt1.image.sprite.name=="level24") {
				SceneManager.LoadScene("Level24");
			}
			else if (bt1.name == "level25"&& bt1.image.sprite.name=="level25") {
				SceneManager.LoadScene("Level25");
			}
			else if (bt1.name == "level26"&& bt1.image.sprite.name=="level26") {
				SceneManager.LoadScene("Level26");
			}
			else if (bt1.name == "level27"&& bt1.image.sprite.name=="level27") {
				SceneManager.LoadScene("Level27");
			}
			else if (bt1.name == "level28"&& bt1.image.sprite.name=="level28") {
				SceneManager.LoadScene("Level28");
			}
			else if (bt1.name == "level29"&& bt1.image.sprite.name=="level29") {
				SceneManager.LoadScene("Level29");
			}
			else if (bt1.name == "level30"&& bt1.image.sprite.name=="level30") {
				SceneManager.LoadScene("Level30");
			}
			else if (bt1.name == "level31"&& bt1.image.sprite.name=="level31") {
				SceneManager.LoadScene("Level31");
			}
			else if (bt1.name == "level32"&& bt1.image.sprite.name=="level32") {
				SceneManager.LoadScene("Level32");
			}
			else if (bt1.name == "level33"&& bt1.image.sprite.name=="level33") {
				SceneManager.LoadScene("Level33");
			}
			else if (bt1.name == "level34"&& bt1.image.sprite.name=="level34") {
				SceneManager.LoadScene("Level34");
			}
			else if (bt1.name == "level35"&& bt1.image.sprite.name=="level35") {
				SceneManager.LoadScene("Level35");
			}
			else if (bt1.name == "level36"&& bt1.image.sprite.name=="level36") {
				SceneManager.LoadScene("Level36");
			}
			else if (bt1.name == "level37"&& bt1.image.sprite.name=="level37") {
				SceneManager.LoadScene("Level37");
			}
			else if (bt1.name == "level38"&& bt1.image.sprite.name=="level38") {
				SceneManager.LoadScene("Level38");
			}
			else if (bt1.name == "level39"&& bt1.image.sprite.name=="level39") {
				SceneManager.LoadScene("Level39");
			}
			else if (bt1.name == "level40"&& bt1.image.sprite.name=="level40") {
				SceneManager.LoadScene("Level40");
			}
			else if (bt1.name == "level41"&& bt1.image.sprite.name=="level41") {
				SceneManager.LoadScene("Level41");
			}
			else if (bt1.name == "level42"&& bt1.image.sprite.name=="level42") {
				SceneManager.LoadScene("Level42");
			}
			else if (bt1.name == "level43"&& bt1.image.sprite.name=="level43") {
				SceneManager.LoadScene("Level43");
			}
			else if (bt1.name == "level44"&& bt1.image.sprite.name=="level44") {
				SceneManager.LoadScene("Level44");
			}
			else if (bt1.name == "level45"&& bt1.image.sprite.name=="level45") {
				SceneManager.LoadScene("Level45");
			}
			else if (bt1.name == "level46"&& bt1.image.sprite.name=="level46") {
				SceneManager.LoadScene("Level46");
			}
			else if (bt1.name == "level47"&& bt1.image.sprite.name=="level47") {
				SceneManager.LoadScene("Level47");
			}
			else if (bt1.name == "level48"&& bt1.image.sprite.name=="level48") {
				SceneManager.LoadScene("Level48");
			}
			else if (bt1.name == "level49"&& bt1.image.sprite.name=="level49") {
				SceneManager.LoadScene("Level49");
			}
			else if (bt1.name == "level50"&& bt1.image.sprite.name=="level50") {
				SceneManager.LoadScene("Level50");
			}
			else if (bt1.name == "level51"&& bt1.image.sprite.name=="level51") {
				SceneManager.LoadScene("Level51");
			}
			else if (bt1.name == "level52"&& bt1.image.sprite.name=="level52") {
				SceneManager.LoadScene("Level52");
			}
			else if (bt1.name == "level53"&& bt1.image.sprite.name=="level53") {
				SceneManager.LoadScene("Level53");
			}
			else if (bt1.name == "level54"&& bt1.image.sprite.name=="level54") {
				SceneManager.LoadScene("Level54");
			}
			else if (bt1.name == "level55"&& bt1.image.sprite.name=="level55") {
				SceneManager.LoadScene("Level55");
			}
			else if (bt1.name == "level56"&& bt1.image.sprite.name=="level56") {
				SceneManager.LoadScene("Level56");
			}
			else if (bt1.name == "level57"&& bt1.image.sprite.name=="level57") {
				SceneManager.LoadScene("Level57");
			}
			else if (bt1.name == "level58"&& bt1.image.sprite.name=="level58") {
				SceneManager.LoadScene("Level58");
			}
			else if (bt1.name == "level59"&& bt1.image.sprite.name=="level59") {
				SceneManager.LoadScene("Level59");
			}
			else if (bt1.name == "level60"&& bt1.image.sprite.name=="level60") {
				SceneManager.LoadScene("Level60");
			}
		}
	}


	// Update is called once per frame
	void Update () {
		
	}
	GameObject FindInActiveObjectByName(string name)
{
    Transform[] objs = Resources.FindObjectsOfTypeAll<Transform>() as Transform[];
    for (int i = 0; i < objs.Length; i++)
    {
        if (objs[i].hideFlags == HideFlags.None)
        {
            if (objs[i].name == name)
            {
                return objs[i].gameObject;
            }
        }
    }
    return null;
}
}
