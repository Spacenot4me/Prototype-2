using Unity.Burst;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    private float fwdZAxisBound = 30f;
    private float backZAxisBound = -10f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > fwdZAxisBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < backZAxisBound)
        {
            Destroy(gameObject);
        }
    }
}
