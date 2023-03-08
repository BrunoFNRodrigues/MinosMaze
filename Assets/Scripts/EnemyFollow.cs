using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    [SerializeField]
    public NavMeshAgent enemy;
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private Transform transform;

    public Transform player;
    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(player.position);
        animator.SetBool("IsMoving", enemy.velocity.magnitude > 0.01f);

        if(Vector3.Distance(player.position, transform.position) < 4.5f)
        {
            animator.SetTrigger("Attack");
            
        }
    }
}
