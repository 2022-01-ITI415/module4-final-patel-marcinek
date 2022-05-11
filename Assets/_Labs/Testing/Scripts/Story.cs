using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("SceneChange", 37.0f);
    }

    void SceneChange()
    {
        SceneManager.LoadScene("Terrain");
    }
}
