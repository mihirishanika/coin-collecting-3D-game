using UnityEngine;
using UnityEngine.UI; // For UI updates (optional)

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float horizontalSpeed = 5f;
    public int health = 3;
    public int score = 0;

    public Text scoreText; // Assign in Inspector
    public Text healthText; // Assign in Inspector
    public GameObject gameOverPanel; // Assign in Inspector

    private void Start()
    {
        UpdateUI();
        gameOverPanel.SetActive(false);
    }

    void Update()
    {
        // Automatic forward movement
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        // Left/Right input
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * horizontalSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            score++;
            Destroy(other.gameObject);
            UpdateUI();
        }
        else if (other.CompareTag("Barrier"))
        {
            health--;
            Destroy(other.gameObject);
            UpdateUI();

            if (health <= 0)
            {
                GameOver();
            }
        }
    }

    void UpdateUI()
    {
        if (scoreText != null) scoreText.text = "Score: " + score;
        if (healthText != null) healthText.text = "Health: " + health;
    }

    void GameOver()
    {
        moveSpeed = 0;
        horizontalSpeed = 0;
        if (gameOverPanel != null)
            gameOverPanel.SetActive(true);
        Debug.Log("Game Over!");
    }
}
