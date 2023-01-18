using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class morcanavar : MonoBehaviour
{
    public iTween.EaseType easeType;
    public iTween.LoopType loopType;

    void Start()
    {
        iTween.MoveTo(this.gameObject, iTween.Hash("z", 2.5, "time", 1.5f, "easetype", easeType, "looptype", loopType));

    }

    // Update is called once per frame
    void Update()
    {

    }
}
