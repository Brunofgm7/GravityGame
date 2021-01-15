using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    public Canvas canvas;
    private CanvasGroup canvasGroup;

    public GameObject MenuLevels;

    private int nrCoinsLevel1;
    private int nrCoinsLevel2;
    private int nrCoinsLevel3;

    public Image[] imagensCoinsLevel1;
    public Image[] imagensCoinsLevel2;
    public Image[] imagensCoinsLevel3;

    public Button BotaoLevel1;
    public Button BotaoLevel2;
    public Button BotaoLevel3;

    private int passouLevel1;
    private int passouLevel2;
    private int passouLevel3;

    private Color novaCorCoins = new Color(255, 255, 255, 255);
    private Color novaCorBotao = new Color(0, 255, 0, 255);

    private void Awake() {

        nrCoinsLevel1 = PlayerPrefs.GetInt("Level 1");
        nrCoinsLevel2 = PlayerPrefs.GetInt("Level 2");
        nrCoinsLevel3 = PlayerPrefs.GetInt("Level 3");

        if (nrCoinsLevel1 == 1) {
            imagensCoinsLevel1[0].GetComponent<Image>().color = novaCorCoins;
        }
        else if (nrCoinsLevel1 == 2) {
            imagensCoinsLevel1[0].GetComponent<Image>().color = novaCorCoins;
            imagensCoinsLevel1[1].GetComponent<Image>().color = novaCorCoins;
        }
        else if (nrCoinsLevel1 == 3) {
            imagensCoinsLevel1[0].GetComponent<Image>().color = novaCorCoins;
            imagensCoinsLevel1[1].GetComponent<Image>().color = novaCorCoins;
            imagensCoinsLevel1[2].GetComponent<Image>().color = novaCorCoins;
        }
        if (nrCoinsLevel2 == 1) {
            imagensCoinsLevel2[0].GetComponent<Image>().color = novaCorCoins;
        }
        else if (nrCoinsLevel2 == 2) {
            imagensCoinsLevel2[0].GetComponent<Image>().color = novaCorCoins;
            imagensCoinsLevel2[1].GetComponent<Image>().color = novaCorCoins;
        }
        else if (nrCoinsLevel2 == 3) {
            imagensCoinsLevel2[0].GetComponent<Image>().color = novaCorCoins;
            imagensCoinsLevel2[1].GetComponent<Image>().color = novaCorCoins;
            imagensCoinsLevel2[2].GetComponent<Image>().color = novaCorCoins;
        }
        if (nrCoinsLevel3 == 1) {
            imagensCoinsLevel3[0].GetComponent<Image>().color = novaCorCoins;
        }
        else if (nrCoinsLevel3 == 2) {
            imagensCoinsLevel3[0].GetComponent<Image>().color = novaCorCoins;
            imagensCoinsLevel3[1].GetComponent<Image>().color = novaCorCoins;
        }
        else if (nrCoinsLevel3 == 3) {
            imagensCoinsLevel3[0].GetComponent<Image>().color = novaCorCoins;
            imagensCoinsLevel3[1].GetComponent<Image>().color = novaCorCoins;
            imagensCoinsLevel3[2].GetComponent<Image>().color = novaCorCoins;
        }

        passouLevel1 = PlayerPrefs.GetInt("Passou level 1");
        passouLevel2 = PlayerPrefs.GetInt("Passou level 2");
        passouLevel3 = PlayerPrefs.GetInt("Passou level 3");

        if (passouLevel1 == 1) {
            BotaoLevel1.GetComponent<Image>().color = novaCorBotao;
        }
        if(passouLevel2 == 1) {
            BotaoLevel2.GetComponent<Image>().color = novaCorBotao;
        }
        if (passouLevel3 == 1) {
            BotaoLevel3.GetComponent<Image>().color = novaCorBotao;
        }
    }

    public void Level1() {

        SceneManager.LoadScene("Level1");

    }

    public void Level2() {

        SceneManager.LoadScene("Level2");

    }

    public void Level3() {

        SceneManager.LoadScene("Level3");

    }

    public void Back() {
        MenuLevels.SetActive(false);
    }

    public void AbrirLevels() {
        MenuLevels.SetActive(true);
    }

}
