using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemManager : MonoBehaviour
{
    public TMP_Text itemCount;
    public TMP_Text pressE;
    public int itemsCollected;

    

    // Start is called before the first frame update
    void Start()
    {
        pressE.text = " ";
        itemCount.text = "Items collected " + itemsCollected;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}