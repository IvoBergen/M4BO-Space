using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class NoteAppear : MonoBehaviour
{
    public GameObject panelText;
    public GameObject paperImage;
    [SerializeField]
    private EnemyFollow follow;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            panelText.SetActive(true);
            paperImage.SetActive(true);
            follow.FollowStatus = false;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            panelText.SetActive(false);
            paperImage.SetActive(false);
            follow.FollowStatus = true;
        }
    }

    
}
