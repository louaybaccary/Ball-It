using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endTrigger : MonoBehaviour
{
   
  void OnTriggerEnter()
    {
        FindObjectOfType<GameManager>().CompleteLevel();
    }
}
