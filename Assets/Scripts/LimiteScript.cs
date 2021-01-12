using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LimiteScript : MonoBehaviour
{
    public Canvas canvas;
    private CanvasGroup canvasGroup;

    private GameObject player;

    private void OnTriggerEnter2D(Collider2D collision) {
         if(collision.gameObject.tag == "Player") {

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


        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
