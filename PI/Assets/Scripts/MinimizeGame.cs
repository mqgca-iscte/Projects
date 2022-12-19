using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinimizeGame : MonoBehaviour
{
    public GameObject game;
    public GameObject mouse;

    public void onClick() {
        game.SetActive(false);
        CryptoTaskbar.open = false;
        mouse.SetActive(true);
    }
}