using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class MusicItemSlot : MonoBehaviour
{
    //ITEM DATA
    public String musicItemName;
    public Sprite musicItemSprite;
    public bool isFull;
    public Sprite emptySprite;

    //SLOT DATA
    [SerializeField]
    private Image musicItemImage;

    void Start() 
    {
        //musicItemImage.sprite = emptySprite; 
    }
    
    
    public void AddItem(String itemName, Sprite itemSprite) 
    {
        this.musicItemName = itemName;
        this.musicItemSprite = itemSprite;
        this.isFull = true;

        musicItemImage.sprite = itemSprite;   
    }
}
