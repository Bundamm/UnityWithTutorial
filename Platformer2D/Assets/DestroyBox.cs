using UnityEngine;

public class DestroyBox : MonoBehaviour
{
    public AppleManager appleManager;
    void Update()
    {
        if (appleManager.appleCount == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
