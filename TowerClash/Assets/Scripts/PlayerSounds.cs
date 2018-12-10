using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour {
 
    public AudioClip attack;
    public AudioSource player;

    void Shootsound ()
    {
        player.PlayOneShot(attack);
    }
    
}
