using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BuildingController : MonoBehaviour
{
    Inputcontroller MtouchControl;
    public float mTouchDelta;
    // Start is called before the first frame update
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

        


    }

    private void FixedUpdate()
    {
        Movement();

       this.mTouchDelta = MtouchControl.InputController.touchControl.ReadValue<float>();
      //  MtouchControl.InputController.touchControl.t



    }


    public void Movement()
    {

        Debug.Log(this.mTouchDelta);





    }


}
