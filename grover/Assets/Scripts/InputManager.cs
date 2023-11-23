using UnityEngine;

public static class InputManager
{
    private static Controls _ctrls;

    private static Vector3 _mousePos;

    private static Camera cam;
    public static Ray GetCameraRay()
    {
        return cam.ScreenPointToRay(_mousePos);
    }

    public static void Init(Player p)
    {
        _ctrls = new();

        cam = Camera.main;
        Cursor.lockState = CursorLockMode.Confined;

        _ctrls.Permenanet.Enable();
        _ctrls.InGame.Movement.performed += jeff =>
        {
            p.SetMovementDirection(jeff.ReadValue<Vector3>());

        };
        _ctrls.InGame.Jump.started += jeff =>
        {
            p.Jump();
        };
        _ctrls.InGame.Look.performed += ctx =>
        {
            p.SetLookDirection(ctx.ReadValue<Vector2>());
        };


        _ctrls.InGame.Shoot.performed += ctx =>
        {
            p.Shoot();
        };
        _ctrls.Permenanet.MousePos.performed += ctx =>
        {
            _mousePos = ctx.ReadValue<Vector2>();
        };
        
    }
    
    
    public static void EnableInGame()
    {
        _ctrls.InGame.Enable();
    }
    public static void SetGameControls()
    {
        _ctrls.InGame.Enable();
        _ctrls.UI.Disable();
    }


    public static void SetUIControls()
    {
        _ctrls.UI.Enable();
        _ctrls.InGame.Enable();
    }
}
