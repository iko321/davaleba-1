using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xora : MonoBehaviour
     { public GameObject hjhh;
     public float speed;
 public Vector2 ghg;
    

     // Update is called once per frame
          void Update()
          {
         if(Input.GetKey(KeyCode.Space)){


 Instantiate(hjhh, ghg, Quaternion.identity); 



          }
         }  
}
