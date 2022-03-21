 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class chase : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;

    private Rigidbody rig;
    private NavMeshAgent nav;

     


    void Start()
    {
        rig = GetComponent<Rigidbody>() ;
        nav = GetComponent<NavMeshAgent>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 v = (player.transform.position - transform.position).normalized;
        //transform.position = v * Time.deltaTime
        //rig.velocity = v;
        //transform.LookAt(player.transform);
        nav.SetDestination(player.transform.position); 
         

    }
}
