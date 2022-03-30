using System.Collections;
using System.Collections.Generic;
using UnityEngine; // ф-ии для игры
using UnityEditor;

public class move_space_1 : MonoBehaviour
{
    public float speed = 1.3f;

    public GameObject space;

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y < -8f)
        {
            Instantiate(space, new Vector3(0, 9f, 2f), Quaternion.identity);// внесение фона вперёд
            Destroy(gameObject);//удаление части фона
        }
    }
}

