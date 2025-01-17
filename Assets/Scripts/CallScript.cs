﻿using UnityEngine;

/// <summary>
/// Call Script is added to the call button 
/// </summary>
public class CallScript : MonoBehaviour
{
    //To make the variable visible on Unity Editor we use SerializeField.
    //long is a dataType that can have more values than an int.
    [SerializeField]
    long MobileNumber = 7401386620;

    //OnMouseDown is a Unity Mouse Click function that is called when user clicks the GameObject with this script.
    //Note that the GameObject should have sometype of Collider for this script to work.
    private void OnMouseDown()
    {
        //Application.OpenURL is used to Open an Link.
        // tel:// is used to say that the link is not an web link but a telephone number.
        Application.OpenURL("tel://" + MobileNumber);
    }
}
