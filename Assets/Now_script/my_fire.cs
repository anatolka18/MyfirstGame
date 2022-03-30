using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class my_fire : MonoBehaviour
{
    public GameObject myfire;
    public Transform firePoint;// точка и сама пуля

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            shoot();
        }

    }

    void shoot()
    {
        Instantiate(myfire, firePoint.position, firePoint.rotation);
    }
}
