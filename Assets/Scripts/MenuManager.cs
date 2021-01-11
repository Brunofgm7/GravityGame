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

    private Color novaCor = new Color(255, 255, 255, 255);

    private void Awake() {

        nrCoinsLevel1 = PlayerPrefs.GetInt("Level 1");
        nrCoinsLevel2 = PlayerPrefs.GetInt("Level 2");
        nrCoinsLevel3 = PlayerPrefs.GetInt("Level 3");

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

    public void StartGame() {

        StartCoroutine(Fade());

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void AbrirLevels() {

        MenuLevels.SetActive(true);

    }

    IEnumerator Fade() {
        canvasGroup = canvas.GetComponent<CanvasGroup>();
        while (canvasGroup.alpha > 0) {
            canvasGroup.alpha -= Time.deltaTime / 2;
            yield return null;
        }
        canvasGroup.interactable = true;
        yield return null;


    }

}
