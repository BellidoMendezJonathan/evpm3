using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float HP;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Tomarda�o(float da�o)
    {
        HP -= da�o;

        if(HP <=0)
        {
            Muerte();
        }

    }

    private void Muerte() 
    {
        anim.SetTrigger("die");
    }
}
