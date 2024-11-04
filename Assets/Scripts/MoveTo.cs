using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Serialization;

public class MoveTo : MonoBehaviour
{
    public Transform[] points;
    private int _destPoint = 0;
    private NavMeshAgent _agent;
   
    void Start()
    {
        // Initialize agent and sets patrolling parameters
        _agent = GetComponent<NavMeshAgent>();
        _agent.updateUpAxis = false;
        _agent.updateRotation = false;
        _agent.autoBraking = false;

        // Starts patrol
        GoToNextPoint();
    }

    private void GoToNextPoint()
    {
        if (points.Length == 0) return;

        // Sends agent to next destination
        _agent.destination = points[_destPoint].position;
        // Updates destination point
        _destPoint = (_destPoint + 1) % points.Length;
    }

    private void Update()
    {
        // Choose next destination point
        if(!_agent.pathPending && _agent.remainingDistance < 0.5f) GoToNextPoint();
    }
}
