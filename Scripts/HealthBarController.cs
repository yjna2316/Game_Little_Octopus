using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Runtime.InteropServices;

public class HealthBarController : MonoBehaviour
{
    public float theScore;
    public Text countText;
    public static int score;
    bool itemed;
    bool hitted;


    public AudioClip P_Attacked;//atacked bgm
    public AudioClip Itemed;

    float timer;
    public Scrollbar HealthBar;
    public static float Health = 100;

    public float TimeD;
    public float spriteWait;// 깜박간격 
    public float spriteCount;//깜박횟수
    public bool unlock=true; //깜박 거릴때 hp 안 깎이게 하기 위해 잠금용

    
    // public Player_total playertotal;

    private GameObject go1,go2,go3,go4,go5,go6;//배경 오브젝트 레퍼런스
    public int i = 1;
    IEnumerator delayTime()
    {
        Debug.Log("Time=" + Time.time);
        yield return new WaitForSeconds(3);
        
    }
    // 문어 깜박거리기
   
    IEnumerator setDelay()
    {
        go1 = GameObject.FindWithTag("oct1");
        go2 = GameObject.FindWithTag("oct2");
        go3 = GameObject.FindWithTag("oct3");
        go4 = GameObject.FindWithTag("oct4");
        go5 = GameObject.FindWithTag("oct5");
        go6 = GameObject.FindWithTag("oct6");
        unlock = false; // 충돌해도 hp 안 깎이게 잠금
        for (int i = 0; i < spriteCount; i++)
        {
            /* this.gameObject.GetComponent<SpriteRenderer>().enabled = false;//깜
             yield return new WaitForSeconds(spriteWait);
             this.gameObject.GetComponent<SpriteRenderer>().enabled = true;//박
             yield return new WaitForSeconds(spriteWait);
             */
            go1.GetComponent<SpriteRenderer>().enabled = false;//깜
            go2.GetComponent<SpriteRenderer>().enabled = false;//깜
            go3.GetComponent<SpriteRenderer>().enabled = false;//깜
            go4.GetComponent<SpriteRenderer>().enabled = false;//깜
            go5.GetComponent<SpriteRenderer>().enabled = false;//깜
            go6.GetComponent<SpriteRenderer>().enabled = false;//깜
            yield return new WaitForSeconds(spriteWait);
            go1.GetComponent<SpriteRenderer>().enabled = true;//박
            go2.GetComponent<SpriteRenderer>().enabled = true;//박
            go3.GetComponent<SpriteRenderer>().enabled = true;//박
            go4.GetComponent<SpriteRenderer>().enabled = true;//박
            go5.GetComponent<SpriteRenderer>().enabled = true;//박
            go6.GetComponent<SpriteRenderer>().enabled = true;//박
            yield return new WaitForSeconds(spriteWait);
        }
        unlock = true;//잠금 해제
    }
  
    // 배경오브젝트_ 없앴다 보이기
   /* IEnumerator setDelay_BGObj()
    {
        go.GetComponent<SpriteRenderer>().enabled = false;//깜
        yield return new WaitForSeconds(1f);
        go.GetComponent<SpriteRenderer>().enabled = true;//박

    }*/

    void Start()
    {
        theScore = 0;
        score = 0;
        itemed = false;
        hitted = false;

        Health = 100;
        timer = 0;
        TimeD = 3f;

    }

    void Update()
    {
         timer += Time.deltaTime;
         theScroeF();
         Health -= TimeD * Time.deltaTime;
         HealthBar.size = Health / 100f;
       
    }



    void theScroeF()
    {
        theScore += Time.deltaTime * 100;
        if (hitted)
        {
            theScore-= 200;
            hitted = false;
        }
        if (itemed)
        {
            theScore+= 200;
            itemed = false;
        }
        score = (int)theScore;
        countText.text = ("Score: "+score);

    }

    //오브젝트 충돌시 hp 10 감소(문어가 Trigger)  또는 hp 증가
    void OnTriggerEnter2D(Collider2D other)
    {

        //왕새우 _ 다음 단계로 이동, hp 20증가
        if (other.CompareTag("Finish"))
        {
            if (Health > 0)
            {
                Health += 20f;
                HealthBar.size = Health / 100f;
                other.gameObject.GetComponent<SpriteRenderer>().enabled = false;//먹은 새우는 사라져
            }
        }

        //적 오브젝트  hp  감소
		if (other.CompareTag("Enemy") || other.CompareTag("Env")|| other.CompareTag("volcano")|| other.CompareTag("wall"))                                
        {

            if (Health > 0 && unlock)
            {
                
                Damage(10);
                StartCoroutine(setDelay());//깜박거리기       
            }
        }
        //hp아이템(새우)  hp  증가
        if (other.CompareTag("item") && Health > 0)
        {
            itemed=true;
            AudioSource.PlayClipAtPoint(Itemed, transform.position);
            
            // other.gameObject.GetComponent<SpriteRenderer>().enabled = false;//먹은 새우는 사라져
            if (Health < 98)
                Recovery();
            Destroy(other.gameObject);//먹은 새우는 사라짐




        }

        
        //무적상태가 아닐때//////////////////////////////////////////////////////////
        
        //배경 오브젝트

       if (other.CompareTag("s1") || other.CompareTag("s2") || other.CompareTag("s3")) {
            if (Health > 0 && unlock)//hp>0 이고 unlock이면
            {
               
                Damage(10);//hp 깎기
                StartCoroutine(setDelay());//깜박 호출        
            }
        }

       

    }


    public void Recovery()//hp 3 증가 함수
    {
          
        Health += 5f;
        HealthBar.size = Health / 100f; 
    }
    
    public void Damage(float value)
    {
        hitted = true;
        AudioSource.PlayClipAtPoint(P_Attacked, transform.position);
        Health -= value;
        HealthBar.size = Health / 100f;
    }

}
