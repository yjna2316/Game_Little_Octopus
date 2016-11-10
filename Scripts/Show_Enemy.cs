using UnityEngine;
using System.Collections;

//player가 야광공 건드리면 아귀가 나오게 하는 스크립트
public class Show_Enemy : MonoBehaviour
{

    public float speed;

    void OnTriggerEnter2D(Collider2D other)//야광공 건드림
    {
        if (other.CompareTag("Player"))
        {
            Show();
        }
    }

    void Show() //아귀 앞으로 움직이기
    {
        transform.position = transform.position + Vector3.right * speed;
    }


}






