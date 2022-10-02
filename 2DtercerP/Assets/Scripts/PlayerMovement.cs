using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //private Vector2 moveDirection; //Para poder sacar la informacion del movimiento X y Y
    [SerializeField] private float moveSpeed; //Para ponerle un valor de la velocidad del objeto
    [SerializeField] private Rigidbody2D rb; //Para poder tener un valor de velocidad de movimiento
    [SerializeField] private Animator anim; //Para poder acceder a blend tree y poder hacer las animaciones
    public static Vector2 moveDirection; //Para poder sacar la informacion del movimiento X y Y

    void Update()
    {
        Movement(); //Sintaxis para mandar llamar una funcion
        Animate();
    }

    void Movement()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); //Obtiene los valores cuando el objeto se mueve de derecha a izquierda
        float moveY = Input.GetAxisRaw("Vertical"); //obtiene los valores cuando el objeto se mueve de abajo a arriba
        moveDirection = new Vector2(moveX, moveY).normalized; //Te arroje valores solo de 1 a -1. No mas y no menos
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed); //aqu se hace el movimiento del personaje usando velocidad con rb

    }
    void Animate()
    {
        anim.SetFloat("moveX", moveDirection.x); //hacer la respectiva animacion dependiendo de si vas a la derecha o izquierda
        anim.SetFloat("moveY", moveDirection.y);
    }
}
