using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReduceAlpha : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().material.color = new Color(gameObject.GetComponent<SpriteRenderer>().material.color.r, gameObject.GetComponent<SpriteRenderer>().material.color.g, gameObject.GetComponent<SpriteRenderer>().material.color.b, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
