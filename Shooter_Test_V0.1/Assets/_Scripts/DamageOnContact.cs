using System;
using UnityEngine;

public class DamageOnContact : MonoBehaviour
{
    [SerializeField]
    float damage;
    
    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
        
        Life life = other.GetComponent<Life>();
        if (life != null)
        {
            life.Amount -= damage;
        }
        
        
        
    }
}
