using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KontroleKamere : MonoBehaviour
{


public Transform targetToFollow;


   void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (
            Mathf.Clamp(targetToFollow.position.x, -16.9f, 16.9f),
             Mathf.Clamp(targetToFollow.position.y, -0.4f, 11.5f),
             transform.position.z);
    }    

}