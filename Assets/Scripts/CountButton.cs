using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CountButton : MonoBehaviour {

    public TextAsset menNames;
    public TextAsset womenNames;
    public TextAsset omniNames;
    public TextAsset agenNames;
    public string[] menNamesText;
    public string[] womenNamesText;
    public string[] omniNamesText;
    public string[] agenNamesText;
    public int counter;
    public Text displayText;
    public Button yourButton;
    public string gender;
    public string slaveName;
    System.Random rndNum = new System.Random();
    // Use this for initialization
    void Start () {

        //captures button
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        // checks if the text documents are imported at start
        if (menNames != null)
        {
            menNamesText = (menNames.text.Split('\n'));
        }
        if (womenNames != null)
        {
            womenNamesText = (womenNames.text.Split('\n'));
        }
        if (omniNames != null)
        {
            omniNamesText = (omniNames.text.Split('\n'));
        }
        if (agenNames != null)
        {
            agenNamesText = (agenNames.text.Split('\n'));
        }

    }
    void TaskOnClick()
    {
        //random number for generating slaves
        int genderRnd = rndNum.Next(1, 5);
        //counter to check stuff
        counter += 1;

        //switch statment to generate slaves depending on random number
        switch (genderRnd)
        {
            case 1:
                //makes a dude
                genderRnd = rndNum.Next(0, 3);   //random number for getting atributes in gender
                gender = "male";
                menNamesText = (menNames.text.Split('\n'));
                slaveName = menNamesText[genderRnd];
                break;
            case 2:
                //makes a chick
                genderRnd = rndNum.Next(0, 3);   //random number for getting atributes in gender
                gender = "female";
                womenNamesText = (womenNames.text.Split('\n'));
                slaveName = womenNamesText[genderRnd];
                break;
            case 3:
                //makes a person
                genderRnd = rndNum.Next(0, 3);   //random number for getting atributes in gender
                gender = "omni-gendered";
                omniNamesText = (omniNames.text.Split('\n'));
                slaveName = omniNamesText[genderRnd];
                break;
            default:
                //makes a person with no gender
                genderRnd = rndNum.Next(0, 3);   //random number for getting atributes in gender
                gender = "a-gendered";
                agenNamesText = (agenNames.text.Split('\n'));
                slaveName = agenNamesText[genderRnd];
                break;
        }
        //test output to check what comes out
        displayText.text = "a " + gender + " named " + slaveName + " was generated";
    }
   
}
