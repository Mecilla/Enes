using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dolap : MonoBehaviour
{
    public iTween.EaseType easeType;
    public iTween.LoopType loopType;

    void Start()
    {
        iTween.MoveBy(gameObject, iTween.Hash("y", 2.0f, "time", 4f, "easetype", "linear", "looptype", iTween.LoopType.pingPong));

    }

    // Update is called once per frame
    void Update()
    {

    }
}
