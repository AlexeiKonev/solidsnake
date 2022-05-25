using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailManager : MonoBehaviour
{
    public Stack<GameObject> tailStack = new Stack<GameObject>();
    public GameObject tail;
    public CharacterJoint tailJoint;
    void Start()
    {

        tailStack.Push(tail);
    }

     
    void Update()
    {
        
    }
    public void TailAdd()
    {
     GameObject baseTail= tailStack.Pop();
     Vector3 newPos=new Vector3(
         baseTail.transform.localPosition.x,
         baseTail.transform.localPosition.y,
         baseTail.transform.localPosition.z-5f
         );

     GameObject newTail= Instantiate(
         tail, 
         newPos, 
         baseTail.transform.localRotation
         );
        tailJoint = newTail.GetComponent<CharacterJoint>();
        tailJoint.connectedBody = baseTail.GetComponent<Rigidbody>();
        tailStack.Push(newTail);
    }
}
