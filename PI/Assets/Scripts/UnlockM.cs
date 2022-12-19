using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UnlockM : MonoBehaviour
{
    public static bool unlocked = false;
     public GameObject silver;
     public GameObject wallet;
     public GameObject unlockm;

     public void onClick() {
         if(MouseClick.total >= 2000){
             unlocked = true;
             MouseClick.total -= 2000;
             wallet.GetComponent<Text>().text = Math.Round(MouseClick.total, 2).ToString();
             silver.SetActive(true);
             unlockm.SetActive(false);
         }
     }
}
