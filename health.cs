using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    private int hp;
    public GameObject eft;
    public Slider hppoint; 


    // Start is called before the first frame update
    void Start()
    {
        hp = 5;
        hppoint.value = 5; 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void damage()
    {
        hp--;
        hppoint.value = hp;
        if(hp<=0)
        {
               
            //如果触碰到的是一个tank，则销毁这个物体
            GameObject e1 = Instantiate(eft, transform.position, transform.rotation);
            //产生一个这样的东西，etf，在unity中把这个物体给到eft这个，就会有相应到效果产生，这个是选择与子弹绑到一块的，实际上是自由的，此案例是这样绑定的
            Destroy(this.gameObject);
            Destroy(e1,1.5f);
        }
    }
}
