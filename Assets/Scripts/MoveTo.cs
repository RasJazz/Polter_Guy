using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Serialization;

public class MoveTo : MonoBehaviour
{
    public Transform[] points;
    private int _destPoint = 0;
    [SerializeField] private NavMeshAgent _agent;
   
    void Start()
    {
        // Initialize agent and sets patrolling parameters
        _agent.updateUpAxis = false;
        _agent.updateRotation = false;
        _agent.autoBraking = false;
        
        // Check if the agent is enabled and on the NavMesh before starting patrol
        if (_agent.enabled)
        {
            Vector3 startPosition = transform.position;
            NavMeshHit hit;

            // Snap to NavMesh if necessary
            if (NavMesh.SamplePosition(startPosition, out hit, 1.0f, NavMesh.AllAreas))
            {
                transform.position = hit.position; // Snap to NavMesh
                // Starts patrol
                GoToNextPoint();
            }
            else
            {
                Debug.LogWarning("Agent is not on NavMesh! Check position or baking.");
            }
        }
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
