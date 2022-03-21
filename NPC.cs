 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC : MonoBehaviour
{
    //NPC具有巡逻，追击，攻击，这三个行为
    //死亡行为在Health脚本中
    /*设计思路：
    1. 如果距离过远，则在所属区域进行无意识移动，巡逻
    2. 当和玩家tank距离缩短至某一个距离时，注意到并开始追击
    3. 到攻击范围时开始攻击

    */
    /*
     
      
    */
    public GameObject player;
    public GameObject bullet;
    public GameObject pos;

    private float distance;
    private float time;
    private Rigidbody rig;
    private Vector3 target;
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
        if(player==null)
        {
            return;
        }  

        //两tank之间到距离是  这样的 
        distance = Vector3.Distance(transform.position, player.transform.position);

        //enemy tank的行为变化

        if(distance>20)
        {
            //巡逻

            if (Vector3.Distance(transform.position, target) < 1)
            { 
                target = transform.position + new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f, 5f));
            }

            /*
               Vector3 v = (target - transform.position).normalized;
               //transform.position += v * Time.deltaTime;
               rig.velocity = v;
               transform.LookAt(target); 
            *///用AI移动替代了矢量移动，因为有障碍物的存在
            nav.SetDestination(target);



        }
        else if(distance<=20)
        {
             if(distance<10)
            {
                //攻击
                time -= Time.deltaTime;
                if (time < 0)
                {
                    Instantiate(bullet, pos.transform.position, transform.rotation);
                    time = 1;
                    
                }
                transform.LookAt(player.transform);
                nav.speed = 0;

            }

             else
            {
                //追击
                /* Vector3 v = (player.transform.position - transform.position).normalized;
                 //   transform.position += v * Time.deltaTime;
                 rig.velocity = v;
                 transform.LookAt(player.transform);
                *///同理，通过AI来替换了矢量的追击
                nav.speed = 1;
                nav.SetDestination(player.transform.position);  

            }

        }
        
    }
}
