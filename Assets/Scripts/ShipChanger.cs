using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipChanger : MonoBehaviour
{
    public GameObject[] Ships;
    private int ShipNumber;
    // Start is called before the first frame update
    void Start()
    {
        ShipNumber = PlayerPrefs.GetInt("Ship");
        Ships[ShipNumber].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
