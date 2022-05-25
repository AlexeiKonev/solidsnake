using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeController : MonoBehaviour
{
    public Transform head;

    //public Transform body;

    public Transform tail;

    

    public float moveSpeed=2f;

    public Rigidbody rb;

    public Stack<Tail> tailsList;




    void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        Rotation();

       
    }
    private void FixedUpdate()
    {
        rb.velocity =
       transform.forward *  moveSpeed*Time.deltaTime;
    }
    //public void SwapTail()
    //{
    //    tailsList.Push( prefBody);
    //    //save previous position of tail 
    //    var Temp = tail ;
    //    var newpos = new Vector3( Temp.position.x,Temp.position.y,Temp.position.z - 2);
    //    //move tail 
    //    Instantiate(prefBody, newpos, Temp.rotation);
    //    tail.position=new Vector3(tail.position.x,tail.position.y,tail.position.z-5f);
    //     rb.velocity=
    //    transform.forward* Time.deltaTime* moveSpeed;

    //}
    public void Rotation()
    {
        if(Input.GetAxis("Horizontal")>0)
        transform.Rotate(transform.rotation.x, transform.rotation.y+5, transform.rotation.z);
        if(Input.GetAxis("Horizontal")<0)
        transform.Rotate(transform.rotation.x, transform.rotation.y-5, transform.rotation.z);
    }
}
