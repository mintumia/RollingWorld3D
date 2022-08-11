using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class M_EventManager : MonoBehaviour
{
    public static event Action mintuEvent;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {

            mintuEvent?.Invoke();
        }
        
    }
}
