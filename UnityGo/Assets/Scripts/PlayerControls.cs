// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerActionControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActionControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Land"",
            ""id"": ""8923272c-7285-48bf-b1ec-0d2c8ef773f5"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a161680a-b2b5-4fc9-b9bd-4a5afbc6b3cc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8b3bf489-e86d-4960-b1cd-66a95208196b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""70b13981-9ee5-4dca-a084-553c3dfa89f9"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Sideways"",
                    ""id"": ""b5a3c87a-60fb-46af-973a-8fcd8e42ab47"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""3bc68e2f-77b7-4171-aeaa-bc2ed06ac69a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e47bf248-2445-4157-baac-646a6f9039b9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Water"",
            ""id"": ""be165772-d74b-46d1-8b32-73759accccc2"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""021a2a88-ee5d-4002-99e8-3191c6dfdde2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ea5058c9-9876-4aad-b16d-3011e0ad2802"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""NextToWallR"",
            ""id"": ""0a759f0b-2cf6-45a5-ad60-c2e458993716"",
            ""actions"": [
                {
                    ""name"": ""HangOn"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4971e3e9-a3de-4672-aa60-84196f3e98e0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a68a7672-3cc7-4394-85d6-81a5cd15ca80"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""befb3d14-5eab-41b9-92bc-88d4deaf3aea"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HangOn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6243add3-88a7-4044-95be-dd428e15c259"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""NextToWallL"",
            ""id"": ""a0bb2d1c-1bfd-40bc-b098-e50a063d65d7"",
            ""actions"": [
                {
                    ""name"": ""HangOn"",
                    ""type"": ""PassThrough"",
                    ""id"": ""90266195-ebe6-4a40-be4e-1d14dcbefd7d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""32170615-be44-4dbd-924a-501f6296886f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""83492b97-ec14-4a4b-82fa-08c05c5e8813"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HangOn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""66f883f2-5152-44db-9b4a-9725be1f9272"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Land
        m_Land = asset.FindActionMap("Land", throwIfNotFound: true);
        m_Land_Move = m_Land.FindAction("Move", throwIfNotFound: true);
        m_Land_Jump = m_Land.FindAction("Jump", throwIfNotFound: true);
        // Water
        m_Water = asset.FindActionMap("Water", throwIfNotFound: true);
        m_Water_Newaction = m_Water.FindAction("New action", throwIfNotFound: true);
        // NextToWallR
        m_NextToWallR = asset.FindActionMap("NextToWallR", throwIfNotFound: true);
        m_NextToWallR_HangOn = m_NextToWallR.FindAction("HangOn", throwIfNotFound: true);
        m_NextToWallR_Jump = m_NextToWallR.FindAction("Jump", throwIfNotFound: true);
        // NextToWallL
        m_NextToWallL = asset.FindActionMap("NextToWallL", throwIfNotFound: true);
        m_NextToWallL_HangOn = m_NextToWallL.FindAction("HangOn", throwIfNotFound: true);
        m_NextToWallL_Jump = m_NextToWallL.FindAction("Jump", throwIfNotFound: true);
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

    // Land
    private readonly InputActionMap m_Land;
    private ILandActions m_LandActionsCallbackInterface;
    private readonly InputAction m_Land_Move;
    private readonly InputAction m_Land_Jump;
    public struct LandActions
    {
        private @PlayerActionControls m_Wrapper;
        public LandActions(@PlayerActionControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Land_Move;
        public InputAction @Jump => m_Wrapper.m_Land_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Land; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LandActions set) { return set.Get(); }
        public void SetCallbacks(ILandActions instance)
        {
            if (m_Wrapper.m_LandActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_LandActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_LandActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_LandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public LandActions @Land => new LandActions(this);

    // Water
    private readonly InputActionMap m_Water;
    private IWaterActions m_WaterActionsCallbackInterface;
    private readonly InputAction m_Water_Newaction;
    public struct WaterActions
    {
        private @PlayerActionControls m_Wrapper;
        public WaterActions(@PlayerActionControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Water_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Water; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WaterActions set) { return set.Get(); }
        public void SetCallbacks(IWaterActions instance)
        {
            if (m_Wrapper.m_WaterActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_WaterActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_WaterActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_WaterActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_WaterActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public WaterActions @Water => new WaterActions(this);

    // NextToWallR
    private readonly InputActionMap m_NextToWallR;
    private INextToWallRActions m_NextToWallRActionsCallbackInterface;
    private readonly InputAction m_NextToWallR_HangOn;
    private readonly InputAction m_NextToWallR_Jump;
    public struct NextToWallRActions
    {
        private @PlayerActionControls m_Wrapper;
        public NextToWallRActions(@PlayerActionControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @HangOn => m_Wrapper.m_NextToWallR_HangOn;
        public InputAction @Jump => m_Wrapper.m_NextToWallR_Jump;
        public InputActionMap Get() { return m_Wrapper.m_NextToWallR; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NextToWallRActions set) { return set.Get(); }
        public void SetCallbacks(INextToWallRActions instance)
        {
            if (m_Wrapper.m_NextToWallRActionsCallbackInterface != null)
            {
                @HangOn.started -= m_Wrapper.m_NextToWallRActionsCallbackInterface.OnHangOn;
                @HangOn.performed -= m_Wrapper.m_NextToWallRActionsCallbackInterface.OnHangOn;
                @HangOn.canceled -= m_Wrapper.m_NextToWallRActionsCallbackInterface.OnHangOn;
                @Jump.started -= m_Wrapper.m_NextToWallRActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_NextToWallRActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_NextToWallRActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_NextToWallRActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HangOn.started += instance.OnHangOn;
                @HangOn.performed += instance.OnHangOn;
                @HangOn.canceled += instance.OnHangOn;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public NextToWallRActions @NextToWallR => new NextToWallRActions(this);

    // NextToWallL
    private readonly InputActionMap m_NextToWallL;
    private INextToWallLActions m_NextToWallLActionsCallbackInterface;
    private readonly InputAction m_NextToWallL_HangOn;
    private readonly InputAction m_NextToWallL_Jump;
    public struct NextToWallLActions
    {
        private @PlayerActionControls m_Wrapper;
        public NextToWallLActions(@PlayerActionControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @HangOn => m_Wrapper.m_NextToWallL_HangOn;
        public InputAction @Jump => m_Wrapper.m_NextToWallL_Jump;
        public InputActionMap Get() { return m_Wrapper.m_NextToWallL; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NextToWallLActions set) { return set.Get(); }
        public void SetCallbacks(INextToWallLActions instance)
        {
            if (m_Wrapper.m_NextToWallLActionsCallbackInterface != null)
            {
                @HangOn.started -= m_Wrapper.m_NextToWallLActionsCallbackInterface.OnHangOn;
                @HangOn.performed -= m_Wrapper.m_NextToWallLActionsCallbackInterface.OnHangOn;
                @HangOn.canceled -= m_Wrapper.m_NextToWallLActionsCallbackInterface.OnHangOn;
                @Jump.started -= m_Wrapper.m_NextToWallLActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_NextToWallLActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_NextToWallLActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_NextToWallLActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HangOn.started += instance.OnHangOn;
                @HangOn.performed += instance.OnHangOn;
                @HangOn.canceled += instance.OnHangOn;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public NextToWallLActions @NextToWallL => new NextToWallLActions(this);
    public interface ILandActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IWaterActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface INextToWallRActions
    {
        void OnHangOn(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface INextToWallLActions
    {
        void OnHangOn(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
