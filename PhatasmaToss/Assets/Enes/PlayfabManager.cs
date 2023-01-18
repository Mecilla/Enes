using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using TMPro;

public class PlayfabManager : MonoBehaviour
{
    public GameObject rowPrefab;
    public Transform rowsParent;
    public InputField emailInput;
    public InputField passwordInput;
    public InputField usernameInput;
    public TextMeshProUGUI messageText;
    [SerializeField] GameObject loginUI, NextScene,RegisterUI;

    // Start is called before the first frame update
    void Start()
    {
        Login();
    }


    public void RegisterButton()
    {
        var request = new RegisterPlayFabUserRequest
        {
            Email = emailInput.text,
            Password = passwordInput.text,
            DisplayName = usernameInput.text,
            RequireBothUsernameAndEmail = false

        };
        PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSuccess, OnError);
    }

    public void LoginButton()
    {
        var request = new LoginWithEmailAddressRequest
        {
            Email = emailInput.text,
            Password = passwordInput.text

        };
        PlayFabClientAPI.LoginWithEmailAddress(request, OnLoginSuccess, OnError);
    }
    private void OnLoginSuccess(LoginResult result)
    {
        messageText.text = "Logged in!";
        loginUI.SetActive(false);
        NextScene.SetActive(true);
        print("Logged in!");
    }
    private void OnRegisterSuccess(RegisterPlayFabUserResult result)
    {
        messageText.text = "Registered and logged in!";
        loginUI.SetActive(true);
        RegisterUI.SetActive(false);
    }
    private void Login()
    {
        var request = new LoginWithCustomIDRequest
        {
            CustomId = SystemInfo.deviceUniqueIdentifier,
            CreateAccount = true
    };
        PlayFabClientAPI.LoginWithCustomID(request, OnSuccess, OnError);
    }

    private void OnSuccess(LoginResult result)
    {
        print("Successful login/account create!");
    }
    private void OnError(PlayFabError error)
    {
        print("Error while logging in/creating account!");
        print(error.GenerateErrorReport());
    }

    public void SendLeaderboard(int score)
    {
        var request = new UpdatePlayerStatisticsRequest
        {
            Statistics = new List<StatisticUpdate>
            {
                new StatisticUpdate
                {
                    StatisticName="Scores",
                    Value=score
                }
            }
        };
        PlayFabClientAPI.UpdatePlayerStatistics(request, OnLeaderboardUpdate, OnError);
    }

     private void OnLeaderboardUpdate(UpdatePlayerStatisticsResult result)
    {
        print("Successfull leaderboard sent");
    }

    public void GetLeaderboard()
    {
        var request = new GetLeaderboardRequest
        {
            StatisticName = "Scores",
            StartPosition = 0,
            MaxResultsCount = 10
        };
        PlayFabClientAPI.GetLeaderboard(request, OnLeaderboardGet, OnError);
    }

    private void OnLeaderboardGet(GetLeaderboardResult result)
    {
        foreach(Transform item in rowsParent)
        {
            Destroy(item.gameObject);
        }
        foreach(var item in result.Leaderboard)
        {
            print(item.Position + " " + item.PlayFabId + " " + item.StatValue);
            GameObject newGo = Instantiate(rowPrefab, rowsParent);
            TextMeshProUGUI[] texts = newGo.GetComponentsInChildren<TextMeshProUGUI>();
            texts[0].text = (item.Position + 1).ToString();
            texts[1].text = item.DisplayName;
            texts[2].text = item.StatValue.ToString();
            
        }
    }
}
