using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayController : MonoBehaviour
{
    public float maxDelay = 1.0f;//the delay you want it to reset to

    public float delay = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void resetDelay()
    {
        delay = maxDelay;
    }

    // Update is called once per frame
    void Update()
    {
        if (delay > 0.0f)
            delay -= Time.deltaTime;
        else if (delay <= 0.0f)
            delay = 0.0f;

    }
}
