using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
public class ResetLives : MonoBehaviour {

	// Use this for initialization
	private float livesResetRate = 3600f;
	private float nextLivesReset = 120f;
	public PlayerLives lives;
	
	public Text amount;
	void Start () {
		DontDestroyOnLoad(this.gameObject);
		amount=this.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
//		if(Time.time>livesResetRate){
//			//nextLivesReset = Time.time + livesResetRate;
//			Lives.livesAmount += 10;
//			amount.text = Lives.livesAmount.ToString();
//			livesResetRate*=2;
//			lives = new PlayerLives{
//				lives = Lives.livesAmount,
//				isLoaded = true
//			};
//			ResourceHelper.SaveToPersistentData("lives.json",lives);
		}
	}

