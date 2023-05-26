using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

 public GameObject[] PerfabObject;
   private  float Xspawnpos = 20.0f;
    private  float zspawnpos = 20.0f;
    private float spwanDelay =1;
    private float spawnInterval = 1f;
    void Start()
    {
        InvokeRepeating("SpawnRandomanimal",spwanDelay,spawnInterval);

    
    }

   void SpawnRandomanimal()
    {
            //creating local variable
            int ObjectIndex = Random.Range(0,PerfabObject.Length);
            Vector3 Spawnpos = new Vector3(Random.Range(-Xspawnpos,Xspawnpos),0.2480001f,Random.Range(-zspawnpos,zspawnpos));
            Instantiate(PerfabObject[ObjectIndex],Spawnpos,PerfabObject[ObjectIndex].transform.rotation);
    }

    }

