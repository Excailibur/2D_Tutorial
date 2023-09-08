using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue_Laser : MonoBehaviour
{
    [SerializeField] private float speed = 5; 

    void Update()
    {
        transform.position += new Vector3(0, speed, 0) * Time.deltaTime;

        Destroy(gameObject,3);
    }
}
