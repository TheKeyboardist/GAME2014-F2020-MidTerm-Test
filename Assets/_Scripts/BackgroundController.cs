/***********************************************************************;
* Project           : Mobile Game Development Fall 2020 Midterm Project
*
* Program name      : "Background.cs"
*
* Author            : Ivan Kravchenko
* 
* Student Number    : 101183016
*
* Date created      : 20/10/20
*
* Description       : It controls side scrolling background
*
* Last modified     : 20/10/20
*
* Revision History  : changed portrait orientatation to horizonatal that looks like portarit
*
*Date        Author Ref    Revision (Date in YYYYMMDD format) 
*20/10/20    Ivan Kravchenko        Edited Script 
*
|**********************************************************************/



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
        transform.position = new Vector3(-verticalBoundary, 0.0f);
    }

    private void _Move()
    {
        transform.position -= new Vector3(verticalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x <= verticalBoundary)
        {
            _Reset();
        }
    }
}
