using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
#endif

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour //Inherits from class `MonoBehaviour`. This makes it attachable to a game object as a component.
{
    //public ColorPicker ColorPicker;

    //public void NewColorSelected(Color color)
    //{
    //    // add code here to handle when a color is selected
    //    MainManager.Instance.TeamColor = color;
    //}
    
    private void Start()
    {
        //ColorPicker.Init();
        ////this will call the NewColorSelected function when the color picker have a color button clicked.
        //ColorPicker.onColorChanged += NewColorSelected;
        //ColorPicker.SelectColor(MainManager.Instance.TeamColor);
    }

    //public void StartNew()
    //{
    //    Debug.Log("Menu Start Chargement de la Scène 1 'Immeuble_00'");
    //    SceneManager.LoadScene(1);
    //}

    public void StartScene1()
    {
        Debug.Log("Menu Start Chargement de la Scène 1 'Immeuble_00'");
        SceneManager.LoadScene(1);
    }

    public void StartScene2()
    {
        Debug.Log("Menu Start Chargement de la Scène 2 'Immeuble_01'");
        SceneManager.LoadScene(2);
    }
    public void StartScene3()
    {
        Debug.Log("Menu Start Chargement de la Scène 3 'Fast Food'");
        SceneManager.LoadScene(3);
    }

    //public void SaveColorClicked()
    //{
    //    MainManager.Instance.SaveColor();
    //}

    //public void LoadColorClicked()
    //{
    //    MainManager.Instance.LoadColor();
    //    ColorPicker.SelectColor(MainManager.Instance.TeamColor);
    //}

    public void Exit()
    {
        MainManager.Instance.SaveColor();

        #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        #else
                Application.Quit(); // original code to quit Unity player
        #endif
    }
}
