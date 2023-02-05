using UnityEngine;

// INHERITANCE
public class BrotherFree : Character
{
    // POLYMORPHISM
    protected override void SaySomething()
    {
        TextChat.text = "Hello, I'm a Free Character!";
    }

    public void SetColor(Color color)
    {
        // Find a child of the character with name "Template_Character"
        var t = transform.Find("Player/Template_Character");
        Debug.Log(t.GetComponent<Renderer>().material.color.ToString());
        t.GetComponent<Renderer>().material.color = color;
    }
}