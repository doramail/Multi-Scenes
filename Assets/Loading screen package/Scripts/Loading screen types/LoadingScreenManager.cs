using UnityEngine;

public class LoadingScreenManager : MonoBehaviour
{
    private Animator _animatorComponent;

    private void Start()
    {
        _animatorComponent = transform.GetComponent<Animator>();  

        // Remove it if you don't want to hide it in the Start function and call it elsewhere
        HideLoadingScreen();
    }

    public void RevealLoadingScreen()
    {
        _animatorComponent.SetTrigger("Reveal");
    }

    public void HideLoadingScreen()
    {
        // Call this function, if you want start hiding the loading screen
        _animatorComponent.SetTrigger("Hide");
    }

    public void OnFinishedReveal() // TODO: You have to remove it's content, and load your own scene here. !!
    {
        // transform.parent.GetComponent<DemoSceneManager>().OnLoadingScreenRevealed(); // Orignal deactivated byME
    }

    public void OnFinishedHide()  // You have to remove it's content and call functions which you want to be called after the loading screen is revealed.
    {
        // transform.parent.GetComponent<DemoSceneManager>().OnLoadingScreenHided();  // Orignal deactivated byME
    }

}
