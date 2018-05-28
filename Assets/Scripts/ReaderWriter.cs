using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


public class ReaderWriter : MonoBehaviour {
    
    public string textEdit;//this is the text that replaces to text doc contents
    public Text displaydoc;
    private string changeText;
  
    public void OnClick()
    {
        //rewrites to the text file specified in the path
        System.IO.File.WriteAllText("Assets/Text Docs/test.txt", textEdit);
        //refreshes text file to use new data that was written to it
        AssetDatabase.Refresh();
        changeText = textEdit;
    }
    void Update()
    {
        if (changeText != null) {
            displaydoc.text = changeText;
        }
    }
}
