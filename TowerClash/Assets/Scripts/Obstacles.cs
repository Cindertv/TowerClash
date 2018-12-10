using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : EnemySounds {

    private void OnTriggerEnter(Collider other)
    {
        TowerAttack bullet = other.GetComponent<TowerAttack>();
        if (bullet != null)
        {
            enemy.PlayOneShot(impactSound);
            Destroy(other.gameObject);
        }
    }
}
