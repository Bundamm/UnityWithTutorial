using UnityEngine;
using UnityEngine.SceneManagement;
public class KillScript : MonoBehaviour
{
    //[SerializeField] public GameObject player;
    //[SerializeField] public Transform respawnPoint;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
            
        }
    }
}