using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parmak : MonoBehaviour
{
    Animator animator;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Power.isPowerUp==false)
        {
            animator.SetBool("fire", true);
        }


    }



}
