using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base_View : MonoBehaviour
{

    [Header("Controller")]
    public Base_Controller controller;

    [Header("References")]
    public Health_Bar healthBar;
    public Rigidbody2D rb;
    public Vector2 current_Position;


    void Start(){
       // current_Position = rb.position;
    }


    public void UpdateMaxHealth(int input){
        healthBar.SetMaxHealth(input);        
    }

    void UpdateHealthBar(){

    }
    
    
    /*
    Description:
        Moves player's rigidbody position

        Auxillary Function:
            controller.UpdatePlayerPosition(Vector2 postion)
    */
    void Move_Player(){
        
        rb.MovePosition(RbPosition);
    }

    public void RotateRight(){
        transform.localRotation = Quaternion.Euler(0, 0, 0);
    }

    public void RotateLeft(){
        transform.localRotation = Quaternion.Euler(0, 180, 0);
    }

    // Update is called once per frame
    void Update(){ 
        controller.UpdatePlayer();
    }

    //Called 50 times a second
    void FixedUpdate(){
        Move_Player();
    }



    public Vector2 RbPosition{
        get {return rb.position;} set{rb.position = value;}
    }



}
