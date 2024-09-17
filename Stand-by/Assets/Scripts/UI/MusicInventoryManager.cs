using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MusicInventoryManager : MonoBehaviour
{
    public GameObject musicInventory;
    private bool menuActive;
    public MusicItemSlot[] musicItemSlots;

    // Start is called before the first frame update
    void Start()
    {
        menuActive = false;
        musicInventory.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire2") && menuActive) {
            musicInventory.SetActive(false);
            menuActive = false;
        }
        else if(Input.GetButtonDown("Fire2") && !menuActive) {
            musicInventory.SetActive(true);
            menuActive = true;
        }
    }

    public void AddItem(MusicItem item)
    {
        for (int i = 0; i < musicItemSlots.Length; i++)
        {
            if (!musicItemSlots[i].isFull)
            {
                musicItemSlots[i].AddItem(item);
                return;
            }
        }
    }
}
