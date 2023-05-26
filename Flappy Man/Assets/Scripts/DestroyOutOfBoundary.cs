using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundary : MonoBehaviour
{
    public float Rightbound = 14f;
    public float leftbound = -20f;
    
    private float topbound = 28f;
    private float lowerbound = -16.41f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > Rightbound || transform.position.z > topbound)
        {
            Destroy(gameObject);
            Debug.Log("Obj Deleted");
        }
        else if(transform.position.x < leftbound || transform.position.z < lowerbound)
        {
            Destroy(gameObject);
            Debug.Log("Obj Deleted");
        }
        
    }
}
