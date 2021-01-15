using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NivelConcluidoScript3 : MonoBehaviour
{
    private int nrCoinsLevel3;

    public Image[] imagensCoinsLevel3;

    private Color novaCor = new Color(255, 255, 255, 255);

    private void Awake() {

        nrCoinsLevel3 = PlayerScript.nrCoins;

        if (nrCoinsLevel3 == 1) {
            imagensCoinsLevel3[0].GetComponent<Image>().color = novaCor;
        }
        else if (nrCoinsLevel3 == 2) {
            imagensCoinsLevel3[0].GetComponent<Image>().color = novaCor;
            imagensCoinsLevel3[1].GetComponent<Image>().color = novaCor;
        }
        else if (nrCoinsLevel3 == 3) {
            imagensCoinsLevel3[0].GetComponent<Image>().color = novaCor;
            imagensCoinsLevel3[1].GetComponent<Image>().color = novaCor;
            imagensCoinsLevel3[2].GetComponent<Image>().color = novaCor;
        }
    }

    public void Menu() {
        SceneManager.LoadScene("Menu");
    }
}
