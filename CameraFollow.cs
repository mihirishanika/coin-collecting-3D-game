using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;         // Drag your Player here
    public Vector3 offset;           // Offset from player to camera

    void Start()
    {
        // Save initial offset at start
        offset = transform.position - player.position;
    }

    void LateUpdate()
    {
        if (player != null)
        {
            transform.position = player.position + offset;
        }
    }
}
