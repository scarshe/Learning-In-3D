using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI victory;
    public GameObject player;

    void Start()
    {
        victory.enabled = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("f") && player.GetComponent<PlayerScript>().respectTrigger == true)
        {
            Victory();
        }
    }

    void Victory()
    {
        victory.enabled = true;
        player.GetComponent<CharacterController>().enabled = false;
        player.GetComponent<PlayerMovement>().enabled = false;
    }
}
