using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaccoonTaskbar : MonoBehaviour
{
    public static bool open = true;
    public GameObject raccoon;

    public void onClick() {
        if(open == true){
            raccoon.SetActive(false);
            open = false;
        }else{
            raccoon.SetActive(true);
            open = true;
        }
    }
}
