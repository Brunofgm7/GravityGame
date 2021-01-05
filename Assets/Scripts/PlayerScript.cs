using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

   

    public float degreesPerSec = 360f;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        transform.position += new Vector3(1f * Time.deltaTime, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space)) {
            if (GetComponent<Rigidbody2D>().gravityScale == 2) {

                GetComponent<Rigidbody2D>().gravityScale = -2;
                transform.eulerAngles = new Vector3 (180,0,0);


            }
            else {

                GetComponent<Rigidbody2D>().gravityScale = 2;
                transform.eulerAngles = new Vector3(0, 0, 0);

            }
        }
    }
}
