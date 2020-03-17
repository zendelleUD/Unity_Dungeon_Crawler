using UnityEngine;

public class Player : MonoBehaviour
{

    public float Movspeed = 2f;
    public Rigidbody2D rigidbody2D;
    Vector2 movement;    
    // Update is called once per frame


    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate(){
        rigidbody2D.MovePosition(rigidbody2D.position + movement * Movspeed * Time.fixedDeltaTime);
    }
}
