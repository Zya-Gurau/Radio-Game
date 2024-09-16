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
        inventory = GameObject.Find("Player").GetComponent<MusicInventoryManager>();
        inventory.AddItem("Pop Disc", sprite);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
