using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tail : MonoBehaviour
{
   public bool Connected=false;
    CharacterJoint joint;
    private void Awake()
    {
        joint = GetComponent<CharacterJoint>();
        joint.connectedBody = GameObject.Find("Tail").GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
