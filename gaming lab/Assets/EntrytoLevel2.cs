using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntrytoLevel2 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && PlayerStats.hasHeart == true)
        {
            SceneManager.LoadScene(2);

            Debug.Log("Lives: " + PlayerStats.lives);
            Debug.Log("Health: " + PlayerStats.health);
            Debug.Log("Score: " + PlayerStats.score);

            AudioManager.Instance.PlayMusic(
                AudioManager.Instance.caveMusic
            );
        }
        else
        {
            FindObjectOfType<Levelmanager>().RespawnPlayer();
        }
    }
}