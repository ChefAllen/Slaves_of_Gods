using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class SlaveMainDisplay : MonoBehaviour {

    public TextAsset autoSave;
    public TextAsset mapTxt;
    public TextAsset baseStats;
    public TextAsset[] randomEvents;
    public string[] slaveProfile;
    public string[] slaveInfo;
    public string[] slaveData = new string[2];
    public string[] mapList;
    public string[] mapLocations;
    public string[] cashInfo;
    public string[] baseInfo;
    public int loopCount;
    public GameObject contentHolder;
    public GameObject contentTextBox;
    System.Random rndNum = new System.Random();
    public Text mainTextDisplay;
    public Text cashDisplay;
    public int cash;

    [SerializeField]
    private GameObject slaveTemplate;

    [SerializeField]
    private GameObject mapTemplate;

    void Start()
    {
        //this block of code just throws somthing into the money display text field. just a place holder till new game and game load functions are made
        baseInfo = (baseStats.text.Split(':'));
        cash = Convert.ToInt32(baseInfo[0]);
        cashDisplay.text = "$ " + cash;
       

    }

    public void ClearFeild()
    {
        //gets all clones which were created with the tag"MainDisplayContent". all things in the main display should have this tag
        var clones = GameObject.FindGameObjectsWithTag("MainDisplayContent");

        //foreach loop destroys all clones with the previously mentioned tag
        foreach (var clone in clones)
        {
            Destroy(clone);
        }

        //turns off the text display of the random event from time progression and events
        contentTextBox.SetActive(false);
        
    }

    public void Money(int moneyChange)
    {
        //takes the cash data from the txt file and stores it in cashInfo[]
        cashInfo = (autoSave.text.Split('$'));

        //converts the cashInfo[] data into an int
        cash = Convert.ToInt32(cashInfo[1]);

        //manipulates the cash amount that was passed to this function
        cash = cash + moneyChange;

        //changes the display of the cash amount to what is current
        cashDisplay.text = "$ "+ cash;
        
        //rewrites to the text file specified in the path to hold the new cash total with the proper formating
        System.IO.File.WriteAllText("Assets/Text Docs/AutoSave.txt", (cashInfo[0] +"$" + cash + "$" + cashInfo[2]));

        //refreshes text file to use new data that was written to it
        AssetDatabase.Refresh();
    }

    public void SlaveStat()
    {
        //catches the data from the autosave file for slaves
        slaveInfo = (autoSave.text.Split('&'));

        //splits all the slaves into an array to easy access
        slaveProfile = (slaveInfo[1].Split(':'));

        //just to save run time, called the funtion here instead of doing so during loop
        loopCount = (slaveProfile.Length - 1);

        // these 2 lines just make the arrays to hold the data for the slaves, this will be expanded on as slaves get more assets
        string[] sName = new string[(loopCount+1)];
        string[] sGender = new string[(loopCount + 1)]; ;

        //this loop runs through the slaves 1 by 1 to generate a Game object for each with their assets properly assigned to the coresponding slave
        for (int j = 0; j <= loopCount; j++)
        {
            //parses the data from slaveprofile into slavedata to isolate a specific slave. slave data's array index represents the current number of assets per slave
            slaveData = (slaveProfile[j].Split(','));

            //this if statment is a fail safe just in case something is stored as a blank so that we keep things rolling smothly
            if ((slaveData[0] == "") || (slaveData[1] == ""))
            {
                break;
                
            }

            //these lines take the data from slave data so that can be more reader friendly to pass to the function later on
            sName[j] = slaveData[0];
            sGender[j] = slaveData[1];

            //instantiates new game object clone for a slave in the main display
            GameObject button = Instantiate(slaveTemplate) as GameObject;

            //this activates the newly instantiated object so it can be interacted with and seen 
            button.SetActive(true);

            //sets the tag to "MainDisplayContent" so that it can be deleted when navigating through the game
            button.gameObject.tag = "MainDisplayContent";

            //passes the data of the slave to the newly instantiated game object
            button.GetComponent<SlaveButtonScript>().SetText(sName[j], sGender[j]);

            //sets the newly instantiated object to be a child of the content object for the main display so it adheres to the formating i wanted
            button.transform.SetParent(slaveTemplate.transform.parent, false);
        }
    }

    public void Map()
    {
        string holder;
        mapList = (mapTxt.text.Split('\n'));
        loopCount = (mapList.Length - 1);

        for (int j = 0; j <= loopCount; j++)
        {
            holder = mapList[j];
            mapLocations = holder.Split(',');

            GameObject mapButton = Instantiate(mapTemplate) as GameObject;
            mapButton.SetActive(true);

            mapButton.gameObject.tag = "MainDisplayContent";

            mapButton.GetComponent<MapButtonScript>().SetText(mapLocations[0], mapLocations[1]);

            mapButton.transform.SetParent(slaveTemplate.transform.parent, false);
        }
    }

    public void RandEventGen()
    {
        //this gets a count of the events so that we call the length function once, should help run time on slower systems
        int eventListCount = randomEvents.Length;

        //generates a random number representing which event got chosen
        int eventRnd = rndNum.Next(0, eventListCount);

        //clears main display
        ClearFeild();

        //activates the text display box in main display
        contentTextBox.SetActive(true);

        //displays the content of the event to the user in the main display
        mainTextDisplay.text = randomEvents[eventRnd].text;

        //this is just a block of test code to get money from the money event. this will probably change to a switch statment when i build out content
        if (eventRnd == 1)
        {

            Money(1000);
            
        }

        
    }
}
