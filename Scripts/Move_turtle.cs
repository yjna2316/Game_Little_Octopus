using UnityEngine;
using System.Collections;

public class Move_turtle : MonoBehaviour {

	//큰거북이 움직이기
	public float speed;

	public float wait1,wait2; 
	void Start()
	{
		GetComponent<Rigidbody>().velocity = transform.right * speed ;//왼쪽으로 

		StartCoroutine(move());

	}

	IEnumerator move()
	{
		yield return new WaitForSeconds(wait1);
		GetComponent<Rigidbody>().velocity = transform.right * speed * 0;//정지
		yield return new WaitForSeconds(wait2);
		GetComponent<Rigidbody>().velocity = transform.right * speed ;//이동
		yield return new WaitForSeconds(wait2);
		Destroy (gameObject);
	
	}


}
