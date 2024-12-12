using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obsticle : MonoBehaviour
{
    public GameObject[] waypoints;
    int current = 0;
    public float speed;
    float waypointRadius = 1;

    private void Update()
    {
        if (Vector3.Distance(waypoints[current].transform.position, transform.position) <= waypointRadius)
        {
            current++;
            if (current >= waypoints.Length)
            {
                current = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, speed * Time.deltaTime);
    }
}
