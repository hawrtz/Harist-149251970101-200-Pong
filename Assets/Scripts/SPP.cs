using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPP : MonoBehaviour
{
    [SerializeField]
    private PowerUpManager manager;

    [SerializeField]
    private Collider2D Ball;

    [SerializeField]
    private GameObject P1;

    [SerializeField]
    private int destory = 2;

    [SerializeField]
    private GameObject P2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == Ball)
        {
            P1.GetComponent<CP>().ActivateSPP();
            P2.GetComponent<CP>().ActivateSPP();
            manager.RemovePowerUp(gameObject);
        }

    }

    private void Start()
    {
        StartCoroutine(DeathTime());

    }

    IEnumerator DeathTime()
    {
        yield return new WaitForSeconds(destory);
        Destroy(gameObject);
    }

}
