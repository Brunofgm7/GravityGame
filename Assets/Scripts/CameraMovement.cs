﻿using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMovement : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject Menu;

    Camera cam;
    float camWidth;
    private GameObject player;

    private bool perdeu = false;

    public Canvas canvas;
    private CanvasGroup canvasGroup;

    // Start is called before the first frame update
    void Awake()
    {

        StartCoroutine(FadeIn());

        player = GameObject.FindGameObjectWithTag("Player");

    }
    void Start()
    {
        cam = Camera.main;
        camWidth = cam.orthographicSize * cam.aspect;
    }

    // Update is called once per frame
    void Update()
    {
        if (perdeu != true) {

            if(canvasGroup.alpha == 1) {
                transform.position += new Vector3(3f * Time.deltaTime, 0, 0);

                if (player.transform.position.x <= cam.transform.position.x - camWidth) {
                    perdeu = true;
                    PlayerScript.Destroy(player);

                    StartCoroutine(FadeOut());

                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape) && (!GameIsPaused)) {
            Pause();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && (GameIsPaused)) {
            Resume();
        }

    }

    public void Resume() {
        Menu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause() {
        Menu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Quit() {

        //StartCoroutine(FadeOut());

        SceneManager.LoadScene(sceneBuildIndex:0);
    }

    IEnumerator FadeOut() {
        canvasGroup = canvas.GetComponent<CanvasGroup>();
        while (canvasGroup.alpha > 0) {
            canvasGroup.alpha -= Time.deltaTime / 2;
            canvasGroup.interactable = false;
            yield return null;
        }
        canvasGroup.interactable = true;
        yield return null;

        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);

    }

    IEnumerator FadeIn() {
        canvasGroup = canvas.GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0;
        while (canvasGroup.alpha < 1) {
            canvasGroup.alpha += Time.deltaTime / 2;
            canvasGroup.interactable = false;
            yield return null;
        }
        canvasGroup.interactable = true;
        yield return null;
    }

}