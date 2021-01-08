using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public Canvas canvas;
    private CanvasGroup canvasGroup;

 
    public void StartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        StartCoroutine(Fade());
    }

    IEnumerator Fade() {
        canvasGroup = canvas.GetComponent<CanvasGroup>();
        while (canvasGroup.alpha > 0) {
            canvasGroup.alpha -= Time.deltaTime / 2;
            yield return null;
        }
        canvasGroup.interactable = true;
        yield return null;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

}
