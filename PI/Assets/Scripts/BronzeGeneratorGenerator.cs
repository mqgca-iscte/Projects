using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BronzeGeneratorGenerator : MonoBehaviour
{
    private int[] gens = new int[] {1, 2, 3, 4, 5};
    private int[] costs = new int[] {250, 275, 300, 325, 350};
    public static int tier = -1;
    public GameObject button;
    public GameObject rtotal;
    public GameObject genstotal;
    public GameObject text;
    public GameObject costr;
    public GameObject genstext;
    public GameObject cost;

    void generateGen() {
        BronzeCoinGenerator.rgens += gens[tier];
        genstotal.GetComponent<Text>().text = BronzeCoinGenerator.rgens.ToString() + "/" + SilverCoinGenerator.mgens.ToString() + "/" + GoldCoinGenerator.bgens.ToString();
    }

    public void onClick() {
        if(RCoinClick.r >= costs[tier + 1] && tier != costs.Length - 1){
            RCoinClick.r -= costs[tier + 1];
            RCoinClick.cost = 1 + (1.06 * RCoinClick.r);
            rtotal.GetComponent<Text>().text = RCoinClick.r.ToString();
            costr.GetComponent<Text>().text = RCoinClick.cost.ToString();
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
