using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour {

    public Canvas canvas;
    private CanvasGroup canvasGroup;

    private GameObject player;

    public GameObject nivelConcluido;

    public int proximoNivel;

    public int nrNivel;

    private static int nrCoins;

    private int ScoreAtualCoins;

    void Awake() {

        player = GameObject.FindGameObjectWithTag("Player");

        proximoNivel = SceneManager.GetActiveScene().buildIndex + 1;

        nrNivel = SceneManager.GetActiveScene().buildIndex;

        ScoreAtualCoins = PlayerPrefs.GetInt("Level " + nrNivel);

    }

    private void Update() {
        nrCoins = PlayerScript.nrCoins;
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player") {
            PlayerPrefs.SetInt("Passou level " + nrNivel, 1);
            if (SceneManager.GetActiveScene().buildIndex == 3) {
                nivelConcluido.SetActive(true);
                StartCoroutine(FadeOut());
                Destroy(collision.gameObject);
            } else {
                if(ScoreAtualCoins >= nrCoins) {
                    nivelConcluido.SetActive(true);
                    StartCoroutine(FadeOut());
                    Destroy(collision.gameObject);
                    if (proximoNivel > PlayerPrefs.GetInt("levelAt")) {
                        PlayerPrefs.SetInt("levelAt", proximoNivel);
                    }
                } else {
                    PlayerPrefs.SetInt("Level " + nrNivel, nrCoins);
                    nivelConcluido.SetActive(true);
                    StartCoroutine(FadeOut());
                    Destroy(collision.gameObject);
                    if (proximoNivel > PlayerPrefs.GetInt("levelAt")) {
                        PlayerPrefs.SetInt("levelAt", proximoNivel);
                    }
                }
            }
        }
    }

    IEnumerator FadeOut() {
        canvasGroup = canvas.GetComponent<CanvasGroup>();
        while (canvasGroup.alpha > 0) {
            canvasGroup.alpha -= Time.deltaTime / 2;
            yield return null;
            canvasGroup.interactable = false;
        }
        canvasGroup.interactable = true;
        yield return null;

    }

}
