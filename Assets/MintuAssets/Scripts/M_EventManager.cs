using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.InputSystem;



public class M_EventManager : MonoBehaviour
{
    public static event Action mintuEvent;
    public static event Action <Vector2> mintuEvent2;
    public Inputcontroller mController;
   

    //  public int repeat = 1;

    // Start is called before the first frame update
    private void Awake()
    {
        mController = new Inputcontroller();


    }

    private void OnEnable()
    {
        
        mController.Enable();

        mController.InputController.m_pad.performed += Movement;
        mController.InputController.movement.performed += Movement_touch;




    }

    private void OnDisable()
    {

        mController.InputController.m_pad.performed -= Movement;
        mController.InputController.movement.performed -= Movement_touch;
        mController?.Disable();
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        /*if (Input.GetMouseButton(0))
        {
          
            
            mintuEvent2?.Invoke(Input.mousePosition);
            Debug.Log("Hello");

        }*/


        /* if (Input.GetMouseButton(0))
         {

             mintuEvent?.Invoke();
         }*/
        /*
                if (Input.GetMouseButton(1))
                {
                    if(repeat >=1)
                    {
                        mintuEvent2?.Invoke(new Vector2(1, 2));
                        repeat--;


                    }




                }
        */



    }

    private void FixedUpdate()
    {

      

       



    }

    public void Movement(InputAction.CallbackContext context)
    {

       // Debug.Log("Joy: x:  " + context.ReadValue<Vector2>().x + " , Y : "+context.ReadValue<Vector2>().y);


    }

    public void Movement_touch(InputAction.CallbackContext context)
    {
        context.ReadValue<Vector2>();

       // Debug.Log("Joy: x:  " + context.ReadValue<Vector2>().x + " , Y : "+context.ReadValue<Vector2>().y);


      


    }



}
