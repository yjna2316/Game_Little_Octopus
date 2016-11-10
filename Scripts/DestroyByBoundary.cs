using UnityEngine;
using System.Collections;

/* if player collide to other game objects, the game objects removed */
public class DestroyByBoundary : MonoBehaviour {

    void OnTriggerExit2D(Collider2D other)  
    {
        
        Destroy(other.gameObject);  
    }


}
