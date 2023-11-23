//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Scripts/Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Controls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""InGame"",
            ""id"": ""af89a6d8-06a9-43a6-8ef1-54a218216a33"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""type"": ""PassThrough"",
                    ""id"": ""daca5b6c-a432-412b-84d0-1ecdf8ddc1df"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""332e40fd-c777-48da-b59a-f606dc736e3c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Weapon1"",
                    ""type"": ""Button"",
                    ""id"": ""c1503b4c-15cb-4930-9741-303a2fe4ed47"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Weapon2"",
                    ""type"": ""Button"",
                    ""id"": ""62bfed1d-8834-4404-abff-139f004954f1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8198742e-e45a-4a27-b53a-1c5a5cdda809"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""78781dda-f968-4e9c-b386-126be2a68a6e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0b20df96-0e4c-44b9-a908-91d6bb17483d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6795d53b-4c77-4c2a-996f-1b08db15dd57"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f67e6b9-cf5f-4b76-8d0b-595c1b4ac74b"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ac709bb-d990-4bfe-85bc-e6caf5bbf3bd"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Weapon1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a4cceb6c-f65f-40e8-8e08-ed29bf6175fd"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Weapon2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b870872b-c19b-460d-b775-51f9ce6c69dd"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""a384bb1a-1bd6-4c7c-8730-50b77fe86864"",
                    ""path"": ""3DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8aae1fbd-b846-4910-a439-fee8d9296a2e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e28e1fa3-030d-4c29-80cc-b58ac52ea55b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""forward"",
                    ""id"": ""e951afd6-0e96-4170-a4fc-dab60077e2c5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""backward"",
                    ""id"": ""1d35da81-c82d-499b-b31d-d546965e5bf4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9f7000d1-9b05-409a-9a69-ff4cfb85a80c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""41cf7694-c17d-4a2e-a160-fbc332fa5c8f"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Permenanet"",
            ""id"": ""8a05f712-4fac-43bf-82ab-5cb828d08c7b"",
            ""actions"": [
                {
                    ""name"": ""MousePos"",
                    ""type"": ""PassThrough"",
                    ""id"": ""60539386-db1f-4c0d-81f0-651d7745845d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""29d64221-5988-4e23-8285-35d1a567aa09"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""08eac1a2-038e-4c50-98a0-1df632a8b2f5"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""b7ee0015-a310-4925-a9b1-19aa5ac710cc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""94a0f5d5-4e19-42e6-9c07-749f5a201202"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // InGame
        m_InGame = asset.FindActionMap("InGame", throwIfNotFound: true);
        m_InGame_Shoot = m_InGame.FindAction("Shoot", throwIfNotFound: true);
        m_InGame_Reload = m_InGame.FindAction("Reload", throwIfNotFound: true);
        m_InGame_Weapon1 = m_InGame.FindAction("Weapon1", throwIfNotFound: true);
        m_InGame_Weapon2 = m_InGame.FindAction("Weapon2", throwIfNotFound: true);
        m_InGame_Movement = m_InGame.FindAction("Movement", throwIfNotFound: true);
        m_InGame_Jump = m_InGame.FindAction("Jump", throwIfNotFound: true);
        m_InGame_Look = m_InGame.FindAction("Look", throwIfNotFound: true);
        // Permenanet
        m_Permenanet = asset.FindActionMap("Permenanet", throwIfNotFound: true);
        m_Permenanet_MousePos = m_Permenanet.FindAction("MousePos", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Newaction = m_UI.FindAction("New action", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // InGame
    private readonly InputActionMap m_InGame;
    private IInGameActions m_InGameActionsCallbackInterface;
    private readonly InputAction m_InGame_Shoot;
    private readonly InputAction m_InGame_Reload;
    private readonly InputAction m_InGame_Weapon1;
    private readonly InputAction m_InGame_Weapon2;
    private readonly InputAction m_InGame_Movement;
    private readonly InputAction m_InGame_Jump;
    private readonly InputAction m_InGame_Look;
    public struct InGameActions
    {
        private @Controls m_Wrapper;
        public InGameActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_InGame_Shoot;
        public InputAction @Reload => m_Wrapper.m_InGame_Reload;
        public InputAction @Weapon1 => m_Wrapper.m_InGame_Weapon1;
        public InputAction @Weapon2 => m_Wrapper.m_InGame_Weapon2;
        public InputAction @Movement => m_Wrapper.m_InGame_Movement;
        public InputAction @Jump => m_Wrapper.m_InGame_Jump;
        public InputAction @Look => m_Wrapper.m_InGame_Look;
        public InputActionMap Get() { return m_Wrapper.m_InGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InGameActions set) { return set.Get(); }
        public void SetCallbacks(IInGameActions instance)
        {
            if (m_Wrapper.m_InGameActionsCallbackInterface != null)
            {
                @Shoot.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnShoot;
                @Reload.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnReload;
                @Reload.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnReload;
                @Reload.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnReload;
                @Weapon1.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnWeapon1;
                @Weapon1.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnWeapon1;
                @Weapon1.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnWeapon1;
                @Weapon2.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnWeapon2;
                @Weapon2.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnWeapon2;
                @Weapon2.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnWeapon2;
                @Movement.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnJump;
                @Look.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnLook;
            }
            m_Wrapper.m_InGameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Reload.started += instance.OnReload;
                @Reload.performed += instance.OnReload;
                @Reload.canceled += instance.OnReload;
                @Weapon1.started += instance.OnWeapon1;
                @Weapon1.performed += instance.OnWeapon1;
                @Weapon1.canceled += instance.OnWeapon1;
                @Weapon2.started += instance.OnWeapon2;
                @Weapon2.performed += instance.OnWeapon2;
                @Weapon2.canceled += instance.OnWeapon2;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
            }
        }
    }
    public InGameActions @InGame => new InGameActions(this);

    // Permenanet
    private readonly InputActionMap m_Permenanet;
    private IPermenanetActions m_PermenanetActionsCallbackInterface;
    private readonly InputAction m_Permenanet_MousePos;
    public struct PermenanetActions
    {
        private @Controls m_Wrapper;
        public PermenanetActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MousePos => m_Wrapper.m_Permenanet_MousePos;
        public InputActionMap Get() { return m_Wrapper.m_Permenanet; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PermenanetActions set) { return set.Get(); }
        public void SetCallbacks(IPermenanetActions instance)
        {
            if (m_Wrapper.m_PermenanetActionsCallbackInterface != null)
            {
                @MousePos.started -= m_Wrapper.m_PermenanetActionsCallbackInterface.OnMousePos;
                @MousePos.performed -= m_Wrapper.m_PermenanetActionsCallbackInterface.OnMousePos;
                @MousePos.canceled -= m_Wrapper.m_PermenanetActionsCallbackInterface.OnMousePos;
            }
            m_Wrapper.m_PermenanetActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MousePos.started += instance.OnMousePos;
                @MousePos.performed += instance.OnMousePos;
                @MousePos.canceled += instance.OnMousePos;
            }
        }
    }
    public PermenanetActions @Permenanet => new PermenanetActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Newaction;
    public struct UIActions
    {
        private @Controls m_Wrapper;
        public UIActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_UI_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface IInGameActions
    {
        void OnShoot(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
        void OnWeapon1(InputAction.CallbackContext context);
        void OnWeapon2(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
    }
    public interface IPermenanetActions
    {
        void OnMousePos(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
