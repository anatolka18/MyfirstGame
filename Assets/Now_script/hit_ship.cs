using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit_ship : MonoBehaviour
{
    public Transform ship;
    public int health = 1;
    public GameObject effect;
    public void TakeDamage1(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
