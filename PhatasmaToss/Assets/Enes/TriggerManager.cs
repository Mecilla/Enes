using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{

    public GameObject asddd;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Glass"))
        {
            Debug.Log("S");
            //FirebaseManager.kills += 1;
        }
    }
}
