using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KillOnHit : MonoBehaviour
{
    public string TargetTag;
    public GameObject panelGameOver;

    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    private void OnTriggerEnter (Collider coll)
    {
        Debug.Log(coll.gameObject.tag);
        if (coll.gameObject.tag == TargetTag)
        {
            GameObject.Find("PlayerCam").GetComponent<PlayerCam>().xRotation = -29;
            GameObject.Find("PlayerCam").GetComponent<PlayerCam>().locked = true;
            coll.gameObject.SetActive(false);
            panelGameOver.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;


        }
    }

}