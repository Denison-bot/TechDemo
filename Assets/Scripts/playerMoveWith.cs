using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMoveWith : MonoBehaviour
{
    private Rigidbody player;
    public GameObject platform;
    public bool onPlatform;

    // Start is called before the first frame update
    void Start()
    {
        onPlatform = false;
        player = player.GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {

        if (onPlatform)
        {
             
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (tag == "Player")
        {
            onPlatform = true;
            //other.transform.parent = platform.transform;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (tag == "Player")
        {
            onPlatform = false;
        }
    }
}
