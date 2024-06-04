using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseSense : MonoBehaviour
{
    public Slider SL;
    private float vala;
    // Start is called before the first frame update
    void Start()
    {
        SL.value = PlayerPrefs.GetFloat("MouseSens");
    }

    // Update is called once per frame
    void Update()
    {
        vala = SL.value;
        PlayerPrefs.SetFloat("MouseSens",vala);
    }
}
