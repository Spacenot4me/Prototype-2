using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject prefabThrow;
    
    private float speed = 25f;
    private float horizontalInput;
    private float x_Boundaries = 15f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -x_Boundaries)
        {
            transform.position = new Vector3(-x_Boundaries, transform.position.y, transform.position.z);
        }

        if (transform.position.x > x_Boundaries)
        {
            transform.position = new Vector3(x_Boundaries, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space)){
            Instantiate(prefabThrow, transform.position, prefabThrow.transform.rotation);
        }

        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);


    }
}
