using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter: MonoBehaviour
{
    public Transform targetLocation;
    GameObject targetToTP;
    public DelayController delayController;

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("nani");
        if (other.GetComponent<Teleportable>() && delayController.delay <= 0.0f)
        {
            delayController.resetDelay();
            TeleportObject(other.gameObject);
        }
    }

    public void TeleportObject(GameObject target)
    {
        target.transform.position = targetLocation.position;
        target.GetComponent<Rigidbody>().velocity = new Vector3(target.GetComponent<Rigidbody>().velocity.x, -target.GetComponent<Rigidbody>().velocity.y, target.GetComponent<Rigidbody>().velocity.z);
    }
}
