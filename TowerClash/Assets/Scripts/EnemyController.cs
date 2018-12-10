using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyController : EnemySounds
{

    NavMeshAgent playerAgent;
    public PlayerController player;
    public float enemyHealth = 100f;
    public Image uiEnemyHeatlh;    
    public float enemyDamage;
    public float movementSpeed = 0.5f;
    public GameController score;
    void Start()
    {
        uiEnemyHeatlh.fillAmount = 1f;
        playerAgent = GetComponent<NavMeshAgent>();
        player = FindObjectOfType<PlayerController>();
        score = FindObjectOfType<GameController>();
        UpdateUI();
    }

    void Update()
    { 
        playerAgent.SetDestination(player.transform.position);
    }
    private void OnTriggerEnter(Collider other)
    {
        TowerAttack bullet = other.GetComponent<TowerAttack>();
        if (bullet != null)
        {
            enemyHealth -= bullet.towerDamage;
            UpdateUI();
            enemy.PlayOneShot(impactSound);
            if (enemyHealth <= 0)
            {
                Destroy(this.gameObject);
                score.AddScore();
                
            }
            Destroy(other.gameObject);           
        }
    }

    private void UpdateUI()
    {
        uiEnemyHeatlh.fillAmount = enemyHealth / 200f;
    }
}

