using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Exponential : MonoBehaviour
{
    float timer;
    public static double value;
    public GameObject exp;

    public static double exponential(double a, double b) {
        return Math.Round(a - b * Math.Log( Uniform.uniform( 0, 1 ) ), 2);
    }

    void changeValue() {
        value = exponential(115, 20);
        if(value < 115){
            value = 115;
        }else if(value > 150){
            value = 150;
        }
        exp.GetComponent<Text>().text = value.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        timer = Uniform.setTimer();
        changeValue();
        Invoke("Start", timer);
    }

}
