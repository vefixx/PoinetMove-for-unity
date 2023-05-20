using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovePointer : MonoBehaviour
{

    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Debug.Log("Start");
    }

    private bool isDragging = false;
    // Update is called once per frame
    private void OnMouseDown()
    {
        isDragging = true;
        Debug.Log(isDragging);
    }

    private void OnMouseUp()
    {
        isDragging = false;
        Debug.Log(isDragging);
    }

    private void Update()
    {
        Vector2 Cursor = Input.mousePosition; //�������� ������� �������
        Cursor = Camera.main.ScreenToWorldPoint(Cursor); // ����������� ���������� ������������ ������

        if (isDragging)
        {
            transform.position = Cursor;
        }

        if (isDragging == false)
        {
            rb.velocity = rb.velocity * 0.99f;
        }
    }
}
