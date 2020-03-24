using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base_Controller : MonoBehaviour
{

    

    [Header("Object References")]
    public Base_Model model;
    public Base_View view;
    public Animator animator;


    Vector2 userInput;

    Vector2 newPlayer_Position;


    void Start(){
        view.UpdateMaxHealth(model.maxHealth);

    }


    public void UpdatePlayer(){
        GetUserInput();
        UpdateAnimator();
        UpdatePlayerPosition(view.rb);
        FlipPlayer();

    }

    private void UpdateAnimator(){
        animator.SetFloat("Horizontal", userInput.x);
        animator.SetFloat("Vertical",userInput.y);
        if(Input.GetMouseButtonDown(0)){animator.SetTrigger("Attack_1");}

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
    private void UpdatePlayerPosition(Rigidbody2D PLayerRigidBody){
        Vector2 oldPosition = PLayerRigidBody.position;
        newPlayer_Position = (oldPosition + userInput * (GetMoveSpeed()) * Time.fixedDeltaTime);
        view.RbPosition = newPlayer_Position;
        
    }

    /*
    Description:
        values UserInput with Input.GetAxisRaw()
    
    Vector2 userInput
    Input.GetAxisRaw(string param) returns Vector2 
    */
    private void GetUserInput(){
        userInput.x = Input.GetAxisRaw("Horizontal");
        userInput.y = Input.GetAxisRaw("Vertical");
    }

    /*
    Returns Player movement speed
    */
    private int GetMoveSpeed(){
        return model.GetMoveSpeed();
    }
    

}
