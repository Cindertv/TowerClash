using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class PlayerAttacks : PlayerSounds
{
    public Rigidbody projectile;
    public float speed;
    public GameObject bulletprefab;
    public Transform firePoint;
    public float rateOfFire = 100f;

    float timeBetweenShots;

    void Shoot ()
    {
        if (Time.time > timeBetweenShots)
        {
            timeBetweenShots = Time.time + rateOfFire / 1000;
            var bullet = Instantiate(bulletprefab, firePoint.position, firePoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * speed;
            Destroy(bullet, 4f);
            player.PlayOneShot(attack);
        }
    }
    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();           
        }
    }


}
