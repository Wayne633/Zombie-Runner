using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;   //������汾�Լ��Զ��������ռ����ȥ��

public class EnemyAI : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float chaseRange = 5f;  //how far away from the enemy before the enemy starts chasing the player


    NavMeshAgent navMeshAgent;
    float distanceToTarget = Mathf.Infinity;
    
    
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();


    }

  
    void Update()
    {
        distanceToTarget = Vector3.Distance (target.position, transform.position);
        
        if(distanceToTarget <= chaseRange)
        {
            navMeshAgent.SetDestination(target.position);
        }


    }
}
