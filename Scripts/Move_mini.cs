using UnityEngine;
using System.Collections;

public class Move_mini : MonoBehaviour {

	//불가사리에 가까워지면 돌을 던지는 스크립트

	public float speed;
	public float x, y, z;
	public float startWait; //대기시간
	void Start()
	{   GetComponent<Rigidbody> ().useGravity = false;
		GetComponent<Rigidbody>().velocity = transform.up * speed ;

		StartCoroutine(Throw());

	}

	IEnumerator Throw()//돌던지기
	{
		yield return new WaitForSeconds(startWait);
		GetComponent<Rigidbody> ().useGravity = true;
		GetComponent<Rigidbody>().velocity =  new Vector3(x,y,z);
	}

}
