using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class wander : MonoBehaviour
{

    private Vector3 target;
    private Rigidbody rig;
    private NavMeshAgent nav; 

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        target = transform.position + new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f, 5f));
        nav = GetComponent<NavMeshAgent>(); 
    }

    // Update is called once per frame
    void Update()
    {

        if(Vector3.Distance(transform.position,target)<1)
        {
            target = transform.position + new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f, 5f));
        }


        // Vector3 v = (target - transform.position).normalized;
        //transform.position += v * Time.deltaTime;
        // rig.velocity = v; 
        //  transform.LookAt(target);
        nav.SetDestination(target);


     }
}
