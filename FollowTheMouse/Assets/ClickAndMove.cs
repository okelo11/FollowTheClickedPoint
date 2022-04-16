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
        if (move == true) //baslangicta ekrana týklanmasa da hit.point=0,0,0 oldugu icin baslangýc hareketini engellemek adýna bool kullanildi
        transform.position = Vector3.MoveTowards(transform.position, hit.point, Time.fixedDeltaTime * speed);
        



    }


}

