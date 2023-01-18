using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sss : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationController.SetBool("stopAnim", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationController.SetBool("stopAnim", false);
        }
    }

}
