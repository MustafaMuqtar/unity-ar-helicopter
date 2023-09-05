using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelicoterAnimation : MonoBehaviour
{
    private AudioSource engineSound;

    public GameObject helicopterPrefab;

    private     Animator animator;
    // Start is called before the first frame update
    void Awake()
    {
        animator = helicopterPrefab.GetComponent<Animator>();
        engineSound = helicopterPrefab.GetComponent<AudioSource>();
 
    }

    // Update is called once per frame
    public void PlayAnimation ()
    {
        animator.SetBool("Snurrar", true);
        engineSound.Play();
       //animator.speed = 1f;


     
    }

    public void PuseHelicopter()
    {
        animator.speed = 0;
        engineSound.Pause();
    }

    public void QuitAR ()
    {
        Application.Quit();
    }
}
