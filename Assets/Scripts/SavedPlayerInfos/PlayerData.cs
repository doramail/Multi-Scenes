using UnityEngine;
using UnityEngine.Events;


[CreateAssetMenu(menuName = "Scriptable Objects/Player Data")]

public class PlayerData : ScriptableObject
{
    [HideInInspector] public UnityEvent updated;

    // Video settings
    public int screenWidht = 1920;
    public int screenHeight = 1080;

    [Range(-80, 30)] public int soundVolume; // in (dB)
    public bool muteMusic;

    public PlayerPrefs playerPrefs;
    public AudioSettings audioSettings;
    public int _health;
    public int XP;
    [Range(0f, 100f)] public float speed; // permet de limiter la valeur de speed.

    public int health
    {
        get { return _health; }
        set
        {
            _health = value;
            if (_health < 0) _health = 0;
            else if (_health > 100) _health = 100;
        }
    }

    private void OnEnable() // Called when the instance is setup.
    {
        if (updated == null)
        {
            updated = new UnityEvent();
        }
    }

    private void OnValidate() // Called when any value is changed in the inspector.
    {
        updated.Invoke();

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
