using UnityEngine;

/// <summary>
/// Mail Script is added to the Mail button 
/// </summary>
public class MailScript : MonoBehaviour
{
    //To make the variable visible on Unity Editor we use SerializeField.
    [SerializeField]
    string emailID;
    [SerializeField]
    string subject;
    [SerializeField]
    string body;

    //OnMouseDown is a Unity Mouse Click function that is called when user clicks the GameObject with this script.
    //Note that the GameObject should have sometype of Collider for this script to work.
    private void OnMouseDown()
    {
        //subject and body both are converted and stored again to the same string
        subject = EscapeURL(subject);
        body = EscapeURL(body);

        //Application.OpenURL is used to Open an Link.
        //"mailto:" is used to say that we are trying to mail so that our device will open our default mailing application.
        Application.OpenURL("mailto:" + emailID + "?subject=" + subject + "&body=" + body);
    }

    //This function is create to replay "+" and change it to "%20"
    //Don't take this too seriously we will look into these kind of functions in Future.
    string EscapeURL(string url)
    {
        return WWW.EscapeURL(url).Replace("+", "%20");
    }
}
