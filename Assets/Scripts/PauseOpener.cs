using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseOpener : MonoBehaviour
{
    // Start is called before the first frame update
    private bool pause = false;
    public GameObject PauseMenu;
    public GameObject SettingsMenu;
    public GameObject cam;
    void Start()
    {
        cam.GetComponent<ThirdPersonOrbitCamBasic>().horizontalAimingSpeed = PlayerPrefs.GetFloat("MouseSens");
        cam.GetComponent<ThirdPersonOrbitCamBasic>().verticalAimingSpeed = PlayerPrefs.GetFloat("MouseSens");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            cam.GetComponent<ThirdPersonOrbitCamBasic>().horizontalAimingSpeed = PlayerPrefs.GetFloat("MouseSens");
            cam.GetComponent<ThirdPersonOrbitCamBasic>().verticalAimingSpeed = PlayerPrefs.GetFloat("MouseSens");
            pause = !pause;
            switch(pause){
                case true:
                    PauseMenu.SetActive(pause);
                    cam.GetComponent<ThirdPersonOrbitCamBasic>().enabled = false;
                    Cursor.lockState = CursorLockMode.None;
		            Cursor.visible = true;
                break;

                case false:
                    PauseMenu.SetActive(pause);
                    cam.GetComponent<ThirdPersonOrbitCamBasic>().enabled = true;
                    SettingsMenu.SetActive(pause);
                    Cursor.lockState = CursorLockMode.Locked;
		            Cursor.visible = false;
                break;
            }
        }
         
    }
    public void OpenSettings(){
        PauseMenu.SetActive(false);
        SettingsMenu.SetActive(true);
    }
}
