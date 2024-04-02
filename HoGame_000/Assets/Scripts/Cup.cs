using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup : MonoBehaviour
{

    public float speed = 5f; // ���� �̵� �ӵ�
    public float moveRange = 10f; // ���� �¿� �̵� ����

    void Update()
    {
        // �¿� ȭ��ǥ �Է��� �޾� ���� �̵���ŵ�ϴ�.
        float horizontalInput = Input.GetAxis("Horizontal");
        Debug.Log("Horizontal Input: " + horizontalInput);

        Vector3 moveDirection = new Vector3(horizontalInput, 0f, 0f); // X ������ �̵��ϵ��� ����

        // ���� ���� ��ġ�� �̵� �ӵ��� ���Ͽ� ���ο� ��ġ ���
        Vector3 newPosition = transform.position + moveDirection * speed * Time.deltaTime;

        // �̵� ������ ������ �����Ͽ� ���� �¿�� �̵��մϴ�.
        newPosition.x = Mathf.Clamp(newPosition.x, -moveRange, moveRange); // X ������ ����

        // ���� ���ο� ��ġ�� ���� �̵���ŵ�ϴ�.
        transform.position = newPosition;

        Debug.Log("Cup Position: " + transform.position);
    }
}
