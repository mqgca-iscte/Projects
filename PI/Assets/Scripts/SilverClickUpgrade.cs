using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SilverClickUpgrade : MonoBehaviour
{
    public GameObject button;
    public GameObject mtotal;
    public GameObject text;
    public GameObject costm;
    public void onClick() {
        if(MCoinClick.m >= 25){
            MouseClick.mult = 2;
            MCoinClick.m -= 25;
            MCoinClick.cost = 1 + (1.06 * MCoinClick.m);
            mtotal.GetComponent<Text>().text = MCoinClick.m.ToString();
            costm.GetComponent<Text>().text = MCoinClick.cost.ToString();
            text.GetComponent<Text>().text = "MAXED OUT";
            Button upgrade = button.GetComponent<Button>();
            upgrade.interactable = false;
        }
    }
}
