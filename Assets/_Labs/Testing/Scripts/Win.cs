using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Win : MonoBehaviour
{
    public bool playerWon = false;
    public TextMeshProUGUI playerWinText;

    // Start is called before the first frame update
    void Start()
    {
        playerWinText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Rocket") {
            if (Timer.countdown > 0.1) {
                if(Collectibles.count == 6){
                    playerWinText.gameObject.SetActive(true);
                    playerWon = true;
                    Invoke("SceneChange", 5.0f);
                }
            }
        }
    }

    void SceneChange()
    {
        playerWinText.gameObject.SetActive(false);
        SceneManager.LoadScene("Menu");
    }
}
