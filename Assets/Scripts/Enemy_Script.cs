using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Script : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    //Point value of the enemy
    [SerializeField] private int point_value = 10;


    void Update()
    {
        transform.position -= new Vector3 (0, speed, 0)*Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Game_Manager.instance.GameOver();
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag.Equals("Laser"))
        {
            Game_Manager.instance.IncreaseScore(point_value);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
