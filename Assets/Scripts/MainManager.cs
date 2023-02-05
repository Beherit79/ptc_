using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance { get; private set; }
    public Color teamColor = Color.white;
    public Character[] characters = new Character[2];

    // Create instance of the MainManager
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Loop through all characters and invoke the SetColor method if it exists
    // Overkill, but this example demonstrate of how to use reflection
    public void OnColorChanged(Color color)
    {
        foreach (var character in characters)
        {
            var setColorMethod = character.GetType().GetMethod("SetColor");
            if (setColorMethod != null)
            {
                setColorMethod.Invoke(character, new object[] { color });
            }
        }
    }
}