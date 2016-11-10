using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    private static SceneManager s_instance = null;

    public void StageChoose()
    {
//        GameObject.Find("Canvas1").SetActive(true);    <-굳이 넣지 않아도 괜찮습니다.
        Application.LoadLevel("Choose");  
 //       GameObject.Find("Canvas1").SetActive(false);   <- 굳이 넣지 않아도 이미 application.load 하면 파괴됩니다.
    }

    public void Stage1()//시작
    {
        //restartCurrentScene();
//        GameObject.Find("Canvas2").SetActive(true);     <- 굳이 넣지 않아도 괜찮습니다.
        Application.LoadLevel("play1_1");
//        GameObject.Find("Canvas2").SetActive(false);    < -굳이 넣지 않아도 이미 application.load 하면 파괴됩니다.
    }

    public void Update()
    {
        // hp = gameObject.GetComponent<HealthBarController>();
        if (HealthBarController.Health <= 0f)
        {
            //           GameObject.Find("Canvas").SetActive(true);
            //           GameObject.Find("OctPlayer").SetActive(true);
            //그리고 이거 application.load~ 와 gameobject.setActive(false) 순서 바꿔줘야 합니다.
            //순서대로 실행해주기 때문에 canvas 와 octPlayer 의 setActive 를 false 로 만들어 준 후,
            //loadLevel 하셔야 순서가 맞습니다.
            GameObject.Find("Canvas").SetActive(false);
            GameObject.Find("OctPlayer").SetActive(false);
            Application.LoadLevel("Dead");
          
        }
       
    }

   
    public void Back()
    {
        GameObject.Find("Canvas").SetActive(true);
        GameObject.Find("OctPlayer").SetActive(true);
        Application.LoadLevel("_Start");
        GameObject.Find("Canvas").SetActive(false);
        GameObject.Find("OctPlayer").SetActive(false);
    }

    public void Back2()
    {
        GameObject.Find("Canvas3").SetActive(true);
        Application.LoadLevel("_Start");
        GameObject.Find("Canvas3").SetActive(false);
        //OnLevelWadLoaded(6); // 데드씬 파괴
    }


    /*
     void Awake()
    {
       
            if (Application.loadedLevelName == "play1_1" || Application.loadedLevelName == "play1_2" || Application.loadedLevelName == "play1_3" || Application.loadedLevelName == "play1_4")
            {
                Debug.Log(Application.loadedLevelName);
                DontDestroyOnLoad(transform.gameObject);
            }
     }

    */
    /*
     public void restartCurrentScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    void OnLevelWadLoaded(int level)
    {
            if(level == 6)
        {
            Destroy(gameObject);
        }
    }*/
}