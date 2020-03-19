
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{

    public Transform player;

    void FixedUpdate(){
        transform.position = new Vector3(player.position.x,player.position.y,transform.position.z); 
    }

}
