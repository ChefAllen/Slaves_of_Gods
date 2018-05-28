using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour {

    public GameObject fader;
    public GameObject resumeButton;
    public GameObject loadButton;
    public GameObject saveButton;
    public GameObject quitButton;


    public void OnClick()
    {
        fader.SetActive(true);
        resumeButton.SetActive(true);
        loadButton.SetActive(true);
        saveButton.SetActive(true);
        quitButton.SetActive(true);
    }

}
