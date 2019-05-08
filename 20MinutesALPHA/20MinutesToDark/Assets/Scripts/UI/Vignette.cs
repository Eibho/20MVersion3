using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vignette : MonoBehaviour
{
    public GameObject image;
    GameObject player;

    public float theDistance = 50;

    // Start is called before the first frame update
    void Start()
    {
       
        
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);

        if (distance <= theDistance)
        {
            image.SetActive(true);
        }
        else
            image.SetActive(false);
    }
}
