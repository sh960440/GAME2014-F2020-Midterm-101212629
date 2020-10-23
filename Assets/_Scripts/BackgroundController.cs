/*******************
File name: BackgroundController.cs
Author: Shun min Hsieh
Student Number: 101212629
Date last Modified: 2020/10/22
Program description: A pubilc class for the scrolling background.
Revision History:
2020/10/22
 - Added internal documentation
 - Modified the _CheckBounds function.

 Class: 
    BackgroundController
 Functions:
    Update
    _Reset
    _Move
    _Checkbounds
*******************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float verticalSpeed;
    public float verticalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        transform.position = new Vector3(verticalBoundary, 0.0f);
    }

    private void _Move()
    {
        transform.position -= new Vector3(verticalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x <= -verticalBoundary)
        {
            _Reset();
        }
    }
}
