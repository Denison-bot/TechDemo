using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemManager : MonoBehaviour
{
    public TMP_Text itemCount;
    public TMP_Text pressE;
    public TMP_Text pressEtoSpawn;
    public int ammo;

    

    // Start is called before the first frame update
    void Start()
    {
        ammo = 0;

        pressE.text = " ";
        itemCount.text = "AMMO: " + ammo;

        pressEtoSpawn.text = " ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
