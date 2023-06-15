using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform Player;
    public LayerMask whatIsGround, whatIsPlayer;

    //patroling
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    private void Start()
    {
       
    }
    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Player.position, out hit))
        {
            if (hit.collider.name == "Player")
            {
                agent.SetDestination(Player.transform.position);
            }
            else
            {
                Patroling();
            }
        }
        else
        {
           
            Patroling();
        }


    }

    private void Awake()
    {
        Player = GameObject.Find("PlayerObj").transform;
        agent = GetComponent<NavMeshAgent>();
    }
    private void Patroling()
    {
        Debug.Log("Patroling");
        if (!walkPointSet) SearchWalkPoint();

     
            

        Vector3 distanceToWalkPoint = transform.position - walkPoint;
        //Debug.Log(distanceToWalkPoint.magnitude);

        //Walkpoint reached
        if (distanceToWalkPoint.magnitude < 1f)
            walkPointSet = false;
    }
    private void SearchWalkPoint()
    {
        // Calculate random point in range
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);
        Debug.Log("walkpoint");

        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y,transform.position.z + randomZ);
        Debug.Log(-transform.up);
        if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
            walkPointSet = true;
            agent.SetDestination(walkPoint);
    }
 
}
