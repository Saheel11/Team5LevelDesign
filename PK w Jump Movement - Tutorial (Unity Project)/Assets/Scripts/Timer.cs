using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float time;
    public bool Active;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Active)
        {
            time += Time.deltaTime;
        } 
    }
    private void OnTriggerExit(Collider other) {
        if(other.tag == "Start")
        {
            Active = true;
        }
    }
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "End")
        {
            Active = false;
        }  
    }
}
