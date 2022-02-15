using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBox : MonoBehaviour
{
    //public Vector3 playerPos;
    //public Vector3 spawn;
    //public Vector3 checkPoint;
    // public GameObject checkPointPos;
    //CharacterController cc;
    public GameObject player;
    public GameObject spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        //spawn = spawnPos.transform.position;
        //checkPoint = spawnPos.transform.position;
        //cc = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        //playerPos = player.transform.position;
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(player.transform.position);
        //Debug.Log("collided");
        //cc.enabled = false;
        player.GetComponent<CharacterController>().enabled = false;
        player.transform.position = spawnPos.transform.position;
        player.GetComponent<CharacterController>().enabled = true;
        //cc.enabled = true;
    }
}
