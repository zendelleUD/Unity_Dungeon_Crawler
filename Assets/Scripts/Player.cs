using UnityEngine;

public class Player : MonoBehaviour
{


    public float Movspeed = 2f;
    public Animator animator;
    public Rigidbody2D rb;
    Vector2 movement;
    public float Horizontal_Direction;
    public float Vertical_Direciton;
        
    // Update is called once per frame
    void Update()
    {
        Horizontal_Direction =Input.GetAxisRaw("Horizontal");
        Vertical_Direciton = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal",Horizontal_Direction);
        animator.SetFloat("Vertical", Vertical_Direciton);
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate(){
        rb.MovePosition(rb.position + movement * Movspeed * Time.fixedDeltaTime);
    }
}
