using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OpenSea(){
        SceneManager.LoadScene("Pirate Village", LoadSceneMode.Single);
    }

    public void fs(){
        PlayerPrefs.SetInt("Ship",0);
    }
    public void ss(){
        PlayerPrefs.SetInt("Ship",1);
    }

}
