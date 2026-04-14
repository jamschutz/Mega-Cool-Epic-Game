using UnityEngine;

public class Yay : MonoBehaviour
{
    private void Start()
    {
        InvokeRepeating(nameof(FindSmileys), 5, 5);
    }


    private void FindSmileys()
    {
        var smileys = GameObject.FindGameObjectsWithTag("smiley");
        // yay :)
    }
}
