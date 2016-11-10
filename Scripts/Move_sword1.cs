using UnityEngine;
using System.Collections;

public class Move_sword1 : MonoBehaviour {


	public float speed;
	public float waitTime1, waitTime2;//정지 시간


	IEnumerator StopAndGo()// 스프라이트 잠깐 멈추었다 가기
	{
		yield return new WaitForSeconds(waitTime1);
		transform.position = transform.position + Vector3.up *-6;//부글부글

		yield return new WaitForSeconds(waitTime2);
		GetComponent<Rigidbody>().velocity = transform.up * speed ;//솟구치기
		//yield return new WaitForSeconds(waitTime3);
		//GetComponent<Rigidbody>().velocity = -transform.up * 500 * Time.deltaTime;//후진
		//yield return new WaitForSeconds(waitTime2);
		//Destroy(gameObject);

	}

	void Start()
	{
		StartCoroutine(StopAndGo());

	}

}
