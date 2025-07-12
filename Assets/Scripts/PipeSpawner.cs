using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float spawnCD;
    public GameObject[] pipeVariants;

    private float startSpwanPipeCd;

    private void Start()
    {
        startSpwanPipeCd = spawnCD;
    }

    private void Update()
    {
        if (spawnCD <= 0)
        {
            var randomVariant = Random.Range(0,pipeVariants.Length);
            Vector3 pipeTransform = new Vector3(transform.position.x, pipeVariants[randomVariant].transform.position.y, transform.position.z);
            Instantiate(pipeVariants[randomVariant], pipeTransform, Quaternion.identity);
            spawnCD = startSpwanPipeCd -= 0.01f;
        }
        else 
        { 
            spawnCD -= Time.deltaTime; 
        }
    }
}
