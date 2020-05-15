using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject objectToRotate;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        objectToRotate.transform.up = (mainCamera.transform.position - objectToRotate.transform.position);
    }
}
