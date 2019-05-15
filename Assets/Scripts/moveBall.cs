using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBall : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float forwardForce = 2000f;
    public float sideForce = 600f;
    public GameObject gm;
    public Swipe swipeControls;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody.AddForce(-forwardForce * Time.deltaTime, 0, 0);
      /*  if ( swipeControls.SwipeUp)
        {
            rigidbody.AddForce(0, sideForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }

         if (swipeControls.SwipeDown)
        {
            rigidbody.AddForce(0, -sideForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }*/
        if ( swipeControls.SwipeRight)
        {
            rigidbody.AddForce(0, -1, sideForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if ( swipeControls.SwipeLeft)
        {
            rigidbody.AddForce(0, -1, -sideForce * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
}
