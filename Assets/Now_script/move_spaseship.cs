using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_spaseship : MonoBehaviour
{

    public float speed = 2f;


    void Update()
    {

        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");// управление кораблём
        Vector3 dir = new Vector3(hor, ver, 0);
        transform.Translate(dir.normalized * Time.deltaTime * speed);

    }


    private void OnCollisionStay(Collision collision)
    { // столкновение кораблей
        if (collision.gameObject.CompareTag("warship"))
        {
            Destroy(gameObject);
        }
    }
}
