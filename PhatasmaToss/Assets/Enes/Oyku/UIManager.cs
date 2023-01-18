using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{
    public GoldManager goldManager;
    public TMP_Text goldText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        goldText.text = "Altin sayisi:" + goldManager.GetGoldCount();
        
    }
}
