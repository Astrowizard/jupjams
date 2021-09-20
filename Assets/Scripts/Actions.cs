// GENERATED AUTOMATICALLY FROM 'Assets/Actions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Actions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Actions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Actions"",
    ""maps"": [
        {
            ""name"": ""Camera"",
            ""id"": ""34e623b9-110f-4efe-ae09-dbeaffff035f"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""5e0880c3-ab93-4bc6-9e87-8f7667d18cc8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""de34abdd-b60a-490a-a506-04ef1129b601"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Scroll"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2a4e705e-edc0-45b9-96e0-d90c53438b03"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""f0b0ac11-1295-45ee-95e3-752a7b1fa37a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reset"",
                    ""type"": ""Button"",
                    ""id"": ""ed88e187-2f94-4e48-847d-96c8adcadffd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""wasd"",
                    ""id"": ""ba4dc48a-34fa-4655-9043-c13660b4057a"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ed2b2c4c-cbdd-4052-8b66-da87a7af49a6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""632e74b9-dabd-47f4-bfde-2cf3a9d81b73"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d8bbafe6-aec8-4468-bae1-78a97fc6b7ea"",
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
                    ""id"": ""e40e9c9b-73c9-410f-8853-f8c8166b9bf4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4c258a2b-7179-4ead-8b34-106a2e68620d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2d0dd17f-5efb-4712-a81b-69c1bd9d7225"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""e8771112-f39f-4ddf-9034-8768b72bd727"",
                    ""path"": ""1DAxis(whichSideWins=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scroll"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5063d456-882b-48d7-b209-666b46a5cbcd"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""082dcbf2-f19b-4d5d-a970-f15ff3967224"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c3dcecd4-4451-458a-be01-02263fffd81a"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c105404-a1e6-4816-8021-711a329c7daa"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Ship"",
            ""id"": ""48c2aa68-073f-4895-a2e3-4f9614caffec"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""a392e255-0877-4cd3-9e0e-1701ec71f54b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""b0522014-1348-4bc2-b9aa-883ba1ee91df"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Go"",
                    ""type"": ""Button"",
                    ""id"": ""2673e8d0-21a4-414e-b98e-94f9f155c3ed"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Button"",
                    ""id"": ""876fef97-e82f-42a3-aa0e-571c782a16d1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reset"",
                    ""type"": ""Button"",
                    ""id"": ""85d91124-06b9-44d9-a7ce-81690faa3423"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Circularize"",
                    ""type"": ""Button"",
                    ""id"": ""e694a82a-c355-45f0-866a-27b6ce0a2ded"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Change Weapon"",
                    ""type"": ""Button"",
                    ""id"": ""3159ee79-c3be-4396-a06f-8063ee888809"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""301637c1-a4e9-4319-a5d0-111eb9d2d772"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""1093b852-21fd-479d-b98b-c3495ec3167c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""723e6c4b-3c31-42cf-b238-de9a06f51414"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""21b9075f-d1f4-4fd6-b4a5-b9fcc444b048"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""99f93d44-bb46-4320-8c1f-bf3109d9b3ac"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Go"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0eb4907b-9677-497e-864c-ffc8835c6b5e"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""931ef3ec-95de-4c07-a0fb-22f6ea7d4274"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Circularize"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""30ecccc6-dc97-4496-8b1f-d66b8501045a"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change Weapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_Movement = m_Camera.FindAction("Movement", throwIfNotFound: true);
        m_Camera_Shoot = m_Camera.FindAction("Shoot", throwIfNotFound: true);
        m_Camera_Scroll = m_Camera.FindAction("Scroll", throwIfNotFound: true);
        m_Camera_Menu = m_Camera.FindAction("Menu", throwIfNotFound: true);
        m_Camera_Reset = m_Camera.FindAction("Reset", throwIfNotFound: true);
        // Ship
        m_Ship = asset.FindActionMap("Ship", throwIfNotFound: true);
        m_Ship_Movement = m_Ship.FindAction("Movement", throwIfNotFound: true);
        m_Ship_Fire = m_Ship.FindAction("Fire", throwIfNotFound: true);
        m_Ship_Go = m_Ship.FindAction("Go", throwIfNotFound: true);
        m_Ship_Zoom = m_Ship.FindAction("Zoom", throwIfNotFound: true);
        m_Ship_Reset = m_Ship.FindAction("Reset", throwIfNotFound: true);
        m_Ship_Circularize = m_Ship.FindAction("Circularize", throwIfNotFound: true);
        m_Ship_ChangeWeapon = m_Ship.FindAction("Change Weapon", throwIfNotFound: true);
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

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_Movement;
    private readonly InputAction m_Camera_Shoot;
    private readonly InputAction m_Camera_Scroll;
    private readonly InputAction m_Camera_Menu;
    private readonly InputAction m_Camera_Reset;
    public struct CameraActions
    {
        private @Actions m_Wrapper;
        public CameraActions(@Actions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Camera_Movement;
        public InputAction @Shoot => m_Wrapper.m_Camera_Shoot;
        public InputAction @Scroll => m_Wrapper.m_Camera_Scroll;
        public InputAction @Menu => m_Wrapper.m_Camera_Menu;
        public InputAction @Reset => m_Wrapper.m_Camera_Reset;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnMovement;
                @Shoot.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnShoot;
                @Scroll.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnScroll;
                @Scroll.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnScroll;
                @Scroll.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnScroll;
                @Menu.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnMenu;
                @Reset.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnReset;
                @Reset.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnReset;
                @Reset.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnReset;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Scroll.started += instance.OnScroll;
                @Scroll.performed += instance.OnScroll;
                @Scroll.canceled += instance.OnScroll;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
                @Reset.started += instance.OnReset;
                @Reset.performed += instance.OnReset;
                @Reset.canceled += instance.OnReset;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);

    // Ship
    private readonly InputActionMap m_Ship;
    private IShipActions m_ShipActionsCallbackInterface;
    private readonly InputAction m_Ship_Movement;
    private readonly InputAction m_Ship_Fire;
    private readonly InputAction m_Ship_Go;
    private readonly InputAction m_Ship_Zoom;
    private readonly InputAction m_Ship_Reset;
    private readonly InputAction m_Ship_Circularize;
    private readonly InputAction m_Ship_ChangeWeapon;
    public struct ShipActions
    {
        private @Actions m_Wrapper;
        public ShipActions(@Actions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Ship_Movement;
        public InputAction @Fire => m_Wrapper.m_Ship_Fire;
        public InputAction @Go => m_Wrapper.m_Ship_Go;
        public InputAction @Zoom => m_Wrapper.m_Ship_Zoom;
        public InputAction @Reset => m_Wrapper.m_Ship_Reset;
        public InputAction @Circularize => m_Wrapper.m_Ship_Circularize;
        public InputAction @ChangeWeapon => m_Wrapper.m_Ship_ChangeWeapon;
        public InputActionMap Get() { return m_Wrapper.m_Ship; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShipActions set) { return set.Get(); }
        public void SetCallbacks(IShipActions instance)
        {
            if (m_Wrapper.m_ShipActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnMovement;
                @Fire.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnFire;
                @Go.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnGo;
                @Go.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnGo;
                @Go.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnGo;
                @Zoom.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnZoom;
                @Reset.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnReset;
                @Reset.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnReset;
                @Reset.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnReset;
                @Circularize.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnCircularize;
                @Circularize.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnCircularize;
                @Circularize.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnCircularize;
                @ChangeWeapon.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnChangeWeapon;
                @ChangeWeapon.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnChangeWeapon;
                @ChangeWeapon.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnChangeWeapon;
            }
            m_Wrapper.m_ShipActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Go.started += instance.OnGo;
                @Go.performed += instance.OnGo;
                @Go.canceled += instance.OnGo;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
                @Reset.started += instance.OnReset;
                @Reset.performed += instance.OnReset;
                @Reset.canceled += instance.OnReset;
                @Circularize.started += instance.OnCircularize;
                @Circularize.performed += instance.OnCircularize;
                @Circularize.canceled += instance.OnCircularize;
                @ChangeWeapon.started += instance.OnChangeWeapon;
                @ChangeWeapon.performed += instance.OnChangeWeapon;
                @ChangeWeapon.canceled += instance.OnChangeWeapon;
            }
        }
    }
    public ShipActions @Ship => new ShipActions(this);
    public interface ICameraActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnScroll(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
        void OnReset(InputAction.CallbackContext context);
    }
    public interface IShipActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnGo(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
        void OnReset(InputAction.CallbackContext context);
        void OnCircularize(InputAction.CallbackContext context);
        void OnChangeWeapon(InputAction.CallbackContext context);
    }
}
