using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityScript : MonoBehaviour
{
    public float startSpeed = 50f;

    void Start()     // Start is called before the first frame update
    {
        Rigidbody rigidBody = GetComponent<Rigidbody> () ;
        rigidBody.velocity = new Vector3(startSpeed, 0, startSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
