using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingAI : MonoBehaviour
{
    public float speed = 3.0f;
    public float obstacleRange = 5.0f;
    private bool isAlive;

    void Start()
    {
        isAlive = true;
    }

    void Update()
    {
        if (isAlive)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            if (Physics.SphereCast(ray, 0.75f, out hit))
            {
                if (hit.distance < obstacleRange)
                {
                    float angle = Random.Range(-110, 110);
                    transform.Rotate(0, angle, 0);
                }
            }
        }

        //draw the ray for debugging purposes
        Debug.DrawRay(transform.position, transform.forward * 10, Color.red);
    }

    public void SetAlive(bool alive)
    {
        isAlive = alive;
    }
}
