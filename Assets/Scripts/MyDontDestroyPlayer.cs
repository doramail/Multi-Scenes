using UnityEngine;

public class MyDontDestroyPlayer : MonoBehaviour //Inherits from class `MonoBehaviour`. This makes it attachable to a game object as a component.
{
    public static MyDontDestroyPlayer instance;
    // Start is called before the first frame update
    void Start()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
            return;
        }
        instance = this;
        GameObject.DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
