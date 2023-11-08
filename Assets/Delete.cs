using UnityEngine;

public class Delete : MonoBehaviour
{
    void Update()
    {

        if(transform.position.y < -6f)
        Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }
}
