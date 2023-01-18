using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopyukari : MonoBehaviour
{
    public iTween.EaseType easeType;
    public iTween.LoopType loopType;

    void Start()
    {
        iTween.RotateTo(this.gameObject, iTween.Hash("z", 90, "time", 1.5f, "easetype", easeType, "looptype", loopType));

    }

    // Update is called once per frame
    void Update()
    {

    }
}
