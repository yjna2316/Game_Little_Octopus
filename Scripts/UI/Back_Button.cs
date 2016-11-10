using UnityEngine;
using System.Collections;

public class Back_Button : MonoBehaviour {

 
    public void backtoHome()
    {
        GameObject.Find("OctPlayer").SetActive(false);
        GameObject.Find("Canvas").SetActive(false);
        Application.LoadLevel("_Start");
    }

}
