using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayerController : MonoBehaviour
{
    public Animator animator;
    public RadioMenuManager radioMenuManager;
    public Timekeeper timekeeper;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        radioMenuManager = FindAnyObjectByType<RadioMenuManager>();
        timekeeper = FindAnyObjectByType<Timekeeper>();
    }

    // Update is called once per frame
    void Update()
    {
        if(radioMenuManager.radioScheduleSlots[timekeeper.currentHour-1].isFull || radioMenuManager.loopLastTrack) {
            animator.Play("Playing");
        } else {
            animator.Play("Idle");
        }
        
    }
}
