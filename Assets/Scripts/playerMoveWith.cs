using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMoveWith : MonoBehaviour
{
    public GameObject player;
    public bool onPlatform;

    // Start is called before the first frame update
    void Start()
    {
        onPlatform = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (onPlatform)
        {
            //player.transform.Translate(HorizontalPlatform.)
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        onPlatform = true;
    }

}
