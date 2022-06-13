using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector2 speed;

    private Rigidbody2D rig;


    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }
}
