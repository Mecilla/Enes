using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zor : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim.speed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.speed = 0;
        }
    }
}
