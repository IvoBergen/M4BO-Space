using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Networking;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class EnemyFollow : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform Player;
    public LayerMask whatIsGround, whatIsPlayer;
    public bool followPlayer;

    //patroling
    public Vector3 walkPoint;
    internal bool walkPointSet;
    public float walkPointRange;

    private bool followStatus = true;
    public bool FollowStatus {
        set
        {
            followStatus = value;
            agent.isStopped = !followStatus;
        }
    }

    public void setFollowing(bool followStatus)
    {
       
    }
    /*private void OnDrawGizmos()
    {
        Vector3 moving = transform.position;        
        moving.y -= 1;
        Gizmos.color = Color.blue;
        Vector3 direction = Player.position;// transform.TransformDirection(Vector3.forward) * 5;
        Gizmos.DrawRay(moving, direction-moving);
    }*/
    public void Update()
    {
       
        // Draws a blue line from this transform to the target
        Vector3 moving = transform.position; 
        moving.y -= 1;
        RaycastHit hit;
        if (followStatus)
        {
            if (Physics.Raycast(moving, Player.position - moving, out hit))
            {

                if (hit.collider.name == "PlayerObj")
                {
                    agent.SetDestination(Player.position) ;
                    followPlayer = true;
                }
                else if (hit.collider.name != "PlayerObj")
                {
                    if (followPlayer)
                    {
                        SearchWalkPoint();
                    }
                    Patroling();
                }
            }
            else
            {
                Patroling();
            }
        }
    }

    private void Awake()
    {
        Player = GameObject.Find("PlayerObj").transform;
        agent = GetComponent<NavMeshAgent>();
    }
    private void Patroling()
    {

        if (!walkPointSet)
        {
            SearchWalkPoint();
        }
     
            

        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        //Walkpoint reached
        if (distanceToWalkPoint.magnitude < 1f)
        {
            walkPointSet = false;
        }
    }

    private void SearchWalkPoint()
    {
        // Calculate random point in range
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);
        if (Physics.Raycast(walkPoint, -transform.up, 10f, whatIsGround))
        {
            walkPointSet = true;
            agent.SetDestination(walkPoint);
            followPlayer = false;
        }
            
    }
 
}
