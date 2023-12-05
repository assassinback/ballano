using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileReader : MonoBehaviour {

	// Use this for initialization
	public static string json;
	public static bool level1 = false;
	public static bool level2 = false;
	public static bool level3 = false;
	public static bool level4 = false;
	public static bool level5 = false;
	public static bool level6 = false;
	public static bool level7 = false;
	public static bool level8 = false;
	public static bool level9 = false;
	public static bool level10 = false;
	public static bool level11 = false;
	public static bool level12 = false;
	public static bool level13 = false;

	public static bool level14 = false;
	public static bool level15 = false;
	public static bool level16 = false;
	public static bool level17 = false;
	public static bool level18 = false;
	public static bool level19 = false;
	public static bool level20 = false;
	public static bool level21 = false;
	public static bool level22 = false;
	public static bool level23 = false;
	public static bool level24 = false;
	public static bool level25 = false;
	public static bool level26 = false;
	public static bool level27 = false;
	public static bool level28 = false;
	public static bool level29 = false;
	public static bool level30 = false;
	public static bool level31 = false;
	public static bool level32 = false;
	public static bool level33 = false;
	public static bool level34 = false;
	public static bool level35 = false;
	public static bool level36 = false;
	public static bool level37 = false;
	public static bool level38 = false;
	public static bool level39 = false;
	public static bool level40 = false;
	public static bool level41 = false;
	public static bool level42 = false;
	public static bool level43 = false;
	public static bool level44 = false;
	public static bool level45 = false;
	public static bool level46 = false;
	public static bool level47 = false;
	public static bool level48 = false;
	public static bool level49 = false;
	public static bool level50 = false;
	public static bool level51 = false;
	public static bool level52 = false;
	public static bool level53 = false;
	public static bool level54 = false;
	public static bool level55 = false;
	public static bool level56 = false;
	public static bool level57 = false;
	public static bool level58 = false;
	public static bool level59 = false;
	public static bool level60 = false;
	void Start () {
		DontDestroyOnLoad(this.gameObject);
		if (ResourceHelper.ExistsInPersistentData ("level1.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level1.json");
			//Level1 = ResourceHelper.DecodeObject<level1> (json);
			level1 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level2.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level2.json");
			//Level2 = ResourceHelper.DecodeObject<level2> (json);
			level2 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level3.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level3.json");
			//Level3 = ResourceHelper.DecodeObject<level3> (json);
			level3 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level4.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level4.json");
			//Level4 = ResourceHelper.DecodeObject<level4> (json);
			level4 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level5.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level5.json");
			level5 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level6.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level6.json");
			level6 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level7.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level7.json");
			level7 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level8.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level8.json");
			level8 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level9.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level9.json");
			level9 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level10.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level10.json");
			level10 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level11.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level11.json");
			level11 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level12.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level12.json");
			level12 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level13.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level13.json");
			level13 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level14.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level14.json");
			level14 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level15.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level15.json");
			level15 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level16.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level16.json");
			level16 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level17.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level17.json");
			level17 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level18.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level18.json");
			level18 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level19.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level19.json");
			level19 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level20.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level20.json");
			level20 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level21.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level21.json");
			level21 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level22.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level22.json");
			level22 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level23.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level23.json");
			level23 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level24.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level24.json");
			level24 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level25.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level25.json");
			level25 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level26.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level26.json");
			level26 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level27.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level27.json");
			level27 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level28.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level28.json");
			level28 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level29.json")){
			json = ResourceHelper.ReadFromPersistentData ("level29.json");
			level29 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level30.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level30.json");
			level30 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level31.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level31.json");
			level31 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level32.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level32.json");
			level32 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level33.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level33.json");
			level33 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level34.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level34.json");
			level34 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level35.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level35.json");
			level35 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level36.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level36.json");
			level36 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level37.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level37.json");
			level37 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level38.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level38.json");
			level38 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level39.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level39.json");
			level39 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level40.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level40.json");
			level40 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level41.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level41.json");
			level41 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level42.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level42.json");
			level42 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level43.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level43.json");
			level43 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level44.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level44.json");
			level44 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level45.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level45.json");
			level45 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level46.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level46.json");
			level46 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level47.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level47.json");
			level47 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level48.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level48.json");
			level48 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level49.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level49.json");
			level49 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level50.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level50.json");
			level50 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level51.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level51.json");
			level51 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level52.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level52.json");
			level52 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level53.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level53.json");
			level53 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level54.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level54.json");
			level54 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level55.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level55.json");
			level55 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level56.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level56.json");
			level56 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level57.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level57.json");
			level57 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level58.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level58.json");
			level58 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level59.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level59.json");
			level59 = true;
		}
		if (ResourceHelper.ExistsInPersistentData ("level60.json")) {
			json = ResourceHelper.ReadFromPersistentData ("level60.json");
			level60 = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
