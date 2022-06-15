using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramario : MonoBehaviour
{public float speed = 20;
    // Start is called before the first frame update
     public GameObject target ;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(target==null)
        return;
        transform.position=new Vector3(target.transform.position.x,
                                        transform.position.y,
                                         transform.position.z);
      
    }
}
