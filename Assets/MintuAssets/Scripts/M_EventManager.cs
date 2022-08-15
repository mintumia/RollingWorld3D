using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.InputSystem;



public class M_EventManager : MonoBehaviour
{

    /********Ruff Start******************/
    public static event Action mintuEvent;
    public static event Action <Vector2> mintuEvent2;
    public static event Action<bool> mintuEvent3;

    /********Ruff End******************/

    public Inputcontroller mController;
    public static Vector2 mrotateAngle;
    private bool changing = false;
    private float waitSecond = 1;


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
       // mController.InputController.movement.performed += Movement2;

        mController.InputController.wsad.performed += Movement2;
        mController.InputController.wsad.canceled += CancelMovement;
        mController.InputController.Movement.performed += Movement2;
        mController.InputController.Movement.canceled += CancelMovement;
        mController.InputController.M_key.performed += Movement2;
        mController.InputController.M_key.canceled += CancelMovement;


    }

    private void OnDisable()
    {

        mController.InputController.m_pad.performed -= Movement;
       // mController.InputController.movement.performed -= Movement2;
        mController.InputController.wsad.performed -= Movement2;
        mController.InputController.wsad.canceled -= CancelMovement;
        mController.InputController.Movement.performed -= Movement2;
        mController.InputController.Movement.canceled -= CancelMovement;
        mController.InputController.M_key.performed -= Movement2;
        mController.InputController.M_key.canceled -= CancelMovement;
        mController?.Disable();
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      //  mintuEvent?.Invoke();

/*
        if(changing == true)
        {
            waitSecond -= Time.deltaTime;


            if (waitSecond < 0) 
            {
                waitSecond = 1;
                mrotateAngle = Vector2.zero;
                changing = false;

            }


        }*/


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

    public void Movement2(InputAction.CallbackContext context)
    {

        mrotateAngle = context.ReadValue<Vector2>();
        changing = true;


     // Debug.Log("Joy: x:  " + context.ReadValue<Vector2>().x + " , Y : "+context.ReadValue<Vector2>().y);





    }

    void CancelMovement(InputAction.CallbackContext context)
    {

        mrotateAngle = Vector2.zero;


    }
   


}
