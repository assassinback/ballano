using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Newtonsoft.Json;
public class CreateLinew34 : MonoBehaviour 
{
	public int ti=13;
	public int linecount=5;
	public Text tex;
	public Text te;
	public Text linesAmount;
	public GameObject linesObj;
    private LineRenderer line; // Reference to LineRenderer
    private Vector3 mousePos;    
    private Vector3 startPos;    // Start position of line
    private Vector3 endPos;    // End position of line
	public Color col;
	public Material mat;
	static public int i=0;
	public int j=-2;
	public int u = 0;
	public List<LineRenderer> a;
	public GameObject image1;
	public GameObject image2;
	public GameObject image3;
	public GameObject image4;
	public GameObject image5;
	public GameObject image6;
	public Sprite sprite;
	public Sprite sprite1;
	public level1 Level1;
	public level2 Level2;
	public level3 Level3;
	public level4 Level4;
	public level5 Level5;
	public level6 Level6;
	public level7 Level7;
	public level8 Level8;
	public level9 Level9;
	public level10 Level10;
	float ll;
	public level11 Level11;
	public level12 Level12;
	public level13 Level13;
	public level14 Level14;
	public level15 Level15;
	public level16 Level16;
	public level17 Level17;
	public level18 Level18;
	public level19 Level19;
	public level20 Level20;
	public level21 Level21;
	public level22 Level22;
	public level23 Level23;
	public level24 Level24;
	public level25 Level25;
	public level26 Level26;
	public level27 Level27;
	public level28 Level28;
	public level29 Level29;
	public level30 Level30;
	public level31 Level31;
	public level32 Level32;
	public level33 Level33;
	public level34 Level34;
	public level35 Level35;
	public level36 Level36;
	public level37 Level37;
	public level38 Level38;
	public level39 Level39;
	public level40 Level40;
	public level41 Level41;
	public level42 Level42;
	public level43 Level43;
	public level44 Level44;
	public level45 Level45;
	public level46 Level46;
	public level47 Level47;
	public level48 Level48;
	public level49 Level49;
	public level50 Level50;
	public level51 Level51;
	public level52 Level52;
	public level53 Level53;
	public level54 Level54;
	public level55 Level55;
	public level56 Level56;
	public level57 Level57;
	public level58 Level58;
	public level59 Level59;
	public level60 Level60;
	public level1 l;
	public GameObject pausepanel;
	public GameObject disc;
	discMove f;
	void Start()
	{
		linecount = 5;
		ti = 13;
		StartCoroutine(timePassed());
		string json;
		if (ResourceHelper.ExistsInPersistentData ("level1.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level1.json");
			Level1 = ResourceHelper.DecodeObject<level1> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level2.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level2.json");
			Level2 = ResourceHelper.DecodeObject<level2> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level3.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level3.json");
			Level3 = ResourceHelper.DecodeObject<level3> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level4.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level4.json");
			Level4 = ResourceHelper.DecodeObject<level4> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level5.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level5.json");
			Level5 = ResourceHelper.DecodeObject<level5> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level6.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level6.json");
			Level6 = ResourceHelper.DecodeObject<level6> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level7.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level7.json");
			Level7 = ResourceHelper.DecodeObject<level7> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level8.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level8.json");
			Level8 = ResourceHelper.DecodeObject<level8> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level9.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level9.json");
			Level9 = ResourceHelper.DecodeObject<level9> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level10.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level10.json");
			Level10 = ResourceHelper.DecodeObject<level10> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level11.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level11.json");
			Level11 = ResourceHelper.DecodeObject<level11> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level12.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level12.json");
			Level12 = ResourceHelper.DecodeObject<level12> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level13.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level13.json");
			Level13 = ResourceHelper.DecodeObject<level13> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level14.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level14.json");
			Level14 = ResourceHelper.DecodeObject<level14> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level15.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level15.json");
			Level15 = ResourceHelper.DecodeObject<level15> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level16.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level16.json");
			Level16 = ResourceHelper.DecodeObject<level16> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level17.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level17.json");
			Level17 = ResourceHelper.DecodeObject<level17> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level18.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level18.json");
			Level18 = ResourceHelper.DecodeObject<level18> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level19.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level19.json");
			Level19 = ResourceHelper.DecodeObject<level19> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level20.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level20.json");
			Level20 = ResourceHelper.DecodeObject<level20> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level21.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level21.json");
			Level21 = ResourceHelper.DecodeObject<level21> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level22.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level22.json");
			Level22 = ResourceHelper.DecodeObject<level22> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level23.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level23.json");
			Level23 = ResourceHelper.DecodeObject<level23> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level24.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level24.json");
			Level24 = ResourceHelper.DecodeObject<level24> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level25.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level25.json");
			Level25 = ResourceHelper.DecodeObject<level25> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level26.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level26.json");
			Level26 = ResourceHelper.DecodeObject<level26> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level27.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level27.json");
			Level27 = ResourceHelper.DecodeObject<level27> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level28.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level28.json");
			Level28 = ResourceHelper.DecodeObject<level28> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level29.json")){
			json = ResourceHelper.ReadFromPersistentData ("level29.json");
			Level29 = ResourceHelper.DecodeObject<level29> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level30.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level30.json");
			Level30 = ResourceHelper.DecodeObject<level30> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level31.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level31.json");
			Level31 = ResourceHelper.DecodeObject<level31> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level32.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level32.json");
			Level32 = ResourceHelper.DecodeObject<level32> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level33.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level33.json");
			Level33 = ResourceHelper.DecodeObject<level33> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level34.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level34.json");
			Level34 = ResourceHelper.DecodeObject<level34> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level35.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level35.json");
			Level35 = ResourceHelper.DecodeObject<level35> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level36.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level36.json");
			Level36 = ResourceHelper.DecodeObject<level36> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level37.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level37.json");
			Level37 = ResourceHelper.DecodeObject<level37> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level38.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level38.json");
			Level38 = ResourceHelper.DecodeObject<level38> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level39.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level39.json");
			Level39 = ResourceHelper.DecodeObject<level39> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level40.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level40.json");
			Level40 = ResourceHelper.DecodeObject<level40> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level41.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level41.json");
			Level41 = ResourceHelper.DecodeObject<level41> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level42.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level42.json");
			Level42 = ResourceHelper.DecodeObject<level42> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level43.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level43.json");
			Level43 = ResourceHelper.DecodeObject<level43> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level44.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level44.json");
			Level44 = ResourceHelper.DecodeObject<level44> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level45.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level45.json");
			Level45 = ResourceHelper.DecodeObject<level45> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level46.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level46.json");
			Level46 = ResourceHelper.DecodeObject<level46> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level47.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level47.json");
			Level47 = ResourceHelper.DecodeObject<level47> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level48.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level48.json");
			Level48 = ResourceHelper.DecodeObject<level48> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level49.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level49.json");
			Level49 = ResourceHelper.DecodeObject<level49> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level50.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level50.json");
			Level50 = ResourceHelper.DecodeObject<level50> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level51.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level51.json");
			Level51 = ResourceHelper.DecodeObject<level51> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level52.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level52.json");
			Level52 = ResourceHelper.DecodeObject<level52> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level53.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level53.json");
			Level53 = ResourceHelper.DecodeObject<level53> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level54.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level54.json");
			Level54 = ResourceHelper.DecodeObject<level54> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level55.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level55.json");
			Level55 = ResourceHelper.DecodeObject<level55> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level56.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level56.json");
			Level56 = ResourceHelper.DecodeObject<level56> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level57.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level57.json");
			Level57 = ResourceHelper.DecodeObject<level57> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level58.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level58.json");
			Level58 = ResourceHelper.DecodeObject<level58> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level59.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level59.json");
			Level59 = ResourceHelper.DecodeObject<level59> (json);
		}
		if (ResourceHelper.ExistsInPersistentData ("level60.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level60.json");
			Level60 = ResourceHelper.DecodeObject<level60> (json);
		}

		//image2.rectTransform.sizeDelta = new Vector2 (0, 0);
		//image.rectTransform.sizeDelta = new Vector2 (0, 0);
		
		//pausepanel = GameObject.Find ("pause");
		//pausepanel.SetActive (false);
		i=0;
		//line.material = mat;
		//line.material=mat;
		// linesObj=GameObject.FindGameObjectWithTag("LinesText");
		// linesAmount = linesObj.GetComponent<Text>();
		print("helloworld");

		Time.timeScale=0;
//		line.SetColors (col, col);

		a = new List<LineRenderer> ();
	}
	IEnumerator timePassed()
	{
		while(true)
		{
			yield return new WaitForSeconds(1f);
			te.text=ti+"";
			if(ti>0)
			ti--;
		}
	}
    void Update () 
    {
		
		if (GameObject.Find ("disc") == null) {
			
			if (linecount>0&&ti>0) {
				Debug.Log("first here");
				if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Main" ) {
					Level1 = new level1 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level1.json", Level1);
					if(!ResourceHelper.ExistsInPersistentData ("level2.json"))
					ResourceHelper.SaveToPersistentData ("level2.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level2" ) {
					Level2 = new level2 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level2.json", Level2);
					if(!ResourceHelper.ExistsInPersistentData ("level3.json"))
						ResourceHelper.SaveToPersistentData ("level3.json", "");

				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level3" ) {
					Level3 = new level3 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level3.json", Level3);
					if(!ResourceHelper.ExistsInPersistentData ("level4.json"))
						ResourceHelper.SaveToPersistentData ("level4.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level4" ) {
					Level4 = new level4 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level4.json", Level4);
					if(!ResourceHelper.ExistsInPersistentData ("level5.json"))
						ResourceHelper.SaveToPersistentData ("level5.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level5" ) {
					Level5 = new level5 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level5.json", Level5);
					if(!ResourceHelper.ExistsInPersistentData ("level6.json"))
						ResourceHelper.SaveToPersistentData ("level6.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level6") {
					Level6 = new level6 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level6.json", Level6);
					if(!ResourceHelper.ExistsInPersistentData ("level7.json"))
						ResourceHelper.SaveToPersistentData ("level7.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level7") {
					Level7 = new level7 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level7.json", Level7);
					if(!ResourceHelper.ExistsInPersistentData ("level8.json"))
						ResourceHelper.SaveToPersistentData ("level8.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level8") {
					Level8 = new level8 {
						completed = true,
						star = 3
					};

					ResourceHelper.SaveToPersistentData ("level8.json", Level8);
					if(!ResourceHelper.ExistsInPersistentData ("level9.json"))
						ResourceHelper.SaveToPersistentData ("level9.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level9") {
					Level9 = new level9 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level9.json", Level9);
					if(!ResourceHelper.ExistsInPersistentData ("level10.json"))
						ResourceHelper.SaveToPersistentData ("level10.json", "");

				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level10" ) {
					Level10 = new level10 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level10.json", Level10);
					if(!ResourceHelper.ExistsInPersistentData ("level11.json"))
						ResourceHelper.SaveToPersistentData ("level11.json", "");

				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level11" ) {
					Level11 = new level11 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level11.json", Level11);
					if(!ResourceHelper.ExistsInPersistentData ("level12.json"))
						ResourceHelper.SaveToPersistentData ("level12.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level12" ) {
					Level12 = new level12 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level12.json", Level12);
					if(!ResourceHelper.ExistsInPersistentData ("level13.json"))
						ResourceHelper.SaveToPersistentData ("level13.json", "");
					
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level13" ) {
					Level13 = new level13 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level13.json", Level13);
					if(!ResourceHelper.ExistsInPersistentData ("level14.json"))
						ResourceHelper.SaveToPersistentData ("level14.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level14" ) {
					Level14 = new level14 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level14.json", Level14);
					if(!ResourceHelper.ExistsInPersistentData ("level15.json"))
						ResourceHelper.SaveToPersistentData ("level15.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level15" ) {
					Level15 = new level15 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level15.json", Level15);
					if(!ResourceHelper.ExistsInPersistentData ("level16.json"))
						ResourceHelper.SaveToPersistentData ("level16.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level16" ) {
					Level16 = new level16 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level16.json", Level16);
					if(!ResourceHelper.ExistsInPersistentData ("level17.json"))
						ResourceHelper.SaveToPersistentData ("level17.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level17" ) {
					Level17 = new level17 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level17.json", Level17);
					if(!ResourceHelper.ExistsInPersistentData ("level18.json"))
						ResourceHelper.SaveToPersistentData ("level18.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level18" ) {
					Level18 = new level18 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level18.json", Level18);
					if(!ResourceHelper.ExistsInPersistentData ("level19.json"))
						ResourceHelper.SaveToPersistentData ("level19.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level19" ) {
					Level19 = new level19 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level19.json", Level19);
					if(!ResourceHelper.ExistsInPersistentData ("level20.json"))
						ResourceHelper.SaveToPersistentData ("level20.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level20" ) {
					Level20 = new level20 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level20.json", Level20);
					if(!ResourceHelper.ExistsInPersistentData ("level21.json"))
						ResourceHelper.SaveToPersistentData ("level21.json", "");

				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level21" ) {
					Level21 = new level21 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level21.json", Level21);
					if(!ResourceHelper.ExistsInPersistentData ("level22.json"))
						ResourceHelper.SaveToPersistentData ("level22.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level22" ) {
					Level22 = new level22 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level22.json", Level22);
					if(!ResourceHelper.ExistsInPersistentData ("level23.json"))
						ResourceHelper.SaveToPersistentData ("level23.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level23" ) {
					Level23 = new level23 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level23.json", Level23);
					if(!ResourceHelper.ExistsInPersistentData ("level24.json"))
						ResourceHelper.SaveToPersistentData ("level24.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level24" ) {
					Level24 = new level24 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level24.json", Level24);
					if(!ResourceHelper.ExistsInPersistentData ("level25.json"))
						ResourceHelper.SaveToPersistentData ("level25.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level25" ) {
					Level25 = new level25 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level25.json", Level25);
					if(!ResourceHelper.ExistsInPersistentData ("level26.json"))
						ResourceHelper.SaveToPersistentData ("level26.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level26" ) {
					Level26 = new level26 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level26.json", Level26);
					if(!ResourceHelper.ExistsInPersistentData ("level27.json"))
						ResourceHelper.SaveToPersistentData ("level27.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level27" ) {
					Level27 = new level27 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level27.json", Level27);
					if(!ResourceHelper.ExistsInPersistentData ("level28.json"))
						ResourceHelper.SaveToPersistentData ("level28.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level28" ) {
					Level28 = new level28 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level28.json", Level28);
					if(!ResourceHelper.ExistsInPersistentData ("level29.json"))
						ResourceHelper.SaveToPersistentData ("level29.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level29" ) {
					Level29 = new level29 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level29.json", Level29);
					if(!ResourceHelper.ExistsInPersistentData ("level30.json"))
						ResourceHelper.SaveToPersistentData ("level30.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level30" ) {
					Level30 = new level30 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level30.json", Level30);
					if(!ResourceHelper.ExistsInPersistentData ("level31.json"))
						ResourceHelper.SaveToPersistentData ("level31.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level31" ) {
					Level31 = new level31 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level31.json", Level31);
					if(!ResourceHelper.ExistsInPersistentData ("level32.json"))
						ResourceHelper.SaveToPersistentData ("level32.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level32" ) {
					Level32 = new level32 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level32.json", Level32);
					if(!ResourceHelper.ExistsInPersistentData ("level33.json"))
						ResourceHelper.SaveToPersistentData ("level33.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level33" ) {
					Level33 = new level33 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level33.json", Level33);
					if(!ResourceHelper.ExistsInPersistentData ("level34.json"))
						ResourceHelper.SaveToPersistentData ("level34.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level34" ) {
					Level34 = new level34 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level34.json", Level34);
					if(!ResourceHelper.ExistsInPersistentData ("level35.json"))
						ResourceHelper.SaveToPersistentData ("level35.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level35" ) {
					Level35 = new level35 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level35.json", Level35);
					if(!ResourceHelper.ExistsInPersistentData ("level36.json"))
						ResourceHelper.SaveToPersistentData ("level36.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level36" ) {
					Level36 = new level36 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level36.json", Level36);
					if(!ResourceHelper.ExistsInPersistentData ("level37.json"))
						ResourceHelper.SaveToPersistentData ("level37.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level37" ) {
					Level37 = new level37 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level37.json", Level37);
					if(!ResourceHelper.ExistsInPersistentData ("level38.json"))
						ResourceHelper.SaveToPersistentData ("level38.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level38" ) {
					Level38 = new level38 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level38.json", Level38);
					if(!ResourceHelper.ExistsInPersistentData ("level39.json"))
						ResourceHelper.SaveToPersistentData ("level39.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level39" ) {
					Level39 = new level39 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level39.json", Level39);
					if(!ResourceHelper.ExistsInPersistentData ("level40.json"))
						ResourceHelper.SaveToPersistentData ("level40.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level40" ) {
					Level40 = new level40 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level40.json", Level40);
					if(!ResourceHelper.ExistsInPersistentData ("level41.json"))
						ResourceHelper.SaveToPersistentData ("level41.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level41" ) {
					Level41 = new level41 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level41.json", Level41);
					if(!ResourceHelper.ExistsInPersistentData ("level42.json"))
						ResourceHelper.SaveToPersistentData ("level42.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level42" ) {
					Level42 = new level42 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level42.json", Level42);
					if(!ResourceHelper.ExistsInPersistentData ("level43.json"))
						ResourceHelper.SaveToPersistentData ("level43.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level43" ) {
					Level43 = new level43 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level43.json", Level43);
					if(!ResourceHelper.ExistsInPersistentData ("level44.json"))
						ResourceHelper.SaveToPersistentData ("level44.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level44" ) {
					Level44 = new level44 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level44.json", Level44);
					if(!ResourceHelper.ExistsInPersistentData ("level45.json"))
						ResourceHelper.SaveToPersistentData ("level45.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level45" ) {
					Level45 = new level45 {
						completed = true,
						star = 3
					};
					if(!ResourceHelper.ExistsInPersistentData ("level46.json"))
						ResourceHelper.SaveToPersistentData ("level46.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level46" ) {
					Level46 = new level46 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level46.json", Level46);
					if(!ResourceHelper.ExistsInPersistentData ("level47.json"))
						ResourceHelper.SaveToPersistentData ("level47.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level47" ) {
					Level47 = new level47 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level47.json", Level47);
					if(!ResourceHelper.ExistsInPersistentData ("level48.json"))
						ResourceHelper.SaveToPersistentData ("level48.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level48" ) {
					Level48 = new level48 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level48.json", Level48);
					if(!ResourceHelper.ExistsInPersistentData ("level49.json"))
						ResourceHelper.SaveToPersistentData ("level49.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level49" ) {
					Level49 = new level49 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level49.json", Level49);
					if(!ResourceHelper.ExistsInPersistentData ("level50.json"))
						ResourceHelper.SaveToPersistentData ("level50.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level50" ) {
					Level50 = new level50 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level50.json", Level50);
					if(!ResourceHelper.ExistsInPersistentData ("level51.json"))
						ResourceHelper.SaveToPersistentData ("level51.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level51" ) {
					Level51 = new level51 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level51.json", Level51);
					if(!ResourceHelper.ExistsInPersistentData ("level52.json"))
						ResourceHelper.SaveToPersistentData ("level52.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level52" ) {
					Level52 = new level52 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level52.json", Level52);
					if(!ResourceHelper.ExistsInPersistentData ("level53.json"))
						ResourceHelper.SaveToPersistentData ("level53.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level53" ) {
					Level53 = new level53 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level53.json", Level53);
					if(!ResourceHelper.ExistsInPersistentData ("level54.json"))
						ResourceHelper.SaveToPersistentData ("level54.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level54" ) {
					Level54 = new level54 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level54.json", Level54);
					if(!ResourceHelper.ExistsInPersistentData ("level55.json"))
						ResourceHelper.SaveToPersistentData ("level55.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level55" ) {
					Level55 = new level55 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level55.json", Level55);
					if(!ResourceHelper.ExistsInPersistentData ("level56.json"))
						ResourceHelper.SaveToPersistentData ("level56.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level56" ) {
					Level56 = new level56 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level56.json", Level56);
					if(!ResourceHelper.ExistsInPersistentData ("level57.json"))
						ResourceHelper.SaveToPersistentData ("level57.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level57" ) {
					Level57 = new level57 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level57.json", Level57);
					if(!ResourceHelper.ExistsInPersistentData ("level58.json"))
						ResourceHelper.SaveToPersistentData ("level58.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level58" ) {
					Level58 = new level58 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level58.json", Level58);
					if(!ResourceHelper.ExistsInPersistentData ("level59.json"))
						ResourceHelper.SaveToPersistentData ("level59.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level59" ) {
					Level59 = new level59 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level59.json", Level59);
					if(!ResourceHelper.ExistsInPersistentData ("level60.json"))
						ResourceHelper.SaveToPersistentData ("level60.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level60" ) {
					Level60 = new level60 {
						completed = true,
						star = 3
					};
					ResourceHelper.SaveToPersistentData ("level60.json", Level60);

				}
			} else if (linecount>0||ti>0) {
				Debug.Log("second here");
				image3.SetActive(false);
				image6.SetActive(true);

				if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Main") {
					Level1 = new level1 {
						
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level1.json", Level1);
					if(!ResourceHelper.ExistsInPersistentData ("level2.json"))
						ResourceHelper.SaveToPersistentData ("level2.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level2") {
					Level2 = new level2 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level2.json", Level2);
					if(!ResourceHelper.ExistsInPersistentData ("level3.json"))
						ResourceHelper.SaveToPersistentData ("level3.json", "");

				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level3" ) {
					Level3 = new level3 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level3.json", Level3);
					if(!ResourceHelper.ExistsInPersistentData ("level4.json"))
						ResourceHelper.SaveToPersistentData ("level4.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level4") {
					Level4 = new level4 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level4.json", Level4);
					if(!ResourceHelper.ExistsInPersistentData ("level5.json"))
						ResourceHelper.SaveToPersistentData ("level5.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level5") {
					Level5 = new level5 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level5.json", Level5);
					if(!ResourceHelper.ExistsInPersistentData ("level6.json"))
						ResourceHelper.SaveToPersistentData ("level6.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level6") {
					Level6 = new level6 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level6.json", Level6);
					if(!ResourceHelper.ExistsInPersistentData ("level7.json"))
						ResourceHelper.SaveToPersistentData ("level7.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level7") {
					Level7 = new level7 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level7.json", Level7);
					if(!ResourceHelper.ExistsInPersistentData ("level8.json"))
						ResourceHelper.SaveToPersistentData ("level8.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level8") {
					Level8 = new level8 {
						completed = true,
						star = 2
					};

					ResourceHelper.SaveToPersistentData ("level8.json", Level8);
					if(!ResourceHelper.ExistsInPersistentData ("level9.json"))
						ResourceHelper.SaveToPersistentData ("level9.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level9") {
					Level9 = new level9 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level9.json", Level9);
					if(!ResourceHelper.ExistsInPersistentData ("level10.json"))
						ResourceHelper.SaveToPersistentData ("level10.json", "");

				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level10" ) {
					Level10 = new level10 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level10.json", Level10);
					if(!ResourceHelper.ExistsInPersistentData ("level11.json"))
						ResourceHelper.SaveToPersistentData ("level11.json", "");

				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level11" ) {
					Level11 = new level11 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level11.json", Level11);
					if(!ResourceHelper.ExistsInPersistentData ("level12.json"))
						ResourceHelper.SaveToPersistentData ("level12.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level12" ) {
					Level12 = new level12 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level12.json", Level12);
					if(!ResourceHelper.ExistsInPersistentData ("level13.json"))
						ResourceHelper.SaveToPersistentData ("level13.json", "");

				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level13" ) {
					Level13 = new level13 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level13.json", Level13);
					if(!ResourceHelper.ExistsInPersistentData ("level14.json"))
						ResourceHelper.SaveToPersistentData ("level14.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level14" ) {
					Level14 = new level14 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level14.json", Level14);
					if(!ResourceHelper.ExistsInPersistentData ("level15.json"))
						ResourceHelper.SaveToPersistentData ("level15.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level15" ) {
					Level15 = new level15 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level15.json", Level15);
					if(!ResourceHelper.ExistsInPersistentData ("level16.json"))
						ResourceHelper.SaveToPersistentData ("level16.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level16" ) {
					Level16 = new level16 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level16.json", Level16);
					if(!ResourceHelper.ExistsInPersistentData ("level17.json"))
						ResourceHelper.SaveToPersistentData ("level17.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level17" ) {
					Level17 = new level17 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level17.json", Level17);
					if(!ResourceHelper.ExistsInPersistentData ("level18.json"))
						ResourceHelper.SaveToPersistentData ("level18.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level18" ) {
					Level18 = new level18 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level18.json", Level18);
					if(!ResourceHelper.ExistsInPersistentData ("level19.json"))
						ResourceHelper.SaveToPersistentData ("level19.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level19" ) {
					Level19 = new level19 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level19.json", Level19);
					if(!ResourceHelper.ExistsInPersistentData ("level20.json"))
						ResourceHelper.SaveToPersistentData ("level20.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level20" ) {
					Level20 = new level20 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level20.json", Level20);
					if(!ResourceHelper.ExistsInPersistentData ("level21.json"))
						ResourceHelper.SaveToPersistentData ("level21.json", "");

				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level21" ) {
					Level21 = new level21 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level21.json", Level21);
					if(!ResourceHelper.ExistsInPersistentData ("level22.json"))
						ResourceHelper.SaveToPersistentData ("level22.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level22" ) {
					Level22 = new level22 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level22.json", Level22);
					if(!ResourceHelper.ExistsInPersistentData ("level23.json"))
						ResourceHelper.SaveToPersistentData ("level23.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level23" ) {
					Level23 = new level23 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level23.json", Level23);
					if(!ResourceHelper.ExistsInPersistentData ("level24.json"))
						ResourceHelper.SaveToPersistentData ("level24.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level24" ) {
					Level24 = new level24 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level24.json", Level24);
					if(!ResourceHelper.ExistsInPersistentData ("level25.json"))
						ResourceHelper.SaveToPersistentData ("level25.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level25" ) {
					Level25 = new level25 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level25.json", Level25);
					if(!ResourceHelper.ExistsInPersistentData ("level26.json"))
						ResourceHelper.SaveToPersistentData ("level26.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level26" ) {
					Level26 = new level26 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level26.json", Level26);
					if(!ResourceHelper.ExistsInPersistentData ("level27.json"))
						ResourceHelper.SaveToPersistentData ("level27.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level27" ) {
					Level27 = new level27 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level27.json", Level27);
					if(!ResourceHelper.ExistsInPersistentData ("level28.json"))
						ResourceHelper.SaveToPersistentData ("level28.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level28" ) {
					Level28 = new level28 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level28.json", Level28);
					if(!ResourceHelper.ExistsInPersistentData ("level29.json"))
						ResourceHelper.SaveToPersistentData ("level29.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level29" ) {
					Level29 = new level29 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level29.json", Level29);
					if(!ResourceHelper.ExistsInPersistentData ("level30.json"))
						ResourceHelper.SaveToPersistentData ("level30.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level30" ) {
					Level30 = new level30 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level30.json", Level30);
					if(!ResourceHelper.ExistsInPersistentData ("level31.json"))
						ResourceHelper.SaveToPersistentData ("level31.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level31" ) {
					Level31 = new level31 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level31.json", Level31);
					if(!ResourceHelper.ExistsInPersistentData ("level32.json"))
						ResourceHelper.SaveToPersistentData ("level32.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level32" ) {
					Level32 = new level32 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level32.json", Level32);
					if(!ResourceHelper.ExistsInPersistentData ("level33.json"))
						ResourceHelper.SaveToPersistentData ("level33.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level33" ) {
					Level33 = new level33 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level33.json", Level33);
					if(!ResourceHelper.ExistsInPersistentData ("level34.json"))
						ResourceHelper.SaveToPersistentData ("level34.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level34" ) {
					Level34 = new level34 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level34.json", Level34);
					if(!ResourceHelper.ExistsInPersistentData ("level35.json"))
						ResourceHelper.SaveToPersistentData ("level35.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level35" ) {
					Level35 = new level35 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level35.json", Level35);
					if(!ResourceHelper.ExistsInPersistentData ("level36.json"))
						ResourceHelper.SaveToPersistentData ("level36.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level36" ) {
					Level36 = new level36 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level36.json", Level36);
					if(!ResourceHelper.ExistsInPersistentData ("level37.json"))
						ResourceHelper.SaveToPersistentData ("level37.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level37" ) {
					Level37 = new level37 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level37.json", Level37);
					if(!ResourceHelper.ExistsInPersistentData ("level38.json"))
						ResourceHelper.SaveToPersistentData ("level38.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level38" ) {
					Level38 = new level38 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level38.json", Level38);
					if(!ResourceHelper.ExistsInPersistentData ("level39.json"))
						ResourceHelper.SaveToPersistentData ("level39.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level39" ) {
					Level39 = new level39 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level39.json", Level39);
					if(!ResourceHelper.ExistsInPersistentData ("level40.json"))
						ResourceHelper.SaveToPersistentData ("level40.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level40" ) {
					Level40 = new level40 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level40.json", Level40);
					if(!ResourceHelper.ExistsInPersistentData ("level41.json"))
						ResourceHelper.SaveToPersistentData ("level41.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level41" ) {
					Level41 = new level41 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level41.json", Level41);
					if(!ResourceHelper.ExistsInPersistentData ("level42.json"))
						ResourceHelper.SaveToPersistentData ("level42.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level42" ) {
					Level42 = new level42 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level42.json", Level42);
					if(!ResourceHelper.ExistsInPersistentData ("level43.json"))
						ResourceHelper.SaveToPersistentData ("level43.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level43" ) {
					Level43 = new level43 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level43.json", Level43);
					if(!ResourceHelper.ExistsInPersistentData ("level44.json"))
						ResourceHelper.SaveToPersistentData ("level44.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level44" ) {
					Level44 = new level44 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level44.json", Level44);
					if(!ResourceHelper.ExistsInPersistentData ("level45.json"))
						ResourceHelper.SaveToPersistentData ("level45.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level45" ) {
					Level45 = new level45 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level45.json", Level45);
					if(!ResourceHelper.ExistsInPersistentData ("level46.json"))
						ResourceHelper.SaveToPersistentData ("level46.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level46" ) {
					Level46 = new level46 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level46.json", Level46);
					if(!ResourceHelper.ExistsInPersistentData ("level47.json"))
						ResourceHelper.SaveToPersistentData ("level47.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level47" ) {
					Level47 = new level47 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level47.json", Level47);
					if(!ResourceHelper.ExistsInPersistentData ("level48.json"))
						ResourceHelper.SaveToPersistentData ("level48.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level48" ) {
					Level48 = new level48 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level48.json", Level48);
					if(!ResourceHelper.ExistsInPersistentData ("level49.json"))
						ResourceHelper.SaveToPersistentData ("level49.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level49" ) {
					Level49 = new level49 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level49.json", Level49);
					if(!ResourceHelper.ExistsInPersistentData ("level50.json"))
						ResourceHelper.SaveToPersistentData ("level50.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level50" ) {
					Level50 = new level50 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level50.json", Level50);
					if(!ResourceHelper.ExistsInPersistentData ("level51.json"))
						ResourceHelper.SaveToPersistentData ("level51.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level51" ) {
					Level51 = new level51 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level51.json", Level51);
					if(!ResourceHelper.ExistsInPersistentData ("level52.json"))
						ResourceHelper.SaveToPersistentData ("level52.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level52" ) {
					Level52 = new level52 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level52.json", Level52);
					if(!ResourceHelper.ExistsInPersistentData ("level53.json"))
						ResourceHelper.SaveToPersistentData ("level53.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level53" ) {
					Level53 = new level53 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level53.json", Level53);
					if(!ResourceHelper.ExistsInPersistentData ("level54.json"))
						ResourceHelper.SaveToPersistentData ("level54.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level54" ) {
					Level54 = new level54 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level54.json", Level54);
					if(!ResourceHelper.ExistsInPersistentData ("level55.json"))
						ResourceHelper.SaveToPersistentData ("level55.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level55" ) {
					Level55 = new level55 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level55.json", Level55);
					if(!ResourceHelper.ExistsInPersistentData ("level56.json"))
						ResourceHelper.SaveToPersistentData ("level56.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level56" ) {
					Level56 = new level56 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level56.json", Level56);
					if(!ResourceHelper.ExistsInPersistentData ("level57.json"))
						ResourceHelper.SaveToPersistentData ("level57.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level57" ) {
					Level57 = new level57 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level57.json", Level57);
					if(!ResourceHelper.ExistsInPersistentData ("level58.json"))
						ResourceHelper.SaveToPersistentData ("level58.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level58" ) {
					Level58 = new level58 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level58.json", Level58);
					if(!ResourceHelper.ExistsInPersistentData ("level59.json"))
						ResourceHelper.SaveToPersistentData ("level59.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level59" ) {
					Level59 = new level59 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level59.json", Level59);
					if(!ResourceHelper.ExistsInPersistentData ("level60.json"))
						ResourceHelper.SaveToPersistentData ("level60.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level60" ) {
					Level60 = new level60 {
						completed = true,
						star = 2
					};
					ResourceHelper.SaveToPersistentData ("level60.json", Level60);

				}
				}
			 else {
				Debug.Log("thirdx here");
				image3.SetActive(false);
				image6.SetActive(true);
				image2.SetActive(false);
				image5.SetActive(true);

				if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Main" ) {
					Level1 = new level1 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level1.json", Level1);
					if(!ResourceHelper.ExistsInPersistentData ("level2.json"))
						ResourceHelper.SaveToPersistentData ("level2.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level2" ) {
					Level2 = new level2 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level2.json", Level2);
					if(!ResourceHelper.ExistsInPersistentData ("level3.json"))
						ResourceHelper.SaveToPersistentData ("level3.json", "");

				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level3" ) {
					Level3 = new level3 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level3.json", Level3);
					if(!ResourceHelper.ExistsInPersistentData ("level4.json"))
						ResourceHelper.SaveToPersistentData ("level4.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level4") {
					Level4 = new level4 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level4.json", Level4);
					if(!ResourceHelper.ExistsInPersistentData ("level5.json"))
						ResourceHelper.SaveToPersistentData ("level5.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level5" ) {
					Level5 = new level5 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level5.json", Level5);
					if(!ResourceHelper.ExistsInPersistentData ("level6.json"))
						ResourceHelper.SaveToPersistentData ("level6.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level6" ) {
					Level6 = new level6 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level6.json", Level6);
					if(!ResourceHelper.ExistsInPersistentData ("level7.json"))
						ResourceHelper.SaveToPersistentData ("level7.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level7" ) {
					Level7 = new level7 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level7.json", Level7);
					if(!ResourceHelper.ExistsInPersistentData ("level8.json"))
						ResourceHelper.SaveToPersistentData ("level8.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level8" ) {
					Level8 = new level8 {
						completed = true,
						star = 1
					};

					ResourceHelper.SaveToPersistentData ("level8.json", Level8);
					if(!ResourceHelper.ExistsInPersistentData ("level9.json"))
						ResourceHelper.SaveToPersistentData ("level9.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level9" ){
					Level9 = new level9 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level9.json", Level9);
					if(!ResourceHelper.ExistsInPersistentData ("level10.json"))
						ResourceHelper.SaveToPersistentData ("level10.json", "");

				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level10") {
					Level10 = new level10 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level10.json", Level10);
					if(!ResourceHelper.ExistsInPersistentData ("level11.json"))
						ResourceHelper.SaveToPersistentData ("level11.json", "");

				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level11") {
					Level11 = new level11 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level11.json", Level11);
					if(!ResourceHelper.ExistsInPersistentData ("level12.json"))
						ResourceHelper.SaveToPersistentData ("level12.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level12") {
					Level12 = new level12 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level12.json", Level12);
					if(!ResourceHelper.ExistsInPersistentData ("level13.json"))
						ResourceHelper.SaveToPersistentData ("level13.json", "");

				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level13" ) {
					Level13 = new level13 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level13.json", Level13);
					if(!ResourceHelper.ExistsInPersistentData ("level14.json"))
						ResourceHelper.SaveToPersistentData ("level14.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level14" ) {
					Level14 = new level14 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level14.json", Level14);
					if(!ResourceHelper.ExistsInPersistentData ("level15.json"))
						ResourceHelper.SaveToPersistentData ("level15.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level15" ) {
					Level15 = new level15 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level15.json", Level15);
					if(!ResourceHelper.ExistsInPersistentData ("level16.json"))
						ResourceHelper.SaveToPersistentData ("level16.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level16" ) {
					Level16 = new level16 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level16.json", Level16);
					if(!ResourceHelper.ExistsInPersistentData ("level17.json"))
						ResourceHelper.SaveToPersistentData ("level17.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level17" ) {
					Level17 = new level17 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level17.json", Level17);
					if(!ResourceHelper.ExistsInPersistentData ("level18.json"))
						ResourceHelper.SaveToPersistentData ("level18.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level18" ) {
					Level18 = new level18 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level18.json", Level18);
					if(!ResourceHelper.ExistsInPersistentData ("level19.json"))
						ResourceHelper.SaveToPersistentData ("level19.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level19" ) {
					Level19 = new level19 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level19.json", Level19);
					if(!ResourceHelper.ExistsInPersistentData ("level20.json"))
						ResourceHelper.SaveToPersistentData ("level20.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level20" ) {
					Level20 = new level20 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level20.json", Level20);
					if(!ResourceHelper.ExistsInPersistentData ("level21.json"))
						ResourceHelper.SaveToPersistentData ("level21.json", "");

				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level21" ) {
					Level21 = new level21 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level21.json", Level21);
					if(!ResourceHelper.ExistsInPersistentData ("level22.json"))
						ResourceHelper.SaveToPersistentData ("level22.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level22" ) {
					Level22 = new level22 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level22.json", Level22);
					if(!ResourceHelper.ExistsInPersistentData ("level23.json"))
						ResourceHelper.SaveToPersistentData ("level23.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level23" ) {
					Level23 = new level23 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level23.json", Level23);
					if(!ResourceHelper.ExistsInPersistentData ("level24.json"))
						ResourceHelper.SaveToPersistentData ("level24.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level24" ) {
					Level24 = new level24 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level24.json", Level24);
					if(!ResourceHelper.ExistsInPersistentData ("level25.json"))
						ResourceHelper.SaveToPersistentData ("level25.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level25" ) {
					Level25 = new level25 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level25.json", Level25);
					if(!ResourceHelper.ExistsInPersistentData ("level26.json"))
						ResourceHelper.SaveToPersistentData ("level26.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level26" ) {
					Level26 = new level26 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level26.json", Level26);
					if(!ResourceHelper.ExistsInPersistentData ("level27.json"))
						ResourceHelper.SaveToPersistentData ("level27.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level27" ) {
					Level27 = new level27 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level27.json", Level27);
					if(!ResourceHelper.ExistsInPersistentData ("level28.json"))
						ResourceHelper.SaveToPersistentData ("level28.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level28" ) {
					Level28 = new level28 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level28.json", Level28);
					if(!ResourceHelper.ExistsInPersistentData ("level29.json"))
						ResourceHelper.SaveToPersistentData ("level29.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level29" ) {
					Level29 = new level29 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level29.json", Level29);
					if(!ResourceHelper.ExistsInPersistentData ("level30.json"))
						ResourceHelper.SaveToPersistentData ("level30.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level30" ) {
					Level30 = new level30 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level30.json", Level30);
					if(!ResourceHelper.ExistsInPersistentData ("level31.json"))
						ResourceHelper.SaveToPersistentData ("level31.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level31" ) {
					Level31 = new level31 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level31.json", Level31);
					if(!ResourceHelper.ExistsInPersistentData ("level32.json"))
						ResourceHelper.SaveToPersistentData ("level32.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level32" ) {
					Level32 = new level32 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level32.json", Level32);
					if(!ResourceHelper.ExistsInPersistentData ("level33.json"))
						ResourceHelper.SaveToPersistentData ("level33.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level33" ) {
					Level33 = new level33 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level33.json", Level33);
					if(!ResourceHelper.ExistsInPersistentData ("level34.json"))
						ResourceHelper.SaveToPersistentData ("level34.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level34" ) {
					Level34 = new level34 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level34.json", Level34);
					if(!ResourceHelper.ExistsInPersistentData ("level35.json"))
						ResourceHelper.SaveToPersistentData ("level35.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level35" ) {
					Level35 = new level35 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level35.json", Level35);
					if(!ResourceHelper.ExistsInPersistentData ("level36.json"))
						ResourceHelper.SaveToPersistentData ("level36.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level36" ) {
					Level36 = new level36 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level36.json", Level36);
					if(!ResourceHelper.ExistsInPersistentData ("level37.json"))
						ResourceHelper.SaveToPersistentData ("level37.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level37" ) {
					Level37 = new level37 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level37.json", Level37);
					if(!ResourceHelper.ExistsInPersistentData ("level38.json"))
						ResourceHelper.SaveToPersistentData ("level38.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level38" ) {
					Level38 = new level38 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level38.json", Level38);
					if(!ResourceHelper.ExistsInPersistentData ("level39.json"))
						ResourceHelper.SaveToPersistentData ("level39.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level39" ) {
					Level39 = new level39 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level39.json", Level39);
					if(!ResourceHelper.ExistsInPersistentData ("level40.json"))
						ResourceHelper.SaveToPersistentData ("level40.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level40" ) {
					Level40 = new level40 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level40.json", Level40);
					if(!ResourceHelper.ExistsInPersistentData ("level41.json"))
						ResourceHelper.SaveToPersistentData ("level41.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level41" ) {
					Level41 = new level41 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level41.json", Level41);
					if(!ResourceHelper.ExistsInPersistentData ("level42.json"))
						ResourceHelper.SaveToPersistentData ("level42.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level42" ) {
					Level42 = new level42 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level42.json", Level42);
					if(!ResourceHelper.ExistsInPersistentData ("level43.json"))
						ResourceHelper.SaveToPersistentData ("level43.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level43" ) {
					Level43 = new level43 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level43.json", Level43);
					if(!ResourceHelper.ExistsInPersistentData ("level44.json"))
						ResourceHelper.SaveToPersistentData ("level44.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level44" ) {
					Level44 = new level44 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level44.json", Level44);
					if(!ResourceHelper.ExistsInPersistentData ("level45.json"))
						ResourceHelper.SaveToPersistentData ("level45.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level45" ) {
					Level45 = new level45 {
						completed = true,
						star = 1
					};
					if(!ResourceHelper.ExistsInPersistentData ("level46.json"))
						ResourceHelper.SaveToPersistentData ("level46.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level46" ) {
					Level46 = new level46 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level46.json", Level46);
					if(!ResourceHelper.ExistsInPersistentData ("level47.json"))
						ResourceHelper.SaveToPersistentData ("level47.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level47" ) {
					Level47 = new level47 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level47.json", Level47);
					if(!ResourceHelper.ExistsInPersistentData ("level48.json"))
						ResourceHelper.SaveToPersistentData ("level48.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level48" ) {
					Level48 = new level48 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level48.json", Level48);
					if(!ResourceHelper.ExistsInPersistentData ("level49.json"))
						ResourceHelper.SaveToPersistentData ("level49.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level49" ) {
					Level49 = new level49 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level49.json", Level49);
					if(!ResourceHelper.ExistsInPersistentData ("level50.json"))
						ResourceHelper.SaveToPersistentData ("level50.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level50" ) {
					Level50 = new level50 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level50.json", Level50);
					if(!ResourceHelper.ExistsInPersistentData ("level51.json"))
						ResourceHelper.SaveToPersistentData ("level51.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level51" ) {
					Level51 = new level51 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level51.json", Level51);
					if(!ResourceHelper.ExistsInPersistentData ("level52.json"))
						ResourceHelper.SaveToPersistentData ("level52.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level52" ) {
					Level52 = new level52 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level52.json", Level52);
					if(!ResourceHelper.ExistsInPersistentData ("level53.json"))
						ResourceHelper.SaveToPersistentData ("level53.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level53" ) {
					Level53 = new level53 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level53.json", Level53);
					if(!ResourceHelper.ExistsInPersistentData ("level54.json"))
						ResourceHelper.SaveToPersistentData ("level54.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level54" ) {
					Level54 = new level54 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level54.json", Level54);
					if(!ResourceHelper.ExistsInPersistentData ("level55.json"))
						ResourceHelper.SaveToPersistentData ("level55.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level55" ) {
					Level55 = new level55 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level55.json", Level55);
					if(!ResourceHelper.ExistsInPersistentData ("level56.json"))
						ResourceHelper.SaveToPersistentData ("level56.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level56" ) {
					Level56 = new level56 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level56.json", Level56);
					if(!ResourceHelper.ExistsInPersistentData ("level57.json"))
						ResourceHelper.SaveToPersistentData ("level57.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level57" ) {
					Level57 = new level57 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level57.json", Level57);
					if(!ResourceHelper.ExistsInPersistentData ("level58.json"))
						ResourceHelper.SaveToPersistentData ("level58.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level58" ) {
					Level58 = new level58 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level58.json", Level58);
					if(!ResourceHelper.ExistsInPersistentData ("level59.json"))
						ResourceHelper.SaveToPersistentData ("level59.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level59" ) {
					Level59 = new level59 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level59.json", Level59);
					if(!ResourceHelper.ExistsInPersistentData ("level60.json"))
						ResourceHelper.SaveToPersistentData ("level60.json", "");
				} else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Level60" ) {
					Level60 = new level60 {
						completed = true,
						star = 1
					};
					ResourceHelper.SaveToPersistentData ("level60.json", Level60);

				}
			}
			this.enabled = false;
		}
        
        // On mouse down new line will be created 
        if(Input.GetMouseButtonDown(0))
        {
			if (u == 0) 
				Time.timeScale = 1;
				//pausepanel.SetActive (true);
				u++;
			
            if(line == null)
                createLine();
			mousePos = new Vector3 ();
			//disc.GetComponent<Rigidbody2D> ().bodyType = RigidbodyType2D.Dynamic;
			//f.enabled = true;
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            line.SetPosition(0,mousePos);
            startPos = mousePos;

        }
        else if(Input.GetMouseButtonUp(0))
        {
            if(line)
			{
				mousePos = new Vector3 ();
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(1,mousePos);
                endPos = mousePos;
				ll = Vector3.Distance(startPos,endPos);
                addColliderToLine();
                line = null;

            }
        }
        else if(Input.GetMouseButton(0))
        {
            if(line)
			{
				mousePos = new Vector3 ();
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(1,mousePos);
            }
        }
    }
    // Following method creates line runtime using Line Renderer component
    private void createLine()
    {
        line = new GameObject("Line"+i).AddComponent<LineRenderer>();
        //line.material =  new Material(Shader.Find("Diffuse"));
		tex.text=linecount+"";
		if(linecount>0)
		linecount--;
		
        line.SetVertexCount(2);
        line.SetWidth(0.3f,0.3f);
        //line.SetColors(Color.black, Color.black);
		line.material = mat;
        line.useWorldSpace = true;
		float lineLength = Vector3.Distance(startPos,endPos);
		print(ll);
		if(ll!=0){
			print(lineLength);
			i+=1;
		}    
		//i+=1;
		//linesAmount.text= i.ToString();
		j++;
		a.Add (line);
		if (a.Count>=3) {

			Destroy (a [0].gameObject);

			a.RemoveAt (0);
		}

    }
    // Following method adds collider to created line
    private void addColliderToLine()
    {
        BoxCollider2D col = new GameObject("Collider").AddComponent<BoxCollider2D> ();
        col.transform.parent = line.transform; // Collider is added as child object of line
        float lineLength = Vector3.Distance (startPos, endPos); // length of line
        col.size = new Vector3 (lineLength, 0.1f, 1f); // size of collider is set where X is length of line, Y is width of line, Z will be set as per requirement
        Vector3 midPoint = (startPos + endPos)/2;
        col.transform.position = midPoint; // setting position of collider object
        // Following lines calculate the angle between startPos and endPos
        float angle = (Mathf.Abs (startPos.y - endPos.y) / Mathf.Abs (startPos.x - endPos.x));
        if((startPos.y<endPos.y && startPos.x>endPos.x) || (endPos.y<startPos.y && endPos.x>startPos.x))
        {
            angle*=-1;
        }
        angle = Mathf.Rad2Deg * Mathf.Atan (angle);
        col.transform.Rotate (0, 0, angle);
		col.gameObject.AddComponent<Rigidbody2D> ();
		col.attachedRigidbody.bodyType = RigidbodyType2D.Static;
		col.gameObject.layer = 1;


    }
}
