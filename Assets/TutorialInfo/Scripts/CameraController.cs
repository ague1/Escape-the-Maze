using UnityEngine;

public class CameraController : MonoBehaviour
{
    
    public Transform player; 
    private Vector3 offset = new Vector3(-0f, 3f, -4f);

    void LateUpdate()
    {
        if (player != null)
        {
            // La cámara se coloca detrás del jugador según su rotación
            transform.position = player.position + player.rotation * offset;

            // La cámara siempre mira al jugador 
            transform.LookAt(player);
        }
    }
}
