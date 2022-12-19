using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SilverGeneratorGenerator : MonoBehaviour
{
    private int[] gens = new int[] {1, 2, 3, 4, 5};
    private int[] costs = new int[] {250, 275, 300, 325, 350};
    public static int tier = -1;
    public GameObject button;
    public GameObject mtotal;
    public GameObject genstotal;
    public GameObject text;
    public GameObject costm;
    public GameObject genstext;
    public GameObject cost;

    void generateGen() {
        SilverCoinGenerator.mgens += gens[tier];
        genstotal.GetComponent<Text>().text = BronzeCoinGenerator.rgens.ToString() + "/" + SilverCoinGenerator.mgens.ToString() + "/" + GoldCoinGenerator.bgens.ToString();
        Invoke("generateGen", 10);
    }

    public void onClick() {
        if(MCoinClick.m >= costs[tier + 1] && tier != costs.Length - 1){
            MCoinClick.m -= costs[tier + 1];
            MCoinClick.cost = 1 + (1.06 * MCoinClick.m);
            mtotal.GetComponent<Text>().text = MCoinClick.m.ToString();
            costm.GetComponent<Text>().text = MCoinClick.cost.ToString();
            if(tier == -1){
                tier++;
                generateGen();
            }else{
                tier++;
            }
            if(tier == costs.Length - 1){
                text.GetComponent<Text>().text = "MAXED OUT";
                Button upgrade = button.GetComponent<Button>();
                upgrade.interactable = false;
            }else{
                text.GetComponent<Text>().text = "Generator Generator (Tier " + (tier + 2) + ")";
                genstext.GetComponent<Text>().text = gens[tier + 1].ToString();
                cost.GetComponent<Text>().text = costs[tier + 1].ToString();
            }
        }
    }
}
