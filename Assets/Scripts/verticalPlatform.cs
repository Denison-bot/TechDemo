using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verticalPlatform : MonoBehaviour
{
    public Vector3 maxHeight;
    public Vector3 minHeight;
    public float speed;
    public bool movingUp;
    public bool movingDown;
    public GameObject platform;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        minHeight = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        maxHeight = new Vector3(transform.position.x, transform.position.y + 10, transform.position.z);
         // default speed

    }

    // Update is called once per frame
    void Update()
    {
        if (movingUp)
        {
            platform.transform.Translate(Vector3.up * speed * Time.deltaTime);
            if (platform.transform.position.y >= maxHeight.y)
            {
                movingUp = false;
            }
        }

        else if (movingUp == false)
        {
            platform.transform.Translate(Vector3.down * speed * Time.deltaTime);
            if (platform.transform.position.y <= minHeight.y)
            {
                movingUp = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            player.transform.parent = transform;
            Physics.autoSyncTransforms = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            player.transform.parent = null;
            Physics.autoSyncTransforms = true;
        }
    }

}
