using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animal : MonoBehaviour
{
    public enum Type
    {
        CAT,
        DOG,
        COW
    }

    // POLYMORPHISM
    public virtual void Sound()
    {

    }

    // POLYMORPHISM
    public virtual void SetTextForSound()
    {

    }
}
