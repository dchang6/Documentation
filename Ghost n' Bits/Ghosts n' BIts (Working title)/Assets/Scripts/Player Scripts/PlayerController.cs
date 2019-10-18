using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public CharacterController cc;
    private Rigidbody rb;
    public static Vector3 playerPos;
    private Vector3 movement;
    public float speed;
    private int count;

    void Start()
    {
        cc = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        count = 0;
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * speed;
        float moveVertical = Input.GetAxis("Vertical") * speed;

        Vector3 zMovement = transform.forward * moveVertical;
        Vector3 xMovement = transform.right * moveHorizontal;
        cc.SimpleMove(zMovement + xMovement);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            Time.timeScale = 0f;
            count = count + 1;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(false);
            Time.timeScale = 0f;
            count = count + 1;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}