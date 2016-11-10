using UnityEngine;
using System.Collections;


//돌이 player에 가까워지면 갑자기 속도가 빨라지는 스크립트

public class Mover_rock : MonoBehaviour {

    public float speed;
    public float startWait; //스피드업 대기시간
    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.up * speed ;

        StartCoroutine(SpeedUp());

    }

    IEnumerator SpeedUp()
    {
        yield return new WaitForSeconds(startWait);
        GetComponent<Rigidbody>().velocity = transform.up * speed * 5;
    }
    

}
