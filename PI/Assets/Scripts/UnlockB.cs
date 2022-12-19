using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UnlockB : MonoBehaviour
{
    public static bool unlocked = false;
     public GameObject gold;
     public GameObject wallet;
     public GameObject unlockb;

     public void onClick() {
         if(MouseClick.total >= 35000){
             unlocked = true;
             MouseClick.total -= 35000;
             wallet.GetComponent<Text>().text = Math.Round(MouseClick.total, 2).ToString();
             gold.SetActive(true);
             unlockb.SetActive(false);
         }
     }
}
