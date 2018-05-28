using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlaveManager : MonoBehaviour {

    public TextAsset autoSave;
    public string[] slaveProfile;
    public string[] slaveData;
    public string[] slaveData1;
    public string[] slaveData2;
    //public GameObject slave;
    public Text sName;
    public Text sName1;
    public Text sName2;
    public GameObject attempt;
    // Use this for initialization
    void Start () {


        slaveProfile = (autoSave.text.Split('\n'));
        slaveData = (slaveProfile[0].Split(','));
        slaveData1 = (slaveProfile[1].Split(','));
        slaveData2 = (slaveProfile[2].Split(','));
        //sName = slave.GetComponentInChildren(GameObject);
       // attempt = (attempt.GetComponentsInChildren(Text));
        sName.text = slaveData[0];
        sName1.text = slaveData1[0];
        sName2.text = slaveData2[0];
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
