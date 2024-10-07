using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMovement : EnemyMovement
{
    Vector3 direction;
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        speed = 2f;
        float x = Random.Range(-1, 1) * speed * Time.deltaTime;
        float y = Random.Range(-1, 1) * speed * Time.deltaTime;
        direction = new Vector3(x, y, 0);
    }

    

    protected override void Move()
    {
        transform.Translate(direction);   
    }
}
