using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour {

	private bool tap,swipeLeft,swipeRight,swipeUp,swipeDown;
	private Vector2 startTouch,swipeDelta;
	private bool isDraging = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	private void Update () {

		tap = swipeLeft = swipeRight = swipeDown = swipeUp = false;

		//Mouse Controls
		if(Input.GetMouseButtonDown(0))
		{
			isDraging = true;
			
			startTouch = Input.mousePosition;
		}
		else if(Input.GetMouseButtonUp(0))
		{	tap = true;
			isDraging = false;
			Reset();
		}

		//Mobile Controls
		if(Input.touches.Length > 0)
		{
			if(Input.touches[0].phase == TouchPhase.Began)
			{
				isDraging=true;
				
				startTouch = Input.touches[0].position;
			}else if(Input.touches[0].phase==TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled )
			{
				tap = true ;
				isDraging = false;
				Reset();
				
			}
		}

		//Calculate the distance
		swipeDelta = Vector2.zero;
		if(isDraging)
		{
			if(Input.touches.Length > 0)
			{
				swipeDelta = Input.touches[0].position - startTouch;
			}else if(Input.GetMouseButton(0))
			{
				swipeDelta = (Vector2)Input.mousePosition - startTouch;
			}
		}

		//Did we cross the deadzone?
		if(swipeDelta.magnitude > 125)
		{
			float x = swipeDelta.x;
			float y = swipeDelta.y;
			if(Mathf.Abs(x)>Mathf.Abs(y))
			{
				if(x<0)
				swipeLeft = true;
				else
				swipeRight = true;
			}
			else
			{
				if(y<0)
				swipeDown = true;
				else
				{
				swipeUp = true;
				//tap = true;
				}
				
			}
		}
	}

	private void Reset()
	{
		startTouch = swipeDelta = Vector2.zero;
		isDraging = false;
	}

	public bool Tap { get { return tap;}}
	public Vector2 SwipeDelta { get { return swipeDelta;}}
	public bool SwipeUp { get { return swipeUp;}}
	public bool SwipeDown { get { return swipeDown;}}
	public bool SwipeRight { get { return swipeRight;}}
	public bool SwipeLeft { get { return swipeLeft;}}
}
