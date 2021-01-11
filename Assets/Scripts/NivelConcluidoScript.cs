using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NivelConcluidoScript : MonoBehaviour
{

    private int nrCoinsLevel1;
    private int nrCoinsLevel2;
    private int nrCoinsLevel3;

    public Image[] imagensCoinsLevel1;

    private Color novaCor = new Color(255, 255, 255, 255);

    private void Awake() {

        nrCoinsLevel1 = PlayerPrefs.GetInt("Level 1");

        if (nrCoinsLevel1 == 1) {
            imagensCoinsLevel1[0].GetComponent<Image>().color = novaCor;
        }
        else if (nrCoinsLevel1 == 2) {
            imagensCoinsLevel1[0].GetComponent<Image>().color = novaCor;
            imagensCoinsLevel1[1].GetComponent<Image>().color = novaCor;
        }
        else if (nrCoinsLevel1 == 3) {
            imagensCoinsLevel1[0].GetComponent<Image>().color = novaCor;
            imagensCoinsLevel1[1].GetComponent<Image>().color = novaCor;
            imagensCoinsLevel1[2].GetComponent<Image>().color = novaCor;
        }
    }

    public void ProximoNivel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Menu () {
        SceneManager.LoadScene("Menu");
    }


}
