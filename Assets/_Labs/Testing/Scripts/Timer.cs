using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{

    public float countdown = 180.0f;
    public bool timerIsRunning = false;
    public TextMeshProUGUI gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
        gameOverText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
    
        if(countdown < 0.1) {
            gameOverText.gameObject.SetActive(true);
            timerIsRunning = false;
            Invoke("SceneChange", 5.0f);
        }
    }

    void SceneChange()
    {
        SceneManager.LoadScene("Terrain");
    }
}
