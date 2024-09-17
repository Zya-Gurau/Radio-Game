using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DraggableItem : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private Transform parentAfterDrag;
    private Vector3 dragOffset;
    public Image image;
    public bool isDraggable;

    public MusicItem item;


    public void OnBeginDrag(PointerEventData eventData)
    {
        if(transform.parent.GetComponent<MusicItemSlot>().isFull) {
            isDraggable = true;
            assignValues();
        } else {
            isDraggable = false;
        }
        if(isDraggable){
            if (eventData.button != PointerEventData.InputButton.Left) return;
            Vector3 worldpoint;
            if (DragWorldPoint(eventData, out worldpoint))
            {
                dragOffset = GetComponent<RectTransform>().position - worldpoint;
            }
            else
            {
                dragOffset = Vector3.zero;
            }
            GetComponent<LayoutElement>().ignoreLayout = true;
            parentAfterDrag = transform.parent;
            transform.SetParent(transform.parent.parent, false);
            transform.SetAsLastSibling();
            image.raycastTarget = false;
        }
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        if(isDraggable){
            GetComponent<LayoutElement>().ignoreLayout = false;
            transform.SetParent(parentAfterDrag);
            image.raycastTarget = true;
            if (eventData.button != PointerEventData.InputButton.Left) return;
        }
        isDraggable = false;
    }
    public void OnDrag(PointerEventData eventData)
    {
        if (isDraggable){
            if (eventData.button != PointerEventData.InputButton.Left) return;

            Vector3 worldpoint;
            if (DragWorldPoint(eventData, out worldpoint))
            {
                RectTransform rt = GetComponent<RectTransform>();
                rt.position = worldpoint + dragOffset;
            }
        }
    }

    // Gets the point in worldspace corresponding to where the mouse is
    private bool DragWorldPoint(PointerEventData eventData, out Vector3 worldPoint)
    {
        return RectTransformUtility.ScreenPointToWorldPointInRectangle(
            GetComponent<RectTransform>(),
            eventData.position,
            eventData.pressEventCamera,
            out worldPoint);
    }

    private void assignValues() 
    {
       this.item = transform.parent.GetComponent<MusicItemSlot>().currentItem;
    }
}