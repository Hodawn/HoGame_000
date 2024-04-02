using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup : MonoBehaviour
{

    public float speed = 5f; // 컵의 이동 속도
    public float moveRange = 10f; // 컵의 좌우 이동 범위

    void Update()
    {
        // 좌우 화살표 입력을 받아 컵을 이동시킵니다.
        float horizontalInput = Input.GetAxis("Horizontal");
        Debug.Log("Horizontal Input: " + horizontalInput);

        Vector3 moveDirection = new Vector3(horizontalInput, 0f, 0f); // X 축으로 이동하도록 수정

        // 컵의 현재 위치와 이동 속도를 곱하여 새로운 위치 계산
        Vector3 newPosition = transform.position + moveDirection * speed * Time.deltaTime;

        // 이동 가능한 범위를 제한하여 컵을 좌우로 이동합니다.
        newPosition.x = Mathf.Clamp(newPosition.x, -moveRange, moveRange); // X 축으로 제한

        // 계산된 새로운 위치로 컵을 이동시킵니다.
        transform.position = newPosition;

        Debug.Log("Cup Position: " + transform.position);
    }
}
