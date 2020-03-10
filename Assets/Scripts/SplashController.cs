using System.Collections;
using UnityEngine;

//--- Scene Management is used to Access Load Scene Function ---//
using UnityEngine.SceneManagement;


public class SplashController : MonoBehaviour
{
    [SerializeField, Range(1f, 5f)]
    int waitTime;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene("VisitingCard");
    }
}
