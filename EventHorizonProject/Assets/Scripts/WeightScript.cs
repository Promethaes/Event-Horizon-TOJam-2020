using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightScript : MonoBehaviour
{
    public GameObject PillarObject;
    List<GameObject> objectsOnMe = new List<GameObject>();

    Vector3 originalPos;
    Vector3 downOne;
    Vector3 downTwo;
    Vector3 downThree;
    Vector3 currentLerpingPos;

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
                objectsOnMe.Add(collision.gameObject);
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
