using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradesM : MonoBehaviour
{
    public GameObject upgrades;
    public GameObject unlockr;
    public GameObject unlockb;
    public GameObject bronze;
    public GameObject gold;
    public GameObject text;
    public static bool open = false;

    public void onClick() {
        if(open == false){
            if(UnlockR.unlocked == true){
                bronze.SetActive(false);
            }else{
                unlockr.SetActive(false);
            }
            if(UnlockB.unlocked == true){
                gold.SetActive(false); 
            }else{
                unlockb.SetActive(false);
            }
            upgrades.SetActive(true);
            open = true;
            text.GetComponent<Text>().text = "RETURN";
        }else{
            if(UnlockR.unlocked == true){
                bronze.SetActive(true);
            }else{
                unlockr.SetActive(true);
            }
            if(UnlockB.unlocked == true){
                gold.SetActive(true); 
            }else{
                unlockb.SetActive(true);
            }
            upgrades.SetActive(false);
            open = false;
            text.GetComponent<Text>().text = "UPGRADES";
        }
    }
}
