/***********************************************************************;
* Project           : Mobile Game Development Fall 2020 Midterm Project
*
* Program name      : "BulletType.cs"
*
* Author            : Ivan Kravchenko
* 
* Student Number    : 101183016
*
* Date created      : 20/10/20
*
* Description       : Contains names for all the types of bullets
*
* Last modified     : 20/10/20
*
* Revision History  : unchanged
*
*Date        Author Ref    Revision (Date in YYYYMMDD format) 
*20/10/20    Ivan Kravchenko        Edited Script 
*
|**********************************************************************/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// list of the all bullet names
[System.Serializable]
public enum BulletType
{
    REGULAR,
    FAT,
    PULSING,
    RANDOM
}
