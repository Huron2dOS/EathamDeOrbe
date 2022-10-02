using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float Healt;

    [SerializeField] private GameObject DeathEffect;

    public void GetDamage(float damage)
    {
        Healt -= damage;
        if (Healt <= 0)
        {
            Death();
        }
    }

    private void Death()
    {
        Instantiate(DeathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
