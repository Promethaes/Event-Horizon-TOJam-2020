using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zucc : MonoBehaviour
{
    public GameObject zuccBox;
    public GameObject BHole;
    public float zuccForceScalar = 1.0f;

    private void FixedUpdate()
    {
        zuccBox.transform.position = BHole.transform.position;
    }

    private void OnTriggerStay(Collider other)
    {
        var temp1 = zuccBox.transform.position - other.gameObject.transform.position;
        var temp2 = temp1.magnitude;
        temp1 = temp1.normalized;

        temp1 *= zuccForceScalar;
        temp1 /= temp2;

        if (other.gameObject.GetComponent<Rigidbody>() && other.gameObject.GetComponent<Zuccable>())
            other.gameObject.GetComponent<Rigidbody>().AddForce(temp1);
    }

}
