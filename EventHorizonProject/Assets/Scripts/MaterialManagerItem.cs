using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialManagerItem : MonoBehaviour
{
    public GameObject ObjectToManage;
    public Material NormalMaterial;
    public Material ActivateMaterial;

    public bool useActivateMaterial = false;

    public int index = -1;//to throw an error if you fuck up

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
