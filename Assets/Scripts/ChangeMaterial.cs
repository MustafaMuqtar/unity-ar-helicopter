using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    private Renderer[] renderer;
   // public GameObject helicopter;
    [SerializeField] private Material material;

    public PlaceHelicopter placeHelicopter;


    private void Start()
    {
        renderer =placeHelicopter.newPlace.GetComponentsInChildren<Renderer>();

    }


    public void ChangeColour()
    {

        foreach (Renderer item in renderer)
        {
            item.material = material;


        }



    }

}
