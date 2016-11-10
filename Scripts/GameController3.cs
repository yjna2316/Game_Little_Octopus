using UnityEngine;
using System.Collections;

public class GameController3: MonoBehaviour {

//	public float speed;
//	public float waitTime2;//정지 시간

	public GameObject hazard1,hazard2,hazard3,hazard4,hazard5,hazard6,hazard7,hazard8,hazard9,hazard10,hazard11,hazard12;
	public Vector3 spawnValues1,spawnValues2,spawnValues3,spawnValues4,spawnValues5,spawnValues6,spawnValues7,spawnValues8,spawnValues9,spawnValues10,spawnValues11,spawnValues12;
	public int hazardCount,hazardCount2;
	public float spawnWait;
	public float wait,wait1,wait2,wait3,wait4,wait5,wait6,wait7,wait8,wait9,wait10,wait11,wait12;
	Vector3 spawnPosition;
	Quaternion spawnRotation;
	void Start ()
	{
		StartCoroutine (SpawnWaves ());
	}

	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (wait);
        //1번째 (황새치)
       


                spawnPosition = new Vector3(-1.1f, 6.65f, 0.0f);
                spawnRotation = Quaternion.identity;
                Instantiate(hazard1, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(wait1);

                spawnPosition = new Vector3 (-0.3f, 6.65f, 0.0f);
				spawnRotation = Quaternion.identity;
				Instantiate (hazard1, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (wait1);

				spawnPosition = new Vector3 (0.3f, 6.65f, 0.0f);
				spawnRotation = Quaternion.identity;
				Instantiate (hazard1, spawnPosition, spawnRotation);
				

			
		

		//2번째(큰거북)
		yield return new WaitForSeconds (wait2);
		spawnPosition = new Vector3 (spawnValues2.x, spawnValues2.y, spawnValues2.z);
	    spawnRotation = Quaternion.identity;
		Instantiate (hazard2, spawnPosition, spawnRotation);


		//3번째(작은거북)
		yield return new WaitForSeconds (wait3);
		for (int i = 0; i < hazardCount; i++)
		{
			
			spawnPosition = new Vector3 (Random.Range (-spawnValues3.x, spawnValues3.x), spawnValues3.y, spawnValues3.z);
			spawnRotation = Quaternion.identity;
			Instantiate (hazard3, spawnPosition, spawnRotation);


			yield return new WaitForSeconds (spawnWait);
		}


		//4번째(통로1)
		yield return new WaitForSeconds (wait4);
		spawnPosition = new Vector3 (spawnValues4.x, spawnValues4.y, spawnValues4.z);
		spawnRotation = Quaternion.identity;
		Instantiate (hazard4, spawnPosition, spawnRotation);

		//5번째(돌)
		yield return new WaitForSeconds (wait5);
		spawnPosition = new Vector3 (spawnValues5.x, spawnValues5.y, spawnValues5.z);
		spawnRotation = Quaternion.identity;
		Instantiate (hazard5, spawnPosition, spawnRotation);

		//6번째(황새치)
		yield return new WaitForSeconds (wait6);




        spawnPosition = new Vector3(1.4f, 6.65f, 0.0f);
        spawnRotation = Quaternion.identity;
        Instantiate(hazard6, spawnPosition, spawnRotation);
        yield return new WaitForSeconds(wait1);

       

        spawnPosition = new Vector3(1.0f, 6.65f, 0.0f);
        spawnRotation = Quaternion.identity;
        Instantiate(hazard6, spawnPosition, spawnRotation);
        yield return new WaitForSeconds(wait1);


        spawnPosition = new Vector3(0.5f, 6.65f, 0.0f);
        spawnRotation = Quaternion.identity;
        Instantiate(hazard6, spawnPosition, spawnRotation);
        yield return new WaitForSeconds(wait1);

        spawnPosition = new Vector3(-0.0f, 6.65f, 0.0f);
        spawnRotation = Quaternion.identity;
        Instantiate(hazard6, spawnPosition, spawnRotation);
        yield return new WaitForSeconds(wait1);

        spawnPosition = new Vector3(-0.3f, 6.65f, 0.0f);
        spawnRotation = Quaternion.identity;
        Instantiate(hazard6, spawnPosition, spawnRotation);
        


        

        

        

     


        //7번째(돌이랑 불가사리)
        yield return new WaitForSeconds (wait7);
		spawnPosition = new Vector3 (spawnValues7.x, spawnValues7.y, spawnValues7.z);
		spawnRotation = Quaternion.identity;
		Instantiate (hazard7, spawnPosition, spawnRotation);

		//8번째(통로2)
		yield return new WaitForSeconds (wait8);
		spawnPosition = new Vector3 (spawnValues8.x, spawnValues8.y, spawnValues8.z);
		spawnRotation = Quaternion.identity;
		Instantiate (hazard8, spawnPosition, spawnRotation);

		//9번째(황새치)

		yield return new WaitForSeconds (wait9);
		spawnPosition = new Vector3 (0.7f, 6.65f, 0.0f);
		spawnRotation = Quaternion.identity;
		Instantiate (hazard6, spawnPosition, spawnRotation);
		yield return new WaitForSeconds (0.5f);

		/*spawnPosition = new Vector3 (0.8f, 6.65f, 0.0f);
		spawnRotation = Quaternion.identity;
		Instantiate (hazard6, spawnPosition, spawnRotation);
		yield return new WaitForSeconds (wait1);*/

		spawnPosition = new Vector3 (-0.7f, 6.65f, 0.0f);
		spawnRotation = Quaternion.identity;
		Instantiate (hazard6, spawnPosition, spawnRotation);
		yield return new WaitForSeconds (wait1);

		//10번째(큰거북)
		yield return new WaitForSeconds (wait10);
		spawnPosition = new Vector3 (spawnValues10.x, spawnValues10.y, spawnValues10.z);
		spawnRotation = Quaternion.identity;
		Instantiate (hazard10, spawnPosition, spawnRotation);

		//11번째(작은거북)
		yield return new WaitForSeconds (wait11);
		for (int i = 0; i < hazardCount2; i++)
		{

			spawnPosition = new Vector3 (Random.Range (-spawnValues11.x, spawnValues11.x), spawnValues11.y, spawnValues11.z);
			spawnRotation = Quaternion.identity;
			Instantiate (hazard11, spawnPosition, spawnRotation);


			yield return new WaitForSeconds (spawnWait);
		}

		//12번째(왕새우)
		yield return new WaitForSeconds (wait12);
		spawnPosition = new Vector3 (spawnValues12.x, spawnValues12.y, spawnValues12.z);
		spawnRotation = Quaternion.identity;
		Instantiate (hazard12, spawnPosition, spawnRotation);

	}


}
