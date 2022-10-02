using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    /* [SerializeField] private Transform ControlDisparo;
     [SerializeField] private GameObject Bullet;

     private void Update()
     {
         if(Input.GetButtonDown("Fire1"))
         {
             Disparar();
         }
     }

     private void Disparar()
     {
         Instantiate(Bullet, ControlDisparo.position, ControlDisparo.rotation);


     }*/

    [SerializeField] private Transform ControlDisparo;
    [SerializeField] private GameObject Bullet;

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Disparar();
        }
    }

    private void Disparar()
    {


        if (PlayerMovement.moveDirection.y == 1)
        {
            Instantiate(Bullet, transform.position, Quaternion.AngleAxis(90, Vector3.forward));
        }
        else if (PlayerMovement.moveDirection.y == -1)
        {
            Instantiate(Bullet, transform.position, Quaternion.AngleAxis(270, Vector3.forward));
        }
        else if (PlayerMovement.moveDirection.x == 1)
        {
            Instantiate(Bullet, transform.position, Quaternion.AngleAxis(0, Vector3.forward));
        }
        else if (PlayerMovement.moveDirection.x == -1)
        {
            Instantiate(Bullet, transform.position, Quaternion.AngleAxis(180, Vector3.forward));
        }
        else
        {
            Instantiate(Bullet, transform.position, Quaternion.AngleAxis(270, Vector3.forward));
        }
    }

}
