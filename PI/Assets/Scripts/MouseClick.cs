using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MouseClick : MonoBehaviour
{
    public GameObject wallet;
    public static double mult = 1;
    public static double total = 0;

    public void onClick(){
        if(Overclock.cur < Overclock.max){
            Overclock.cur += 1;
        }
        total += (1 * mult) * Overclock.mult;
        wallet.GetComponent<Text>().text = Math.Round(total, 2).ToString();
    }
}
