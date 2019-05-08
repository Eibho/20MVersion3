using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{
    GameObject monster;
    float theDistance = 50;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        monster = GameObject.FindGameObjectWithTag("Enemy");
        this.anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Flicker();
    }

    void Flicker()
    {
        float distance = Vector3.Distance(monster.transform.position, transform.position);

        if (distance < theDistance)
        {
            Debug.Log("Flicker");
            this.anim.SetBool("isFlicker", true);
        }
        else
            this.anim.SetBool("isFlicker", false);
    }
}
