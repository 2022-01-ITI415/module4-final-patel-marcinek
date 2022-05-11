using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Instructions : MonoBehaviour
{
    public TextMeshProUGUI movementText;
    public TextMeshProUGUI sprintText;
    public TextMeshProUGUI collectText;
    // Start is called before the first frame update
    void Start()
    {
        movementText.gameObject.SetActive(true);
        sprintText.gameObject.SetActive(true);
        collectText.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("RemoveInstructions", 10.0f);
    }

    void RemoveInstructions()
    {
        movementText.gameObject.SetActive(false);
        sprintText.gameObject.SetActive(false);
        collectText.gameObject.SetActive(false);
    }
}
