using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeLife : MonoBehaviour
{

    [SerializeField] private float timeLife;

    private void Start()
    {
        Destroy(gameObject, timeLife);
    }

}
