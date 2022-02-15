using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) == true)
        {
            gameObject.GetComponent<CharacterController>().enabled = false;
            gameObject.transform.position = Vector3.zero;
            gameObject.GetComponent<CharacterController>().enabled = true;
        }
    }
}
