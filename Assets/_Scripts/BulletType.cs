/*******************
File name: BulletType.cs
Author: Shun min Hsieh
Student Number: 101212629
Date last Modified: 2020/10/22
Program description: An enumeration includes different bullet types.
Revision History:
2020/10/22
 - Added internal documentation

Enumeration: 
    BulletType
*******************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum BulletType
{
    REGULAR,
    FAT,
    PULSING,
    RANDOM
}
