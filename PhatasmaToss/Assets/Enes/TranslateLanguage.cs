using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TranslateLanguage : MonoBehaviour
{
    public TextMeshProUGUI login, password, register, inPassword,quest,nickname,Contunie,passwordConfirm,cont,back,howtoPlay;

    private void Start()
    {
        Turkish();
    }
    public void English()
    {
        login.text = "Login";
        password.text = "Password";
        register.text = "Register";
        inPassword.text = "Password";
        quest.text = "Quess Enter";
        nickname.text = "Nickname";
        Contunie.text = "Contunie";
        passwordConfirm.text = "Password";
        cont.text = "Contunie";
        back.text = "Back";
        howtoPlay.text = "How to Play";
        
    }

    public void Turkish()
    {
        login.text = "Giris Yap";
        password.text = "Sifre";
        register.text = "Kayit ol";
        inPassword.text = "Sifre";
        quest.text = "Misafir";
        nickname.text = "Kullanici adi";
        Contunie.text = "Devam et";
        passwordConfirm.text = "Sifre";
        cont.text = "Devam et";
        back.text = "Geri";
        howtoPlay.text = "Nasil Oynanir";
    }
}
