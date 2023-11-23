using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    [SerializeField] private WeaponBase myWeapon1 ;
    private Vector3 _moveDirection;
    [SerializeField] private float speed;
  
    [SerializeField] private float jumpForce;
    private Rigidbody rb;
    public bool isGrounded;
    private bool weaponShootToggle;

    [SerializeField, Range(1, 20)] private float mouseSensX;
    [SerializeField, Range(1, 20)] private float mouseSensY;

    [SerializeField] private Transform LookAtPoint;

    [SerializeField, Range(0, 180)] private float minViewAngle;
    [SerializeField, Range(0, 180)] private float maxViewAngle;

    private Vector2 currentRotation;
    private float depth;

    private void Start()
    {
        InputManager.Init(this);
        InputManager.EnableInGame();
        rb = GetComponent<Rigidbody>();

    }
    private void Update()
    {
        transform.position += transform.rotation * (speed * Time.deltaTime * _moveDirection);
        CheckGround();
    }



    public void Shoot()
    {



        print("I shot: " + InputManager.GetCameraRay());
        weaponShootToggle = !weaponShootToggle;
        if (weaponShootToggle) myWeapon1.StartShooting();
        else myWeapon1.StopShooting();



        



    }
    public void SetMovementDirection(Vector3 currentDirection)
    {
        _moveDirection = currentDirection;
    }
    public void Jump()
    {
        Debug.Log("Jump called");
        if (isGrounded)
        {
            Debug.Log("i jumped");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
    private void CheckGround()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, GetComponent<Collider>().bounds.size.y);
        Debug.DrawRay(transform.position, Vector3.down * GetComponent<Collider>().bounds.size.y, Color.green, duration: 0, depthTest: false);
    }

    internal void SetLookDirection(Vector2 readValue)
    {
        //controls rotation angles
        currentRotation.x += readValue.x * Time.deltaTime * mouseSensX;
        currentRotation.y += readValue.y * Time.deltaTime * mouseSensY;

        //rotates left and right
        transform.rotation = Quaternion.AngleAxis(currentRotation.x, Vector3.up);

        //clamp rotation angle 
        currentRotation.y = Mathf.Clamp(currentRotation.y, minViewAngle, maxViewAngle);

        //rotate up and down
        LookAtPoint.localRotation = Quaternion.AngleAxis(currentRotation.y, Vector3.right);
    }
}
