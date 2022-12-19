using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseRaccoon : MonoBehaviour
{
    public GameObject text;
    public GameObject raccoon;
    public GameObject icon;
    public GameObject taskbar;
    public GameObject bg;
    public GameObject video;

    public void onClick() {
        if(UnlockRaccoon.unlocked == true){
            video.SetActive(false);
            bg.SetActive(true);
        }
        InputField input = text.GetComponent<InputField>();
        input.text = "";
        raccoon.SetActive(false);
        icon.GetComponent<Button>().interactable = true;
        RaccoonTaskbar.open = false;
        taskbar.SetActive(false);
    }
}
