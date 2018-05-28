using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitToDesktopButton : MonoBehaviour {

    public void OnClick() {

        Debug.Log("game has ended");
        Application.Quit();

    }
}
