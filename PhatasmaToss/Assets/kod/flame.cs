using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flame : MonoBehaviour
{
    public iTween.EaseType easeType;
    public iTween.LoopType loopType;

    void Start()
    {
        iTween.MoveBy(gameObject, iTween.Hash("z", 6.0f, "time", 4f, "easetype", "linear", "looptype", iTween.LoopType.pingPong));

    }

    // Update is called once per frame
    void Update()
    {

    }
}
