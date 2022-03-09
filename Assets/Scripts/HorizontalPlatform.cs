using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalPlatform : MonoBehaviour
{
    public float speed;
    public bool movingForeward = true;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (movingForeward == true)
        {
            gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (movingForeward == false)
        {
            gameObject.transform.Translate(Vector3.back * speed * Time.deltaTime);
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

