using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradesB : MonoBehaviour
{
    public GameObject upgrades;
    public GameObject unlockm;
    public GameObject unlockr;
    public GameObject bronze;
    public GameObject silver;
    public GameObject text;
    public static bool open = false;

    public void onClick() {
        if(open == false){
            if(UnlockM.unlocked == true){
                silver.SetActive(false);
            }else{
                unlockm.SetActive(false);
            }
            if(UnlockR.unlocked == true){
                bronze.SetActive(false); 
            }else{
                unlockr.SetActive(false);
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
            if(UnlockR.unlocked == true){
                bronze.SetActive(true); 
            }else{
                unlockr.SetActive(true);
            }
            upgrades.SetActive(false);
            open = false;
            text.GetComponent<Text>().text = "UPGRADES";
        }
    }
}
