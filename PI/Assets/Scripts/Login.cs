using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public GameObject username;
    public GameObject password;
    public GameObject desktop;
    public GameObject login;
    public GameObject user;
    public static string pass;
    
    public void onClick() {
        if(username.GetComponent<Text>().text.Length != 0 && password.GetComponent<Text>().text.Length != 0){
            pass = password.GetComponent<Text>().text;
            login.SetActive(false);
            desktop.SetActive(true);
            user.GetComponent<Text>().text = username.GetComponent<Text>().text;;
        }
    }
}
