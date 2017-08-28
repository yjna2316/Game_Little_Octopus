using UnityEngine;
using System.Collections;
/* fading when the stage/scene changes */
public class Fading : MonoBehaviour {

    public Texture2D fadeOutTexture;  // black screen when fading
    public float fadeSpeed = 0.8f;  // fading speed

    private int drawDepth = -1000;
    private float alpha = 1.0f;
    private int fadeDir = -1;

    void onGUI()
    {
        Debug.Log(10);
        alpha += fadeDir * fadeSpeed * Time.deltaTime;
        Debug.Log(20);
        alpha = Mathf.Clamp01(alpha);
        Debug.Log(30);
        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        Debug.Log(40);
        GUI.depth = drawDepth;
        Debug.Log(50);
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeOutTexture);
        Debug.Log(60);
    }

    public float BeginFade(int direction)
    {
      
        fadeDir = direction;
        return (fadeSpeed);
    }

    void OnLevelWasLoaded()
    {
        BeginFade(-1);
    }
    
}
