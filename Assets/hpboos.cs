using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpboos : MonoBehaviour
{
    public GameObject boss;
    public float hp;
       
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Restarhp(float da�o)
    {
        hp -= da�o;
        
        if (hp <= 0)
        {
            
            Destroy(boss);

        }
    }
}
           

