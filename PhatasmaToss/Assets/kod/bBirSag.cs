using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bBirSag : MonoBehaviour
{
    public iTween.EaseType easeType;
    public iTween.LoopType loopType;

    void Start()
    {
        iTween.MoveTo(this.gameObject, iTween.Hash("x", 0.7f, "time", 1.5f, "easetype", easeType, "looptype", loopType));

    }

    // Update is called once per frame
    void Update()
    {

    }
}
