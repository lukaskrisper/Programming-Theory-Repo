using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// INHERITANCE
public class Cat : Animal
{
    private Type animalType;
    [SerializeField] private Text meowText;

    // Start is called before the first frame update
    void Start()
    {
        animalType = Type.CAT;
    }

    // POLYMORPHISM
    public override void Sound()
    {
        SetTextForSound(); // ENCAPSULATION
    }

    // POLYMORPHISM + ABSTRACTION
    public override void SetTextForSound()
    {
        meowText.GetComponent<Text>().text = "Meow";
    }
}
