using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody rig;

    public GameObject bullet;
    public GameObject pos;
    public int number;
     

    // Start is called before the first frame update
    void Start()
    {
        rig = transform.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical"+number);//利用了字符串的拼接，如果1则通过上下左右，2则是wasd
        float h = Input.GetAxis("Horizontal"+number);

        rig.velocity = transform.forward * v * 5 ;
        rig.angularVelocity = transform.up * h * 10;

       /* if(Input.GetMouseButtonDown( 0))
        {
            Instantiate(bullet, pos.transform.position, transform.rotation);

        }*/
       if(Input.GetKeyDown(KeyCode.LeftCommand)&&number==2)
        {
            Instantiate(bullet, pos.transform.position, transform.rotation);

        }

       if(Input.GetKeyDown(KeyCode.RightCommand)&&number==1)
        {
            Instantiate(bullet, pos.transform.position, transform.rotation);

        }
         
        
    }
}
