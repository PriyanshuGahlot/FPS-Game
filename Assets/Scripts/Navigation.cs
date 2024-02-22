using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navigation : MonoBehaviour
{
    NavMeshAgent agent;
    public float movementSpeed;
    public int maxCloseness;

    private void Start()
    {
        agent = transform.GetComponent<NavMeshAgent>();
        agent.speed = movementSpeed;
    }

    void Update()
    {
        Vector3 playerPos = FindObjectOfType<Player>().transform.position;
        float dis = Vector3.Distance(transform.position, playerPos);
        if (dis > maxCloseness) agent.SetDestination(playerPos);
        else agent.SetDestination(transform.position);
    }
}