using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionListButton : MonoBehaviour
{

    [SerializeField]
    private Text myText;

    public void SetText(string textString)
    {
        myText.text = textString;
    }
    // Update is called once per frame
    public void OnClick()
    {

    }
}
