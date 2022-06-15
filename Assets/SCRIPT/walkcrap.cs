using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkcrap : MonoBehaviour

    
{
     public float speed = -1;
      public float force = 300;
      public GameObject mario;
      public int score=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
    }
}
 void OnCollisionEnter2D(Collision2D target) 
     { 
     if(target.gameObject.name.StartsWith("mario") )
     {
         score=score+1;
        Destroy(target.gameObject); 
            
        Debug.Log(score); 
       
                   
                    
     } 

    }
}