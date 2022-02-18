using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class itemSpawner : MonoBehaviour
{
    public bool canPickUp = false;
    public int itemsCollected;
    private GameObject thisItem;

    public float respawnTimer = 5.0f;
    public bool collected = false;

    public ItemManager itemManager;

    // Start is called before the first frame update
    void Start()
    {
        //thisItem = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canPickUp == false)
        {
            //pressE.GetComponent<GameObject>().SetActive(false);
        }
        else if (canPickUp == true)
        {
            //pressE.GetComponent<GameObject>().SetActive(true);
            itemManager.pressE.text = "Press E";
        }

        if (canPickUp == true && Input.GetKeyDown(KeyCode.E))
        {
            thisItem = gameObject;
            //Debug.Log("Button Pressed");
            itemManager.itemsCollected++;
            collected = true;
            itemManager.pressE.text = " ";
            canPickUp = false;
            itemManager.itemCount.text = "Items collected " + itemManager.itemsCollected;
            thisItem.GetComponent<MeshRenderer>().enabled = false;
            //Debug.Log("ALIVE");
        }
        if (collected == true)
        {
            respawnTimer -= Time.deltaTime;
            if (respawnTimer <= 0)
            {
                thisItem.GetComponent<MeshRenderer>().enabled = true;
                collected = false;
                respawnTimer = 5.0f;
            }
        }
        if (GetComponent<MeshRenderer>().enabled == false)
        {
            itemManager.pressE.text = " ";
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        
        canPickUp = true;
    }
    private void OnTriggerExit(Collider other)
    {
        canPickUp = false;
        itemManager.pressE.text = " ";
    }
}
