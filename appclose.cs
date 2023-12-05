using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appclose : MonoBehaviour {

	// Use this for initialization
	public timex tim;
	void Start () {

		string json = ResourceHelper.ReadFromPersistentData ("time.json");
		tim = ResourceHelper.DecodeObject<timex> (json);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnApplicationQuit()
	{
		float x = tim.t;
		timex tim1=new timex
		{
			t=Time.time+x
		};
		ResourceHelper.DeleteFromPersistentData ("time.json");
		ResourceHelper.SaveToPersistentData ("time.json", tim1);
		print (tim1.t);
	}
}
