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

    public Image black;
    public Animator anim;

    void Awake() {

        player = GameObject.FindGameObjectWithTag("Player");

    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player") {

            nivelConcluido.SetActive(true);
            StartCoroutine(FadeOut());
            Destroy(collision.gameObject);

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
