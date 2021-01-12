using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NivelConcluidoScript2 : MonoBehaviour {

    private int nrCoinsLevel2;

    public Image[] imagensCoinsLevel2;

    private Color novaCor = new Color(255, 255, 255, 255);

    private void Awake() {

        nrCoinsLevel2 = PlayerScript.nrCoins;

        if (nrCoinsLevel2 == 1) {
            imagensCoinsLevel2[0].GetComponent<Image>().color = novaCor;
        }
        else if (nrCoinsLevel2 == 2) {
            imagensCoinsLevel2[0].GetComponent<Image>().color = novaCor;
            imagensCoinsLevel2[1].GetComponent<Image>().color = novaCor;
        }
        else if (nrCoinsLevel2 == 3) {
            imagensCoinsLevel2[0].GetComponent<Image>().color = novaCor;
            imagensCoinsLevel2[1].GetComponent<Image>().color = novaCor;
            imagensCoinsLevel2[2].GetComponent<Image>().color = novaCor;
        }
    }

    public void ProximoNivel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Menu() {
        SceneManager.LoadScene("Menu");
    }
}
