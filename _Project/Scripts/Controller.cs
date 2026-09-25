using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour, InputSystem_Actions.IVectorsClassActions
{
    private InputSystem_Actions inputActions;

    private void Awake()
    {
        inputActions = new InputSystem_Actions();
        inputActions.VectorsClass.SetCallbacks(this);
    }

    private void OnEnable() => inputActions.Enable();
    private void OnDisable() => inputActions.Disable();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnOnJump(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }
}
