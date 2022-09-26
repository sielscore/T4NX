using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace T4NX
{
    public class Gamepad : MonoSingleton<Gamepad>
    {
        [SerializeField] private bool _isUpPressed = false;
        [SerializeField] private bool _isDownPressed = false;
        [SerializeField] private bool _isLeftPressed = false;
        [SerializeField] private bool _isRightPressed = false;

        [SerializeField] private bool _isSelectPressed = false;
        [SerializeField] private bool _isStartPressed = false;

        [SerializeField] private bool _isBPressed = false;
        [SerializeField] private bool _isAPressed = false;

        [SerializeField] private GamepadButton _upButton;
        [SerializeField] private GamepadButton _downButton;
        [SerializeField] private GamepadButton _leftButton;
        [SerializeField] private GamepadButton _rightButton;

        [SerializeField] private GamepadButton _selectButton;
        [SerializeField] private GamepadButton _startButton;

        [SerializeField] private GamepadButton _BButton;
        [SerializeField] private GamepadButton _AButton;

        /// <summary>
        /// 
        /// </summary>
        public bool IsUpPressed { get { return _upButton.IsPressed || _isUpPressed; } }
        /// <summary>
        /// 
        /// </summary>
        public bool IsDownPressed { get { return _downButton.IsPressed || _isDownPressed; } }
        /// <summary>
        /// 
        /// </summary>
        public bool IsLeftPressed { get { return _leftButton.IsPressed || _isLeftPressed; } }
        /// <summary>
        /// 
        /// </summary>
        public bool IsRightPressed { get { return _rightButton.IsPressed || _isRightPressed; } }

        /// <summary>
        /// 
        /// </summary>
        public bool IsSelectPressed { get { return _selectButton.IsPressed || _isSelectPressed; } }
        /// <summary>
        /// 
        /// </summary>
        public bool IsStartPressed { get { return _startButton.IsPressed || _isStartPressed; } }

        /// <summary>
        /// 
        /// </summary>
        public bool IsBPressed { get { return _BButton.IsPressed || _isBPressed; } }
        /// <summary>
        /// 
        /// </summary>
        public bool IsAPressed { get { return _AButton.IsPressed || _isAPressed; } }

        // Start is called before the first frame update
        void Start()
        {

        }

        /// <summary>
        /// Every frame is taking data from a desktop keyboard (debug purposes only).
        /// </summary>
        void Update()
        {
            // Direction buttons

            // Up button
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                _isUpPressed = true;
                GamepadEventsManager.Instance.DispatchEvent(GamepadEvent.Up_Pressed);
            }
            else if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.UpArrow))
            {
                _isUpPressed = false;
                GamepadEventsManager.Instance.DispatchEvent(GamepadEvent.Up_Released);
            }

            // Down button
            if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                _isDownPressed = true;
                GamepadEventsManager.Instance.DispatchEvent(GamepadEvent.Down_Pressed);
            }
            else if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
            {
                _isDownPressed = false;
                GamepadEventsManager.Instance.DispatchEvent(GamepadEvent.Down_Released);
            }

            // Left button
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                _isLeftPressed = true;
                GamepadEventsManager.Instance.DispatchEvent(GamepadEvent.Left_Pressed);
            }
            else if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
            {
                _isLeftPressed = false;
                GamepadEventsManager.Instance.DispatchEvent(GamepadEvent.Left_Released);
            }

            // Right button
            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                _isRightPressed = true;
                GamepadEventsManager.Instance.DispatchEvent(GamepadEvent.Right_Pressed);
            }
            else if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
            {
                _isRightPressed = false;
                GamepadEventsManager.Instance.DispatchEvent(GamepadEvent.Right_Released);
            }

            // Select & Start
            if (Input.GetKeyDown(KeyCode.O))
            {
                _isSelectPressed = true;
                GamepadEventsManager.Instance.DispatchEvent(GamepadEvent.Select_Pressed);
            }
            else if (Input.GetKeyUp(KeyCode.O))
            {
                _isSelectPressed = false;
                GamepadEventsManager.Instance.DispatchEvent(GamepadEvent.Select_Released);
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                _isStartPressed = true;
                GamepadEventsManager.Instance.DispatchEvent(GamepadEvent.Start_Pressed);
            }
            else if (Input.GetKeyUp(KeyCode.P))
            {
                _isStartPressed = false;
                GamepadEventsManager.Instance.DispatchEvent(GamepadEvent.Start_Released);
            }

            // Action button B
            if (Input.GetKeyDown(KeyCode.K) || Input.GetKeyDown(KeyCode.LeftBracket))
            {
                _isBPressed = true;
                GamepadEventsManager.Instance.DispatchEvent(GamepadEvent.B_Pressed);
            }
            else if (Input.GetKeyUp(KeyCode.K) || Input.GetKeyUp(KeyCode.LeftBracket))
            {
                _isBPressed = false;
                GamepadEventsManager.Instance.DispatchEvent(GamepadEvent.B_Released);
            }

            // Action button A
            if (Input.GetKeyDown(KeyCode.L) || Input.GetKeyDown(KeyCode.RightBracket))
            {
                _isAPressed = true;
                GamepadEventsManager.Instance.DispatchEvent(GamepadEvent.A_Pressed);
            }
            else if (Input.GetKeyUp(KeyCode.L) || Input.GetKeyUp(KeyCode.RightBracket))
            {
                _isAPressed = false;
                GamepadEventsManager.Instance.DispatchEvent(GamepadEvent.A_Released);
            }
        }
    }
}
