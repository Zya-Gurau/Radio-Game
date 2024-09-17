using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioMenuManager : MonoBehaviour
{
    public int numActiveSlots;
    public RadioScheduleSlot[] radioScheduleSlots;
    public Timekeeper timekeeper;
    // Start is called before the first frame update
    public bool loopLastTrack;

    void Start ()
    {
        timekeeper = FindAnyObjectByType<Timekeeper>();
    }

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

    void Update()
    {
        if (timekeeper.currentHour > numActiveSlots && getSlotsFull() > 0) {
            loopLastTrack = true;
        } else {
            loopLastTrack = false;
        }
    }

    private int getSlotsFull()
    {
        int count = 0;
        for (int i = 0; i < radioScheduleSlots.Length; i++)
        {
            if (radioScheduleSlots[i].isFull)
            {
                count += 1;
            }
        }
        return count;
    }
    
}
