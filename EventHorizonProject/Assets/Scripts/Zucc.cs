using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zucc : MonoBehaviour
{
    public GameObject zuccBox;
    public GameObject BHole;
    public float ZuccBoxMass = 10.0f;

    private void FixedUpdate()
    {
        zuccBox.transform.position = BHole.transform.position;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<Rigidbody>() && other.gameObject.GetComponent<Zuccable>())
        {
            float G = (float)(6.67 * Math.Pow(10, -11));
            float M = ZuccBoxMass;
            float m = other.gameObject.GetComponent<Rigidbody>().mass;
            float r = zuccBox.GetComponent<SphereCollider>().radius;

            float result = (G * M * m) / (float)Math.Pow(r, 2.0f);

            Vector3 direction = (zuccBox.transform.position - other.transform.position).normalized;
            direction *= result;

            other.gameObject.GetComponent<Rigidbody>().AddForce(direction);
        }
    }

}
