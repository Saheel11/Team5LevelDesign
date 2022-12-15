using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTimer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit(Collider other) {
        if(other == GameObject.Find("Player"))
        {
            Debug.Log("A");
            other.GetComponent<Timer>().Active = true;
        }
    }

}
