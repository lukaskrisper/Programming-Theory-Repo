using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// INHERITANCE
public class Cow : Animal
{
    private Type animalType;
    [SerializeField] private Text cowText;

    // Start is called before the first frame update
    void Start()
    {
        animalType = Type.COW;
    }

    // POLYMORPHISM
    public override void Sound()
    {
        SetTextForSound(); // ENCAPSULATION
    }

    // POLYMORPHISM + ABSTRACTION
    public override void SetTextForSound()
    {
        cowText.GetComponent<Text>().text = "Mooow";
    }
}
