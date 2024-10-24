using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering.Universal;

public class PauseScreen : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject controlsPanel;
    [SerializeField]
    private EnemyFollow follow;

    public void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        { 
            PausePanel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            GameObject.Find("PlayerCam").GetComponent<PlayerCam>().locked = true;
            follow.FollowStatus = false;
        }

    }
    public void Resume()
    {
        PausePanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        GameObject.Find("PlayerCam").GetComponent<PlayerCam>().locked = false;
        follow.FollowStatus = true;
    }
    public void ShowControls()
    {
        controlsPanel.SetActive(true);
    }
    public void RemoveControls()
    {
        controlsPanel.SetActive(false);
    }
    public void Return()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Exit()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
