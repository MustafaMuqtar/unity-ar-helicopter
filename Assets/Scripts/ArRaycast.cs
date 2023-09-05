using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ArRaycast : MonoBehaviour
{
   private ARRaycastManager aR;
    private GameObject planeToPlace;


    private List<ARRaycastHit> hits = new List<ARRaycastHit>();



    private void Start()
    {
        aR = FindObjectOfType<ARRaycastManager>();
        planeToPlace = transform.GetChild(0).gameObject;
        planeToPlace.SetActive(false);
    }
    private void Update()
    {
        var ray = new Vector2(Screen.width / 2, Screen.height / 2);


        if (aR.Raycast(ray, hits, TrackableType.Planes))
        {
            Pose pose = hits[0].pose;
            transform.position = pose.position;
            transform.rotation = pose.rotation;
            if (!planeToPlace.activeInHierarchy)
            {
                planeToPlace.SetActive (true);
            }
        }
    }
}
