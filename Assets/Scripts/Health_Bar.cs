using UnityEngine;
using UnityEngine.UI;

public class Health_Bar : MonoBehaviour
{
    
   public Slider slider;

   public void setHealth(int health){
       slider.value = health;
   }

   public void setMaxValue(int health){
       slider.maxValue = health;
       setHealth(health);
   }
   
}
