using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    private int contador;
    public GameObject hint;

    public Canvas canvas;
    public CanvasGroup canvasGroup;

    public bool isGrounded = false;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (canvasGroup.alpha == 1) {

            GetComponent<Animator>().enabled = true;

            transform.position += new Vector3(3f * Time.deltaTime, 0, 0);

            if (Input.GetKeyDown(KeyCode.Space) && isGrounded) {
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
            if (contador > 1) {
                hint.gameObject.SetActive(false);
            }
        }
    }

    private void OnCollisionStay2D(Collision2D collision) {
        if(collision.collider.tag == "Ground") {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision) {
        isGrounded = false;
    }


}
