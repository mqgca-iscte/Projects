using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradesR : MonoBehaviour
{
    public GameObject upgrades;
    public GameObject unlockm;
    public GameObject unlockb;
    public GameObject silver;
    public GameObject gold;
    public GameObject text;
    public static bool open = false;

    public void onClick() {
        if(open == false){
            if(UnlockM.unlocked == true){
                silver.SetActive(false);
            }else{
                unlockm.SetActive(false);
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
            if(UnlockM.unlocked == true){
                silver.SetActive(true);
            }else{
                unlockm.SetActive(true);
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
