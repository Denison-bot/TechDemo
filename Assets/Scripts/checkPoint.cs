using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPoint : MonoBehaviour
{
    public PlayerManager playerManager;
    private AudioSource source;
    public AudioClip checkpointPing;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(playerManager.respawnPos != this.gameObject.transform.position)
        {
            source.PlayOneShot(checkpointPing);
        }
        playerManager.respawnPos = this.gameObject.transform.position;
    }
}
