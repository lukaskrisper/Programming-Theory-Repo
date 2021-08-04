using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// INHERITANCE
public class Dog : Animal
{
    private Type animalType;
    [SerializeField] private Text dogText;

    // Start is called before the first frame update
    void Start()
    {
        animalType = Type.DOG;
    }

    // POLYMORPHISM
    public override void Sound()
    {
        SetTextForSound(); // ENCAPSULATION
    }

    // POLYMORPHISM + ABSTRACTION
    public override void SetTextForSound()
    {
        dogText.GetComponent<Text>().text = "Wuff";
    }
}
