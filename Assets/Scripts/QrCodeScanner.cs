using UnityEngine;
using ZXing;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QRCodeScanner : MonoBehaviour
{
    [SerializeField]
    private RawImage _rawImageBackground;
    [SerializeField]
    private AspectRatioFitter _aspectRatioFitter;
    [SerializeField]
    private Text _textOut;
    [SerializeField]
    private RectTransform _scanZone;
    [SerializeField]
    private Image _backgroundImage;

    private bool _isCamAvaible;
    private WebCamTexture _cameraTexture;

    void Start()
    {
        SetUpCamera();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCameraRender();
    }

    private void SetUpCamera()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        if (devices.Length == 0)
        {
            _isCamAvaible = false;
            _textOut.text = "Camera not Found";
            return;
        }
        for (int i = 0; i < devices.Length; i++)
        {
            if (devices[i].isFrontFacing == false)
            {
                _cameraTexture = new WebCamTexture(devices[i].name, (int)_scanZone.rect.width, (int)_scanZone.rect.height);
                break;
            }
        }
        _cameraTexture.Play();
        _rawImageBackground.texture = _cameraTexture;
        _isCamAvaible = true;
    }

    private void UpdateCameraRender()
    {
        if (_isCamAvaible == false)
        {
            return;
        }
        float ratio = (float)_cameraTexture.width / (float)_cameraTexture.height;
        _aspectRatioFitter.aspectRatio = ratio;

        int orientation = _cameraTexture.videoRotationAngle;
        orientation = orientation * 3;
        _rawImageBackground.rectTransform.localEulerAngles = new Vector3(0, 0, orientation);

    }
    public void OnClickScan()
    {
        Scan();
    }

    public void OnClick()
    {
        if (_textOut.text != "Failed to Read QR CODE")
        {
            string _levelName = LocationManager.Instance.GetLevelName();
            SceneManager.LoadScene(_levelName);
        }
    }

    private void Scan()
    {
        IBarcodeReader barcodeReader = new BarcodeReader();
        Result result = barcodeReader.Decode(_cameraTexture.GetPixels32(), _cameraTexture.width, _cameraTexture.height);
        try
        {
            if (result != null)
            {
                string _barcodeData = result.Text;
                LocationManager.Instance.SetLocationName(_barcodeData);
                _textOut.text = result.Text + " selected!";
            }
            else
            {
                _textOut.text = "Failed to Read QR CODE";
            }
        }
        catch
        {
            _textOut.text = "FAILED IN TRY";
        }
    }
}
