// GENERATED AUTOMATICALLY FROM 'Assets/Drone Components/DroneController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @DroneController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @DroneController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DroneController"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""8a4c461d-2d10-43db-9727-e195c313db99"",
            ""actions"": [
                {
                    ""name"": ""X_Neg"",
                    ""type"": ""PassThrough"",
                    ""id"": ""fa2d4588-f645-4a85-9f93-3a632deade5b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""X_Pos"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a26d5dd4-1bd5-4e0c-b581-eeb9f00cb8d0"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Y_Neg"",
                    ""type"": ""PassThrough"",
                    ""id"": ""cac0dad2-5f8a-4e60-a667-8c60dd9285a7"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Y_Pos"",
                    ""type"": ""PassThrough"",
                    ""id"": ""05b16ab4-e6eb-408d-aee8-563667c4c141"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Z_Pos"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0813fc62-35b1-48bf-b679-d49137de94f7"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Z_Neg"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5dff8174-b71e-4529-9bfe-a68fc8c33454"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5a176517-9214-48d2-88f8-4e9931713e15"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""General Gamepad"",
                    ""action"": ""X_Neg"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a0425c8-c931-49c0-9d0e-a0f91c685fc0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""X_Neg"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dad3d6c5-25e3-42a0-9de4-825f8a38d591"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""General Gamepad"",
                    ""action"": ""X_Pos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""62636ecd-06e1-42c0-b7eb-18175871de77"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""X_Pos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1e3490f3-c624-4ee9-9c99-360401358d24"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""General Gamepad"",
                    ""action"": ""Y_Neg"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be6a747c-07b9-47f6-a56d-0eaea7952c3d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Y_Neg"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac25abba-7b82-4dab-b87c-71a013502223"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""General Gamepad"",
                    ""action"": ""Y_Pos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7cf304f6-24b0-4da0-a887-d27a5c871029"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Y_Pos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2eb17a19-3e10-4c84-9040-0f569193253c"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Z_Pos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7d7d66cc-e855-4085-9abc-787010fa2beb"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Z_Pos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef644c3d-eb64-43bc-9e0b-fccce550be3d"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Z_Neg"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce8da2fd-1c69-43ec-8f40-d93b491723ec"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Z_Neg"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""General Gamepad"",
            ""bindingGroup"": ""General Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_X_Neg = m_Gameplay.FindAction("X_Neg", throwIfNotFound: true);
        m_Gameplay_X_Pos = m_Gameplay.FindAction("X_Pos", throwIfNotFound: true);
        m_Gameplay_Y_Neg = m_Gameplay.FindAction("Y_Neg", throwIfNotFound: true);
        m_Gameplay_Y_Pos = m_Gameplay.FindAction("Y_Pos", throwIfNotFound: true);
        m_Gameplay_Z_Pos = m_Gameplay.FindAction("Z_Pos", throwIfNotFound: true);
        m_Gameplay_Z_Neg = m_Gameplay.FindAction("Z_Neg", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_X_Neg;
    private readonly InputAction m_Gameplay_X_Pos;
    private readonly InputAction m_Gameplay_Y_Neg;
    private readonly InputAction m_Gameplay_Y_Pos;
    private readonly InputAction m_Gameplay_Z_Pos;
    private readonly InputAction m_Gameplay_Z_Neg;
    public struct GameplayActions
    {
        private @DroneController m_Wrapper;
        public GameplayActions(@DroneController wrapper) { m_Wrapper = wrapper; }
        public InputAction @X_Neg => m_Wrapper.m_Gameplay_X_Neg;
        public InputAction @X_Pos => m_Wrapper.m_Gameplay_X_Pos;
        public InputAction @Y_Neg => m_Wrapper.m_Gameplay_Y_Neg;
        public InputAction @Y_Pos => m_Wrapper.m_Gameplay_Y_Pos;
        public InputAction @Z_Pos => m_Wrapper.m_Gameplay_Z_Pos;
        public InputAction @Z_Neg => m_Wrapper.m_Gameplay_Z_Neg;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @X_Neg.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnX_Neg;
                @X_Neg.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnX_Neg;
                @X_Neg.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnX_Neg;
                @X_Pos.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnX_Pos;
                @X_Pos.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnX_Pos;
                @X_Pos.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnX_Pos;
                @Y_Neg.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnY_Neg;
                @Y_Neg.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnY_Neg;
                @Y_Neg.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnY_Neg;
                @Y_Pos.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnY_Pos;
                @Y_Pos.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnY_Pos;
                @Y_Pos.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnY_Pos;
                @Z_Pos.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnZ_Pos;
                @Z_Pos.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnZ_Pos;
                @Z_Pos.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnZ_Pos;
                @Z_Neg.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnZ_Neg;
                @Z_Neg.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnZ_Neg;
                @Z_Neg.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnZ_Neg;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @X_Neg.started += instance.OnX_Neg;
                @X_Neg.performed += instance.OnX_Neg;
                @X_Neg.canceled += instance.OnX_Neg;
                @X_Pos.started += instance.OnX_Pos;
                @X_Pos.performed += instance.OnX_Pos;
                @X_Pos.canceled += instance.OnX_Pos;
                @Y_Neg.started += instance.OnY_Neg;
                @Y_Neg.performed += instance.OnY_Neg;
                @Y_Neg.canceled += instance.OnY_Neg;
                @Y_Pos.started += instance.OnY_Pos;
                @Y_Pos.performed += instance.OnY_Pos;
                @Y_Pos.canceled += instance.OnY_Pos;
                @Z_Pos.started += instance.OnZ_Pos;
                @Z_Pos.performed += instance.OnZ_Pos;
                @Z_Pos.canceled += instance.OnZ_Pos;
                @Z_Neg.started += instance.OnZ_Neg;
                @Z_Neg.performed += instance.OnZ_Neg;
                @Z_Neg.canceled += instance.OnZ_Neg;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    private int m_GeneralGamepadSchemeIndex = -1;
    public InputControlScheme GeneralGamepadScheme
    {
        get
        {
            if (m_GeneralGamepadSchemeIndex == -1) m_GeneralGamepadSchemeIndex = asset.FindControlSchemeIndex("General Gamepad");
            return asset.controlSchemes[m_GeneralGamepadSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnX_Neg(InputAction.CallbackContext context);
        void OnX_Pos(InputAction.CallbackContext context);
        void OnY_Neg(InputAction.CallbackContext context);
        void OnY_Pos(InputAction.CallbackContext context);
        void OnZ_Pos(InputAction.CallbackContext context);
        void OnZ_Neg(InputAction.CallbackContext context);
    }
}
