using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject player;
    public float resetTimer = 5f;
    
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //if (player.holdingBall == false)
        //{
        //    resetTimer -= Time.deltaTime;
        //    if (resetTimer <= 0)
        //    {
        //        SceneManager.LoadScene("Demo");
        //    }
        //}

    }
}
