using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BCoinClick : MonoBehaviour
{
    public static float interval = 7;
    public static int b = 0;
    public static double upgrade = 1;
    public static double prestige = 1;
    public static double cost = 1;
    public GameObject btotal;
    public GameObject wallet;
    public GameObject costb;

    void passiveB(){
        MouseClick.total += b * Exponential.value * upgrade * Overclock.mult * prestige;
        wallet.GetComponent<Text>().text = Math.Round(MouseClick.total, 2).ToString();
        Invoke("passiveB", interval);
    }
    
    public void onClick(){
        if(MouseClick.total >= cost){
            MouseClick.total -= cost;
            b += 1;
            cost = 1 + (1.06 * b);
            btotal.GetComponent<Text>().text = b.ToString();
            wallet.GetComponent<Text>().text = Math.Round(MouseClick.total, 2).ToString();
            costb.GetComponent<Text>().text = cost.ToString();
            if(b == 1){
                passiveB();
            }
        }
    }
}
