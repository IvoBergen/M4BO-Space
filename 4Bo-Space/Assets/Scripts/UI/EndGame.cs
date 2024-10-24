using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class EndGame : MonoBehaviour
{
    public GameObject endScreen;
    public AudioSource alarm;

    private void OnTriggerEnter(Collider other)
    {
        endScreen.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        alarm.Stop();
    }
}
