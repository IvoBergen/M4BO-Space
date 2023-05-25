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

    private void onColissionEnter (Collision coll)
    {
        if (coll.gameObject.tag == TargetTag)
        {
            Destroy(coll.gameObject, 0.1f);
        }
    }
}