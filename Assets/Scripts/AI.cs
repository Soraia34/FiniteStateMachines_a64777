using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    NavMeshAgent agent;
    Animator anim;
    public Transform player;
    State currentState;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        currentState = new Idle(this.gameObject, agent, anim, player);
    }

    // Update is called once per frame
    void Update()
    {
        currentState = currentState.Process();
    }
}
