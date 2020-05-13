using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightScript : MonoBehaviour
{
   
    public GameObject PillarObject;
    List<GameObject> objectsOnMe = new List<GameObject>();

    //vectors to constantly lerp
    Vector3 originalPos;
    Vector3 currentLerpingPos;

    //lerp param
    float u = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        originalPos = PillarObject.transform.position;
        currentLerpingPos = originalPos;
    }

    // Update is called once per frame
    void Update()
    {
        if (u < 1.0f)
        {
            u += Time.deltaTime;
            PillarObject.transform.position = Vector3.Lerp(originalPos, currentLerpingPos, u);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "WeightEntity")
        {
            for (int i = 0; i < objectsOnMe.Count; i++)
            {
                if (objectsOnMe[i] == collision.gameObject)
                    return;
            }

            if (objectsOnMe.Count < 3)
            {
                //add the object to the list and set its parent to the pillar
                objectsOnMe.Add(collision.gameObject);
                objectsOnMe[objectsOnMe.Count - 1].transform.SetParent(PillarObject.transform);

                //reset u and lower the pillar's destination point
                currentLerpingPos.y -= 0.5f;
                u = 0.0f;
                originalPos = PillarObject.transform.position;
            }

        }

    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "WeightEntity")
        {
            for (int i = 0; i < objectsOnMe.Count; i++)
            {
                if (objectsOnMe[i] == collision.gameObject)
                {
                    objectsOnMe[i].transform.parent = null;
                    objectsOnMe.RemoveAt(i);
                    break;
                }
            }

            currentLerpingPos.y += 0.5f;
            u = 0.0f;
            originalPos = PillarObject.transform.position;
            


        }
    }

}
