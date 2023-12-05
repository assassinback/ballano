using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Lives : MonoBehaviour {

	// Use this for initialization
	//public static int livesAmount = 50;
	public static int currentLives;
	public static Text timeText;
	public PlayerLives live;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	
}
public class PlayerLives{
		public int lives{get;set;}
		public bool isLoaded{get;set;}
	}