using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Animations : MonoBehaviour
{
    //Maak een variabele aan voor je animator component
    public Animator ani;

    void Start()
    {
        //Pak het animator component en sla die op in de variabele
        ani = GetComponent<Animator>();
    }
    void Update()
    {
        //Check voor verticale input
        if (Input.GetAxis("Vertical") > 0)
        {
            //is de waarde groter dan 0 dan heb je een knop naar boven ingedrukt 
            //Roep de juiste trigger aan!
            //ani.SetBool setBool;
            //setBool("Walk 0") = true;
            //SetTrigger is trigger activeren
            ani.ResetTrigger("Idle");
            //ResetTrigger is Trigger de-activeren
        }
        else
        {
            //is de waarde 0 dan heb je niets ingedrukt
            //Roep de juiste trigger aan
            ani.SetTrigger("Idle");
            ani.ResetTrigger("Walk");
        }
    }


}
