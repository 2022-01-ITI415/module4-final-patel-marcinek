using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{

    public static float countdown = 250.0f;
    public bool timerIsRunning = false;
    public TextMeshProUGUI gameOverText;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
        gameOverText.gameObject.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
    
        if(countdown < 0.1) {
            gameOverText.gameObject.SetActive(true);
            timerIsRunning = false;
            audioSource.Play();
            Invoke("SceneChange", 5.0f);
        }
    }

    void SceneChange()
    {
        countdown = 250.0f;
        gameOverText.gameObject.SetActive(false);
        SceneManager.LoadScene("Terrain");
    }
}
