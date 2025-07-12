using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score;
    public TMP_Text scoreText;

    public AudioClip point;
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Update()
    {
        scoreText.text = score.ToString();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.CompareTag("Score"))
         {
            Score.score++;
            audioSource.PlayOneShot(point);
         }
    }
}
