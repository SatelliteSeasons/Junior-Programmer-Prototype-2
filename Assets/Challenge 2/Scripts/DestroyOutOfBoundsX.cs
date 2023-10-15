using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -45;
    private float bottomLimit = -5;

    void Update()
    {
        // Détruit le chien si la position x est en dessous de leftLimite
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }
        // Détruit les balles si la position y est en dessous de bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }

    }
}
