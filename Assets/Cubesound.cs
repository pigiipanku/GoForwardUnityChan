using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubesound : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collider other)
    {
        if (other.gameObject.tag == "GroundTag"|| other.gameObject.tag == "BlockTag")
        {
            GameObject.Find("CubeGenerator").GetComponent<AudioSource>().Play();
        }
    }
}
