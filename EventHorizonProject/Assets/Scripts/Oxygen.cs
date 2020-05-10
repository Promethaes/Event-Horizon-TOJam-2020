using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Oxygen : MonoBehaviour
{
    ControllerInput inputActions;

    //Oxygen stuff
    [SerializeField] float maxOxygen;
    [SerializeField] float currentOxygen;
    public bool hasOxygen;
    public Slider oxygenBar;
    public float refillMultiplier = 5f;
    public float drainRate;

    public MaterialManager mm;

    //Tether stuff
    [SerializeField] GameObject playerEnt1;
    [SerializeField] GameObject playerEnt2;
    private float playerEntDistance;
    public float closenessCheck; //rename later i dunno what to call it lol

    // Start is called before the first frame update
    void Start()
    {
        currentOxygen = maxOxygen;
        DrainOxygen(maxOxygen/2.0f);//debug feature
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

        oxygenBar.value = OxygenBarValue();
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
            //death n stuff
        }
    }

    private float OxygenBarValue()
    {
        float calculatedAmount = Mathf.Clamp((currentOxygen / maxOxygen), 0, 1);
        return calculatedAmount;
    }
}
