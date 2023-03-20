using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

#if UNITY_EDITOR
#endif

public class MyUIBehaviourScript : MonoBehaviour //Inherits from class `MonoBehaviour`. This makes it attachable to a game object as a component.
{
    private UIDocument _myUIBehaviourScript;
    Button scene1, scene2, scene3, sortie;

    #region OnEnable
    private void OnEnable()
    {
        _myUIBehaviourScript = GetComponent<UIDocument>();
        if (_myUIBehaviourScript == null)
        {
            Debug.Log("No '_myUIBehaviourScript' Document Found");
        }
        scene1 = _myUIBehaviourScript.rootVisualElement.Q(name: "ButtonScene1") as Button;
        if (scene1 != null)
        {
            Debug.Log("ButtonScene1 Found");
        }
        scene1.RegisterCallback<ClickEvent>(StartScene1);

        scene2 = _myUIBehaviourScript.rootVisualElement.Q(name: "ButtonScene2") as Button;
        if (scene2 != null)
        {
            Debug.Log("ButtonScene2 Found");
        }
        scene2.RegisterCallback<ClickEvent>(StartScene2);

        scene3 = _myUIBehaviourScript.rootVisualElement.Q(name: "ButtonScene3") as Button;
        if (scene3 != null)
        {
            Debug.Log("ButtonScene3 Found");
        }
        scene3.RegisterCallback<ClickEvent>(StartScene3);

        sortie = _myUIBehaviourScript.rootVisualElement.Q(name: "ButtonSortie") as Button;
        if (scene1 != null)
        {
            Debug.Log("ButtonSortie Found");
        }
        sortie.RegisterCallback<ClickEvent>(Exit);

    }
    #endregion OnEnable

    public void OnButtonClick(ClickEvent clickEvent)
    {
        Debug.Log("The UI Button has been clicked on successfully !");
    }

    public void StartScene1(ClickEvent clickEvent)
    {
        Debug.Log("Menu Start Chargement de la Scène 1 'Immeuble_00'");
        //_MenuUIHandler.StartScene1();
        SceneManager.LoadScene(1);
    }

    public void StartScene2(ClickEvent clickEvent)
    {
        Debug.Log("Menu Start Chargement de la Scène 2 'Immeuble_01'");
        //_MenuUIHandler.StartScene2();
        SceneManager.LoadScene(2);
    }

    public void StartScene3(ClickEvent clickEvent)
    {
        Debug.Log("Menu Start Chargement de la Scène 3 'Fast Food'");
        //_MenuUIHandler.StartScene3();
        SceneManager.LoadScene(3);
    }

    public void Exit(ClickEvent clickEvent)
    {
    #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
    #else
                Application.Quit(); // original code to quit Unity player
    #endif
    }
}