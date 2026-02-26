using UnityEngine;

public class WaveGenerator : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Delay between spawnings")]
    private float delay = 1f;
    
    [SerializeField]
    [Tooltip("Start and end time to spawn")]
    private float startTime, endTime;
    
    [SerializeField]
    [Tooltip("Prefab to spawn")]
    private GameObject prefab;
    
    
    
    void Start()
    {
        InvokeRepeating("Spawn", startTime, delay);
        Invoke("CancelInvoke", endTime);
    }

    void Spawn()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
    
    
    
}
