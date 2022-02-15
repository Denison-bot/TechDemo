using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class itemSpawner : MonoBehaviour
{
    private bool canPickUp = false;
    private int itemsCollected;
    private GameObject thisItem;

    public float respawnTimer = 5.0f;
    public bool collected = false;


    public TMP_Text itemCount;
    public TMP_Text pressE;

    // Start is called before the first frame update
    void Start()
    {
        itemsCollected = 0;
    }

    // Update is called once per frame
    void Update()
    {
        itemCount.text = "Items collected " + itemsCollected;

        if (canPickUp == false)
        {
            //pressE.GetComponent<GameObject>().SetActive(false);
            pressE.text = " ";
        }
        else if (canPickUp == true)
        {
            //pressE.GetComponent<GameObject>().SetActive(true);
            pressE.text = "Press E";
        }

        if (canPickUp == true && Input.GetKeyDown(KeyCode.E))
        {
            //Debug.Log("Button Pressed");
            thisItem.SetActive(false);
            itemsCollected++;
            collected = true;
            //pressEText.SetActive(false);
            canPickUp = false;
        }
        if (collected == true)
        {
            respawnTimer -= Time.deltaTime;
            if (respawnTimer <= 0)
            {
                thisItem.SetActive(true);
                collected = false;
                respawnTimer = 5.0f;
            }

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        thisItem = other.gameObject;
        canPickUp = true;
    }
    private void OnTriggerExit(Collider other)
    {
        canPickUp = false;
    }
}
