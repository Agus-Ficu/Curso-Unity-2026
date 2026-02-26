using UnityEngine;

public class Life : MonoBehaviour
{
    [SerializeField]
    private float amount;

    public float Amount
    {
        get => amount;
        set
        {
            amount=value;
            if (amount <= 0)
            {
                Invoke("PlayParticleSystem",1f);
                Animator animator = GetComponentInChildren<Animator>();
                animator.SetTrigger("Die");
                Destroy(gameObject,2f);
            }
        }
    }

    void PlayParticleSystem()
    {
        ParticleSystem explosion = GetComponentInChildren<ParticleSystem>();
        explosion.Play();
    }
}
