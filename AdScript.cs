using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class AdScript : MonoBehaviour {

	// Use this for initialization
	private BannerView bannerView;
    void Start () {

        showBannerAd();
		
	}

    private void showBannerAd()
    {
        string adID = "ca-app-pub-3940256099942544/6300978111";

        //***For Testing in the Device***
        AdRequest request = new AdRequest.Builder()
       .AddTestDevice(AdRequest.TestDeviceSimulator)       // Simulator.
       .AddTestDevice("ee87b17a516ab4a51480da4998602f1a")  // My test device.
       .Build();

        //***For Production When Submit App***
        //AdRequest request = new AdRequest.Builder().Build();

        BannerView bannerAd = new BannerView(adID, AdSize.SmartBanner, AdPosition.Top);
        bannerAd.LoadAd(request);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
//"EE87B17A516AB4A51480DA4998602F1A"