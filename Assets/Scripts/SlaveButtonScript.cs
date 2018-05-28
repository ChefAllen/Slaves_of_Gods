using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlaveButtonScript : MonoBehaviour {

    [SerializeField]
    private Text nameText;

    [SerializeField]
    private Text genderText;

    public void SetText(string name, string gender)
    {
        nameText.text = name;
        genderText.text = gender;
    }
    // Update is called once per frame
    public void OnClick()
    {

    }
}
