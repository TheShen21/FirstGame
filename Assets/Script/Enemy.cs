using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 50;
    int currentHealth;

    //AI
    public NavMeshAgent agent;
    public Transform player;

    int damage = 1;

    public Transform bodyPoint;
    public float damageRange = 1;
    public LayerMask PlayerLayers;

    private void Awake()
    {
        player = GameObject.Find("player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }
    private void Update()
    {
        Chase();
        Explosion();
    }


    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0) 
        {
            Die();
        }
        void Die()
        {
            ScoreScript.scoreValue = +100;
            Debug.Log("Enemy died");
            Destroy(gameObject);

        }

        

    }
void Chase()
        {
            agent.SetDestination(player.position);
        }
    void Explosion()
    {
        Collider[] hitplayer = Physics.OverlapSphere(bodyPoint.position, damageRange, PlayerLayers);
        foreach (Collider player in hitplayer)
        {
            Destroy(gameObject);
            player.gameObject.GetComponent<playerHealth>().takeDamage(damage);
            
            
        }

        
    }

}
