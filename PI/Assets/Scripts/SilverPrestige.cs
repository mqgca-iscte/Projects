using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SilverPrestige : MonoBehaviour
{
    private double[] multipliers = new double[] {1.5, 2, 3, 4, 5};
    private int[] costs = new int[] {125, 250, 750, 1000, 1250};
    private int tier = 0;
    public GameObject button;
    public GameObject mtotal;
    public GameObject genstotal;
    public GameObject text;
    public GameObject pmult;
    public GameObject pcost;
    public GameObject costm;
    public GameObject coingens;
    public GameObject coingenstext;
    public GameObject coingenscost;
    public GameObject gens;
    public GameObject genstext;
    public GameObject genscost;
    public GameObject income;
    public GameObject incmult;
    public GameObject inccost;
    public GameObject interval;
    public GameObject itv;
    public GameObject itvcost;
    public GameObject incbutton;
    public GameObject intbutton;
    public GameObject coinbutton;
    public GameObject genbutton;

    public void onClick() {
        if(MCoinClick.m >= costs[tier] && tier != costs.Length - 1){
            MCoinClick.prestige = multipliers[tier];
            MCoinClick.m = 0;
            MCoinClick.cost = 1 + (1.06 * MCoinClick.m);
            SilverCoinGenerator.mgens = 0;
            SilverCoinGenerator.tier = -1;
            SilverGeneratorGenerator.tier = -1;
            SilverIncomeUpgrade.tier = 0;
            SilverIntervalUpgrade.tier = 0;
            mtotal.GetComponent<Text>().text = MCoinClick.m.ToString();
            costm.GetComponent<Text>().text = MCoinClick.cost.ToString();
            genstotal.GetComponent<Text>().text = BronzeCoinGenerator.rgens.ToString() + "/" + SilverCoinGenerator.mgens.ToString() + "/" + GoldCoinGenerator.bgens.ToString();
            coingens.GetComponent<Text>().text = "Coin Generator (Tier 1)";
            coingenstext.GetComponent<Text>().text = "1";
            coingenscost.GetComponent<Text>().text = "50";
            gens.GetComponent<Text>().text = "Generator Generator (Tier 1)";
            genstext.GetComponent<Text>().text = "1";
            genscost.GetComponent<Text>().text = "250";
            income.GetComponent<Text>().text = "Income Upgrade (Tier 1)";
            incmult.GetComponent<Text>().text = "x1.7";
            inccost.GetComponent<Text>().text = "200";
            interval.GetComponent<Text>().text = "Income Interval Upgrade (Tier 1)";
            itv.GetComponent<Text>().text = "5.5s";
            itvcost.GetComponent<Text>().text = "100";
            Button incb = incbutton.GetComponent<Button>();
            Button intb = intbutton.GetComponent<Button>();
            Button coinb = coinbutton.GetComponent<Button>();
            Button genb = genbutton.GetComponent<Button>();
            if(incb.interactable == false){
                incb.interactable = true;
            }
            if(intb.interactable == false){
                intb.interactable = true;
            }
            if(coinb.interactable == false){
                coinb.interactable = true;
            }
            if(genb.interactable == false){
                genb.interactable = true;
            }
            tier++;
            if(tier == costs.Length){
                text.GetComponent<Text>().text = "MAXED OUT";
                Button upgrade = button.GetComponent<Button>();
                upgrade.interactable = false;
            }else{
                text.GetComponent<Text>().text = "Prestige (Tier " + (tier + 1) + ")";
                pmult.GetComponent<Text>().text = "x" + multipliers[tier].ToString();
                pcost.GetComponent<Text>().text = costs[tier].ToString();
            }
        }
    }
}
