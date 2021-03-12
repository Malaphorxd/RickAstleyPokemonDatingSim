using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour {

    public void quitgame() {
        Debug.Log("has quit game");
        Application.Quit();
    }

}
