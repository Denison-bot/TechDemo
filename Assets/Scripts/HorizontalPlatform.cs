using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalPlatform : MonoBehaviour
{
    public float speed;
    public bool movingForeward = true;
    public GameObject platform;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (movingForeward == true)
        {
            platform.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (movingForeward == false)
        {
            platform.transform.Translate(Vector3.back * speed * Time.deltaTime);
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

    private void OnCollisionEnter(Collision collision)
    {
        if (movingForeward == true)
        {
            movingForeward = false;
        }
        else if (movingForeward == false)
        {
            movingForeward = true;
        }
    }

    //gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);


}

