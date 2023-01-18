using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NetworkCheck : MonoBehaviour
{
    public Text checkbox;
 
    // Update is called once per frame
    void Update()
    {
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            checkbox.text = "Internet yok!";

        }
       else if (Application.internetReachability==NetworkReachability.ReachableViaCarrierDataNetwork)
        {
            checkbox.text = "Mobil veriye ge�i� yap�ld�";

        }
        else if (Application.internetReachability == NetworkReachability.ReachableViaLocalAreaNetwork)
        {
            checkbox.text = "Wifiye ge�i� yap�ld�";

        }
        else if(Application.internetReachability != NetworkReachability.NotReachable)
        {
            checkbox.text = "Internet var";
        }
    }
}
