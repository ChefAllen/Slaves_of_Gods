using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class TimeManagmentButton : MonoBehaviour {

    public TextAsset autoSave;
    public int week = 1;
    public int year = 1;
    public string[] timeInfo;
    public string[] timeParse;
    public Text outputDisplay;
    public GameObject mainDisplay;
    public Text buttonText;

    string DateCalc(int w, int y)
    {
        if (w >= 52)
        {
            w = w - 51;
            y++;
        }

        string outputDate;
        if (y <= 1)
        {
            outputDate = "WEEK " + w;
        }
        else
        {
            outputDate = "WEEK "+ w +", YEAR "+ y;
        }

        return outputDate;
    }

	// Use this for initialization
	void Start () {

        outputDisplay.text = DateCalc(week, year);
       // TimeSaveFunc(week, year);

    }
	public void OnClick()
    {

        week++;
        outputDisplay.text = DateCalc(week, year);
        if (week >= 52)
        {
            week = week - 51;
            year = year + 1;
        }
        buttonText.text = "Next";
        mainDisplay.GetComponent<SlaveMainDisplay>().RandEventGen();
    }



    //*******************************************need to work on this so that it changes the currenttime display

    public void TimeSaveFunc(int w, int y)
    {
        //takes the time data from the txt file and stores it in timeInfo[]
        timeInfo = (autoSave.text.Split('^'));

        timeParse = (timeInfo[1].Split(','));

        //converts the cashInfo[] data into an int
        week = Convert.ToInt32(timeParse[0]);
        year = Convert.ToInt32(timeParse[1]);

        //creates output for the date in relation to what the save file says
        string outputDate;
        if (y <= 1)
        {
            outputDate = "WEEK " + w;
        }
        else
        {
            outputDate = "WEEK " + w + ", YEAR " + y;
        }
        /*

        this will be worked on when i build save system


        //rewrites to the text file specified in the path to hold the new date with the proper formating
        System.IO.File.WriteAllText("Assets/Text Docs/AutoSave.txt", (timeInfo[0] + "^" + week + ","+ year + "^" + timeInfo[2]));

        //refreshes text file to use new data that was written to it
        AssetDatabase.Refresh();
        */

        //returns the date in the save file
        outputDisplay.text = outputDate;
        //return outputDate;
    }
}
