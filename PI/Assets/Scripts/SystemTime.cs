using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SystemTime : MonoBehaviour
{
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        text.GetComponent<Text>().text = System.DateTime.Now.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        text.GetComponent<Text>().text = System.DateTime.Now.ToString();
    }
}
