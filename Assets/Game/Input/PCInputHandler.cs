using UnityEngine;

public class PCInputHandler : MonoBehaviour, IInputHandler
{
    private Player.Controller player;
    private InputManager inputManager;

    private void Start()
    {
        player = FindFirstObjectByType<Player.Controller>();
        inputManager = GetComponent<InputManager>();
    }
    private void Update()
    {
        RotateTurret();
    }

    public void RotateTurret()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10;
        player.RotateTurret(Camera.main.ScreenToWorldPoint(mousePos));
        //Debug.Log(Camera.main.ScreenToWorldPoint(mousePos));
        //Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        //Debug.Log(inputManager.cam.ScreenToWorldPoint(Input.mousePosition));
    }
}
