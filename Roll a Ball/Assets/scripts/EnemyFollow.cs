using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    private NavMeshAgent _agent; // A component on this allow to us Ai functions

    [SerializeField, Tooltip("The object for this enemy to follow")]
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        _agent.SetDestination(target.position);
    }
}
