using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "player")
        {
            other.GetComponent<Renderer>().material.color = Color.gray;
            other.attachedRigidbody.mass = 8f;
        }
    }
}
