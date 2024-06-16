using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hpjugador : MonoBehaviour
{
    public GameObject player;
    [SerializeField] public float hp;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();   
    }
    public void Tomarda�o(float da�o) 
    {
        hp -= da�o;
        Debug.Log("da�o");
        if(hp <= 0) 
        {
            player.tag = new("muerto");
            Invoke("muerte", 3);
            anim.SetTrigger("die");
            player.GetComponent<movplayer>().enabled = false;
            
            player.GetComponent<mel�>().enabled = false;
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void muerte() 
    {
        SceneManager.LoadScene("lose");
    }
}
