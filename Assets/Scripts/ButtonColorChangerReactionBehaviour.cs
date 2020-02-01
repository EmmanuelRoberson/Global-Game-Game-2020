using INterfaces;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColorChangerReactionBehaviour : MonoBehaviour, IReactable
{
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
    }

    public void React()
    {
        if (button.colors.normalColor == Color.green)
        {
            ColorBlock newColors = button.colors;
            newColors.normalColor = Color.blue;
            newColors.highlightedColor = Color.gray;
            button.colors = newColors;
        }
        else
        {
            ColorBlock newColors = button.colors;
            newColors.normalColor = Color.green;
            newColors.highlightedColor = Color.gray;
            button.colors = newColors;
        }
    }

}
