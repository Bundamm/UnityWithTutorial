using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyBox : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Reference to apple manager for apple count.")]
    private AppleManager appleManager;

    void FixedUpdate()
    {
        // Deactivates box after collecting all apples on the current scene
        if (appleManager.appleCount <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }
}