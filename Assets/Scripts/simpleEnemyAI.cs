using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleEnemyAI : MonoBehaviour
{
    public float speed = .3f;
    public bool movingLeft = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (movingLeft == true)
        {
            gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (movingLeft == false)
        {
            gameObject.transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (movingLeft == true)
        {
            movingLeft = false;
        }
        else if (movingLeft == false)
        {
            movingLeft = true;
        }
    }
}
