using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapButtonScript : MonoBehaviour {

    [SerializeField]
    private Text locationText;

    [SerializeField]
    private Text descriptionText;

    public void SetText(string location, string description)
    {
        locationText.text = location;
        descriptionText.text = description;
    }
    // Update is called once per frame
    public void OnClick()
    {

    }
}