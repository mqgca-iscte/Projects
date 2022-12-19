using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CryptoTaskbar : MonoBehaviour
{
    public static bool open = true;
    public GameObject game;
    public GameObject mouse;

    public void onClick() {
        if(open == true){
            game.SetActive(false);
            open = false;
            mouse.SetActive(true);
        }else{
            game.SetActive(true);
            open = true;
            mouse.SetActive(false);
        }
    }
}
