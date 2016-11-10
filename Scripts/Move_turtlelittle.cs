using UnityEngine;
using System.Collections;

public class Move_turtlelittle : MonoBehaviour {


	//작은 거북이 이동
	public float speed;
	public float waitTime1, waitTime2;//정지 시간


	IEnumerator StopAndGo()// 스프라이트 잠깐 멈추었다 가기
	{
		yield return new WaitForSeconds(waitTime1);
		//transform.position = transform.position + Vector3.up *-2;//부글부글

		//yield return new WaitForSeconds(waitTime2);
		GetComponent<Rigidbody>().velocity = transform.up * speed ;//솟구치기

	}

	void Start()
	{
		StartCoroutine(StopAndGo());

	}
}
