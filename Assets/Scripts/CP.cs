using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CP : MonoBehaviour
{
    private int TimesSpeed = 2;
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    private float scale = 4;
    private float timesUp;

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

    
    public void ActivateSPP()
    {
        speed = TimesSpeed * speed;
        StartCoroutine(SpeedAwal());
    }

    public void ActivateEPP()
    {
        this.gameObject.transform.localScale += new Vector3(0, scale, 0);
        StartCoroutine(SkalaAwal());
    }

    IEnumerator SpeedAwal()
    {
        yield return new WaitForSeconds(timesUp);
        Debug.Log("Cooldown");
        speed = speed / TimesSpeed;
    }

    IEnumerator SkalaAwal()
    {
        yield return new WaitForSeconds(timesUp);
        this.gameObject.transform.localScale -= new Vector3(0, scale, 0);
    }

}
