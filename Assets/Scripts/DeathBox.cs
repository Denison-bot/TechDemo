using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBox : MonoBehaviour
{
    //public Vector3 spawn;
    //public Vector3 checkPoint;
    //public GameObject checkPointPos;
    //public GameObject spawnPos;
    public PlayerManager playerManager;

    // Start is called before the first frame update
    void Start()
    {
        //spawn = spawnPos.transform.position;
        //checkPoint = spawnPos.transform.position;

    }

    // Update is called once per frame
    void Update()
    {



    }
    private void OnTriggerEnter(Collider other)
    {
        playerManager.player.GetComponent<CharacterController>().enabled = false;
        playerManager.player.transform.position = playerManager.respawnPos;
        playerManager.player.GetComponent<CharacterController>().enabled = true;
    }
}
