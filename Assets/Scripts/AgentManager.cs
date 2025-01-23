using UnityEngine;
using UnityEngine.AI;
public class AgentManager : MonoBehaviour
{
    NavMeshAgent[] agents;
    public Transform Target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agents = FindObjectsByType<NavMeshAgent>(FindObjectsSortMode.None);
    }

    private void FixedUpdate()
    {
        foreach (NavMeshAgent agent in agents)
        {
            agent.SetDestination(Target.position);
        }
    }
}