using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UITimer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    public Text text;
    void Start()
    {
        Player = GameObject.Find("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        
        text.text =Player.GetComponent<Timer>().time.ToString("f1");
    }
}
