using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{

    public static int contador;
    //public GameObject hint;

    public Canvas canvas;
    public CanvasGroup canvasGroup;

    public bool isGrounded = false;

    public static int nrCoins;

    private int nivelAtual;

    private void Awake() {
        nrCoins = 0;
        nivelAtual = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update() {
        if (canvasGroup.alpha == 1) {

            GetComponent<Animator>().enabled = true;

            if(nivelAtual == 1) {
                transform.position += new Vector3(3f * Time.deltaTime, 0, 0);
            } else if (nivelAtual == 2) {
                transform.position += new Vector3(6f * Time.deltaTime, 0, 0);
            }

            if ((Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) && isGrounded) {
                contador++;
                if (GetComponent<Rigidbody2D>().gravityScale == 2) {

                    GetComponent<Rigidbody2D>().gravityScale = -2;
                    transform.eulerAngles = new Vector3(180, 0, 0);

                }
                else {

                    GetComponent<Rigidbody2D>().gravityScale = 2;
                    transform.eulerAngles = new Vector3(0, 0, 0);

                }
            }
        }
    }

    private void OnCollisionStay2D(Collision2D collision) {
        if (collision.collider.tag == "Ground") {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision) {
        isGrounded = false;
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Coin")) {
            nrCoins++;
        } 
    }

}