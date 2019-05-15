using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;
public class playerCollision : MonoBehaviour
{
    public moveBall mouvement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "wall")
        {
            CameraShaker.Instance.ShakeOnce(4f, 4f, .1f, 1f);
            mouvement.enabled = false;
            
            FindObjectOfType<GameManager>().EndGame();
        }
        if (collisionInfo.collider.tag == "Bonus")
        {
            Debug.Log("Bonus");
            FindObjectOfType<GameManager>().AddScore();
        }


    }
    void Update()
    {
        if (mouvement.rigidbody.position.y < 0.5)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
