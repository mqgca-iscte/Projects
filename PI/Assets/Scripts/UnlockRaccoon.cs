using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockRaccoon : MonoBehaviour
{
    public GameObject password;
    public GameObject bg;
    public GameObject raccoon;
    public static bool unlocked = false;
    
    public void onClick() {
        if(password.GetComponent<Text>().text == Login.pass){
            unlocked = true;
            bg.SetActive(false);
            raccoon.SetActive(true);
        }
    }
}