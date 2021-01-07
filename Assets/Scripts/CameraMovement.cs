using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{


    Camera cam;
    float camWidth;
    private GameObject player;

    public bool perdeu = false;

    public float playerX;
    public float playerY;

    // Start is called before the first frame update

    void Awake()
    {
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
        if(perdeu != true) {
            //transform.Translate(new Vector3(1, 0, 0) * 2f * Time.deltaTime);
            transform.position += new Vector3(3f * Time.deltaTime, 0, 0);
            playerX = player.transform.position.x;
            playerY = player.transform.position.y;

            if (player.transform.position.x <= cam.transform.position.x - camWidth) {
                perdeu = true;
                PlayerScript.Destroy(player);


            }
        } else {

        }
        
    }
}
