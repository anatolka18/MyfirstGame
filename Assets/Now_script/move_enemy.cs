using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_enemy : MonoBehaviour
{
    public float speed = 1.5f;// скорость движения вражеского корабля

    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);// перемещение вперёд(right из-за разворота картинки)

        if(transform.position.y < -6)
        {
            Destroy(gameObject);// при выходе за границы камеры объект удаляется
        }
    }
}
