using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseAudio : MonoBehaviour
{
    public void PauseOrPlay() {
        if (MusicScript.Instance.gameObject.GetComponent<AudioSource>().isPlaying) {
            MusicScript.Instance.gameObject.GetComponent<AudioSource>().Pause();
        }
        else {
            MusicScript.Instance.gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
