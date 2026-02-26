using System;
using UnityEngine;

public class CollectPotion : MonoBehaviour
{
    [SerializeField]
    [Tooltip("The amount of life that the potion gives when collected")]
    private float providedLife;
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MeshRenderer mr = GetComponent<MeshRenderer>();
            mr.enabled = false;
            ParticleSystem explosionCloud = GetComponent<ParticleSystem>();
            explosionCloud.Play();
            AudioSource collectSound = GetComponent<AudioSource>();
            collectSound.Play();
            Destroy(transform.parent.gameObject,0.5f);
            
            Life life = other.GetComponent<Life>();
            if (life != null)
            {
                life.Amount += 30;
            }
            

        }
    }
}
