using UnityEngine;
using UnityEngine.SceneManagement;
public class KillScript : MonoBehaviour
{
    [SerializeField] public GameObject player;
    [SerializeField] public Transform respawnPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Scene currentScene = SceneManager.GetActiveScene();
            // SceneManager.LoadScene(currentScene.name);
            player.transform.position = respawnPoint.position;
        }
    }
}