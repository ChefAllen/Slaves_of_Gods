using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapNavButton : MonoBehaviour {

    public GameObject DisplayMain;

    public void OnClick()
    {

        DisplayMain.GetComponent<SlaveMainDisplay>().ClearFeild();
        DisplayMain.GetComponent<SlaveMainDisplay>().Map();


    }
}
