using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectibles : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public static int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);

            count = count + 1;

            SetCountText();
        }
    }
}
