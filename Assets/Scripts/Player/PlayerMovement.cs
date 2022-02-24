using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float maxMoveSpeed;
    [SerializeField] private Vector2 movement;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
   

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = movement * moveSpeed * Time.fixedDeltaTime; 
    }

    public void IncreaseSpeed(float bonus)
    {
        moveSpeed += bonus;
        if(moveSpeed >= maxMoveSpeed)
        {
            moveSpeed = maxMoveSpeed;
        }
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();        
    }
}
