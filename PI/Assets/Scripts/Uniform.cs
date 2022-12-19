using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Uniform : MonoBehaviour
{
    float timer;
    public static double value;
    static System.Random r = new System.Random();
    public GameObject uni;

    public static double uniform(double xMin, double xMax) {
        return Math.Round(xMin + ( xMax - xMin ) * r.NextDouble(), 2);
    }

    public static float setTimer() {
        double p, p1, p2, x;
        do {
            p1 = uniform(-1,1);
            p2 = uniform(-1,1);
            p = p1 * p1 + p2 * p2;
        } while ( p >= 1 );
        x = 40 + 20 * p1 * Math.Sqrt(-2 * Math.Log( p ) / p);
        if(10 <= x && x <= 40){
            return (float) x;
        }else if(x < 10){
            return 10;
        }else{
            return 40;
        }
    }

    void changeValue() {
        value = uniform(1, 1.5);
        uni.GetComponent<Text>().text = value.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        timer = setTimer();
        changeValue();
        Invoke("Start", timer);
    }
}