using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace SojaExiles

{
	public class opencloseStallDoor : MonoBehaviour
    {
        public Animator openandclose;
        public bool open;
        public Transform Player;

        void Start()
        {
            open = false;
        }

        private void OnMouseDown()
        {
            {
                if (Player)
                {
                    float dist = Vector3.Distance(Player.position, transform.position);
                    if (dist < 15)
                    {
                        if (open == false)
                        {
                            //Mouse.current.leftButton.ReadValueFromEvent<>
                            if (Mouse.current.leftButton.wasPressedThisFrame)
                            {
                                // Code lors du clic gauche sur la souris
                                Debug.Log("From MyOpenCloseDoor, OnMouseDown entered, play opening of the door");
                                StartCoroutine(opening());
                            }
                        }
                        else
                        {
                            if (open == true)
                            {
                                if (Mouse.current.leftButton.wasPressedThisFrame)
                                {
                                    // Code lors du clic gauche sur la souris
                                    Debug.Log("From MyOpenCloseDoor, OnMouseDown entered, play Closing of the door");
                                    StartCoroutine(closing());
                                }
                            }
                        }
                    }
                }
            }
        }

        IEnumerator opening()
        {
            print("My you are opening the door");
            openandclose.Play("OpeningStall");
            open = true;
            yield return new WaitForSeconds(.5f);
        }

        IEnumerator closing()
        {
            print("My you are closing the door");
            openandclose.Play("ClosingStall");
            open = false;
            yield return new WaitForSeconds(.5f);
        }


    }

    //{

    //	public Animator openandclose;
    //	public bool open;
    //	public Transform Player;

    //	void Start()
    //	{
    //		open = false;
    //	}

    //	void OnMouseOver()
    //	{
    //		{
    //			if (Player)
    //			{
    //				float dist = Vector3.Distance(Player.position, transform.position);
    //				if (dist < 15)
    //				{
    //					if (open == false)
    //					{
    //						if (Input.GetMouseButtonDown(0))
    //						{
    //							StartCoroutine(opening());
    //						}
    //					}
    //					else
    //					{
    //						if (open == true)
    //						{
    //							if (Input.GetMouseButtonDown(0))
    //							{
    //								StartCoroutine(closing());
    //							}
    //						}

    //					}

    //				}
    //			}

    //		}

    //	}

    //	IEnumerator opening()
    //	{
    //		print("you are opening the door");
    //		openandclose.Play("OpeningStall");
    //		open = true;
    //		yield return new WaitForSeconds(.5f);
    //	}

    //	IEnumerator closing()
    //	{
    //		print("you are closing the door");
    //		openandclose.Play("ClosingStall");
    //		open = false;
    //		yield return new WaitForSeconds(.5f);
    //	}


    //}
}