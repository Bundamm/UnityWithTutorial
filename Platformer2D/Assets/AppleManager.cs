using TMPro;
using UnityEngine;

public class AppleManager : MonoBehaviour
{
    public int appleCount;
    public TextMeshProUGUI appleText;
    void FixedUpdate()
    {
        countApples();
        appleText.text = "Remaining apples: " + appleCount.ToString();
    }

    private int countApples()
    {
        GameObject[] apples = GameObject.FindGameObjectsWithTag("Apple");
        appleCount = apples.Length;
        return appleCount;
    } 
}
