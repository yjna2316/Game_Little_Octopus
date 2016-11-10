using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
	public string scenename;

    void OnTriggerEnter2D(Collider2D other)//if player eats the big shrimp
    {
        if (other.CompareTag("Player"))
        {
            //move to next scene "change the stage"
    		SceneManager.LoadScene(scenename);
            
       
        }
    }
   
}


