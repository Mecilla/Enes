using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sandalye : MonoBehaviour
{
    public iTween.EaseType easeType;
    public iTween.LoopType loopType;

    void Start()
    {
        iTween.RotateBy(gameObject, iTween.Hash("y", 10.0f,"time",20f, "easetype", "linear", "looptype", iTween.LoopType.loop));

    }

    // Update is called once per frame
    void Update()
    {

    }
}
