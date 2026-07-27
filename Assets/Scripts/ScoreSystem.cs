using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    private int score = 0;
    public void DieEnemy()
    {
        score += 100;
        SetText();
    }
    public void SetText()
    {
        Text text = GetComponent<Text>();
        text.text = $"{score:00000}";
    }
}
