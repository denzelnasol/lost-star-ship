using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{

    //Array of waypointsd to walk from one to another
    [SerializeField]
    private Transform[] waypoints;

    //Walk speed that can be set in Inspector
    [SerializeField]
    private float moveSpeed = 3f;

    //Index of current waypoint from which Enemy walks
    //to the next one
    private int waypointIndex = 0;

    //Use this for initialization
    void Start()
    {
        //Set position of Enemy as position of the first waypoint
        transform.position = waypoints[waypointIndex].transform.position;
    }

    void Update()
    {
        //Move Enemy
        Move();
    }

    private void Move()
    {
        //If Enemy didn't reach last waypoint it can move
        //If enemy reached last waypoint then it stops
        if (waypointIndex <= waypoints.Length - 1)
        {
            //Move Enemy from current waypoint to the next one
            //Use MoveToward method
            transform.position = Vector2.MoveTowards(transform.position,
                waypoints[waypointIndex].transform.position,
                moveSpeed * Time.deltaTime);

            // If Enemy reaches position of waypoint he waliked towards
            // then waypointsIndex is increased by 1
            // And Enemy starts to walk to the next waypoint
            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }

        }
    }
}