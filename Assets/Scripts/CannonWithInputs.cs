using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonWithInputs : MonoBehaviour
{
    [SerializeField] GameObject BulletType;
    [SerializeField] GameObject TwoBulletsType;
    [SerializeField] GameObject ThreeBulletsType;
    [SerializeField] GameObject FourBulletsType;

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

        switch(bulletAmmount)
        {
            case 2:
                spawnBullet(TwoBulletsType);
                break;
            case 3:
                spawnBullet(ThreeBulletsType);
                break;
            case 4:
                spawnBullet(FourBulletsType);
                break;
            default:
                spawnBullet(BulletType);
                break;
        }
        
        isShooting = false;
    }

    void spawnBullet(GameObject bulletType)
    {
        Instantiate(bulletType, transform.GetChild(0).transform);
    }
}
