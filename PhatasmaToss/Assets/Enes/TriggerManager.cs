using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{

    public GameObject asddd;
    public int kills;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Glass"))
        {
            // int x=kills = PlayerPrefs.GetInt("kills");
            // x+=1;
            // Debug.Log("S");
            // PlayerPrefs.SetInt("kills",x);
            //FirebaseManager.kills += 1;
        }
    }
}
