using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    PlayerState playerState;
    public bool isGameFinish = false;
    public float playerSpeed = 15;
    private Vector3 horizontalInput;
    private Animator animator;
    private void Reset()
    {
        playerSpeed = 15;
    }
    private void Awake()
    {
        if (instance == null)
            instance = this;
        if (instance != this)
            Destroy(instance);
    }
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        Strafe();
    }
    private void Strafe()
    {
        horizontalInput = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.Translate(horizontalInput * Time.deltaTime * playerSpeed);
        animator.SetFloat("Strafe", horizontalInput.x);
    }

}
