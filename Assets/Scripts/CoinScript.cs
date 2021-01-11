using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour
{
    public Image imagem;

    private Color novaCor = new Color(255, 255, 255, 255);

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Player")) {
            Destroy(gameObject);
            imagem.GetComponent<Image>().color = novaCor;
        }
    }
}