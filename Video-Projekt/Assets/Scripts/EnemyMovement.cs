using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyMovement : MonoBehaviour
{
    // Attribut
    protected float speed = 5f;


    // Start is called before the first frame update
    protected virtual void Start()
    {
        // Do something
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    protected abstract void Move();
}
