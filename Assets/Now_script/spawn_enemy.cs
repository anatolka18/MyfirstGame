using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_enemy : MonoBehaviour
{
    public GameObject warship;
    private float[] positions = { -4.5f, -3.5f, -2.5f, -1.5f, -0.5f, 0.5f, 1.5f, 2.5f, 3.5f, 4.5f, -2f, -1f, 0f, 1f, 2f };
    private int k = 0;
    void Start()
    {
        StartCoroutine(spawn());
    }
    IEnumerator spawn()// создаём куратину
    {
        while (k!=30)
        {
            Instantiate(warship, new Vector3(positions [Random.Range(0, positions.Length)], 6.57f, -2f),Quaternion.Euler(new Vector3(0, 0, -90f)));// создание кораблей
            yield return new WaitForSeconds(2f);
            k++;
        }

    }
}
