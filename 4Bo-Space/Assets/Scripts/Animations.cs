using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Animations : MonoBehaviour
{
    public Animator ani;
    private EnemyFollow moving;
    void Start()
    {
        ani = GetComponent<Animator>();
        moving = GetComponent<EnemyFollow>();
    }
    void Update()
    {
        ani.SetTrigger("Idle");
        ani.ResetTrigger("Walk");
        //check if moving
        if (moving.walkPointSet == true)
        {
            Debug.Log("walking");
            ani.SetTrigger("Walk");
            ani.ResetTrigger("Idle");
        }
        if(moving.followPlayer == true) 
        {
            ani.SetTrigger("Walk");
            ani.ResetTrigger("Idle");
        }
            
        
    }

    private void OnTriggerEnter(Collider other)
    {
        ani.SetTrigger("JumpScare");
        ani.ResetTrigger("Idle");
        ani.ResetTrigger("Walk");
    }


}
