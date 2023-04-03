using UnityEditor;
using UnityEngine;

public class MenuImmeuble00 : MonoBehaviour
{
    public GameObject MainMenuImmeuble00;
    public GameObject OptionsMenuImmeuble00;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MenuPrincipalPlayButton() // OK
    {
        Time.timeScale = 1.0f;
        MainMenuImmeuble00.SetActive(false);
        Cursor.visible = false;
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
        Debug.Log("From 'MenuPrincipalPlayButton', Cursor.lockState = " + Cursor.lockState);


    }

    public void MenuPrincipalOptionsButton()
    {
        //Debug.Log("MenuPrincipalOptionsButton Activated");
        OptionsMenuImmeuble00.SetActive(true);
        MainMenuImmeuble00.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        //UnityEngine.Cursor.lockState = CursorLockMode.Locked; // Curseur souris vérouillé, (bloqué au centre + caché)
        Debug.Log("From 'MenuPrincipalOptionsButton', Cursor.lockState = " + Cursor.lockState);
    }

    public void MenuPrincipalBackButton()
    {
        Debug.Log("MenuPrincipalBackButton Activated");
        OptionsMenuImmeuble00.SetActive(false);
        MainMenuImmeuble00.SetActive(true);
        //UnityEngine.Cursor.lockState = CursorLockMode.Locked; // Curseur souris vérouillé, (bloqué au centre + caché)
        Cursor.lockState = CursorLockMode.None;
        Debug.Log("From 'MenuPrincipalBackButton', Cursor.lockState = " + Cursor.lockState);
    }

    public void MenuPrincipalQuit()
    {
        Debug.Log("MenuPrincipalQuit Activated");
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit(); // original code to quit Unity player
        #endif
    }
}
