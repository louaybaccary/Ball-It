using UnityEngine;
using UnityEngine.UI;


public class DiceScript : MonoBehaviour
{
   public Text Score;

   void RollDice(){
       int number = Random.Range(1, 7);
       Score.text = number.ToString();
   }
}
