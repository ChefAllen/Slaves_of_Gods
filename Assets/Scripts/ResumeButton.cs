using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeButton : MonoBehaviour {

    public GameObject fader;
    public GameObject resumeButton;
    public GameObject loadButton;
    public GameObject saveButton;
    public GameObject quitButton;


    public void OnClick()
    {
        fader.SetActive(false);
        resumeButton.SetActive(false);
        loadButton.SetActive(false);
        saveButton.SetActive(false);
        quitButton.SetActive(false);
    }
}
