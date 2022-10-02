using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    [SerializeField] private Camera cam; //aqui va la main camera

    private void OnTriggerEnter2D(Collider2D collision) //entra una colision de tipo trigger
    {
        if (collision.gameObject.tag == "Area2") //cuando choques con un objeto llamado area2
        {
            Vector3 camPosition = new Vector3(0, -15.08f, -10); //aqui hacemos una variable llamada camPosition para que obtenga la posicion nueva de la camara
            cam.transform.position = camPosition; //Le pones la informacion de la nueva posicion a la camara con repecto a la camPosition

            Vector3 playerPosition = new Vector3(-0.17f, -10.75f, 0); //aqui hacemos una variable llamada playerposition para que obtenga la posicion nueva del personaje
            this.transform.position = playerPosition; // le pones la informacion de la nueva posicion al personaje con respecto a playerPosition
        }

        if(collision.gameObject.tag == "Area1") //cuando choques con un objeto llamado area1
        {
            Vector3 camPosition = new Vector3(0, -0.01f, -10);
            cam.transform.position = camPosition;

            Vector3 playerPosition = new Vector3(-0.89f, -4.07f, 0);
            this.transform.position = playerPosition;
        }
        
    }
}
