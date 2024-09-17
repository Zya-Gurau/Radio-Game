using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioMenuTrigger : MonoBehaviour
{
    public GameObject radioMenu;
    public Rigidbody2D rb; 
    public GameObject player;
    public GameObject prompt;
    private bool menuActive;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        menuActive = false;
        radioMenu.SetActive(false);
        prompt.SetActive(false);
    }

    void Update()
    {
        if (rb.IsTouching(player.GetComponent<BoxCollider2D>())) {
            
            if(Input.GetButtonDown("Fire1") && menuActive) {
                Debug.Log("deactivate menu");
                radioMenu.SetActive(false);
                menuActive = false;
                prompt.SetActive(true);
            }
            else if(Input.GetButtonDown("Fire1") && !menuActive) {
                Debug.Log("activate menu");
                prompt.SetActive(false);
                radioMenu.SetActive(true);
                menuActive = true;
            }
        } else {
            radioMenu.SetActive(false);
            menuActive = false;
            prompt.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D col) {
        Debug.Log("collide");
        if (col.gameObject.CompareTag("Player")) 
        { 
            prompt.SetActive(true);
        }
    }
}
