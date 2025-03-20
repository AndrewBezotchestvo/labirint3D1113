using UnityEngine;

public class PauseController : MonoBehaviour
{
    [SerializeField] private GameObject _pausePanel;

    private bool _paused;

    void Start()
    {
        _paused = false;
        _pausePanel.SetActive(false);
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ChangePauseState();
        }
    }

    public void ChangePauseState()
    {
        _paused = !_paused;

        if (_paused)
        {
            _pausePanel.SetActive(true);
            Time.timeScale = 0f; //��������� ������� ��������� ������ �� ������
        }
        else
        {
            _pausePanel.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
