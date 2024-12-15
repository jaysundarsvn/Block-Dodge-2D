using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject crate;
    public float maxPos;
    public Transform spawnPoint;
    public float spawnRate = 0;
    bool gameStarted = false;
    public GameObject tapText;
    public TextMeshProUGUI scoreText;
    int score = 0;
    
    //public static GameManager instance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !gameStarted)
        {
            StartSpawningCrates();
            gameStarted = true; 

            tapText.SetActive(false);
        }
    }

    void StartSpawningCrates()
    {
        InvokeRepeating("SpawnCrate", 0.5f, spawnRate);
    }

    void SpawnCrate()
    {
        Vector3 spawnPos = spawnPoint.position;

        spawnPos.x = Random.Range(-maxPos, maxPos);

        Instantiate(crate, spawnPos, Quaternion.identity);

        score++;
        scoreText.text = score.ToString();
    }

}
