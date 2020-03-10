using UnityEngine;

public class LinkScript : MonoBehaviour
{
    [SerializeField]
    string profileName;

    private void OnMouseDown()
    {
        Application.OpenURL("https://www.linkedin.com/in/" + profileName);
    }
}
