using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOnHit : MonoBehaviour
{
    public string TargetTag;
    
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    private void OnCollisonEnter (Collision coll)
    {
        if (coll.gameObject.tag == TargetTag)
        {
            GameObject.Find("PlayerCam").GetComponent<PlayerCam>().locked = true;
            coll.gameObject.SetActive(false);
        }
    }
   
}