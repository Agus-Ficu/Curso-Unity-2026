using UnityEngine;

public class Autodestroy : MonoBehaviour
{
    [SerializeField] private float destructionDelay;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        //Destroy(gameObject, destructionDelay);

        Invoke("HideObject",destructionDelay);
    }
    
    void HideObject()
    {
        gameObject.SetActive(false);
    }
  
}
