using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_enemy : MonoBehaviour
{
    public float speed = 1.5f;// �������� �������� ���������� �������

    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);// ����������� �����(right ��-�� ��������� ��������)

        if(transform.position.y < -6)
        {
            Destroy(gameObject);// ��� ������ �� ������� ������ ������ ���������
        }
    }
}
