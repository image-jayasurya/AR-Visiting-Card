using UnityEngine;

/// <summary>
/// LinkedIn Link Script is added to the LinkedIn button 
/// </summary>
public class LinkedInLinkScript : MonoBehaviour
{
    //To make the variable visible on Unity Editor we use SerializeField.
    [SerializeField]
    string LinkedInprofileName;

    //OnMouseDown is a Unity Mouse Click function that is called when user clicks the GameObject with this script.
    //Note that the GameObject should have sometype of Collider for this script to work.
    private void OnMouseDown()
    {
        //Application.OpenURL is used to Open an Link.
        //https://www.linkedin.com/in/ is common prefix for all linkedIn profiles in India.
        Application.OpenURL("https://www.linkedin.com/in/" + LinkedInprofileName);
    }
}
