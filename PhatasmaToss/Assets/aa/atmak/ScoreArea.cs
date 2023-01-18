using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreArea : MonoBehaviour
{
    public GameObject effectObject;
    
    public static bool alicemDogru;


    private void Awake()
    {
        
        
    }
    private void Start()
    {
       

        effectObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.GetComponent<Ball> () != null)
        {
            effectObject.SetActive(true);
            
            alicemDogru = true;
            Debug.Log("Score!");
        }
    }
}
