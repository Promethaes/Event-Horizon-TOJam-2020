using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialManager : MonoBehaviour
{
    public List<MaterialManagerItem> objectsToManage;
  
    private void Start()
    {
        for (int i = 0; i < objectsToManage.Count - 1; i++)
        {
            objectsToManage[i].index = i;
        }
    }

    //might be useful in the future
    //public DelayController delayController;

    //control whether or not the activate material is on for all items in the list
    public void TurnOnActivateMaterial(bool shouldUseActiveMaterial)
    {
        for (int i = 0; i < objectsToManage.Count; i++)
        {
            objectsToManage[i].useActivateMaterial = shouldUseActiveMaterial;
        }
    }

    //control whether or not the activate material is on for one item at index i
    public void TurnOnActivateMaterial(bool shouldUseActiveMaterial, int i)
    {
        objectsToManage[i].useActivateMaterial = shouldUseActiveMaterial;
    }


}
