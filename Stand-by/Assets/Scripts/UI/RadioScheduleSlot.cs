using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class RadioScheduleSlot : MonoBehaviour, IDropHandler
{
    public TMP_Text slotText;
    public bool isFull = false;


    public void OnDrop(PointerEventData eventData)
    {
        MusicItem item = eventData.pointerDrag.GetComponent<DraggableItem>().item;
        slotText.text = item.musicName + ", Genre: " + item.genre + ", Format: " + item.format;
        isFull = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
