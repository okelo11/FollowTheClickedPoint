using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndMove : MonoBehaviour
{
    RaycastHit hit;
    public float distance=100f;
    public float speed = 3f;
    Vector3 temp;
    public bool move=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetMouseButtonDown(0))
        { 
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out hit, distance);      
         temp = hit.point-transform.position;
         move = true;

        }
        if (move == true) //Even if you don't click at the begining,the hit.point is (0,0,0).So bool move is used to avoid this case.
        transform.position = Vector3.MoveTowards(transform.position, hit.point, Time.fixedDeltaTime * speed);
        



    }


}

