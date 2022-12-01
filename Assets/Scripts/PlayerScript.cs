using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public GameObject Respect;
    public bool respectTrigger;

    // Start is called before the first frame update
    void Start()
    {
        Respect.SetActive(false);
    }
    
    public void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Respawn")
        {
            GetComponent<CharacterController>().enabled = false;
            
            transform.position = new Vector3(47.5f, 227, -18.5f);
            GetComponent<PlayerMovement>().pitch = 10.0f;
            GetComponent<PlayerMovement>().yaw = 0.0f;
            
            GetComponent<CharacterController>().enabled = true;
        }

        if(collider.gameObject.tag == "Respect")
        {
            Respect.SetActive(true);
            respectTrigger = true;
        }
    }

    public void OnTriggerExit(Collider collider)
    {
        if(collider.gameObject.name == "Respect")
        {
            Respect.SetActive(false);
            respectTrigger = false;
        }
    }
}
