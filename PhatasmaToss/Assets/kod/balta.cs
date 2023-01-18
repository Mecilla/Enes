using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balta : MonoBehaviour
{
    public iTween.EaseType easeType;
    public iTween.LoopType loopType;

    void Start()
    {
        iTween.MoveTo(this.gameObject, iTween.Hash("z", -9, "time", 7f, "easetype", easeType, "looptype", loopType));

    }

    // Update is called once per frame
    void Update()
    {

    }
}
