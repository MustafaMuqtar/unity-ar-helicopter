using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceHelicopter : MonoBehaviour
{

    private ArRaycast arRaycast;
    public GameObject newPlace;
    public GameObject helicopterPrefab;
    private AudioSource engineSound;
    public Rigidbody rBHelicopter;

    public Transform helcopterPosy;


    private Animator animator;
    void Start()
    {
        arRaycast = FindObjectOfType<ArRaycast>();


    }

    

    public void PlaceObject()
    {
        newPlace = Instantiate(helicopterPrefab, arRaycast.transform.position, arRaycast.transform.rotation);

        animator = newPlace.GetComponentInChildren<Animator>();
        engineSound = newPlace.GetComponentInChildren<AudioSource>();
        rBHelicopter = newPlace.GetComponentInChildren<Rigidbody>();
        helcopterPosy = newPlace.transform.GetChild(0);
             rBHelicopter.isKinematic = true;
    }


    public void PlayAnimation()
    {
        animator.SetBool("Snurrar", true);
        engineSound.Play();
        animator.speed = 1f;

        rBHelicopter.isKinematic = false;


        /* if (helcopterPosy.position.y <= 0)
         {
             rBHelicopter.isKinematic = true;

         }
         else if (helcopterPosy.position.y > 0)
         {
             rBHelicopter.isKinematic = false;

         }

         Debug.Log(helcopterPosy.position.y);
         Debug.Log(helcopterPosy.name);*/

    }


    public void PuseHelicopter()
    {
        animator.speed = 0;
        engineSound.Pause();
    }

    public void QuitAR()
    {
        Application.Quit();
    }
}
