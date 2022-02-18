using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorButton : MonoBehaviour
{
    public GameObject door;
    public bool buttonPressable = false;
    public bool doorOpen = false;
    private float speed = 3.0f;
    private Vector3 startPos;
    private Vector3 openPos;
    public float doorTimer = 5.0f;
    public ItemManager itemManager;

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
        if (buttonPressable == true)
        {
            itemManager.pressE.text = "Press E";
        }
        if (buttonPressable == false)
        {
            itemManager.pressE.text = " ";
        }
        if (buttonPressable == true && Input.GetKeyDown(KeyCode.E))
        {
            doorOpen = true;
        }
        if (doorOpen == true)
        {
            if (door.transform.position.y < openPos.y)
            {
                door.transform.Translate(Vector3.up * speed * Time.deltaTime);

            }

            if (door.transform.position.y >= openPos.y)
            {
                doorTimer -= Time.deltaTime;
                if (doorTimer <= 0)
                {
                    doorOpen = false;
                }
            }
        }
        if (doorOpen == false)
        {
            if (door.transform.position.y > startPos.y)
            {
                door.transform.Translate(Vector3.down * speed * Time.deltaTime);
                doorTimer = 5.0f;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        buttonPressable = true;
    }
    private void OnTriggerExit(Collider other)
    {
        buttonPressable = false;
    }
}