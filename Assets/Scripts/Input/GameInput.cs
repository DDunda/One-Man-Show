//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Input/GameInput.inputactions
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

public partial class @GameInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInput"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""7484d10f-0d88-4af6-8332-6f0cf5d026eb"",
            ""actions"": [
                {
                    ""name"": ""LeftParry"",
                    ""type"": ""Button"",
                    ""id"": ""8aea6b45-c6b8-45a8-842d-a29d38378536"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RightParry"",
                    ""type"": ""Button"",
                    ""id"": ""fdb2decc-6656-4355-8aa6-788956e1bd2d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ForwardParry"",
                    ""type"": ""Button"",
                    ""id"": ""db298f4b-d482-49e0-b8f1-86d2b1e4e2ce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TESTPLAYERHIT"",
                    ""type"": ""Button"",
                    ""id"": ""f72b0171-710a-4aca-834d-537a7be318ac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e9e200b0-af1f-4c2c-be27-4d1211521f1c"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftParry"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4ed29ccd-4be5-4413-b4ce-843433e6fbfb"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftParry"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""efcd11b7-e453-4c58-8ce5-2c293e7ec9bc"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftParry"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""924db9af-58aa-468b-b92b-e3f2e02c4a09"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightParry"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3537bd2d-96e8-45c2-8360-eb238a506e29"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightParry"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2583e657-db54-4e21-aa05-026502383ece"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightParry"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""832479cd-3942-4b95-bab5-b1bd9c179481"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardParry"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a0def36-3d2a-47bb-8b83-a450e0869aee"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardParry"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd002cf1-bf37-4bfa-8e96-562538b4e08e"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardParry"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c3f4bd7-9f4f-47df-8c70-b80d357fe287"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TESTPLAYERHIT"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_LeftParry = m_Gameplay.FindAction("LeftParry", throwIfNotFound: true);
        m_Gameplay_RightParry = m_Gameplay.FindAction("RightParry", throwIfNotFound: true);
        m_Gameplay_ForwardParry = m_Gameplay.FindAction("ForwardParry", throwIfNotFound: true);
        m_Gameplay_TESTPLAYERHIT = m_Gameplay.FindAction("TESTPLAYERHIT", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private List<IGameplayActions> m_GameplayActionsCallbackInterfaces = new List<IGameplayActions>();
    private readonly InputAction m_Gameplay_LeftParry;
    private readonly InputAction m_Gameplay_RightParry;
    private readonly InputAction m_Gameplay_ForwardParry;
    private readonly InputAction m_Gameplay_TESTPLAYERHIT;
    public struct GameplayActions
    {
        private @GameInput m_Wrapper;
        public GameplayActions(@GameInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftParry => m_Wrapper.m_Gameplay_LeftParry;
        public InputAction @RightParry => m_Wrapper.m_Gameplay_RightParry;
        public InputAction @ForwardParry => m_Wrapper.m_Gameplay_ForwardParry;
        public InputAction @TESTPLAYERHIT => m_Wrapper.m_Gameplay_TESTPLAYERHIT;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void AddCallbacks(IGameplayActions instance)
        {
            if (instance == null || m_Wrapper.m_GameplayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Add(instance);
            @LeftParry.started += instance.OnLeftParry;
            @LeftParry.performed += instance.OnLeftParry;
            @LeftParry.canceled += instance.OnLeftParry;
            @RightParry.started += instance.OnRightParry;
            @RightParry.performed += instance.OnRightParry;
            @RightParry.canceled += instance.OnRightParry;
            @ForwardParry.started += instance.OnForwardParry;
            @ForwardParry.performed += instance.OnForwardParry;
            @ForwardParry.canceled += instance.OnForwardParry;
            @TESTPLAYERHIT.started += instance.OnTESTPLAYERHIT;
            @TESTPLAYERHIT.performed += instance.OnTESTPLAYERHIT;
            @TESTPLAYERHIT.canceled += instance.OnTESTPLAYERHIT;
        }

        private void UnregisterCallbacks(IGameplayActions instance)
        {
            @LeftParry.started -= instance.OnLeftParry;
            @LeftParry.performed -= instance.OnLeftParry;
            @LeftParry.canceled -= instance.OnLeftParry;
            @RightParry.started -= instance.OnRightParry;
            @RightParry.performed -= instance.OnRightParry;
            @RightParry.canceled -= instance.OnRightParry;
            @ForwardParry.started -= instance.OnForwardParry;
            @ForwardParry.performed -= instance.OnForwardParry;
            @ForwardParry.canceled -= instance.OnForwardParry;
            @TESTPLAYERHIT.started -= instance.OnTESTPLAYERHIT;
            @TESTPLAYERHIT.performed -= instance.OnTESTPLAYERHIT;
            @TESTPLAYERHIT.canceled -= instance.OnTESTPLAYERHIT;
        }

        public void RemoveCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameplayActions instance)
        {
            foreach (var item in m_Wrapper.m_GameplayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnLeftParry(InputAction.CallbackContext context);
        void OnRightParry(InputAction.CallbackContext context);
        void OnForwardParry(InputAction.CallbackContext context);
        void OnTESTPLAYERHIT(InputAction.CallbackContext context);
    }
}