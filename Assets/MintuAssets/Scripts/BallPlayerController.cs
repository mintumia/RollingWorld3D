using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BallPlayerController : MonoBehaviour
{
    private void OnEnable()
    {
        M_EventManager.mintuEvent += test;
    }
    

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void test()
    {
        Debug.Log("Events");



    }

    private void OnDisable()
    {
        M_EventManager.mintuEvent -= test;
    }


}
