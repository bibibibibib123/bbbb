using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class islandtrack : MonoBehaviour
{
    public TMP_Text EnterIsland;
    public TMP_Text IslandName;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Island")
        {
            EnterIsland.text = "Для входа нажми Е";
            IslandName.text = collision.gameObject.name;
        }

    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Island")
        {
            EnterIsland.text = "";
            IslandName.text = "";
        }
    }

    private void OnTriggerStay(Collider other){
        if(Input.GetKeyDown(KeyCode.E)) {
            if (other.gameObject.name == "Деревня") SceneManager.LoadScene("Pirate village", LoadSceneMode.Single);
        }
    }

    private void Update()
    {

    }
}
