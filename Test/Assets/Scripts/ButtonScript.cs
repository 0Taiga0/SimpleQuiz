using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] GameManagerScript gameManagerScript;

    public void SetQuest()
    {
        gameManagerScript.SetQuestion();
    }

}
