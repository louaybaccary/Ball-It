using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObstacles : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float forwardForce = 2000f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddForce(forwardForce * Time.deltaTime, 0, 0);

    }
}
