using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpenemigos : MonoBehaviour
{
    public GameObject expp;
    protected float da�o = 1f;
    public movplayer exp;
    [SerializeField] public float HP;
    public int experienceReward = 50;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public  void Tomarda�o(float da�o)
    {
        HP -= da�o;

        if (HP <= 0)
        {
            Muerte();
            
        }

    }

    protected virtual void Muerte()
    {
        gameObject.SetActive(false);
        exp.GainExperience(experienceReward);
        Debug.Log("exp recibida");
        exp.PrintInfo();
       
    }

}
