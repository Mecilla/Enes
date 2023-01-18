using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Power : MonoBehaviour
{
    public Image PowerUpImage;

    public Text PowerText;
    private int count;
    public static bool isPowerUp = true;
    public static bool stopHand;
    public GameObject nextLevel;
    bool isDirection = true;
    private bool againTRY;
    private int tryCount;
    float power = 0;
    float powerSpeed = 100.0f;
    private Transform startPos;
    [SerializeField] GameObject ReSpawn;
    [SerializeField] GameObject stopButton,shootButton,loseScreen;
    //[SerializeField] private GameObject powerScript;



    public GameObject player;

    private void Awake()
    {
        loseScreen = GameObject.FindGameObjectWithTag("LoseScreen");
        nextLevel = GameObject.FindGameObjectWithTag("NextLevel");
        nextLevel.SetActive(false);
    }
    private void Start()
    {
        //stopHand = true;
        loseScreen.SetActive(false);
        tryCount = 3;
        ReSpawn = GameObject.FindGameObjectWithTag("asd");

    }
    void Update()
    {
        
        startPos = ReSpawn.transform;
        print(startPos.transform);

        if (isPowerUp == true)
        {
            PowerActive();
        }

        if (ScoreArea.alicemDogru == true)
        {
            nextLevel.SetActive(true);
        }

        //if (Input.GetMouseButtonDown(0))
        //{
        //    EndPower();
        //}
    }

    void PowerActive()
    {
        if (isDirection == true)
        {
            power += Time.deltaTime * powerSpeed;

            if (power > 100)
            {
                isDirection = false;
                power = 100;
            }

        }
        else
        {
            power -= Time.deltaTime * powerSpeed;
            if (power < 0)
            {
                isDirection = true;
                power = 0;
            }
        }

        PowerUpImage.fillAmount = power / 100;

    }
    public void iStop()
    {
        stopHand = true;
        PowerActive();


    }
    public void Shot()
    {
        tryCount -= 1;
        EndPower();
        if (tryCount==0)
        {
            loseScreen.SetActive(true);
        }
    }
    void EndPower()
    {
        isPowerUp = false;
        PowerText.text = power.ToString("F0");


        player.GetComponent<Rigidbody>().velocity = new Vector3(0, power / 20, power / 20);
        isPowerUp = true;
        againTRY = true;
        
        StartCoroutine(tryAgain());

    }

    private IEnumerator tryAgain()
    {
        while (againTRY==true&&ScoreArea.alicemDogru!=true&&tryCount!=0)
        {
            print("oykus");
            yield return new WaitForSeconds(3f);
            player.transform.position = new Vector3(startPos.transform.position.x, startPos.transform.position.y, startPos.transform.position.z);
            yield return new WaitForSeconds(1.5f);
            stopHand = false;
            stopButton.SetActive(true);
            shootButton.SetActive(false);
            againTRY = false;

        }
    }

}