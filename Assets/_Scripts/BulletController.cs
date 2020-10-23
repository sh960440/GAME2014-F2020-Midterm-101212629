/*******************
File name: BulletController.cs
Author: Shun min Hsieh
Student Number: 101212629
Date last Modified: 2020/10/22
Program description: A public class handles the bullet movement and collision.
Revision History:
2020/10/22
 - Added internal documentation
 - Modified _Move function.
 - Modified _CheckBounds function.

 Class: 
    BulletController
 Functions:
    Start
    Update
    _Move
    _Checkbounds
    OnTriggerEnter2D
    ApplyDamage
*******************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour, IApplyDamage
{
    public float verticalSpeed;
    public float verticalBoundary;
    public BulletManager bulletManager;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(verticalSpeed, 0.0f, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        if (transform.position.x > verticalBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.gameObject.name);
        bulletManager.ReturnBullet(gameObject);
    }

    public int ApplyDamage()
    {
        return damage;
    }
}
