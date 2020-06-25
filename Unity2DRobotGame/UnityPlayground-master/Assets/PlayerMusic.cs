using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerMusic : MonoBehaviour
{
    public AudioSource perfectDarkCI;
    public AudioSource perfectDark30min;
    public AudioSource collectSFX; //new script. Ignore rest

    public bool playerSong = true;
    public bool collisionSong = false;


    public void Level1Music()
    {
        playerSong = true;
        collisionSong = false;
        perfectDarkCI.Play();
    }

    public void BonusLevel()
    {



        if (perfectDarkCI.isPlaying)
        {
            playerSong = false;
            perfectDarkCI.Stop();
        }
        if (!perfectDark30min.isPlaying && collisionSong == false)
        {
            perfectDark30min.Play();
            collisionSong = true;
        }

    }

    private void OnTriggerEnter(Collider other) //new script here 
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            collectSFX.Play(); //Audio SFX when player collects items.

            other.gameObject.SetActive(false);

        }
    }
}
