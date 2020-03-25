using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable: MonoBehaviour
{

    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;

    
    void Update(){
        if(isInRange){ //Checks if the Player is withing the Object Collider with onTriggerEnter2d()
            if(Input.GetKeyDown(interactKey)){ //Checks if Key input is set to right key.
                 interactAction.Invoke(); //Fire Events
            }
        }
    }

    /* Is called whenever a collision is detected entering the object the script is attached to. */
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Player")){
            isInRange = true;
            Debug.Log("Player Entered");
        }
        
    }

    /* Is called whenever a collision is detected exeting the object the script is attached to. */
    private void OnTriggerExit2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Player")){
            isInRange = false;
            Debug.Log("Player Left");
        }
    }

}
