using UnityEngine;
using System.Collections;

[System.Serializable]
public class _Boundary
{
    public float yMin, yMax;//y축으로 움직이는 거리 제한
}

public class Move_object : MonoBehaviour
{

    public AudioClip Volcanobgm;
    public AudioClip VolBomed;

    public float speed;
    public float waitTime1, waitTime2, waitTime3;//정지 시간
    public _Boundary boundary;


    IEnumerator StopAndGo()// 스프라이트 잠깐 멈추었다 가기
    {
        AudioSource.PlayClipAtPoint(Volcanobgm, transform.position);
        yield return new WaitForSeconds(waitTime1);
        transform.position = transform.position + Vector3.up * 2;//부글부글
    
        yield return new WaitForSeconds(waitTime2);
        AudioSource.PlayClipAtPoint(VolBomed, transform.position);
        GetComponent<Rigidbody>().velocity = transform.up * speed * Time.deltaTime ;//솟구치기
        yield return new WaitForSeconds(waitTime3);
        GetComponent<Rigidbody>().velocity = -transform.up * 500 * Time.deltaTime;//후진
        yield return new WaitForSeconds(waitTime2);
        Destroy(gameObject);
        
    }

    void Start()
    {
        StartCoroutine(StopAndGo());

    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().position = new Vector3 //y축으로 움직일 수 있는 거리 제한
        (
            0.0f,
            Mathf.Clamp(GetComponent<Rigidbody>().position.y, boundary.yMin, boundary.yMax),
            0.0f
        );
    }
}
