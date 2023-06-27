using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Animations : MonoBehaviour
{
    //Maak een variabele aan voor je animator component
    public Animator ani;
    
    private EnemyFollow moving;


    void Start()
    {
        //Pak het animator component en sla die op in de variabele
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
            ani.SetTrigger("Walk");
            ani.ResetTrigger("Idle");
        }
        else if(moving.followPlayer == true) 
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
