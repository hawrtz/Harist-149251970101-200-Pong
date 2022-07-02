using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EPP : MonoBehaviour
{

    [SerializeField]
    private PowerUpManager manager;

    [SerializeField]
    private Collider2D ball;

    [SerializeField]
    private GameObject CP;

    private int destroy = 2;




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision = ball)
        {
            CP.GetComponent<CP>().ActivateEPP();
            manager.RemovePowerUp(gameObject);
        }
    }

    private void Start()
    {
        StartCoroutine(DeathTime());
    }

    private void Update()
    {
        
    }

    IEnumerator DeathTime()
    {
        yield return new WaitForSeconds(destroy);
        Destroy(gameObject);
    }
}
