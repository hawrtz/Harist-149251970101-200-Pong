using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CP : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;

    private Rigidbody2D rig;
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    
    private void Update()
    {
        //Gerakan Objek 
        MoveObject(GetInput());
    }

    private Vector2 GetInput()
    {
        Vector2 movement = Vector2.zero;

        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        Debug.Log("TEST" + movement);
        rig.velocity = movement;
    }



}
