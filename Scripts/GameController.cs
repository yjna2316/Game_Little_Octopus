using UnityEngine;
using System.Collections;
// 배경 오브젝트 동일한 위치에서 반복해서 나타남  
public class GameController : MonoBehaviour {


    public GameObject BG_obj; //배경 오브젝트
    public Vector3 spawnValues; 
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves() 
    {
        yield return new WaitForSeconds(startWait);//잠깐 기다렸다가
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(spawnValues.x, spawnValues.y, spawnValues.z); //내가 지정한 위치에서
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(BG_obj, spawnPosition, spawnRotation);//출현
                yield return new WaitForSeconds(spawnWait); // 잠깐 기다려
            }
            yield return new WaitForSeconds(waveWait);//또 기다려
        }
    }
}
