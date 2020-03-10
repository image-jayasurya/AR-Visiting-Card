using System.Collections;
using UnityEngine;

//--- Scene Management is used to Access Load Scene Function ---//
using UnityEngine.SceneManagement;

/// <summary>
/// This is added to the Splash Canvas in the Splas Scene
/// </summary>
public class SplashController : MonoBehaviour
{
    //To make the variable visible on Unity Editor we use SerializeField.
    //Range is used to Insert a Scroll bar to adjust the value. Just Show off Code :P
    [SerializeField, Range(1f, 5f)]
    int waitTime;

    //IEnumerator is a function that allows us to wait and execute the reset of the code after waiting.
    //This function will wait for the waitTime and them load the VisitingCard Scene.
    IEnumerator Start()
    {
        //Waits for the seconds mentioned in WaitTime. 
        yield return new WaitForSeconds(waitTime);
        //Loads the VisitingCard Scene
        SceneManager.LoadScene("VisitingCard");
    }
}
