using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class MusicItemSlot : MonoBehaviour, IPointerDownHandler
{
    //ITEM DATA
    public String musicItemName;
    public Sprite musicItemSprite;
    public bool isFull;
    public Sprite emptySprite;
    public String description;
    public MusicItem currentItem;

    //SLOT DATA
    [SerializeField]
    private Image musicItemImage;

    //DESCRIPTION SLOT
    public TMP_Text descriptionNameText;
    public TMP_Text descriptionDeText;
    
    public void AddItem(MusicItem item) 
    {
        this.musicItemName = item.musicName;
        this.musicItemSprite = item.sprite;
        this.description = item.getDescription();
        this.isFull = true;
        this.currentItem = item;

        musicItemImage.sprite = item.sprite;   
    }

    public void OnPointerDown(PointerEventData data)
    {
        if(data.button == PointerEventData.InputButton.Left) {
            Debug.Log("CLICK");
            OnLeftClick();
        }
    }

    public void OnLeftClick()
    {
        descriptionNameText.text = musicItemName;
        descriptionDeText.text = description;

    }
    

}
