using UnityEngine;
using System.Collections;
//내가 원하는 시간과 위치에서 오브젝트가 생성되게 하는 스크립트
public class GameController_BGObj_03 : MonoBehaviour {

	public GameObject BG_object1,BG_object2,BG_object3,BG_object4,BG_object5,BG_object6,BG_object7, BG_object8, BG_object9, BG_object10, BG_object11;//배경 오브젝트들
	public Vector3 spawnValues1, spawnValues2, spawnValues3,spawnValues4,spawnValues5, spawnValues6, spawnValues7, spawnValues8, spawnValues9, spawnValues10, spawnValues11;//출현 위치
   // public int hazardCount1;//한 블럭당 출현 횟수
    public float startWait;// 게임시작후 대기 시간
   // public float spawnWait;// 같은 BG_object간 대기 시간
	public float waveWait2,waveWait3,waveWait4,waveWait5, waveWait6, waveWait7, waveWait8, waveWait9, waveWait10, waveWait11; //다음 BG_object 대기 시간


    Vector3 spawnPosition;//지정 위치
    Quaternion spawnRotation;//회전
  
    void Start()
    {

        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
       yield return new WaitForSeconds(startWait);//잠깐 기다렸다가


       //1번째
            spawnPosition = new Vector3(spawnValues1.x, spawnValues1.y, spawnValues1.z); //내가 지정한 위치에서
            spawnRotation = Quaternion.identity;
            Instantiate(BG_object1, spawnPosition, spawnRotation);//첫번째 출현

        
        
        //두번째
        yield return new WaitForSeconds(waveWait2);//다음 주자 기다려
        spawnPosition = new Vector3(spawnValues2.x, spawnValues2.y, spawnValues2.z);
        spawnRotation = Quaternion.identity;
        Instantiate(BG_object2, spawnPosition, spawnRotation);
        //세번째
        yield return new WaitForSeconds(waveWait3);//다음 주자 기다려
       spawnPosition = new Vector3(spawnValues3.x, spawnValues3.y, spawnValues3.z);
        spawnRotation = Quaternion.identity;
        Instantiate(BG_object3, spawnPosition, spawnRotation);
       
        //4번째(single rock)
        yield return new WaitForSeconds(waveWait4);//다음 주자 기다려
        spawnPosition = new Vector3(spawnValues4.x, spawnValues4.y, spawnValues4.z);
        Instantiate(BG_object4, spawnPosition, spawnRotation);
       //5번째(화산)
        yield return new WaitForSeconds(waveWait5);
        spawnPosition = new Vector3(spawnValues5.x, spawnValues5.y, spawnValues5.z);
        spawnRotation = Quaternion.identity;
        Instantiate(BG_object5, spawnPosition, spawnRotation);
       
    
      //5-2
      yield return new WaitForSeconds(waveWait6);
      spawnPosition = new Vector3(spawnValues6.x, spawnValues6.y, spawnValues6.z);
      Instantiate(BG_object6, spawnPosition, spawnRotation);

        //7번째
        yield return new WaitForSeconds(waveWait7);
       spawnPosition = new Vector3(spawnValues7.x, spawnValues7.y, spawnValues7.z);
        Instantiate(BG_object7, spawnPosition, spawnRotation);

		//8번째(오징어와 돌)
        yield return new WaitForSeconds(waveWait8);
       spawnPosition = new Vector3(spawnValues8.x, spawnValues8.y, spawnValues8.z);
        Instantiate(BG_object8, spawnPosition, spawnRotation);

		//9번째(화산)
        yield return new WaitForSeconds(waveWait9);
        spawnPosition = new Vector3(spawnValues9.x, spawnValues9.y, spawnValues9.z);
        Instantiate(BG_object9, spawnPosition, spawnRotation);

		//10번째(불가사리)
		yield return new WaitForSeconds(waveWait10);
		spawnPosition = new Vector3(spawnValues10.x, spawnValues10.y, spawnValues10.z);
		Instantiate(BG_object10, spawnPosition, spawnRotation);

		//11번째(왕새우)
		yield return new WaitForSeconds(waveWait11);
		spawnPosition = new Vector3(spawnValues11.x, spawnValues11.y, spawnValues11.z);
		Instantiate(BG_object11, spawnPosition, spawnRotation);

    }
}
