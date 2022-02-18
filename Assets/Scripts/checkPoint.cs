using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPoint : MonoBehaviour
{
    public PlayerManager playerManager;

    private void OnTriggerEnter(Collider other)
    {
        playerManager.respawnPos = this.gameObject.transform.position;
    }
}
