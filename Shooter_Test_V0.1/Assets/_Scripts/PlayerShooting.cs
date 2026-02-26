using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
   
    public GameObject shootingPoint;
    
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            GameObject bullet = ObjectPool.SharedInstance.GetFirstPooledObject();
            bullet.layer = LayerMask.NameToLayer("Player Bullet");
            bullet.transform.position = shootingPoint.transform.position;
            bullet.transform.rotation = shootingPoint.transform.rotation;
            bullet.SetActive(true);
        }
    }


    
}
