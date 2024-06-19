using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    public PlayerState playerState;
    public bool isGameFinish = false;
    public float playerSpeed = 15;
    public GameObject food;
    public GameObject foodSpawnPoint;
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
        if (!isGameFinish)
        {
            Strafe();
            if (TimeElapsed.instance.timeElapsed > 1)
                Throw();
        }
        else if (playerState != PlayerState.Finish)
        {
            animator.SetTrigger("GameEnd");
        }

    }
    private void Strafe()
    {
        horizontalInput = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.Translate(horizontalInput * Time.deltaTime * playerSpeed);
        animator.SetFloat("Strafe", horizontalInput.x);
    }
    private void Throw()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject throwable = Instantiate(food);
            throwable.transform.position = foodSpawnPoint.transform.position;
            throwable.GetComponent<Rigidbody>().AddForce(Vector3.forward * 500);
            if (playerState != PlayerState.Throw)
            {
                playerState = PlayerState.Throw;
                animator.SetTrigger("Throw");
            }
        }
    }
}
