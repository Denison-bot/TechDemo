using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Vector3 respawnPos;
    public Vector3 checkPointPos;
    //public GameObject checkPoint;
    public GameObject player;
    public GameObject startSpawn;
    //public bool checkPointHit = false;

    // Start is called before the first frame update
    void Start()
    {
        respawnPos = startSpawn.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
