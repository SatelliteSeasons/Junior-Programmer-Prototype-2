using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    private float xRange = 15;

    public GameObject projectile;
    void Start()
    {
        
    }

    void Update()
    {
        //Permet de restraindre le joueur dans un invervalle de position
        if(this.transform.position.x < -xRange)
        {
            this.transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (this.transform.position.x > xRange)
        {
            this.transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");

        this.transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

        if(Input.GetKeyDown( KeyCode.Space))
        {
            //Lancer le projectile depuis le joueur
            Instantiate(projectile, this.transform.position, projectile.transform.rotation);
        }
    }
}
