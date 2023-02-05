using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPicker : MonoBehaviour
{
    public Color[] availableColors;
    public Button colorButtonPrefab;

    private Color SelectedColor { get; set; }
    public System.Action<Color> OnColorChanged;

    private readonly List<Button> _mColorButtons = new List<Button>();

    public void Init()
    {
        foreach (var color in availableColors)
        {
            var newButton = Instantiate(colorButtonPrefab, transform);
            newButton.GetComponent<Image>().color = color;

            newButton.onClick.AddListener(() =>
            {
                SelectedColor = color;
                foreach (var button in _mColorButtons)
                {
                    button.interactable = true;
                }

                newButton.interactable = false;

                OnColorChanged.Invoke(SelectedColor);
            });

            _mColorButtons.Add(newButton);
        }
    }
}