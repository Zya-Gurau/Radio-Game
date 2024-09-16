using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicItem : MonoBehaviour
{
    public String musicName;
    public String genre;
    public String format;
    public Sprite sprite;
    private MusicInventoryManager inventory;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.Find("UICanvas").GetComponent<MusicInventoryManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addToInventory()
    {
        inventory.AddItem(musicName, sprite);
    }
}
