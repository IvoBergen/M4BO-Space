using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class NoteAppear : MonoBehaviour
{
    
    public GameObject panelText;
    public GameObject paperImage;
    

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            panelText.SetActive(true);
            paperImage.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            panelText.SetActive(false);
            paperImage.SetActive(false);

        }
    }

    
}
