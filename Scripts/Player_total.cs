using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax;
}


public class Player_total : MonoBehaviour
{
  

    public float speed = 10;
    Transform myTrans;
    Rigidbody2D myBody;
    float hInput = 0;

    public Boundary boundary;
    public InkBarController inkbarcontroller;
    public HealthBarController healthbarcontroller;

    //public Animator anim2; // ani
    
    void Start()
    {
        myBody = this.GetComponent<Rigidbody2D>();
        myTrans = this.transform;
        //anim2 = GetComponent<Animator>(); // ani
    }

    void FixedUpdate()
    {
#if !UNITY_ANDROID && !UNITY_IPHONE && !UNITY_BlACKBERRY && !UNITY_WIRT
#endif
        Move(hInput);
    }

    public void Move(float horizonalInput)
    {
        Vector2 moveVel = myBody.velocity;
        moveVel.x = horizonalInput * speed;
        myBody.velocity = moveVel;
        myBody.position = new Vector2
            (
                Mathf.Clamp(myBody.position.x, (float)boundary.xMin, (float)boundary.xMax),
                0.0f
             );
    }

    public void StartMoving(float horizonalInput)
    {
        hInput = horizonalInput;
    }

    public void Update()
    {
        int count = Input.touchCount;
        if (count == 0)
        {
            //anim2.SetTrigger("Booster_End"); // to play Oct_Idle
            inkbarcontroller.Damage(0f);
            return;
        }
        else if (count == 1)
        {
            healthbarcontroller.unlock = true;
            //anim2.SetTrigger("Booster_End"); // to play Oct_Idle
            inkbarcontroller.Damage(0f);
            return;
        }
        else if (count == 2)
        {
            if (inkbarcontroller.Ink > 0.3f)
            {
                healthbarcontroller.unlock = false;
                inkbarcontroller.Damage(0.5f);
            }
            else
            {
                inkbarcontroller.Damage(0f);
                //anim2.SetTrigger("Booster_End"); // to play Oct_Booster
            }
            return;
        }
        else
        {
            //anim2.SetTrigger("Booster_End"); // to play Oct_Idle
            inkbarcontroller.Damage(0f);
            return;
        }
    }

}
