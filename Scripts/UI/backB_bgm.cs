using UnityEngine;
using System.Collections;

public class backB_bgm : MonoBehaviour {

    public AudioClip bb_bgm;

    public void click_b()
    {
        AudioSource.PlayClipAtPoint(bb_bgm, transform.position);
    }
}
