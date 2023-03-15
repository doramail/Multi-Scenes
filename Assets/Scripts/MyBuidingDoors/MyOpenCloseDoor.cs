using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

namespace SojaExiles

{
    public class MyOpenCloseDoor : MonoBehaviour
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
                                    Debug.Log("From MyOpenCloseDoor, OnMouseDown entered, play Closinging of the door");
                                    StartCoroutine(closing());
                                }
                            }
                        }
                    }
                }
            }
        }

        //void OnMouseOver()
        //{
        //	{
        //		if (Player)
        //		{
        //			float dist = Vector3.Distance(Player.position, transform.position);
        //			if (dist < 15)
        //			{
        //				if (open == false)
        //				{
        //					if (Input.GetMouseButtonDown(0))
        //					{
        //						StartCoroutine(opening());
        //					}
        //				}
        //				else
        //				{
        //					if (open == true)
        //					{
        //						if (Input.GetMouseButtonDown(0))
        //						{
        //							StartCoroutine(closing());
        //						}
        //					}

        //				}

        //			}
        //		}

        //	}

        //}

        IEnumerator opening()
        {
            print("you are opening the door");
            openandclose.Play("Opening");
            open = true;
            yield return new WaitForSeconds(.5f);
        }

        IEnumerator closing()
        {
            print("you are closing the door");
            openandclose.Play("Closing");
            open = false;
            yield return new WaitForSeconds(.5f);
        }


    }
}