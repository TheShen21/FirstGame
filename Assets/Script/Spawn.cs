using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemy;
    public Transform Spawnpoint;
    public int count = 0;
    public int timer = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        count++;
        if (count > timer)
        {
            Instantiate(enemy, Spawnpoint.position, Spawnpoint.rotation);
            Debug.Log("hi");
            count = 0;
            timer -= 50;
        }
            
       
    }
    
}