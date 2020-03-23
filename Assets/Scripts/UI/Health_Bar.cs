using UnityEngine;
using UnityEngine.UI;

public class Health_Bar : MonoBehaviour
{
    
   public Slider current_health;

    public void SetMaxHealth(int health){
       current_health.maxValue = health;
       current_health.value = health;
   }

   public void SetHealth(int health){
       current_health.value = health;
   }

   
   
}
