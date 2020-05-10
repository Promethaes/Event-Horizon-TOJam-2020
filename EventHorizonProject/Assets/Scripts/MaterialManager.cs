using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialManager : MonoBehaviour
{
    public GameObject ObjectToManage;
    public Material NormalMaterial;
    public Material ActivateMaterial;

    public bool useActivateMaterial = false;

    //might be useful in the future
    //public DelayController delayController;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (useActivateMaterial)
            ObjectToManage.GetComponent<Renderer>().material = ActivateMaterial;
        //add more if statements here to use different materials
        else
            ObjectToManage.GetComponent<Renderer>().material = NormalMaterial;


    }
}
