using TMPro;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    private string _name = "George";     // ENCAPSULATION

    private const int Age = 20;
    private Transform _chatBubble;
    protected TextMeshPro TextChat;

    private void Start()
    {
        _chatBubble = transform.Find("ChatBubble");
        TextChat = _chatBubble.Find("textChat").gameObject.GetComponent<TextMeshPro>();
    }

    // ABSTRACTION
    protected virtual void SaySomething()
    {
        var message = "Hey my name is " + _name + " and I'm " + Age + " years old.";
        TextChat.text = message;
    }

    private void OnMouseDown()
    {
        SaySomething();
    }

    // ENCAPSULATION
    public void SetName(string newName)   
    {
        _name = newName;
    }
}