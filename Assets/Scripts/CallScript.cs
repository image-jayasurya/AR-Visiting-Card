using UnityEngine;

public class CallScript : MonoBehaviour
{
    [SerializeField]
    long MobileNumber = 7401386620;

    private void OnMouseDown()
    {
        Application.OpenURL("tel://" + MobileNumber); //tel://7401386620
    }
}
