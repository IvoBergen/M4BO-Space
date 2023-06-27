using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class StartText : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject startClick;
    public GameObject startClick2;
    public GameObject startText;
    public GameObject startText2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape)) 
        { 
            startClick.SetActive(false);
            startText.SetActive(false);
            startText2.SetActive(true);
            startClick2.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            startPanel.SetActive(false);
            startClick2.SetActive(false);
            startText2.SetActive(false);
        }
    }
}
