using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public Transform spawnArea;
    public int spawnInterval;
    public int maxPowerUpAmount;
    public List<GameObject> powerUptemplateList;
    public Vector2 powerUpAreaMin;
    public Vector2 powerUpAreaMax;
    private List<GameObject> PowerUpList;

    private float timer;

    private void Start()
    {
        PowerUpList = new List<GameObject>();
        timer = 0;   
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnInterval)
        {
            GenerateRandomPowerUp();
            timer -= spawnInterval;
        }
    }

    public void GenerateRandomPowerUp()
    {
        GenerateRandomPowerUp(new Vector2(Random.Range(powerUpAreaMin.x, powerUpAreaMax.x), Random.Range(powerUpAreaMin.y, powerUpAreaMax.y)));
    }

    public void GenerateRandomPowerUp(Vector2 position)
    {
        if (PowerUpList.Count >= maxPowerUpAmount)
        {
            return;
        }

        if (position.x < powerUpAreaMin.x || 
            position.x > powerUpAreaMax.x ||
            position.y < powerUpAreaMin.y ||
            position.y > powerUpAreaMax.y)
        {
            return;
        }

        int randomIndex = Random.Range(0, powerUptemplateList.Count);

        GameObject powerUp = Instantiate(powerUptemplateList[randomIndex], new Vector3 (position.x, position.y, powerUptemplateList[randomIndex].transform.position.z), Quaternion.identity, spawnArea);
        powerUp.SetActive(true);

        PowerUpList.Add(powerUp);
    }

    public void RemovePowerUp(GameObject powerUp)
    {
        PowerUpList.Remove(powerUp);
        Destroy(powerUp);
    }

    public void RemoveAllPowerUp()
    {
        while(PowerUpList.Count > 0)
        {
            RemovePowerUp(PowerUpList[0]);
        }
    }

}
