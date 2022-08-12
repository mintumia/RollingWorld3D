using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class BuildingController : MonoBehaviour
{


    private void OnEnable()
    {

      //  M_EventManager.mintuEvent2 += test;
    }
    private void OnDisable()
    {
       // M_EventManager.mintuEvent2 -= test;
      

    }

    private void Start()
    {
        
       

    }

    private void Update()
    {
        



    }

    private void FixedUpdate()
    {
        



    }

   public void test(Vector2 _vecValue)
    {


        Debug.Log("Test working : " + _vecValue);
    }


}
