﻿using UnityEngine;
using UnityEngine.SceneManagement;

//handles collision detection between Game Objects
public class Collisions : MonoBehaviour {
    // Use this for initialization
    void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {

    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.tag == "Player" && gameObject.tag =="Enemy")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            GameObject.Find("AdMobHandler").GetComponent<AdMob>().bannerShow();
            SceneManager.LoadScene("Game Over");
        }

        if (col.gameObject.tag == "Player" && gameObject.tag == "Collectable")
        {
            AudioSource.PlayClipAtPoint(gameObject.GetComponent<AudioSource>().clip, gameObject.transform.position);
            Destroy(gameObject);
            ScoreHandler.score += 1;
            SpawnStuff.counter++;
        }
    }
}
