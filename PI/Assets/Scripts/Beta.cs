using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Beta : MonoBehaviour
{
    float timer;
    public static double value;
    public GameObject bet;

    double gamma( double a, double b, double c ) {

    double A = 1 / Math.Sqrt( 2 * c - 1 );
    double B = c - Math.Log( 4 );
    double Q = c + 1 / A;
    double T = 4.5;
    double D = 1 + Math.Log( T );
    double C = 1 + c / Math.E;

    if ( c < 1 ) {
        while ( true ) {
            double p = C * Uniform.uniform( 0, 1 );
            if ( p > 1 ) {
                double y = -Math.Log( ( C - p ) / c );
                if ( Uniform.uniform( 0, 1 ) <= Math.Pow( y, c - 1 ) ) return a + b * y;
            }
            else {
                double y = Math.Pow( p, 1 / c );
                if ( Uniform.uniform( 0, 1 ) <= Math.Exp( -y ) ) return a + b * y;
            }
        }
    }
    else if ( c == 1.0 ) return Exponential.exponential( a, b );
    else {
        while ( true ) {
            double p1 = Uniform.uniform( 0, 1 );
            double p2 = Uniform.uniform( 0, 1 );
            double v = A * Math.Log( p1 / ( 1 - p1 ) );
            double y = c * Math.Exp( v );
            double z = p1 * p1 * p2;
            double w = B + Q * v - y;
            if ( w + D - T * z >= 0 || w >= Math.Log( z ) ) return a + b * y;
            }
        }
    }

    double beta() {
        double y1 = gamma( 0, 1, 0.4 );
        double y2 = gamma( 0, 1, 0.4 );
        return Math.Round(10 + ( 15 - 10 ) * y1 / ( y1 + y2 ), 2);
    }

    void changeValue() {
        value = beta();
        bet.GetComponent<Text>().text = value.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        timer = Uniform.setTimer();
        changeValue();
        Invoke("Start", timer);
    }
}
