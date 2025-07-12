using UnityEngine;

public class Pape : MonoBehaviour
{
    public static float speed;


    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < -5)
        {
            Destroy(gameObject);
        }
    }
}
