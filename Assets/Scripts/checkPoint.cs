using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPoint : MonoBehaviour
{
    public DeathBox deathBox;

    private void OnTriggerEnter(Collider other)
    {
        deathBox.checkPointHit = true;
    }
}
