// GENERATED AUTOMATICALLY FROM 'Assets/Controller/Controller.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ControllerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ControllerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controller"",
    ""maps"": [
        {
            ""name"": ""PlayerControllerInput"",
            ""id"": ""6bbc62ad-7ed4-414c-8df9-e3259e048908"",
            ""actions"": [
                {
                    ""name"": ""Player1Moving"",
                    ""type"": ""PassThrough"",
                    ""id"": ""03d6469c-8d23-4be1-95dd-16090a99a525"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Player2Moving"",
                    ""type"": ""PassThrough"",
                    ""id"": ""fff7f6bf-970a-41c0-8e4b-92bd93e28e4b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""aButton"",
                    ""type"": ""Button"",
                    ""id"": ""e13fb491-5c1a-40cf-9548-0804ee9d4e00"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""bButton"",
                    ""type"": ""Button"",
                    ""id"": ""f3ae5531-18be-4988-9f1d-84e62830161e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""xButton"",
                    ""type"": ""Button"",
                    ""id"": ""a73f747c-4860-4f78-9f31-5f4fa99793ec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""yButton"",
                    ""type"": ""Button"",
                    ""id"": ""d4594b98-0e79-40f4-a67b-546d69b8b8e7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""leftBumper"",
                    ""type"": ""Button"",
                    ""id"": ""b4ad89df-23d3-4393-b124-9afa0c069255"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""rightBumper"",
                    ""type"": ""Button"",
                    ""id"": ""4a852bc1-df5a-42ad-b7cd-3f4d3a820425"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""leftTrigger"",
                    ""type"": ""Button"",
                    ""id"": ""1f35b95a-65be-497c-93ab-aa54368ec3af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""rightTrigger"",
                    ""type"": ""Button"",
                    ""id"": ""a8cb0bd8-4c36-4d1d-a971-30bd84b309ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""leftStickClick"",
                    ""type"": ""Button"",
                    ""id"": ""121b0f96-9f04-4cef-a2c2-a665d7449192"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""rightStickClick"",
                    ""type"": ""Button"",
                    ""id"": ""84066d23-a519-4c09-ade8-45f35be53718"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cdea4a68-8418-49d9-8c8d-d50ab558e5ca"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player1Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac21ecd8-dcfd-417d-977f-1a7ff6c793fc"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player2Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1fe1c3e4-9609-48c4-9c37-aab7850af0b0"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""aButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9b05f5a3-4cca-43f5-8443-c8aec71b7e09"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""bButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e648b6d1-c11a-4e3b-abce-2f326fc6f788"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""xButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ea99252-e42c-4e55-83bc-1349c5b57c3b"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""yButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e1262a9-032c-46a2-b364-dfe07938afc3"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""leftBumper"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d351506f-7a4f-4983-b2c4-0dc672f2cedc"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rightBumper"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2622f5be-9500-4442-a50f-f3278f661863"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""leftTrigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3460d411-a2c0-424f-8ef8-93e2396a209e"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rightTrigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c774f673-e627-4a22-9890-9d3d4b9b3cbe"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""leftStickClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20301890-8228-437f-bcd4-054c043aa6c6"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rightStickClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerControllerInput
        m_PlayerControllerInput = asset.FindActionMap("PlayerControllerInput", throwIfNotFound: true);
        m_PlayerControllerInput_Player1Moving = m_PlayerControllerInput.FindAction("Player1Moving", throwIfNotFound: true);
        m_PlayerControllerInput_Player2Moving = m_PlayerControllerInput.FindAction("Player2Moving", throwIfNotFound: true);
        m_PlayerControllerInput_aButton = m_PlayerControllerInput.FindAction("aButton", throwIfNotFound: true);
        m_PlayerControllerInput_bButton = m_PlayerControllerInput.FindAction("bButton", throwIfNotFound: true);
        m_PlayerControllerInput_xButton = m_PlayerControllerInput.FindAction("xButton", throwIfNotFound: true);
        m_PlayerControllerInput_yButton = m_PlayerControllerInput.FindAction("yButton", throwIfNotFound: true);
        m_PlayerControllerInput_leftBumper = m_PlayerControllerInput.FindAction("leftBumper", throwIfNotFound: true);
        m_PlayerControllerInput_rightBumper = m_PlayerControllerInput.FindAction("rightBumper", throwIfNotFound: true);
        m_PlayerControllerInput_leftTrigger = m_PlayerControllerInput.FindAction("leftTrigger", throwIfNotFound: true);
        m_PlayerControllerInput_rightTrigger = m_PlayerControllerInput.FindAction("rightTrigger", throwIfNotFound: true);
        m_PlayerControllerInput_leftStickClick = m_PlayerControllerInput.FindAction("leftStickClick", throwIfNotFound: true);
        m_PlayerControllerInput_rightStickClick = m_PlayerControllerInput.FindAction("rightStickClick", throwIfNotFound: true);
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

    // PlayerControllerInput
    private readonly InputActionMap m_PlayerControllerInput;
    private IPlayerControllerInputActions m_PlayerControllerInputActionsCallbackInterface;
    private readonly InputAction m_PlayerControllerInput_Player1Moving;
    private readonly InputAction m_PlayerControllerInput_Player2Moving;
    private readonly InputAction m_PlayerControllerInput_aButton;
    private readonly InputAction m_PlayerControllerInput_bButton;
    private readonly InputAction m_PlayerControllerInput_xButton;
    private readonly InputAction m_PlayerControllerInput_yButton;
    private readonly InputAction m_PlayerControllerInput_leftBumper;
    private readonly InputAction m_PlayerControllerInput_rightBumper;
    private readonly InputAction m_PlayerControllerInput_leftTrigger;
    private readonly InputAction m_PlayerControllerInput_rightTrigger;
    private readonly InputAction m_PlayerControllerInput_leftStickClick;
    private readonly InputAction m_PlayerControllerInput_rightStickClick;
    public struct PlayerControllerInputActions
    {
        private @ControllerInput m_Wrapper;
        public PlayerControllerInputActions(@ControllerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Player1Moving => m_Wrapper.m_PlayerControllerInput_Player1Moving;
        public InputAction @Player2Moving => m_Wrapper.m_PlayerControllerInput_Player2Moving;
        public InputAction @aButton => m_Wrapper.m_PlayerControllerInput_aButton;
        public InputAction @bButton => m_Wrapper.m_PlayerControllerInput_bButton;
        public InputAction @xButton => m_Wrapper.m_PlayerControllerInput_xButton;
        public InputAction @yButton => m_Wrapper.m_PlayerControllerInput_yButton;
        public InputAction @leftBumper => m_Wrapper.m_PlayerControllerInput_leftBumper;
        public InputAction @rightBumper => m_Wrapper.m_PlayerControllerInput_rightBumper;
        public InputAction @leftTrigger => m_Wrapper.m_PlayerControllerInput_leftTrigger;
        public InputAction @rightTrigger => m_Wrapper.m_PlayerControllerInput_rightTrigger;
        public InputAction @leftStickClick => m_Wrapper.m_PlayerControllerInput_leftStickClick;
        public InputAction @rightStickClick => m_Wrapper.m_PlayerControllerInput_rightStickClick;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControllerInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControllerInputActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControllerInputActions instance)
        {
            if (m_Wrapper.m_PlayerControllerInputActionsCallbackInterface != null)
            {
                @Player1Moving.started -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnPlayer1Moving;
                @Player1Moving.performed -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnPlayer1Moving;
                @Player1Moving.canceled -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnPlayer1Moving;
                @Player2Moving.started -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnPlayer2Moving;
                @Player2Moving.performed -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnPlayer2Moving;
                @Player2Moving.canceled -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnPlayer2Moving;
                @aButton.started -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnAButton;
                @aButton.performed -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnAButton;
                @aButton.canceled -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnAButton;
                @bButton.started -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnBButton;
                @bButton.performed -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnBButton;
                @bButton.canceled -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnBButton;
                @xButton.started -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnXButton;
                @xButton.performed -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnXButton;
                @xButton.canceled -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnXButton;
                @yButton.started -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnYButton;
                @yButton.performed -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnYButton;
                @yButton.canceled -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnYButton;
                @leftBumper.started -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnLeftBumper;
                @leftBumper.performed -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnLeftBumper;
                @leftBumper.canceled -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnLeftBumper;
                @rightBumper.started -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnRightBumper;
                @rightBumper.performed -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnRightBumper;
                @rightBumper.canceled -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnRightBumper;
                @leftTrigger.started -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnLeftTrigger;
                @leftTrigger.performed -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnLeftTrigger;
                @leftTrigger.canceled -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnLeftTrigger;
                @rightTrigger.started -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnRightTrigger;
                @rightTrigger.performed -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnRightTrigger;
                @rightTrigger.canceled -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnRightTrigger;
                @leftStickClick.started -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnLeftStickClick;
                @leftStickClick.performed -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnLeftStickClick;
                @leftStickClick.canceled -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnLeftStickClick;
                @rightStickClick.started -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnRightStickClick;
                @rightStickClick.performed -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnRightStickClick;
                @rightStickClick.canceled -= m_Wrapper.m_PlayerControllerInputActionsCallbackInterface.OnRightStickClick;
            }
            m_Wrapper.m_PlayerControllerInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Player1Moving.started += instance.OnPlayer1Moving;
                @Player1Moving.performed += instance.OnPlayer1Moving;
                @Player1Moving.canceled += instance.OnPlayer1Moving;
                @Player2Moving.started += instance.OnPlayer2Moving;
                @Player2Moving.performed += instance.OnPlayer2Moving;
                @Player2Moving.canceled += instance.OnPlayer2Moving;
                @aButton.started += instance.OnAButton;
                @aButton.performed += instance.OnAButton;
                @aButton.canceled += instance.OnAButton;
                @bButton.started += instance.OnBButton;
                @bButton.performed += instance.OnBButton;
                @bButton.canceled += instance.OnBButton;
                @xButton.started += instance.OnXButton;
                @xButton.performed += instance.OnXButton;
                @xButton.canceled += instance.OnXButton;
                @yButton.started += instance.OnYButton;
                @yButton.performed += instance.OnYButton;
                @yButton.canceled += instance.OnYButton;
                @leftBumper.started += instance.OnLeftBumper;
                @leftBumper.performed += instance.OnLeftBumper;
                @leftBumper.canceled += instance.OnLeftBumper;
                @rightBumper.started += instance.OnRightBumper;
                @rightBumper.performed += instance.OnRightBumper;
                @rightBumper.canceled += instance.OnRightBumper;
                @leftTrigger.started += instance.OnLeftTrigger;
                @leftTrigger.performed += instance.OnLeftTrigger;
                @leftTrigger.canceled += instance.OnLeftTrigger;
                @rightTrigger.started += instance.OnRightTrigger;
                @rightTrigger.performed += instance.OnRightTrigger;
                @rightTrigger.canceled += instance.OnRightTrigger;
                @leftStickClick.started += instance.OnLeftStickClick;
                @leftStickClick.performed += instance.OnLeftStickClick;
                @leftStickClick.canceled += instance.OnLeftStickClick;
                @rightStickClick.started += instance.OnRightStickClick;
                @rightStickClick.performed += instance.OnRightStickClick;
                @rightStickClick.canceled += instance.OnRightStickClick;
            }
        }
    }
    public PlayerControllerInputActions @PlayerControllerInput => new PlayerControllerInputActions(this);
    public interface IPlayerControllerInputActions
    {
        void OnPlayer1Moving(InputAction.CallbackContext context);
        void OnPlayer2Moving(InputAction.CallbackContext context);
        void OnAButton(InputAction.CallbackContext context);
        void OnBButton(InputAction.CallbackContext context);
        void OnXButton(InputAction.CallbackContext context);
        void OnYButton(InputAction.CallbackContext context);
        void OnLeftBumper(InputAction.CallbackContext context);
        void OnRightBumper(InputAction.CallbackContext context);
        void OnLeftTrigger(InputAction.CallbackContext context);
        void OnRightTrigger(InputAction.CallbackContext context);
        void OnLeftStickClick(InputAction.CallbackContext context);
        void OnRightStickClick(InputAction.CallbackContext context);
    }
}
