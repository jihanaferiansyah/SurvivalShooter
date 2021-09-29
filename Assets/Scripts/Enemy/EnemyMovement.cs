using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    private Transform player;
    private PlayerHealth playerHealth;
    private EnemyHealth enemyHealth;
    private UnityEngine.AI.NavMeshAgent nav;

    private void Awake()
    {
        //cari game object dengan tag player
        player = GameObject.FindGameObjectWithTag("Player").transform;

        //mendapatkan komponen reference
        playerHealth = player.GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    private void Update()
    {
        // pindah ke player position
        if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        {
            nav.SetDestination(player.position);
        }
        else //stop moving
        {
            nav.enabled = false;
        }
    }
}