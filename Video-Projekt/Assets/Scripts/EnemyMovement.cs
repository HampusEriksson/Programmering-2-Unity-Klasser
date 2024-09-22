using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Attribut
    private float speed = 5f;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // Move towards the player, max speed steps per second
        Vector3 move_direction = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);

        transform.position = move_direction;
    }
}
