using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject trailObject;

    void Start()
    {
        trailObject.SetActive(false);
    }
    public void ActivateTrail()
    {
        trailObject.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
