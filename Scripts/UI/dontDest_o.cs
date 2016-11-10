using UnityEngine;
using System.Collections;

public class dontDest_o : MonoBehaviour {

    void Awake()
    {
        if (Application.loadedLevelName == "play1_1" || Application.loadedLevelName == "play1_2" ||
            Application.loadedLevelName == "play1_3" || Application.loadedLevelName == "play1_4")
            DontDestroyOnLoad(this.gameObject);

        if (Application.loadedLevelName == "Dead" || Application.loadedLevelName == "_Start")
        {
            Destroy(this.gameObject);
            Debug.Log("fuckthis shit");

        }
    }

}
