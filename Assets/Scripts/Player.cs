using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;
    public float Movspeed = 2f;
    public Animator animator;
    public Rigidbody2D rb;
    Vector2 movement;
    public Health_Bar healthBar;
    //Meantsfor debugging in Unity Ide
    public float Horizontal_Direction;
    public float Vertical_Direciton;



    void Start(){
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth); 
    }


    /*
    UpdateAnimator
        x_axis  float valued between -1 & 1
        y_axis  float valued between -1 & 1
    
    Description:
        Takes in Input.GetAxisRaw() for x and y directions and updates
        object Animator's Horiztonal and Vertical Attributes for blend tree
    */
     void updateAnimator(float x_axis,float y_axis){
        Horizontal_Direction = x_axis;
        Vertical_Direciton = y_axis;
        
        if(x_axis <= -.01){
            //transform.localRotation = Quaternion.Euler(x_direction, y_direction, z_direction);
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }else if(x_axis >= .01){
            //transform.localRotation = Quaternion.Euler(x_direction, y_direction, z_direction);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        animator.SetFloat("Horizontal",Horizontal_Direction);
        animator.SetFloat("Vertical", Vertical_Direciton);
     }   

    /*
    Handles Player Movements
    */
     void Move_Player(){
        rb.MovePosition(rb.position + movement * Movspeed * Time.fixedDeltaTime);
     }

     void Attack(){
        animator.SetTrigger("Attack_1");
     }

     void TakeDamage(int damage){
        currentHealth -= damage ;
        healthBar.SetHealth(currentHealth);
     }

    // Update is called once per frame
    // Variable rate of frames, not good for physics
    void Update()
    {
        updateAnimator(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
        
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetMouseButtonDown(0)) { Attack(); };

        if(Input.GetButtonDown("Jump")){  TakeDamage(20); };
        
    }

    //Called 50 times a second, Best for physics
    void FixedUpdate(){
       Move_Player();
       //Attack();
    }
}
