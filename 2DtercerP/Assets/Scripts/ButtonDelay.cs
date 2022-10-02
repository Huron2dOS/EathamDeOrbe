using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDelay : MonoBehaviour
{
    [SerializeField] private GameObject buttonOn; //Obtener nuestra imagen de button on
    [SerializeField] private float time = 0; //setear el tiempo que quieres que tarde
    [SerializeField] private GameObject[] obstacle; //obtener el sprite de snorlax

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") //cuando choques con un objeto con el tag de player
        {
            Debug.Log("hola");
            StartCoroutine(ActivateButton(time)); //empieza la corrutina que se llma "ActiveButton" y le pones el valor de tiempo en enteros
        }
    }

    IEnumerator ActivateButton(float time) //funcion de la corrutina
    {
        buttonOn.SetActive(false); //desactivar buttonOn
        obstacle[0].SetActive(false); //desactivar obstacle
        obstacle[1].SetActive(false);
        obstacle[2].SetActive(false);
        yield return new WaitForSeconds(time); //espera una cantidad de segundos y despues
        buttonOn.SetActive(true); //avtivar buttonOn
        obstacle[0].SetActive(true); //
        obstacle[1].SetActive(true);
        obstacle[2].SetActive(true);
        StopCoroutine(ActivateButton(time));
    }

}
