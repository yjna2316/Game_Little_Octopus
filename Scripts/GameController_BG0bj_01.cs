using UnityEngine;
using System.Collections;

/* occurence of game objects on designated position */

public class GameController_BG0bj_01 : MonoBehaviour {

    //public GameObject BG_object1, BG_object2;
    public GameObject BG_object1,BG_object2, BG_object3;//배경 오브젝트들
    public Vector3 spawnValues1, spawnValues2, spawnValues3;//출현 위치
    public int hazardCount;//한 블럭당 출현 횟수
    public float startWait;// 게임시작후 대기 시간
    public float spawnWait2, spawnWait3 ;// 출현간 대기 시간
   
    //public float waveWait;
    //public int a = 0;
    void Start()
    {
       
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);//잠깐 기다렸다가
       
         
            for (int i = 0; i < hazardCount; i++) //hazardCount 개수만큼 출현
            {
                Vector3 spawnPosition = new Vector3(spawnValues1.x, spawnValues1.y, spawnValues1.z); //내가 지정한 위치에서
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(BG_object1, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait2); // 잠깐 기다려

                spawnPosition = new Vector3(spawnValues2.x, spawnValues2.y, spawnValues2.z); 
                spawnRotation = Quaternion.identity;
                Instantiate(BG_object2, spawnPosition, spawnRotation);

            yield return new WaitForSeconds(spawnWait3); 

            spawnPosition = new Vector3(spawnValues3.x, spawnValues3.y, spawnValues3.z); 
            spawnRotation = Quaternion.identity;
            Instantiate(BG_object3, spawnPosition, spawnRotation);

        }
       
            
            
        }
    }

