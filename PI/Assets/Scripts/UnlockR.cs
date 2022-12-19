using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UnlockR : MonoBehaviour
{
    public static bool unlocked = false;
     public GameObject bronze;
     public GameObject wallet;
     public GameObject unlockr;

     public void onClick() {
         if(MouseClick.total >= 15){
             unlocked = true;
             MouseClick.total -= 15;
             wallet.GetComponent<Text>().text = Math.Round(MouseClick.total, 2).ToString();
             bronze.SetActive(true);
             unlockr.SetActive(false);
         }
     }
}
