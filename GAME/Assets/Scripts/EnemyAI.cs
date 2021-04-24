using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{

    public bool InRange = false;

    public float SpinSpeed = 10f;

    public float LookRadius = 10f;

    public GameObject Player;

    public GameObject PlayerObj;

    public bool PlayerDeadBool = false;

    Transform target;
    NavMeshAgent agent;

    public bool NoEnd = false;

    void Start()
    {
        PlayerObj = GameObject.FindGameObjectWithTag("Player");
        Player = PlayerObj;
        target = Player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= LookRadius && PlayerDeadBool == false)
        {
            InRange = true;

            
            if(PlayerDeadBool == false)
            {
                agent.SetDestination(target.position);
            }

            if(distance <= agent.stoppingDistance && PlayerDeadBool == false)
            {
                FaceTarget();
            }
        }
        else if (distance >= LookRadius)
        {
            InRange = false;
        }


        
    }


    public void destoyEnemys()
    {
        Destroy(this.gameObject);
    }

    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion LookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, LookRotation, Time.deltaTime * SpinSpeed);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, LookRadius);
    }
}
