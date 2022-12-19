using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Overclock : MonoBehaviour
{
    public static int max = 100;
    public static int cur = 0;
    public static double mult = 1;
    float timer;
    bool alternate = true;
    bool space = true;
    public GameObject mask;
    public GameObject text;
 
    void getCurrentFill() {
        float fillamount = (float) cur / (float) max;
        Image fill = mask.GetComponent<Image>();
        fill.fillAmount = fillamount;
    }

    void pressSpace() {
        text.GetComponent<Text>().text = "PRESS SPACE";
    }

    void overclock(){
        text.GetComponent<Text>().text = "OVERCLOCK";
    }

    float setTimer() {
        double p, p1, p2, x;
        do {
            p1 = Uniform.uniform(-1,1);
            p2 = Uniform.uniform(-1,1);
            p = p1 * p1 + p2 * p2;
        } while ( p >= 1 );
        x = Math.Round(30 + 20 * p1 * Math.Sqrt(-2 * Math.Log( p ) / p));
        if(15 <= x && x <= 45){
            return (float) x;
        }else{
            return 60;
        }
    }

    void generateMultiplier(){
        double x = Uniform.uniform(0, 1);
        if(x <= 0.5){
            mult = 2;
        }else if(0.5 < x && x <= 0.7){
            mult = 1.5;
        }else if(0.7 < x && x <= 0.9){
            mult = 2.5;
        }else if(0.9 < x && x <= 0.95){
            mult = 3;
        }else if(0.95 < x && x <= 0.99){
            mult = 5;
        }else if(x == 1){
            mult = 10;
        }
    }

    void resetMultiplier(){
        CancelInvoke();
        cur = 0;
        alternate = true;
        space = true;
        mult = 1;
        text.GetComponent<Text>().text = "OVERCLOCK";
    }

    void timerCountdown(){
        timer -= 1;
        text.GetComponent<Text>().text = "Multiplier: x" + mult + "   Timer: " + timer + "s";
    }

    // Update is called once per frame
    void Update()
    {
        getCurrentFill();
        if(cur == max){
            if(alternate == true){
                InvokeRepeating("pressSpace", 0.001f, 4);
                InvokeRepeating("overclock", 2, 4);
                alternate = false;
            }
            if(Input.GetKeyDown("space") && space == true){
                CancelInvoke();
                timer = setTimer();
                generateMultiplier();
                text.GetComponent<Text>().text = "Multiplier: x" + mult + "   Timer: " + timer + "s";
                Invoke("resetMultiplier", timer);
                InvokeRepeating("timerCountdown", 1, 1);
                space = false;
            }
        }
    }
}
