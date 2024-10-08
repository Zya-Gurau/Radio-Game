using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialMusicItem : MonoBehaviour
{
    public Sprite sprite;
    private MusicInventoryManager inventory;
    // Start is called before the first frame update
    void Start()
    {
        MusicItem item = new MusicItem();
        item.musicName = "Pop Disc";
        item.genre = "Pop";
        item.format = "CD";
        item.sprite = sprite;

        MusicItem item2 = new MusicItem();
        item2.musicName = "Rock n Roll Disc";
        item2.genre = "Rock";
        item2.format = "CD";
        item2.sprite = sprite;

        inventory = GameObject.Find("Player").GetComponent<MusicInventoryManager>();
        inventory.AddItem(item);
        inventory.AddItem(item2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
