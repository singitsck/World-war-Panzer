using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameCheck : MonoBehaviour
{
    public Text Enemy;
    private GameObject[] EnemyNo;
    private GameObject[] PlayerNo;
    public float restartDelay;
    private float restartTime;

    // Update is called once per frame
    void Update()
    {
        EnemyNo = GameObject.FindGameObjectsWithTag("Enemy");
        PlayerNo = GameObject.FindGameObjectsWithTag("Player");

        Enemy.text = "EnemyNo = " + EnemyNo.Length;

        if (EnemyNo.Length <= 0)
        {
            restartTime += Time.deltaTime;
            if (restartTime >= restartDelay)
            {
                SceneManager.LoadScene("Win");
            }
        }
        if (PlayerNo.Length <= 0)
        {
            restartTime += Time.deltaTime;
            if (restartTime >= restartDelay)
            {
                SceneManager.LoadScene("Lose");
            }
        }
    }
}
