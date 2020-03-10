using UnityEngine;

public class MailScript : MonoBehaviour
{
    [SerializeField]
    string emailID;
    [SerializeField]
    string subject;
    [SerializeField]
    string body;

    private void OnMouseDown()
    {
        subject = EscapeURL(subject);
        body = EscapeURL(body);
        Application.OpenURL("mailto:" + emailID + "?subject=" + subject + "&body=" + body);
    }

    string EscapeURL(string url)
    {
        return WWW.EscapeURL(url).Replace("+", "%20");
    }
}
