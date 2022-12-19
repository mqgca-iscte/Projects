using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class RCoinClick : MonoBehaviour
{
    public static float interval = 7;
    public static int r = 0;
    public static double upgrade = 1;
    public static double prestige = 1;
    public static double cost = 1;
    public GameObject rtotal;
    public GameObject wallet;
    public GameObject costr;
    
    void passiveR(){
        MouseClick.total += r * Uniform.value * upgrade * Overclock.mult * prestige;
        wallet.GetComponent<Text>().text = Math.Round(MouseClick.total, 2).ToString();
        Invoke("passiveR", interval);
    }

    public void onClick(){
        if(MouseClick.total >= cost){
            MouseClick.total -= cost;
            r += 1;
            cost = 1 + (1.06 * r);
            rtotal.GetComponent<Text>().text = r.ToString();
            wallet.GetComponent<Text>().text = Math.Round(MouseClick.total, 2).ToString();
            costr.GetComponent<Text>().text = cost.ToString();
            if(r == 1){
                passiveR();
            }
        }
    }
}