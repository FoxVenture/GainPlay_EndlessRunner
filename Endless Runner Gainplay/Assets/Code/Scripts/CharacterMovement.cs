using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public int rows = 3;
    //public int[] rows = new int[] { -1, 0, 1 };     // x position of each row
    private int targetRow = 2;
    private int currentRow = 2;
    Rigidbody m_Rigidbody;
    float m_Speed;


    private void Awake()
    {
        transform.position = new Vector3(currentRow, 0, 0);
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Speed = 10.0f;
    }


    void Update()
    {
        m_Rigidbody.velocity = transform.forward * m_Speed;

        if (Input.GetKeyDown(KeyCode.LeftArrow) && targetRow > 0)
        {
            targetRow--;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && targetRow < rows - 1)
        {
            targetRow++;
        }

        if (currentRow != targetRow)
        {

            transform.position = new Vector3(targetRow*2, 0, transform.position.z);
            currentRow = targetRow;
        }
    }

}
