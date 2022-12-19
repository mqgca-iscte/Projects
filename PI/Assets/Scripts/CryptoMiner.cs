using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CryptoMiner : MonoBehaviour
{
    public GameObject game;
    public GameObject taskbar;
    public GameObject icon;
    public GameObject mouse;

    public void onClick() {
        game.SetActive(true);
        taskbar.SetActive(true);
        CryptoTaskbar.open = true;
        icon.GetComponent<Button>().interactable = false;
        mouse.SetActive(false);
    }
}
