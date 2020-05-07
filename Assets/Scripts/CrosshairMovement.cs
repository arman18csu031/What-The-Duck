using UnityEngine;
public class CrosshairMovement : MonoBehaviour
{
    private Camera Camera = null;

    public Joystick joystick;
    public float speed = 40.0f;
    private float Horizontalmov = 0f;
    private float Verticalmov = 0f;
    private void Start()
    {
        Camera = Camera.main;
    }
    private void Update()
    {
        /*if (joystick.Horizontal >= .2f)
        {
            Horizontalmov = speed;
        }
        else if (joystick.Horizontal <= .2f)
        {
            Horizontalmov = -speed;
        }
        else if(joystick.Vertical >= .2f)
        {
            Verticalmov = speed;
        }*/
           
        Vector2 mousePos = Camera.ScreenToWorldPoint(Input.mousePosition);
        Cursor.visible = mousePos.x < -8.5f || mousePos.x > 8.5f || mousePos.y < -3.5f || mousePos.y > 4.5f;
        transform.position = new Vector3(Mathf.Clamp(mousePos.x, -8.5f, 8.5f), Mathf.Clamp(mousePos.y, -3.5f, 4.5f));

    }
}
