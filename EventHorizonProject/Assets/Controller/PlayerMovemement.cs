using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemement : MonoBehaviour
{
    public GameObject Player1Entity;
    public GameObject Player2Entity;
    //used to orient player axis
    public Camera GameCamera;

    ControllerInput inputActions;

    Vector2 leftStick;
    Vector2 rightStick;
    bool aPressed = false;
    

    void Awake()
    {
        //all button inputs going to methods / 
        inputActions = new ControllerInput();

        inputActions.PlayerControllerInput.Player1Moving.performed += ctx => leftStick = ctx.ReadValue<Vector2>();
        inputActions.PlayerControllerInput.Player2Moving.performed += ctx => rightStick = ctx.ReadValue<Vector2>();

        inputActions.PlayerControllerInput.aButton.started += AButton_started;
        inputActions.PlayerControllerInput.aButton.canceled += AButton_canceled;
        inputActions.PlayerControllerInput.bButton.performed += BButton_performed;
        inputActions.PlayerControllerInput.xButton.performed += XButton_performed;
        inputActions.PlayerControllerInput.yButton.performed += YButton_performed;

        inputActions.PlayerControllerInput.leftTrigger.performed += LeftTrigger_performed;
        inputActions.PlayerControllerInput.rightTrigger.performed += RightTrigger_performed;

        inputActions.PlayerControllerInput.leftBumper.performed += LeftBumper_performed;
        inputActions.PlayerControllerInput.rightBumper.performed += RightBumper_performed;

        inputActions.PlayerControllerInput.leftStickClick.performed += LeftStickClick_performed;
        inputActions.PlayerControllerInput.rightStickClick.performed += RightStickClick_performed;
    }




    #region Stick Clicks
    private void RightStickClick_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
       
    }

    private void LeftStickClick_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        
    }
    #endregion
    #region Bumpers
    private void RightBumper_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        
    }

    private void LeftBumper_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        
    }
    #endregion
    #region Triggers
    private void RightTrigger_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
       
    }

    private void LeftTrigger_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
       
    }
    #endregion
    #region Face Buttons
    private void YButton_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
       
    }

    private void XButton_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        
    }

    private void BButton_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        
    }
    private void AButton_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {

    }
    private void AButton_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
       
    }
    #endregion


    void FixedUpdate()
    {
        //player 1
        if ((leftStick.x > 0.5 || leftStick.x < -0.5) || (leftStick.y > 0.5 || leftStick.y < -0.5))
        {
            Player1Entity.transform.LookAt(new Vector3(Player1Entity.transform.position.x + leftStick.x, Player1Entity.transform.position.y, Player1Entity.transform.position.z + leftStick.y));
            Player1Entity.GetComponent<Rigidbody>().AddForce(new Vector3(500f * leftStick.x * Time.deltaTime, 0f, 500f * leftStick.y * Time.deltaTime));
        }
        //player 2
        if ((rightStick.x > 0.5 || rightStick.x < -0.5) || (rightStick.y > 0.5 || rightStick.y < -0.5))
        {
            Player2Entity.transform.LookAt(new Vector3(Player2Entity.transform.position.x + rightStick.x, Player2Entity.transform.position.y, Player2Entity.transform.position.z + rightStick.y));
            Player2Entity.GetComponent<Rigidbody>().AddForce(new Vector3(500f * rightStick.x * Time.deltaTime, 0f, 500f * rightStick.y * Time.deltaTime));
        }
    }

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }
}
