using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{

    public Transform teleportTarget;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        player.GetComponent<CharacterController>().enabled = false;
        player.transform.position = teleportTarget.transform.position;
        player.GetComponent<CharacterController>().enabled = true;
    }
}
