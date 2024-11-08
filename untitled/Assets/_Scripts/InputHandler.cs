using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private DynamicJoystick _joystick;
    [SerializeField] private Button _attackButton;
    [SerializeField] private Button _barrierButton;
    [SerializeField] private Button _ultimateButton;


    [HideInInspector] public UnityEvent OnPressAttack = new();
    [HideInInspector] public UnityEvent OnPressBarrier = new();
    [HideInInspector] public UnityEvent OnPressUltimate = new();


    private void OnEnable()
    {
        _attackButton.onClick.AddListener(() => OnPressAttack.Invoke());
        _barrierButton.onClick.AddListener(() => OnPressBarrier.Invoke());
        _ultimateButton.onClick.AddListener(() => OnPressUltimate.Invoke());
    }

    private void OnDisable()
    {
        _attackButton.onClick.RemoveAllListeners();
        _barrierButton.onClick.RemoveAllListeners();
        _ultimateButton.onClick.RemoveAllListeners();
    }

    public Vector2 GetJoystickInput()
    {
        return new Vector2(_joystick.Horizontal, _joystick.Vertical);
    }
}
