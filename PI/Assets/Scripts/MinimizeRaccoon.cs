using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinimizeRaccoon : MonoBehaviour
{
    public GameObject raccoon;

    public void onClick() {
        raccoon.SetActive(false);
        RaccoonTaskbar.open = false;
    }
}