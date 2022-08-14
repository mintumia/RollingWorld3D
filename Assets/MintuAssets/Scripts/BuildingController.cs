using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class BuildingController : MonoBehaviour
{

    private Vector3 rotateAngle;
    //[SerializeField]
    private float speed = 5f;
    private Vector3 newrotate = Vector3.zero;

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
        
        transform.Rotate(new Vector3 (newrotate.x + speed * M_EventManager.mrotateAngle.y *Time.deltaTime, 0f, newrotate.z + speed * M_EventManager.mrotateAngle.x*-1 * Time.deltaTime));


    }

   public void test(Vector2 _vecValue)
    {


        Debug.Log("Test working : " + _vecValue);
    }


}
