using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public int speed = 2;

    void Update()
    {
        // ���� ��ġ(transform.position)�� �ð�(Time.deltaTime)�� ���� ����(transform.forward)��
        // ���� ���� speed��� �÷� ����
        // �� ��ũ��Ʈ�� ����� ���� ������Ʈ�� �����Ӹ��� ������ �ӵ��� ������Ű�� ����
        transform.position += Time.deltaTime * transform.forward * speed;
        //transform.position += Time.deltaTime * transform.forward * 2;
    }
}
