using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemy;
    public Transform Spawnpoint;
    public int count = 7500;
    public int timer = 10;
    public int Srate = 10;

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
            timer -= Srate;
        }
            
       
    }
    
}