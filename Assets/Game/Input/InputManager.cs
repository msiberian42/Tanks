using UnityEngine;

public enum InputType
{
    PC
}

public class InputManager : MonoBehaviour
{
    [SerializeField] private InputType inputType;
    [SerializeField] private Camera _cam;

    public Camera cam => _cam;

    private IInputHandler inputHandler;

    private void Awake()
    {
        switch (inputType)
        {
            case InputType.PC:
                inputHandler = gameObject.AddComponent<PCInputHandler>();
                break;
            default:
                break;
        }
    }
}
