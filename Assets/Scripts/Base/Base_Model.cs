using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base_Model : MonoBehaviour
{

    [Header("Controller")]
    public Base_Controller controller;

    [Header("Health")]
    public int maxHealth;
    public int currentHealth;

    [Header("Movement")]
    public int mvmt_speed;
    
   void Start(){
       currentHealth = maxHealth;
   }


    public int GetMoveSpeed(){
        return mvmt_speed;
    }


}
