using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldManager : MonoBehaviour
{
   [SerializeField] public  int goldCount = 0;

    public void InceraseGoldCount()
    {
        goldCount += 5;
    }
    public int GetGoldCount()
    {
        return goldCount;
    }
}
