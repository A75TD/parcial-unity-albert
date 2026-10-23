using UnityEngine;

// Igual que en clase: la camara no se mueve, solo gira para mirar siempre a la esfera.
public class CameraLookAt : MonoBehaviour
{
    [SerializeField] private Transform target;   // arrastra aqui la esfera
    [SerializeField] private float smoothing = 5f;

    void LateUpdate()
    {
        if (target == null) return;
        Quaternion wanted = Quaternion.LookRotation(target.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, wanted, smoothing * Time.deltaTime);
    }
}
