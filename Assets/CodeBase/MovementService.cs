using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovementService : MonoBehaviour
{
    public Transform goal;
    private NavMeshAgent _agent;



    void Awake()
    {
        // Получение компонента агента
     
           _agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        // Указаие точки назначения
        //MoveToPlayer();
    }

    public void MoveToPlayer(Animator anim, string key)
    {
        _agent.destination = goal.position;
        anim.SetInteger(key, 1);
        
        if(_agent.destination == goal.position)
            anim.SetInteger(key, 2);
    }

    public void MoveToIdle(Transform goal, Animator anim, string key)
    {
        anim.SetInteger(key, 3);
        _agent.destination = goal.position;

        if (_agent.destination == goal.position)
            anim.SetInteger(key, 2);

    }


}
