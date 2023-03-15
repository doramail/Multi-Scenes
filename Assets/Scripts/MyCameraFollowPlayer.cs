using UnityEngine;

public class MyCameraFollowPlayer : MonoBehaviour
{
    [SerializeField] public Transform target;
    [SerializeField] public float smoothTime = 0.3f;
    [SerializeField] public Vector3 offset;
    [SerializeField] private Vector3 velocity = Vector3.zero;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LetsCameraFollow();
    }

    void LetsCameraFollow()
    {
        if (target != null)
        {
            Vector3 targetPosition = target.position + offset;
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        }

    }
}
