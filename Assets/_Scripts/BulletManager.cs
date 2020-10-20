/***********************************************************************;
* Project           : Mobile Game Development Fall 2020 Midterm Project
*
* Program name      : "BulletManager.cs"
*
* Author            : Ivan Kravchenko
* 
* Student Number    : 101183016
*
* Date created      : 20/10/20
*
* Description       : It mamanges bullet count, creating and deleting
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

[System.Serializable]
public class BulletManager : MonoBehaviour
{
    public BulletFactory bulletFactory;
    public int MaxBullets;

    private Queue<GameObject> m_bulletPool;


    // Start is called before the first frame update
    void Start()
    {
        _BuildBulletPool();
    }

    private void _BuildBulletPool()
    {
        // create empty Queue structure
        m_bulletPool = new Queue<GameObject>();

        for (int count = 0; count < MaxBullets; count++)
        {
            var tempBullet = bulletFactory.createBullet();
            m_bulletPool.Enqueue(tempBullet);
        }
    }

    public GameObject GetBullet(Vector3 position)
    {
        var newBullet = m_bulletPool.Dequeue();
        newBullet.SetActive(true);
        newBullet.transform.position = position;
        return newBullet;
    }

    public bool HasBullets()
    {
        return m_bulletPool.Count > 0;
    }

    public void ReturnBullet(GameObject returnedBullet)
    {
        returnedBullet.SetActive(false);
        m_bulletPool.Enqueue(returnedBullet);
    }
}
