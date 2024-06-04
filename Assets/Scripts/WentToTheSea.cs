using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WentToTheSea : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other){
        if (other.gameObject.name == "boat"){
            canvas.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other){
        if (other.gameObject.name == "boat"){
            canvas.SetActive(false);
        }
    }
    private void OnTriggerStay(Collider other){
        if (other.gameObject.name == "boat"){
            if(Input.GetKeyDown(KeyCode.E)){
                SceneManager.LoadScene("Sea", LoadSceneMode.Single);
            }
        }
    }
}
