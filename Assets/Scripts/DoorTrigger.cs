using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public GameObject door;
    private bool doorOpen = false;
    private float speed = 3.0f;
    private Vector3 startPos;
    private Vector3 openPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = door.transform.position;
        openPos = door.transform.position;
        openPos.y = door.transform.position.y + 4;
    }

    // Update is called once per frame
    void Update()
    {
        if (doorOpen == true)
        {
            if (door.transform.position.y < openPos.y)
            {
                door.transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
        }
        if (doorOpen == false)
        {
            if (door.transform.position.y > startPos.y)
            {
                door.transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        doorOpen = true;
    }
    private void OnTriggerExit(Collider other)
    {
        doorOpen = false;
    }
}