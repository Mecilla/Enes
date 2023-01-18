using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using System;

public class RewardManager : MonoBehaviour
{

    private RewardedAd odullureklam;
    private GoldManager goldManager;
    private string adID;


    void Start()
    {
        

        goldManager = gameObject.GetComponent<GoldManager>();
#if UNITY_ANDROID
        adID = "ca-app-pub-6544458607667034/9529788583";
#endif
        this.odullureklam = new RewardedAd(adID);
        this.odullureklam.OnUserEarnedReward += OyuncuyaOdulVer;

     

    }

    public void ReklamIzlet()
    {
        
        AdRequest request = new AdRequest.Builder().Build();
        this.odullureklam.LoadAd(request);
        if (this.odullureklam.IsLoaded())
        {
            this.odullureklam.Show();


        }

    }

    private void OyuncuyaOdulVer(object sender, Reward e)
    {
        Debug.Log("Kullan�c� reklam� izledi ve �d�l� verildi");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
