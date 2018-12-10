using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySounds : MonoBehaviour {

    public AudioClip impactSound;
    public AudioSource enemy;

    void ImpactSound ()
    {
        enemy.PlayOneShot(impactSound);
    }
}
