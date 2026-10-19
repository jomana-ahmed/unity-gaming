using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deadlydrop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //function that executes upon trigger (when something collides with the spikes)
void OnTriggerEnter2D(Collider2D other) {if (other.tag == "Player") {
    FindObjectOfType<Levelmanager>().RespawnPlayer();
}
}
}
