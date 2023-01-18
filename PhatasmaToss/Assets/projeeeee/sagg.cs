using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sagg : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim.speed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Power.stopHand==true)
        {
            anim.speed = 0;
        }
        else if (Power.stopHand==false)
        {
            anim.speed = 1;
        }
    }
}
