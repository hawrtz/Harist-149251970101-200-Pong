using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PU_SpeedUpController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D Ball;
    public float magnitude;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == Ball)
        {
            Ball.GetComponent<Ball>().ActivatePuSpeedUp(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }
}
