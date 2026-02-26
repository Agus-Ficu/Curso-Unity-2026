using System;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField]
    private float speed;
    
  
   

    

    // Update is called once per frame
    void Update()
    {
        transform.Translate( Vector3.forward * (speed * Time.deltaTime));
        
    }
}
