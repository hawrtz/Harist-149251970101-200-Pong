using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text SkorKiri;
    public Text SkorKanan;

    public ScoreManager manager;

    private void Update()
    {
        SkorKiri.text = manager.leftScore.ToString();
        SkorKanan.text = manager.rightScore.ToString();
    }

}
