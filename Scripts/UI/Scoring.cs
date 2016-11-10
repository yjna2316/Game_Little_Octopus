using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Scoring : MonoBehaviour {

    public Text DeadText;

    // Use this for initialization
    void Start () {

        DeadText.text = ("Score: " + HealthBarController.score);

    }
	
	
}
