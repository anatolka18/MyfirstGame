using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_fire : MonoBehaviour
{
    private float timeShots;
    public float startTimeShots = 2;
    public GameObject enemyfire;
    public Transform EfirePoint;// точка и сама пуля
    void Update()
    {
        if (timeShots <= 0)
        {
            if (true)
            {
                shoot();
                timeShots = startTimeShots;
            }
        }
        else
        {
            timeShots -= Time.deltaTime;
        }

    }

    void shoot()
    {
        Instantiate(enemyfire, EfirePoint.position, EfirePoint.rotation);
    }
}
