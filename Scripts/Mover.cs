using UnityEngine;
using System.Collections;

//object들이 아래로 움직이도록함
public class Mover : MonoBehaviour {

    public float speed;

    void Start()
    {
              GetComponent<Rigidbody>().velocity = transform.up * speed;//위로 올라감

        //GetComponent<Rigidbody2D>().velocity = transform.up * speed;//위로 올라감
    }

}
