using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBox : MonoBehaviour
{
    public Vector3 spawn;
    public Vector3 checkPoint;
    public GameObject checkPointPos;
    public GameObject player;
    public GameObject spawnPos;

    public bool checkPointHit = false;

    // Start is called before the first frame update
    void Start()
    {
        spawn = spawnPos.transform.position;
        checkPoint = spawnPos.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (checkPointHit == true)
        {
            spawn = checkPointPos.transform.position;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        player.GetComponent<CharacterController>().enabled = false;
        player.transform.position = spawn;
        player.GetComponent<CharacterController>().enabled = true;
    }
}
