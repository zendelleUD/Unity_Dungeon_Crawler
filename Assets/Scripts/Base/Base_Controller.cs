using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base_Controller : MonoBehaviour
{

    

    [Header("Object References")]
    public Base_Model model;
    public Base_View view;

    Vector2 userInput;

    Vector2 newPlayer_Position;


    void Start(){
        view.UpdateMaxHealth(model.maxHealth);

    }


    /*
    Description:
        Calls GetUserInput() and checks whether to flip Player RigidBody right or left

    */
    void FlipPlayer(){
       // GetUserInput();

        if(userInput.x > 0.1){
                view.RotateRight();
        }else if (userInput.x < -.01){
                view.RotateLeft();
        }  
    }


    /*
    Description:
        Takes in a Vector2 parameter and returns a Vector2

    Parameters:
        Vector2 current_Position
    
    Return:
        Vector2 newPlayer_Position
    */
    public void UpdatePlayerPosition(Vector2 current_Position){
        Vector2 oldPosition = current_Position;
        GetUserInput();
        newPlayer_Position = (current_Position + userInput * (GetMoveSpeed()) * Time.fixedDeltaTime);
        view.rb.position = newPlayer_Position;
        FlipPlayer();
        
    }

    /*
    Description:
        values UserInput with Input.GetAxisRaw()
    
    Vector2 userInput
    Input.GetAxisRaw(string param) returns Vector2 
    */
    void GetUserInput(){
        userInput.x = Input.GetAxisRaw("Horizontal");
        userInput.y = Input.GetAxisRaw("Vertical");
    }

    /*
    Returns Player movement speed
    */
    public int GetMoveSpeed(){
        return model.GetMoveSpeed();
    }


    void FixedUpdate(){
        
    }
    

}
