using UnityEngine;


public class PlayerController : MonoBehaviour
{
    
    public float health = 100f;

    public Camera camera;

    private Vector2 mousePosition;

    public Rigidbody2D rb;

    
    private void FixedUpdate()
    {
        MouseSlide();
    }
    public void MouseSlide()
    {
        mousePosition = camera.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookDir = mousePosition- rb.position;

        float angel = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;

    rb.rotation = angel;
    }
}
