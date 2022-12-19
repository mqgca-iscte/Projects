using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldCoinGenerator : MonoBehaviour
{
    private int[] coins = new int[] {1, 2, 3, 4, 5};
    private int[] costs = new int[] {50, 75, 90, 125, 150};
    public static int tier = -1;
    public static int bgens = 0;
    public GameObject button;
    public GameObject btotal;
    public GameObject genstotal;
    public GameObject text;
    public GameObject costb;
    public GameObject coinstext;
    public GameObject cost;

    void generateCoin() {
        BCoinClick.b += bgens * coins[tier];
        btotal.GetComponent<Text>().text = BCoinClick.b.ToString();
        Invoke("generateCoin", 10);
    }

    public void onClick() {
        if(BCoinClick.b >= costs[tier + 1] && tier != costs.Length - 1){
            BCoinClick.b -= costs[tier + 1];
            BCoinClick.cost = 1 + (1.06 * BCoinClick.b);
            btotal.GetComponent<Text>().text = BCoinClick.b.ToString();
            costb.GetComponent<Text>().text = BCoinClick.cost.ToString();
            if(tier == -1){
                bgens++;
                tier++;
                genstotal.GetComponent<Text>().text = BronzeCoinGenerator.rgens.ToString() + "/" + SilverCoinGenerator.mgens.ToString() + "/" + bgens.ToString();
                generateCoin();
            }else{
                tier++;
            }
            if(tier == costs.Length - 1){
                text.GetComponent<Text>().text = "MAXED OUT";
                Button upgrade = button.GetComponent<Button>();
                upgrade.interactable = false;
            }else{
                text.GetComponent<Text>().text = "Coin Generator (Tier " + (tier + 2) + ")";
                coinstext.GetComponent<Text>().text = coins[tier + 1].ToString();
                cost.GetComponent<Text>().text = costs[tier + 1].ToString();
            }
        }
    }
}
