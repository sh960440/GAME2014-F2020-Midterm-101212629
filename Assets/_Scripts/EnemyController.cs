/*******************
File name: EnemyController.cs
Author: Shun min Hsieh
Student Number: 101212629
Date last Modified: 2020/10/22
Program description: A public class controls the enemy's movement.
Revision History:
2020/10/22
 - Added internal documentation
 - Modified _Move function.
 - Modified _CheckBounds function.

 Class: 
    EnemyController
 Functions:
    Update
    _Move
    _CheckBounds
*******************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float verticalSpeed;
    public float verticalBoundary;
    public float direction;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(0.0f, verticalSpeed * direction * Time.deltaTime, 0.0f);
    }

    private void _CheckBounds()
    {
        // check right boundary
        if (transform.position.y >= verticalBoundary)
        {
            direction = -1.0f;
        }

        // check left boundary
        if (transform.position.y <= -verticalBoundary)
        {
            direction = 1.0f;
        }
    }
}
