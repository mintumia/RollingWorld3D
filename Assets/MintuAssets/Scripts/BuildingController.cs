using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BuildingController : MonoBehaviour
{
    Inputcontroller MtouchControl;
    public float mTouchDelta;
    // Start is called before the first frame update

    private void OnEnable()
    {
        MtouchControl.Enable();
        MtouchControl.InputController.touchControl.performed += Movement;

    }
    private void OnDisable()
    {
        MtouchControl.InputController.touchControl.performed -= Movement;
        MtouchControl.Disable();
    }

    private void Awake()
    {
        MtouchControl = new Inputcontroller();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        this.mTouchDelta = MtouchControl.InputController.touchControl.ReadValue<float>();

       // m_Input.m_Player.move.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
      //  Movement();

       
        //  MtouchControl.InputController.touchControl.t
       


    }


    public void Movement(InputAction.CallbackContext context)
    {

        Debug.Log(context);

        //  Debug.Log(this.mTouchDelta);
        //m_Input.m_Player.move.performed -= setAxis;
        //InputAction.CallbackContext context
       


    }


}
