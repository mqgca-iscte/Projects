using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MCoinClick : MonoBehaviour
{
    public static float interval = 7;
    public static int m = 0;
    public static double upgrade = 1;
    public static double prestige = 1;
    public static double cost = 1;
    public GameObject mtotal;
    public GameObject wallet;
    public GameObject costm;
    
    void passiveM(){
        MouseClick.total += m * Beta.value * upgrade * Overclock.mult * prestige;
        wallet.GetComponent<Text>().text = Math.Round(MouseClick.total, 2).ToString();
        Invoke("passiveM", interval);
    }

    public void onClick(){
        if(MouseClick.total >= cost){
            MouseClick.total -= cost;
            m += 1;
            cost = 1 + (1.06 * m);
            mtotal.GetComponent<Text>().text = m.ToString();
            wallet.GetComponent<Text>().text = Math.Round(MouseClick.total, 2).ToString();
            costm.GetComponent<Text>().text = cost.ToString();
            if(m == 1){
                passiveM();
            }
        }
    }
}