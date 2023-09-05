using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HelicopterMovement : MonoBehaviour
{

    private PlaceHelicopter placeHelicopter;

    [SerializeField] private float speed;
    [SerializeField] private Rigidbody rigidbody;
    private Vector2 moveInputValue;


    private void Start()
    {
        placeHelicopter = FindObjectOfType<PlaceHelicopter>();
   
    }
    private void OnMove(InputValue value)
    {
        moveInputValue = value.Get<Vector2>();
    }



    private void MoveLoic ()
    {

        Vector2 result = moveInputValue * speed * Time.deltaTime;
        rigidbody.velocity = result;

        if (placeHelicopter.helcopterPosy.position.y <= 0 &&( result.y <=0 ||  result.x <= 0) )
    {
            placeHelicopter.rBHelicopter.isKinematic = true;
 


        }

        
       else if (result.y >0)
          {
           placeHelicopter.rBHelicopter.isKinematic = false;
      

       }

    }


    private void FixedUpdate()
    {
        MoveLoic();

    }
}