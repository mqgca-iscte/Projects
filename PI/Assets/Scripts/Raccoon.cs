using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Raccoon : MonoBehaviour
{
    public GameObject raccoon;
    public GameObject taskbar;
    public GameObject icon;

    public void onClick() {
        raccoon.SetActive(true);
        taskbar.SetActive(true);
        RaccoonTaskbar.open = true;
        icon.GetComponent<Button>().interactable = false;
    }
}
