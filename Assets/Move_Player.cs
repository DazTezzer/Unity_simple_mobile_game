using UnityEngine;
using UnityEngine.UI;

public class Move_Player : MonoBehaviour
{
    private float speed = 10f;
    public Text Count;
    public Transform player;
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.x = mousePos.x > 2.5f ? 2.5f : mousePos.x;
        mousePos.x = mousePos.x < -2.5f ? -2.5f : mousePos.x;
        player.position = Vector2.MoveTowards(player.position, new Vector2(mousePos.x, player.position.y), speed * Time.deltaTime);

    }

}
