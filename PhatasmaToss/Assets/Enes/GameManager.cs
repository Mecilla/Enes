using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;
using GoogleMobileAds.Api;


public class GameManager : MonoBehaviour
{
    private BannerView bannerView;
    private InterstitialAd Interstitial;
    public bool reklamGosterildi = false;
    public PlayfabManager fbmanager;
    public GameObject scoreArea;
    int kills;
    public List<GameObject> levelsButton = new List<GameObject>();
    public int x;
    public bool rigor;

    private void Awake()
    {

        kills = PlayerPrefs.GetInt("kills");
        scoreArea = GameObject.FindGameObjectWithTag("NextLevel");
        x = kills;
    }

    private void Start()
    {
        MobileAds.Initialize(InitializationStatus => { });
        this.RequestBanner();
        this.RequestInterstitial();
        getButtons();
    }

    public void getButtons()
    {


        for (int i = 0; i <= x; i++)
        {

            levelsButton[i].SetActive(true);

        }

        // GameObject asd = levelsButton[levelsButton.Count - 1];
        // asd.transform.DOShakeScale(1.5f,2,10);

    }

    // private void Update()
    // {
    //     for (int i = 0; i <= x; i++)
    //     {

    //         levelsButton[i].SetActive(true);

    //     }

    //     // GameObject asd = levelsButton[levelsButton.Count - 1];
    //     // asd.transform.DOShakeScale(1.5f,2,10);
    // }

    void RequestBanner()
    {
#if UNITY_ANDROID
        string ReklamId = "ca-app-pub-6544458607667034/4374697034";
#else

        string ReklamId = "Unexcpected Platform!";
#endif


        this.bannerView = new BannerView(ReklamId, AdSize.Banner, AdPosition.Top);
        AdRequest request = new AdRequest.Builder().Build();
        this.bannerView.LoadAd(request);

    }


    void RequestInterstitial()
    {
#if UNITY_ANDROID
        string ReklamId = "ca-app-pub-6544458607667034/9178434794";
#else

        string ReklamId = "Unexcpected Platform!";
#endif


        this.Interstitial = new InterstitialAd(ReklamId);
        AdRequest request = new AdRequest.Builder().Build();
        this.Interstitial.LoadAd(request);
    }

    public void LoadMainMenu()
    {
        fbmanager.SendLeaderboard(kills);
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadLevel1()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(2);
        DontDestroyOnLoad(scoreArea);
    }
    public void LoadLevel2()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(3);

