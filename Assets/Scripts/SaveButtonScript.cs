using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveButtonScript : MonoBehaviour {

    public GameObject backButton;
    public GameObject deleteButton;
    public GameObject saveFile1;
    public GameObject saveFile2;
    public GameObject saveFile3;
    public GameObject saveFile4;
    public GameObject saveFile5;
    public GameObject saveFile6;
    public GameObject saveFile7;
    public GameObject saveFile8;
    public GameObject saveFile9;
    public GameObject resumeButton;
    public GameObject loadButton;
    public GameObject saveButton;
    public GameObject quitButton;

    public void OnClick() {
        backButton.SetActive(true);
        deleteButton.SetActive(true);
        saveFile1.SetActive(true);
        saveFile2.SetActive(true);
        saveFile3.SetActive(true);
        saveFile4.SetActive(true);
        saveFile5.SetActive(true);
        saveFile6.SetActive(true);
        saveFile7.SetActive(true);
        saveFile8.SetActive(true);
        saveFile9.SetActive(true);
        resumeButton.SetActive(false);
        loadButton.SetActive(false);
        saveButton.SetActive(false);
        quitButton.SetActive(false);

    }
}
