using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Vector3 offset;
    public Transform player;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
 
}
