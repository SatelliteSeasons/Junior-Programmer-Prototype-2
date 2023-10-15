using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 30.0f;
    public float lowBound = -15.0f;
    void Start()
    {
        
    }

    void Update()
    {
        if (this.transform.position.z > topBound)
        {
            Destroy(gameObject);
        }else if(this.transform.position.z < lowBound)
        {
            Destroy(gameObject);
            Debug.Log("GAME OVER!");
        }
    }
}
