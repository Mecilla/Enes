using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orak : MonoBehaviour
{
    public iTween.EaseType easeType;
    public iTween.LoopType loopType;

    void Start()
    {
        iTween.RotateTo(this.gameObject, iTween.Hash("x", 72, "time", 1.5f, "easetype", easeType, "looptype", loopType));

    }

    // Update is called once per frame
    void Update()
    {

    }
}
