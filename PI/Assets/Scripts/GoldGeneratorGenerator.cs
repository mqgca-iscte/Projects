using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldGeneratorGenerator : MonoBehaviour
{
    private int[] gens = new int[] {1, 2, 3, 4, 5};
    private int[] costs = new int[] {250, 275, 300, 325, 350};
    public static int tier = -1;
    public GameObject button;
    public GameObject btotal;
    public GameObject genstotal;
    public GameObject text;
    public GameObject costb;
    public GameObject genstext;
    public GameObject cost;

    void generateGen() {
        GoldCoinGenerator.bgens += gens[tier];
        genstotal.GetComponent<Text>().text = BronzeCoinGenerator.rgens.ToString() + "/" + SilverCoinGenerator.mgens.ToString() + "/" + GoldCoinGenerator.bgens.ToString();
        Invoke("generateGen", 10);
    }

    public void onClick() {
        if(BCoinClick.b >= costs[tier + 1] && tier != costs.Length - 1){
            BCoinClick.b -= costs[tier + 1];
            BCoinClick.cost = 1 + (1.06 * BCoinClick.b);
            btotal.GetComponent<Text>().text = BCoinClick.b.ToString();
            costb.GetComponent<Text>().text = BCoinClick.cost.ToString();
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
