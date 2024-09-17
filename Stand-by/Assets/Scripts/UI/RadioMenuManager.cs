using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioMenuManager : MonoBehaviour
{
    public int numActiveSlots;
    public RadioScheduleSlot[] radioScheduleSlots;
    // Start is called before the first frame update
 

    void Awake()
    {
        for (int i = 0; i < radioScheduleSlots.Length; i++)
        {
            if (i < numActiveSlots) 
            {
                radioScheduleSlots[i].gameObject.SetActive(true);
            } else {
                radioScheduleSlots[i].gameObject.SetActive(false);
            }
        }    
    }

    // Update is called once per frame
    
}
