using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour
{
    public bool buttonPressable = false;
    public Vector3 spawnLocation;
    public GameObject spawnBlock;
    public GameObject goomba;
    public ItemManager itemManager;
    // Start is called before the first frame update
    void Start()
    {
        spawnLocation = spawnBlock.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        
        if (buttonPressable == true)
        {
            itemManager.pressEtoSpawn.text = "Press E to Spawn Enemy";
        }
        if (buttonPressable == false)
        {
            itemManager.pressEtoSpawn.text = " ";
        }
        if (buttonPressable == true && Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(goomba, spawnLocation, Quaternion.identity);
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
