using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Banana;
    void Start()
    {
        StartCoroutine(SpawnB ());
    }

    IEnumerator SpawnB ()
    {
        while (true)
        {
            Instantiate(Banana, new Vector2(Random.Range(-2.5f, 2.5f), 5.9f), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
        }
    }
}
