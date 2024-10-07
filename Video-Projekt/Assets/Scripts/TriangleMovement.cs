using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleMovement : EnemyMovement
{
    private GameObject player;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        player = GameObject.Find("Player");
        speed = 4f;
    }

    protected override void Move()
    {
        // Move towards the player, max speed steps per second
        Vector3 move_direction = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);

        transform.position = move_direction;
    }
}
