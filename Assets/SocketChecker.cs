using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketChecker : MonoBehaviour
{
    public XRSocketInteractor socket1;
    public XRSocketInteractor socket2;
    public XRSocketInteractor socket3;

    public GameObject requiredObject1;
    public GameObject requiredObject2;
    public GameObject requiredObject3;

    public UnityEvent onAllSocketsFilled;

    private void Update()
    {
        if (CheckSockets())
        {
            onAllSocketsFilled.Invoke();
        }
    }

    private bool CheckSockets()
    {
        // Check if each socket has the correct object
        bool socket1Filled = socket1.firstInteractableSelected != null && socket1.firstInteractableSelected.transform.gameObject == requiredObject1;
        bool socket2Filled = socket2.firstInteractableSelected != null && socket2.firstInteractableSelected.transform.gameObject == requiredObject2;
        bool socket3Filled = socket3.firstInteractableSelected != null && socket3.firstInteractableSelected.transform.gameObject == requiredObject3;

        return socket1Filled && socket2Filled && socket3Filled;
    }
}