        DontDestroyOnLoad(scoreArea);
    }
    public void LoadLevel3()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(4);
        DontDestroyOnLoad(scoreArea);
    }
    public void LoadLevel4()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(5);
        DontDestroyOnLoad(scoreArea);
    }
    public void LoadLevel5()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(6);
        DontDestroyOnLoad(scoreArea);
    }
    public void LoadLevel6()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(7);
        DontDestroyOnLoad(scoreArea);
    }
    public void LoadLevel7()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(8);
        DontDestroyOnLoad(scoreArea);
    }
    public void LoadLevel8()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(9);
        DontDestroyOnLoad(scoreArea);
    }
    public void LoadLevel9()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(10);
        DontDestroyOnLoad(scoreArea);
    }
    public void LoadLevel10()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(11);
        DontDestroyOnLoad(scoreArea);
    }
    public void LoadLevel11()
    {
        ScoreArea.alicemDogru = false;
        DontDestroyOnLoad(scoreArea);
        SceneManager.LoadScene(12);
    }
    public void LoadLevel12()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(13);
        DontDestroyOnLoad(scoreArea);
    }
    public void LoadLevel13()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(14);
        DontDestroyOnLoad(scoreArea);
    }
    public void LoadLevel14()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(15);
        DontDestroyOnLoad(scoreArea);
    }
    public void LoadLevel15()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(16);
    }
    public void LoadLevel16()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(17);
    }
    public void LoadLevel17()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(18);
    }
    public void LoadLevel18()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(19);
    }
    public void LoadLevel19()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(20);
    }
    public void LoadLevel20()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(21);
    }

    public void LoadLevel21()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(22);
    }
    public void LoadLevel22()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(23);

    }

    public void LoadLevel23()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(24);
    }
    public void LoadLevel24()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(25);
    }
    public void LoadLevel25()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(26);
    }

    public void LoadLevel26()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(27);
    }

    public void LoadLevel27()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(28);
    }

    public void LoadLevel28()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(29);
    }
    public void LoadLevel29()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(30);
    }
    public void LoadLevel30()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(31);
    }
    public void LoadLevel31()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(32);
    }
    public void LoadLevel32()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(33);
    }
    public void LoadLevel33()
    {
        ScoreArea.alicemDogru = false;
        SceneManager.LoadScene(34);
    }
    public void LoadLevel34()
    {
        SceneManager.LoadScene(27);
    }
    public void LoadLevel35()
    {
        SceneManager.LoadScene(35);
    }
    public void LoadLevel36()
    {
        SceneManager.LoadScene(36);
    }
    public void LoadLevel37()
    {
        SceneManager.LoadScene(37);
    }
    public void LoadLevel38()
    {
        SceneManager.LoadScene(38);
    }
    public void LoadLevel39()
    {
        SceneManager.LoadScene(39);
    }
    public void LoadLevel40()
    {
        SceneManager.LoadScene(40);
    }
    public void LoadLevel41()
    {
        SceneManager.LoadScene(41);
    }
    public void LoadLevel42()
    {
        SceneManager.LoadScene(42);
    }
    public void LoadLevel43()
    {
        SceneManager.LoadScene(27);
    }
    public void LoadLevel44()
    {
        SceneManager.LoadScene(43);
    }
    public void LoadLevel45()
    {
        SceneManager.LoadScene(44);
    }
    public void LoadLevel46()
    {
        SceneManager.LoadScene(47);
    }
    public void LoadLevel47()
    {
        SceneManager.LoadScene(48);
    }
    public void LoadLevel48()
    {
        SceneManager.LoadScene(49);
    }
    public void LoadLevel49()
    {
        SceneManager.LoadScene(50);
    }
    public void LoadLevel50()
    {
        SceneManager.LoadScene(51);
    }
    public void LoadLevel51()
    {
        SceneManager.LoadScene(52);
    }

    public void LoadLevel52()
    {
        SceneManager.LoadScene(53);
    }
    public void LoadLevel53()
    {
        SceneManager.LoadScene(54);
    }
    public void LoadLevel54()
    {
        SceneManager.LoadScene(55);
    }
    public void LoadLevel55()
    {
        SceneManager.LoadScene(56);
    }
    public void LoadLevel56()
    {
        SceneManager.LoadScene(57);
    }
    public void LoadLevel57()
    {
        SceneManager.LoadScene(58);
    }
    public void LoadLevel58()
    {
        SceneManager.LoadScene(59);
    }
    public void LoadLevel59()
    {
        SceneManager.LoadScene(60);
    }
    public void LoadLevel60()
    {
        SceneManager.LoadScene(61);
    }

    public void LoadLevel61()
    {
        SceneManager.LoadScene(62);
    }
    public void LoadLevel62()
    {
        SceneManager.LoadScene(63);
    }
    public void LoadLevel63()
    {
        SceneManager.LoadScene(64);
    }
    public void LoadLevel64()
    {
        SceneManager.LoadScene(65);
    }
    public void LoadLevel65()
    {
        SceneManager.LoadScene(66);
    }
    public void LoadLevel66()
    {
        SceneManager.LoadScene(67);
    }
    public void LoadLevel67()
    {
        SceneManager.LoadScene(68);
    }
    public void LoadLevel68()
    {
        SceneManager.LoadScene(69);
    }
    public void LoadLevel69()
    {
        SceneManager.LoadScene(70);
    }
    public void LoadLevel70()
    {
        SceneManager.LoadScene(71);
    }
    public void LoadLevel71()
    {
        SceneManager.LoadScene(72);
    }
    public void LoadLevel72()
    {
        SceneManager.LoadScene(73);
    }
    public void LoadLevel73()
    {
        SceneManager.LoadScene(74);
    }
    public void LoadLevel74()
    {
        SceneManager.LoadScene(75);
    }
    public void LoadLevel75()
    {
        SceneManager.LoadScene(76);
    }
    public void LoadLevel76()
    {
        SceneManager.LoadScene(77);
    }
    public void LoadLevel77()
    {
        SceneManager.LoadScene(78);
    }
    public void LoadLevel78()
    {
        SceneManager.LoadScene(79);
    }
    public void LoadLevel79()
    {
        SceneManager.LoadScene(80);
    }
    public void LoadLevel80()
    {
        SceneManager.LoadScene(81);
    }
    public void LoadLevel81()
    {
        SceneManager.LoadScene(82);
    }
    public void LoadLevel82()
    {
        SceneManager.LoadScene(83);
    }
    public void LoadLevel83()
    {
        SceneManager.LoadScene(84);
    }
    public void LoadLevel84()
    {
        SceneManager.LoadScene(85);
    }
    public void LoadLevel85()
    {
        SceneManager.LoadScene(86);
    }
    public void LoadLevel86()
    {
        SceneManager.LoadScene(87);
    }
    public void LoadLevel87()
    {
        SceneManager.LoadScene(88);
    }
    public void LoadLevel88()
    {
        SceneManager.LoadScene(89);
    }
    public void LoadLevel89()
    {
        SceneManager.LoadScene(90);
    }
    public void LoadLevel90()
    {
        SceneManager.LoadScene(91);
    }
    public void LoadLevel91()
    {
        SceneManager.LoadScene(92);
    }
    public void LoadLevel92()
    {
        SceneManager.LoadScene(93);
    }
    public void LoadLevel93()
    {
        SceneManager.LoadScene(94);
    }
    public void LoadLevel94()
    {
        SceneManager.LoadScene(95);
    }
    public void LoadLevel95()
    {
        SceneManager.LoadScene(96);
    }
    public void LoadLevel96()
    {
        SceneManager.LoadScene(97);
    }
    public void LoadLevel697()
    {
        SceneManager.LoadScene(98);
    }
    public void LoadLevel698()
    {
        SceneManager.LoadScene(99);
    }
    public void LoadLevel699()
    {
        SceneManager.LoadScene(100);
    }
    public void LoadLevel6100()
    {
        SceneManager.LoadScene(101);
    }




}
