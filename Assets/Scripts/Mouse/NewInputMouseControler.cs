using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;

public class NewInputMouseControler : MonoBehaviour, 
             IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler, IPointerDownHandler,
             IPointerUpHandler, IPointerMoveHandler, IPointerCaptureEvent, IMouseCaptureEvent, 
             /*IMouseEvent,*/ IMouseEventUnit
{
    [SerializeField] private Vector2 deplacementPointer;
    private MyDefaultInputActions _myInputAction;
    private Camera _camera;

    private void Awake()
    {
        _myInputAction = new MyDefaultInputActions();
        _myInputAction.Player.Fire.started += MouseClick;
        _myInputAction.Player.MousePosition.performed += MousePosition;
        _camera = Camera.main;
    }
    //public EventModifiers modifiers => throw new System.NotImplementedException();
    public void MousePosition(InputAction.CallbackContext context)
    {
        deplacementPointer = context.ReadValue<Vector2>();
        //Debug.Log("MousePosition"); OK
    }

    public void MouseClick(InputAction.CallbackContext context)
    {
        Debug.Log("Left button MouseClick"); // OK
        Debug.Log("From MouseClick function, DeplacementPointer = " + deplacementPointer);
        int numberOfCamerasInScene = Camera.allCamerasCount;
        Debug.Log("Nombre de Caméras présentes dans la scène = " + numberOfCamerasInScene);
        Ray _ray = _camera.ScreenPointToRay(deplacementPointer);
        //_ = Camera.main.gameObject.name;
        //Debug.Log("Nom de l'objet rattaché = " + Camera.main.gameObject.name); // OK

        RaycastHit hit;
        if (Physics.Raycast(_ray, out hit, 20))
        {
            //Debug.Log("Inside Raycast OK"); // OK
            Debug.DrawLine(_ray.origin, hit.point, Color.red, 3);
            if(hit.collider != null) // Si on touche quelque chose
            {
                Debug.Log("GameObject Touché par le RayCast = " + hit.collider.transform.gameObject.name);
            }
        }
    }

    private void OnEnable()
    {
        _myInputAction.Player.Enable();
    }

    public void OnDisable()
    {
        _myInputAction.Player.Disable();
    }


    //public Vector2 mousePosition => throw new System.NotImplementedException();

    //public Vector2 localMousePosition => throw new System.NotImplementedException();

    //public Vector2 mouseDelta => throw new System.NotImplementedException();

    //public int clickCount => throw new System.NotImplementedException();

    //public int button => throw new System.NotImplementedException();

    //public int pressedButtons => throw new System.NotImplementedException();

    //public bool shiftKey => throw new System.NotImplementedException();

    //public bool ctrlKey => throw new System.NotImplementedException();

    //public bool commandKey => throw new System.NotImplementedException();

    //public bool altKey => throw new System.NotImplementedException();

    //public bool actionKey => throw new System.NotImplementedException();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        //if (eventData.button == PointerEventData.InputButton.Left)
        {
            print(" Bouton gauche de la souris appuyé !");
        }
        print("OnPointerClick Activated !");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        //if (eventData.button == PointerEventData.InputButton.Left)
        {
            print("OnPointerDown Down");
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        print("OnPointerEnter activated !");

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        print("OnPointerExit Exit");
    }

    public void OnPointerMove(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        print("OnPointerMove Move");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        print("OnPointerUp Up");
    }
}
