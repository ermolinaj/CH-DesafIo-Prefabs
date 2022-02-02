using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] GameObject BulletType;

    // Start is called before the first frame update
    void Start()
    {
        Shoot();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shoot()
    {
        //Asumo que el script siempre va a ser asignado a un cañon con un object spawning point como child en el indice 0
        Instantiate(BulletType, transform.GetChild(0).transform);
    }
}
