using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public string promtMessage;
    //This function will be called from player  
    public void BaseInteract()
    {
        Interact();
    }


    protected virtual void Interact()
    {
        //template function
    }
}
