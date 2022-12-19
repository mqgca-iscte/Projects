using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseGame : MonoBehaviour
{
    public GameObject game;
    public GameObject icon;
    public GameObject taskbar;
    public GameObject mouse;

    public void onClick() {
        game.SetActive(false);
        icon.GetComponent<Button>().interactable = true;
        CryptoTaskbar.open = false;
        taskbar.SetActive(false);
        mouse.SetActive(true);
    }
}
