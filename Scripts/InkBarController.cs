using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Runtime.InteropServices;

public class InkBarController : MonoBehaviour
{
    float timer;

    public Scrollbar InkBar;
    public float Ink = 100;

    public float TimeD;

    public Animator anim; // ani

    void Start()
    {
        timer = 0;
        TimeD = 3f;
        anim = GetComponent<Animator>(); // ani

    }

    public void Damage(float value)
    {
        if(value > 0f)
        {
            Ink -= value;
            InkBar.size = Ink / 100f;
            anim.SetTrigger("Booster_Start"); // to play Oct_Booster
        }
        else
        {
            anim.SetTrigger("Booster_End"); // to play Oct_Idle
        }
        
    }

    void Update()
    {
        if (Ink <= 100)
        {
            timer += Time.deltaTime;
            Ink += TimeD * Time.deltaTime;
            InkBar.size = Ink / 100f;
        }
    }


}
