using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Y Position of the player
    private float yPosition;

    //Laser for player
    [SerializeField] private GameObject laser;
    [SerializeField] private float fireRate = 1f;

    void Start()
    {
        //Locks the Y
        yPosition = transform.position.y;

        InvokeRepeating("Shoot", 0, fireRate);
    }

    // Update is called once per frame
    void Update()
    {
        //Player Movement
        Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(position.x, yPosition);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            Game_Manager.instance.GameOver();
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

    public void Shoot()
    {
        Instantiate(laser, transform.position, Quaternion.identity);
    }
}
