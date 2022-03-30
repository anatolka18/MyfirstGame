using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 7f;
    public Rigidbody rb;// физика пули

    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    void Update()
    {

        if (transform.position.y > 6 )
        {
            Destroy(gameObject);// при выходе за границы камеры объект удаляется
        }
    }

    private void OnTriggerEnter(Collider hitInfo)
    {
        Hit_warship hit_warship = hitInfo.GetComponent<Hit_warship>();
        if (hit_warship != null)
        {
            hit_warship.TakeDamage(1);
        }
        Destroy(gameObject);
    }

}
