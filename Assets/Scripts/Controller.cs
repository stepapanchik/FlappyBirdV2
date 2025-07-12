using System.IO.Pipes;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    [SerializeField] private float jumpSpeed;
    [SerializeField] private float rotatePower;

    [SerializeField] public float speedPipe;

    public AudioClip jumpSound;
    public AudioClip dead;

    public GameObject gameOverMenu;

    private AudioSource audioSource;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();

        Pape.speed = speedPipe;
    }

    private void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began || Input.GetMouseButtonDown(0))
        {
            rb.linearVelocity = Vector2.up * jumpSpeed;

            if (jumpSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(jumpSound);
            }
        }
    

        transform.eulerAngles = new Vector3 (0, 0,rb.linearVelocity.y * rotatePower);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.PlayOneShot(dead);
        Time.timeScale = 0f;
        gameOverMenu.SetActive(true);
    }
}
