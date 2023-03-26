using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySavedInfosScene1 : MonoBehaviour
{
    Vector3 _playerPosition;
    [SerializeField] float my_PlayerPositionx = 0;
    [SerializeField] float my_PlayerPositiony = 0;
    [SerializeField] float my_PlayerPositionz = 0;

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    private void Start()
    {
        _playerPosition = GetComponent<Transform>().position;
        Debug.Log("My Start = " + _playerPosition);
        //Debug.Log("_PlayerPosition = " + _playerPosition + "\n" + "_PlayerPosition.x = " + _playerPosition.x + "\n" + "_PlayerPosition.y = " + _playerPosition.y + "\n _PlayerPosition.z = " + _playerPosition.z);
        //PlayerPrefs.SetFloat(tag, _playerPosition.x);
        //PlayerPrefs.SetFloat(tag, _playerPosition.y);
        //PlayerPrefs.SetFloat(tag, _playerPosition.z);
        Debug.Log("From My Start - Hello World");
    }

    // Update is called once per frame
    private void Update()
    {
        //print("From Update - Hello World");

    }
}
