using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonWithInputs : MonoBehaviour
{
    [SerializeField] GameObject BulletType;
    bool isShooting;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("J dispara 2, K 3 y L 4 balas desde el cañon!");
        isShooting = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isShooting)
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                Shoot(2);
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                Shoot(3);
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                Shoot(4);
            }
        }
        
    }

    void Shoot(int bulletAmmount)
    {
        isShooting = true;
        Debug.Log("Disparando " + bulletAmmount.ToString() + " balas.");

        for(int i = 1; i <= bulletAmmount; i ++)
        {
            //Asumo que el script siempre va a ser asignado a un cañon con un object spawning point como child en el indice 0    
            spawnBullet();
        }
        isShooting = false;
    }

    void spawnBullet()
    {
        Instantiate(BulletType, transform.GetChild(0).transform);
    }
}
