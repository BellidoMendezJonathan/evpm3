using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batbullet : MonoBehaviour
{
    [SerializeField] public float HP;
    public hpjugador hj;
    public float da�o = 10f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void Tomarda�o(float da�o)
    {
        HP -= da�o;

        if (HP <= 0)
        {
            Muerte();

        }

    }
    public void Muerte()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            hj.Tomarda�o(da�o);
            Destroy(gameObject);
        }
    }
}
