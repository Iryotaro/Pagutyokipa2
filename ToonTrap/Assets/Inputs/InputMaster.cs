//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Inputs/InputMaster.inputactions
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

public partial class @InputMaster : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""20097fc2-fbcb-43c7-a3f7-bd1a96ea3163"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""31e45fcc-5ffb-4835-bdea-ee1004438b59"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""9939c235-992a-4da8-8605-55c0591deb3a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Rock"",
                    ""type"": ""Button"",
                    ""id"": ""5ea6ed07-9ee7-4218-9098-f23c7c7b555a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Scissors"",
                    ""type"": ""Button"",
                    ""id"": ""516bd105-5b72-4866-a30b-efa1f41d827e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Paper"",
                    ""type"": ""Button"",
                    ""id"": ""9996ea0c-8ab7-4f91-bd73-c5ba47ecb93d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ChangeHand"",
                    ""type"": ""Button"",
                    ""id"": ""e0409578-62b1-4aa5-b3cc-0b29f9fedb42"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Button Only Cross"",
                    ""id"": ""8d61a079-d945-4d80-bea4-9b2537e5bca2"",
                    ""path"": ""ButtonOnlyCross"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7b2cc8f9-c8ed-4bde-bdf3-2cf1a476be1f"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""22e584dc-28c7-44cb-8ad3-ce2c668f527d"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6a0c01a8-4db4-476f-95a6-295a2a1d1f30"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""55386a82-0251-4eaa-90d6-c6a131aa33a5"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b30cd9c9-ea5a-4489-80ff-a9906071db1d"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d234d877-905c-4cf2-bb94-32f23fed01d5"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scissors"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c3ed6e5f-f8ec-4962-8e0f-0c551832a0a8"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Paper"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""706ba631-814c-4c52-9910-5ad3ebadd311"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""934207dd-4f5b-409d-83bb-427da333d7e2"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Title"",
            ""id"": ""96a11827-4914-4e59-85cf-90dbeb64edd7"",
            ""actions"": [
                {
                    ""name"": ""SelectUp"",
                    ""type"": ""Button"",
                    ""id"": ""d5562d8b-dc35-408e-8541-202b02188a7f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SelectDown"",
                    ""type"": ""Button"",
                    ""id"": ""b9be3828-5f30-4d22-9f50-f4bddbd2cf28"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Decide"",
                    ""type"": ""Button"",
                    ""id"": ""3049e1c1-eb6a-45c9-92fb-0cf30d555e13"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""95b2a507-5f8a-4d06-92de-c409c05d3ecf"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""30817a43-5181-451f-b1b0-b39a6acfba62"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc2786fa-2d5f-495d-add1-d930b30b0bea"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Decide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Game"",
            ""id"": ""1e5c90d4-d517-4c53-90f0-40f26d603099"",
            ""actions"": [
                {
                    ""name"": ""BackToTitle"",
                    ""type"": ""Button"",
                    ""id"": ""1a4508a5-5194-44b0-b30e-5165e4d7cd11"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c7d4a270-145d-457f-a532-b4616b649f43"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackToTitle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Attack = m_Player.FindAction("Attack", throwIfNotFound: true);
        m_Player_Rock = m_Player.FindAction("Rock", throwIfNotFound: true);
        m_Player_Scissors = m_Player.FindAction("Scissors", throwIfNotFound: true);
        m_Player_Paper = m_Player.FindAction("Paper", throwIfNotFound: true);
        m_Player_ChangeHand = m_Player.FindAction("ChangeHand", throwIfNotFound: true);
        // Title
        m_Title = asset.FindActionMap("Title", throwIfNotFound: true);
        m_Title_SelectUp = m_Title.FindAction("SelectUp", throwIfNotFound: true);
        m_Title_SelectDown = m_Title.FindAction("SelectDown", throwIfNotFound: true);
        m_Title_Decide = m_Title.FindAction("Decide", throwIfNotFound: true);
        // Game
        m_Game = asset.FindActionMap("Game", throwIfNotFound: true);
        m_Game_BackToTitle = m_Game.FindAction("BackToTitle", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Attack;
    private readonly InputAction m_Player_Rock;
    private readonly InputAction m_Player_Scissors;
    private readonly InputAction m_Player_Paper;
    private readonly InputAction m_Player_ChangeHand;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Attack => m_Wrapper.m_Player_Attack;
        public InputAction @Rock => m_Wrapper.m_Player_Rock;
        public InputAction @Scissors => m_Wrapper.m_Player_Scissors;
        public InputAction @Paper => m_Wrapper.m_Player_Paper;
        public InputAction @ChangeHand => m_Wrapper.m_Player_ChangeHand;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Attack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @Rock.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRock;
                @Rock.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRock;
                @Rock.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRock;
                @Scissors.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnScissors;
                @Scissors.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnScissors;
                @Scissors.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnScissors;
                @Paper.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPaper;
                @Paper.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPaper;
                @Paper.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPaper;
                @ChangeHand.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeHand;
                @ChangeHand.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeHand;
                @ChangeHand.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeHand;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Rock.started += instance.OnRock;
                @Rock.performed += instance.OnRock;
                @Rock.canceled += instance.OnRock;
                @Scissors.started += instance.OnScissors;
                @Scissors.performed += instance.OnScissors;
                @Scissors.canceled += instance.OnScissors;
                @Paper.started += instance.OnPaper;
                @Paper.performed += instance.OnPaper;
                @Paper.canceled += instance.OnPaper;
                @ChangeHand.started += instance.OnChangeHand;
                @ChangeHand.performed += instance.OnChangeHand;
                @ChangeHand.canceled += instance.OnChangeHand;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Title
    private readonly InputActionMap m_Title;
    private ITitleActions m_TitleActionsCallbackInterface;
    private readonly InputAction m_Title_SelectUp;
    private readonly InputAction m_Title_SelectDown;
    private readonly InputAction m_Title_Decide;
    public struct TitleActions
    {
        private @InputMaster m_Wrapper;
        public TitleActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @SelectUp => m_Wrapper.m_Title_SelectUp;
        public InputAction @SelectDown => m_Wrapper.m_Title_SelectDown;
        public InputAction @Decide => m_Wrapper.m_Title_Decide;
        public InputActionMap Get() { return m_Wrapper.m_Title; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TitleActions set) { return set.Get(); }
        public void SetCallbacks(ITitleActions instance)
        {
            if (m_Wrapper.m_TitleActionsCallbackInterface != null)
            {
                @SelectUp.started -= m_Wrapper.m_TitleActionsCallbackInterface.OnSelectUp;
                @SelectUp.performed -= m_Wrapper.m_TitleActionsCallbackInterface.OnSelectUp;
                @SelectUp.canceled -= m_Wrapper.m_TitleActionsCallbackInterface.OnSelectUp;
                @SelectDown.started -= m_Wrapper.m_TitleActionsCallbackInterface.OnSelectDown;
                @SelectDown.performed -= m_Wrapper.m_TitleActionsCallbackInterface.OnSelectDown;
                @SelectDown.canceled -= m_Wrapper.m_TitleActionsCallbackInterface.OnSelectDown;
                @Decide.started -= m_Wrapper.m_TitleActionsCallbackInterface.OnDecide;
                @Decide.performed -= m_Wrapper.m_TitleActionsCallbackInterface.OnDecide;
                @Decide.canceled -= m_Wrapper.m_TitleActionsCallbackInterface.OnDecide;
            }
            m_Wrapper.m_TitleActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SelectUp.started += instance.OnSelectUp;
                @SelectUp.performed += instance.OnSelectUp;
                @SelectUp.canceled += instance.OnSelectUp;
                @SelectDown.started += instance.OnSelectDown;
                @SelectDown.performed += instance.OnSelectDown;
                @SelectDown.canceled += instance.OnSelectDown;
                @Decide.started += instance.OnDecide;
                @Decide.performed += instance.OnDecide;
                @Decide.canceled += instance.OnDecide;
            }
        }
    }
    public TitleActions @Title => new TitleActions(this);

    // Game
    private readonly InputActionMap m_Game;
    private IGameActions m_GameActionsCallbackInterface;
    private readonly InputAction m_Game_BackToTitle;
    public struct GameActions
    {
        private @InputMaster m_Wrapper;
        public GameActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @BackToTitle => m_Wrapper.m_Game_BackToTitle;
        public InputActionMap Get() { return m_Wrapper.m_Game; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameActions set) { return set.Get(); }
        public void SetCallbacks(IGameActions instance)
        {
            if (m_Wrapper.m_GameActionsCallbackInterface != null)
            {
                @BackToTitle.started -= m_Wrapper.m_GameActionsCallbackInterface.OnBackToTitle;
                @BackToTitle.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnBackToTitle;
                @BackToTitle.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnBackToTitle;
            }
            m_Wrapper.m_GameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @BackToTitle.started += instance.OnBackToTitle;
                @BackToTitle.performed += instance.OnBackToTitle;
                @BackToTitle.canceled += instance.OnBackToTitle;
            }
        }
    }
    public GameActions @Game => new GameActions(this);
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnRock(InputAction.CallbackContext context);
        void OnScissors(InputAction.CallbackContext context);
        void OnPaper(InputAction.CallbackContext context);
        void OnChangeHand(InputAction.CallbackContext context);
    }
    public interface ITitleActions
    {
        void OnSelectUp(InputAction.CallbackContext context);
        void OnSelectDown(InputAction.CallbackContext context);
        void OnDecide(InputAction.CallbackContext context);
    }
    public interface IGameActions
    {
        void OnBackToTitle(InputAction.CallbackContext context);
    }
}
