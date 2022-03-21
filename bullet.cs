using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject ef;
     
    private Rigidbody rig;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 1);
        rig = transform.GetComponent<Rigidbody>();
        rig.AddForce(transform.forward * 800);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* public void OnCollisionEnter(Collision collision)
     {
         Destroy(this.gameObject);
     }*/

    public void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
        GameObject e = Instantiate(ef, transform.position, transform.rotation);
        Destroy(e, 1.5f);

        if(other.tag=="tank1")
        {
            //碰到就调用敌方tank的damage方法,通过sendmassage来进行调用，调用谁的？调用other身上所带的脚本中的那个指定（sendmessage里写的） 的方法
            other.SendMessage("damage");
        }
         
    }
}
