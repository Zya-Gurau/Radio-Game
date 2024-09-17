using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timekeeper : MonoBehaviour
{
    public int currentHour;
    private float timePassed;
    public int hourLength;
    public bool hasChanged = false;
    // Start is called before the first frame update
    void Start()
    {
        currentHour = 1;
        timePassed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed >= hourLength)
        {
            hasChanged = true;
            if(currentHour < 12) {
                currentHour += 1;
            } else {
                currentHour = 1;
            }
            
            timePassed = 0f;
            hasChanged = false;
        }
        
    }
}
