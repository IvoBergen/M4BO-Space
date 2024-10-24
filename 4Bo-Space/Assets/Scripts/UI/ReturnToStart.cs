using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToStart : MonoBehaviour
{

    public void ReturntoStart()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Exit()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
