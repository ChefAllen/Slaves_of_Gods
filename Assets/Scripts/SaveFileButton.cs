using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveFileButton : MonoBehaviour {

    public Text nameDisplay;
    public Text playTimeDisplay;
    public TextAsset autoSaveFile;
    public TextAsset saveFile;
    public string[] fileCheck;
    public string[] playerInfo;
    public string[] playerName;
    public string[] playTimeInfo;
    public string[] playTime;

	// Use this for initialization
	void Start () {
        fileCheck = (saveFile.text.Split('!'));
        if (fileCheck[1] == "YES") {

            playerInfo = (saveFile.text.Split('*'));
            playerName = (playerInfo[1].Split(','));
            playTimeInfo = (saveFile.text.Split('^'));
            playTime = (playTimeInfo[1].Split(','));

            nameDisplay.text = "Player Name: " + playerName[0];
            playTimeDisplay.text = "Time : W "+playTime[0] + ", Y " + playTime[1];

        }
        else
        {
            nameDisplay.text = "* EMPTY *";
            playTimeDisplay.text = "* FILE *";
        }
    }

    public void OnClick()
    {

    }

}
