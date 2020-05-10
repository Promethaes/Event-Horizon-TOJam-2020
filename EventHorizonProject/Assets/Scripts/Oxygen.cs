using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Oxygen : MonoBehaviour
{
    //controls 
    public float jumpForce = 10f; //No pun intended
    ControllerInput inputActions;
    bool aButtonPress = false;
    

    //Oxygen stuff
    [SerializeField] float maxOxygen;
    [SerializeField] float currentOxygen;
    public bool hasOxygen;
    //public Slider oxygenBar;
    public float refillMultiplier = 5f;
    public float drainRate;

    public MaterialManager mm;

    //Tether stuff
    [SerializeField] GameObject playerEnt1;
    [SerializeField] GameObject playerEnt2;
    private float playerEntDistance;
    public float closenessCheck; //rename later i dunno what to call it lol

    void Awake()
    {
        inputActions = new ControllerInput();
        inputActions.PlayerControllerInput.aButton.started += AButton_started;
        inputActions.PlayerControllerInput.aButton.canceled += AButton_canceled;

    }

    private void AButton_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        aButtonPress = false;
    }

    private void AButton_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        aButtonPress = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        currentOxygen = maxOxygen;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentOxygen > 0)
        {
            hasOxygen = true;
        }

        playerEntDistance = Vector3.Distance(playerEnt1.transform.position, playerEnt2.transform.position);

        if (playerEntDistance <= closenessCheck)
        {
            RefillOxygen();
        }
        else
            mm.TurnOnActivateMaterial(false);

        if (aButtonPress)
        {
            DrainOxygen(drainRate);
            if (hasOxygen)
            {
                playerEnt1.GetComponent<Rigidbody>().AddForce(new Vector3(0f, jumpForce, 0f));
            }
        }

        //oxygenBar.value = OxygenBarValue();
    }

    private void RefillOxygen()
    {
        if (currentOxygen < maxOxygen)
        {
            mm.TurnOnActivateMaterial(true);
            currentOxygen += refillMultiplier * Time.deltaTime;
        }
    }

    public void DrainOxygen(float amount)
    {
        if (currentOxygen > 0)
        {
            currentOxygen -= amount;
        }
        else
        {
            hasOxygen = false;
            print("dead boi");
            //death n stuff
        }
    }

    private float OxygenBarValue()
    {
        float calculatedAmount = Mathf.Clamp((currentOxygen / maxOxygen), 0, 1);
        return calculatedAmount;
    }
    //Controller related
    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }
}
