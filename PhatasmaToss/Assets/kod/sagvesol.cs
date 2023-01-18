using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sagvesol : MonoBehaviour
{
    public iTween.EaseType easeType;
    public iTween.LoopType loopType;

    void Start()
    {
        iTween.MoveTo(this.gameObject, iTween.Hash("x", 1.8f,"z",11f, "time", 1.5f, "easetype", easeType, "looptype", loopType));

    }

    // Update is called once per frame
    void Update()
    {

    }
}
