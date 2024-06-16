using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class habjefe : MonoBehaviour
{
    [SerializeField] private float da�o1;
    [SerializeField] private Vector2 tm�caja;
    [SerializeField] private Transform posicioncj;
    [SerializeField] private float tiempovd;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, tiempovd);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Golpe() 
    {
        Collider2D[] objetos = Physics2D.OverlapBoxAll(posicioncj.position, tm�caja, 0f);

        foreach(Collider2D colisiones in objetos) 
        {
        if(colisiones.CompareTag( "player"))
            {
                colisiones.GetComponent<hpjugador>().Tomarda�o(da�o1);

            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireCube(posicioncj.position, tm�caja);
    }
}
