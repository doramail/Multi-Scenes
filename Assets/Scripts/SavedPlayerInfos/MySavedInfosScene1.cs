using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class MySavedInfosScene1 : MonoBehaviour
{
    Vector3 _playerPosition;
    [SerializeField] float my_PlayerPositionx = 0;
    [SerializeField] float my_PlayerPositiony = 0;
    [SerializeField] float my_PlayerPositionz = 0;
    public Transform Player;
    //public TextMeshProUGUI helperText;

    private void Awake()
    {
        _playerPosition = GetComponent<Transform>().position;
        my_PlayerPositionx = _playerPosition.x;
        my_PlayerPositionx = _playerPosition.y;
        my_PlayerPositionx = _playerPosition.z;
        LoadPosition();
        Debug.Log("From AWAKE _PlayerPosition = " + _playerPosition + "\n" + "_PlayerPosition.x = " + my_PlayerPositionx + "\n" + "_PlayerPosition.y = " + my_PlayerPositiony + "\n _PlayerPosition.z = " + my_PlayerPositionz);
    }

    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        //print("From Update - Hello World");
        // StartCoroutine(SavePosition());
        my_PlayerPositionx = _playerPosition.x;
        my_PlayerPositionx = _playerPosition.y;
        my_PlayerPositionx = _playerPosition.z;
        Debug.Log("From Update function = " + _playerPosition);
        PlayerPrefs.SetFloat("my_PlayerPositionx", my_PlayerPositionx);
        PlayerPrefs.SetFloat("my_PlayerPositiony", my_PlayerPositiony);
        PlayerPrefs.SetFloat("my_PlayerPositionz", my_PlayerPositionz);
        SavePosition();
    }

    private void OnMouseDown()
    {
        if (!enabled) return;
        if (Player)
        {
            Debug.Log("from MySavedInfosScene1, Player OK");
            if (Mouse.current.middleButton.isPressed)
            {
                Debug.Log("From MySavedInfosScene1, OnMouseDown entered, Right Clicked ?");
                StartCoroutine(SaveInfos());
            }
        }
    }

    IEnumerator SaveInfos()
    {
        print("Right button Mouse Clicked");
        yield return new WaitForSeconds(.5f);
    }

    public void SavePosition()
    {
        Debug.Log("From Start function = " + _playerPosition);
        PlayerPrefs.SetFloat("my_PlayerPositionx", my_PlayerPositionx);
        PlayerPrefs.SetFloat("my_PlayerPositiony", my_PlayerPositiony);
        PlayerPrefs.SetFloat("my_PlayerPositionz", my_PlayerPositionz);
        //helperText.text = "new Player Position Saved";
    }

    public void LoadPosition()
    {
        Player.transform.position = new Vector3(PlayerPrefs.GetFloat("my_PlayerPositionx"), PlayerPrefs.GetFloat("my_PlayerPositiony"), PlayerPrefs.GetFloat("my_PlayerPositionz"));
        Debug.Log("LoadPosition = " + Player.transform.position);
        //helperText.text = "Player Position Loaded";
    }

}
