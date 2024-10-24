using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class StartText : MonoBehaviour
{
    public List<GameObject> objectList = new List<GameObject>();
  
    private int state = 0;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && state < 3)
        {
            if(state == 0) 
            {
                objectList[2].SetActive(false);
                objectList[3].SetActive(true);
            }
            if(state == 1) 
            {
                objectList[3].SetActive(false);
                objectList[4].SetActive(true);
            }
            if(state == 2)
            {
                objectList[0].SetActive(false);
                objectList[1].SetActive(false);
                objectList[4].SetActive(false);
            }
            state++;
        }
    }
}
