using UnityEngine;
using System.Collections;


public class Move_squids : MonoBehaviour {
    
	public float speed,speedup;
	public float x, y, z;
	public float startWait; //대기시간
	void Start()
	{   GetComponent<Rigidbody> ().useGravity = false;
		GetComponent<Rigidbody>().velocity = transform.up * speed ;

		StartCoroutine(go());

	}

	IEnumerator go()//오징어 움직이기
	{
		yield return new WaitForSeconds(startWait);
		//GetComponent<Rigidbody> ().useGravity = true;
		GetComponent<Rigidbody>().velocity =  new Vector3(x,y,z) * speedup;
	}



}
