using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlaveScript : MonoBehaviour {

    public TextAsset slaveData;
    public string[] saveText;
    public Text displayName;
    // Use this for initialization
    void Start () {
        saveText = (slaveData.text.Split(','));
        displayName.text = saveText[0];
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
