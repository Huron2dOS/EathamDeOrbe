using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealt : MonoBehaviour
{
    [SerializeField] RawImage[] hearts; //Arreglo de corazones
    private int healthCount;

    void Start()
    {
        healthCount = 3; //inicializando con un valor de 3
    }

    void Update()
    {
        switch (healthCount)
        {
            case 0:
                hearts[0].GetComponent<RawImage>().enabled = false; //desactivar la imagen de heart que esta en la posicion 0 del array
                break;
            case 1:
                hearts[1].GetComponent<RawImage>().enabled = false; //desactivar la imagen de heart que esta en la posicion 1 del array
                break;
            case 2:
                hearts[2].GetComponent<RawImage>().enabled = false; //desactivar la imagen de heart que esta en la posicion 2 del array
                break;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy") //al chocar con un objeto con tag "enemy"
        {
            healthCount--; //Se reduce uno cada que choque con enemy
        }
    }
}
