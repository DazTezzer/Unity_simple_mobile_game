using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text Count;
    int a = 0;
    void OnTriggerEnter2D(Collider2D other)
    {
        a++;
        Count.text = a.ToString();
    }
}
