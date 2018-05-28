using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveBackButton : MonoBehaviour {

    public GameObject backButton;
    public GameObject memFile1;
    public GameObject memFile2;
    public GameObject memFile3;
    public GameObject memFile4;
    public GameObject memFile5;
    public GameObject memFile6;
    public GameObject memFile7;
    public GameObject memFile8;
    public GameObject memFile9;
    public GameObject resumeButton;
    public GameObject loadButton;
    public GameObject saveButton;
    public GameObject quitButton;

    public void OnClick()
    {
        backButton.SetActive(false);
        memFile1.SetActive(false);
        memFile2.SetActive(false);
        memFile3.SetActive(false);
        memFile4.SetActive(false);
        memFile5.SetActive(false);
        memFile6.SetActive(false);
        memFile7.SetActive(false);
        memFile8.SetActive(false);
        memFile9.SetActive(false);
        resumeButton.SetActive(true);
        loadButton.SetActive(true);
        saveButton.SetActive(true);
        quitButton.SetActive(true);

    }
}
