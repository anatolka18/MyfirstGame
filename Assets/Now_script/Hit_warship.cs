using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_warship : MonoBehaviour
{
    public Transform warship;
    public int health = 1;
    public GameObject effect;
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}

