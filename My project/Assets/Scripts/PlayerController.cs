using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forwardSpeed = 25f, strafeSpeed = 7.5f, hoverSpeed = 5f;
    private float activeForwardSpeed, activeStrafeSpeed, activeHoverSpeed;

    void Update()
    {
        activeForwardSpeed = Input.GetAxisRaw("Vertical") * forwardSpeed;
        activeStrafeSpeed = Input.GetAxisRaw("Horizontal") * strafeSpeed;
        activeHoverSpeed = Input.GetAxisRaw("Hover") * hoverSpeed;

        transform.position += (transform.forward * activeForwardSpeed + 
                               transform.right * activeStrafeSpeed + 
                               transform.up * activeHoverSpeed) * Time.deltaTime;
    }
}