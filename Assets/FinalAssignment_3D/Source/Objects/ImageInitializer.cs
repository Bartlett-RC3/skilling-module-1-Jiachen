using UnityEngine;
using UnityEngine.UI;

namespace RC3
{
    [CreateAssetMenu(menuName = "RC3/WS1/ImageInitializer")]
    public class ImageInitializer : ModelInitializer
    {
        [SerializeField] private Texture2D _texture1;
        [SerializeField] private Texture2D _texture2;
        [SerializeField] private Texture2D _texture3;
        [SerializeField] private Texture2D _texture4;
        [SerializeField] private Texture2D _texture5;
        [SerializeField] private Texture2D _texture6;
        [SerializeField] private Texture2D _texture7;
        [SerializeField] private Texture2D _texture8;
        [SerializeField] private Texture2D _texture9;
        [SerializeField] private Texture2D _texture10;
        [SerializeField] private Texture2D _texture11;
        [SerializeField] private Texture2D _texture12;
        [SerializeField] private Texture2D _texture13;
        [SerializeField] private Texture2D _texture14;
        [SerializeField] private Texture2D _texture15;
        [SerializeField] private Texture2D _texture16;
        [SerializeField] private Texture2D _texture17;
        [SerializeField] private Texture2D _texture18;
        [SerializeField] private float _threshold = 0.5f;
        private GameObject _seedImage;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="state"></param>
        public override void Initialize(int[,] state)
        {
            Dropdown myDropdown = GameObject.Find("SeedImage").GetComponent<Dropdown>();

            int m = state.GetLength(0);
            int n = state.GetLength(1);

            float tm = 1.0f / (m - 1);
            float tn = 1.0f / (n - 1);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (myDropdown.value == 0)
                    {
                        Color color = _texture1.GetPixelBilinear(j * tn, i * tm);

                        if (color.grayscale > _threshold)
                            state[i, j] = 1;
                        else
                            state[i, j] = 0;
                        _seedImage = GameObject.FindGameObjectWithTag("SeedImage");
                        _seedImage.GetComponent<Image>().sprite = Sprite.Create(_texture1, new Rect(0, 0, _texture1.width, _texture1.height), new Vector2(0.5f, 0.5f));
                    }
                    if (myDropdown.value == 1)
                    {
                        Color color = _texture2.GetPixelBilinear(j * tn, i * tm);

                        if (color.grayscale > _threshold)
                            state[i, j] = 1;
                        else
                            state[i, j] = 0;
                        _seedImage = GameObject.FindGameObjectWithTag("SeedImage");
                        _seedImage.GetComponent<Image>().sprite = Sprite.Create(_texture2, new Rect(0, 0, _texture2.width, _texture2.height), new Vector2(0.5f, 0.5f));
                    }
                    if (myDropdown.value == 2)
                    {
                        Color color = _texture3.GetPixelBilinear(j * tn, i * tm);

                        if (color.grayscale > _threshold)
                            state[i, j] = 1;
                        else
                            state[i, j] = 0;
                        _seedImage = GameObject.FindGameObjectWithTag("SeedImage");
                        _seedImage.GetComponent<Image>().sprite = Sprite.Create(_texture3, new Rect(0, 0, _texture3.width, _texture3.height), new Vector2(0.5f, 0.5f));
                    }
                    if (myDropdown.value == 3)
                    {
                        Color color = _texture4.GetPixelBilinear(j * tn, i * tm);

                        if (color.grayscale > _threshold)
                            state[i, j] = 1;
                        else
                            state[i, j] = 0;
                        _seedImage = GameObject.FindGameObjectWithTag("SeedImage");
                        _seedImage.GetComponent<Image>().sprite = Sprite.Create(_texture4, new Rect(0, 0, _texture4.width, _texture4.height), new Vector2(0.5f, 0.5f));
                    }
                    if (myDropdown.value == 4)
                    {
                        Color color = _texture5.GetPixelBilinear(j * tn, i * tm);

                        if (color.grayscale > _threshold)
                            state[i, j] = 1;
                        else
                            state[i, j] = 0;
                        _seedImage = GameObject.FindGameObjectWithTag("SeedImage");
                        _seedImage.GetComponent<Image>().sprite = Sprite.Create(_texture5, new Rect(0, 0, _texture5.width, _texture5.height), new Vector2(0.5f, 0.5f));
                    }
                    if (myDropdown.value == 5)
                    {
                        Color color = _texture6.GetPixelBilinear(j * tn, i * tm);

                        if (color.grayscale > _threshold)
                            state[i, j] = 1;
                        else
                            state[i, j] = 0;
                        _seedImage = GameObject.FindGameObjectWithTag("SeedImage");
                        _seedImage.GetComponent<Image>().sprite = Sprite.Create(_texture6, new Rect(0, 0, _texture6.width, _texture6.height), new Vector2(0.5f, 0.5f));
                    }
                    if (myDropdown.value == 6)
                    {
                        Color color = _texture7.GetPixelBilinear(j * tn, i * tm);

                        if (color.grayscale > _threshold)
                            state[i, j] = 1;
                        else
                            state[i, j] = 0;
                        _seedImage = GameObject.FindGameObjectWithTag("SeedImage");
                        _seedImage.GetComponent<Image>().sprite = Sprite.Create(_texture7, new Rect(0, 0, _texture7.width, _texture7.height), new Vector2(0.5f, 0.5f));
                    }
                    if (myDropdown.value == 7)
                    {
                        Color color = _texture8.GetPixelBilinear(j * tn, i * tm);

                        if (color.grayscale > _threshold)
                            state[i, j] = 1;
                        else
                            state[i, j] = 0;
                        _seedImage = GameObject.FindGameObjectWithTag("SeedImage");
                        _seedImage.GetComponent<Image>().sprite = Sprite.Create(_texture8, new Rect(0, 0, _texture8.width, _texture8.height), new Vector2(0.5f, 0.5f));
                    }
                    if (myDropdown.value == 8)
                    {
                        Color color = _texture9.GetPixelBilinear(j * tn, i * tm);

                        if (color.grayscale > _threshold)
                            state[i, j] = 1;
                        else
                            state[i, j] = 0;
                        _seedImage = GameObject.FindGameObjectWithTag("SeedImage");
                        _seedImage.GetComponent<Image>().sprite = Sprite.Create(_texture9, new Rect(0, 0, _texture9.width, _texture9.height), new Vector2(0.5f, 0.5f));
                    }
                    if (myDropdown.value == 9)
                    {
                        Color color = _texture10.GetPixelBilinear(j * tn, i * tm);

                        if (color.grayscale > _threshold)
                            state[i, j] = 1;
                        else
                            state[i, j] = 0;
                        _seedImage = GameObject.FindGameObjectWithTag("SeedImage");
                        _seedImage.GetComponent<Image>().sprite = Sprite.Create(_texture10, new Rect(0, 0, _texture10.width, _texture10.height), new Vector2(0.5f, 0.5f));
                    }
                    if (myDropdown.value == 10)
                    {
                        Color color = _texture11.GetPixelBilinear(j * tn, i * tm);

                        if (color.grayscale > _threshold)
                            state[i, j] = 1;
                        else
                            state[i, j] = 0;
                        _seedImage = GameObject.FindGameObjectWithTag("SeedImage");
                        _seedImage.GetComponent<Image>().sprite = Sprite.Create(_texture11, new Rect(0, 0, _texture11.width, _texture11.height), new Vector2(0.5f, 0.5f));
                    }
                    if (myDropdown.value == 11)
                    {
                        Color color = _texture12.GetPixelBilinear(j * tn, i * tm);

                        if (color.grayscale > _threshold)
                            state[i, j] = 1;
                        else
                            state[i, j] = 0;
                        _seedImage = GameObject.FindGameObjectWithTag("SeedImage");
                        _seedImage.GetComponent<Image>().sprite = Sprite.Create(_texture12, new Rect(0, 0, _texture12.width, _texture12.height), new Vector2(0.5f, 0.5f));
                    }
                    if (myDropdown.value == 12)
                    {
                        Color color = _texture13.GetPixelBilinear(j * tn, i * tm);

                        if (color.grayscale > _threshold)
                            state[i, j] = 1;
                        else
                            state[i, j] = 0;
                        _seedImage = GameObject.FindGameObjectWithTag("SeedImage");
                        _seedImage.GetComponent<Image>().sprite = Sprite.Create(_texture13, new Rect(0, 0, _texture13.width, _texture13.height), new Vector2(0.5f, 0.5f));
                    }
                    if (myDropdown.value == 13)
                    {
                        Color color = _texture14.GetPixelBilinear(j * tn, i * tm);

                        if (color.grayscale > _threshold)
                            state[i, j] = 1;
                        else
                            state[i, j] = 0;
                        _seedImage = GameObject.FindGameObjectWithTag("SeedImage");
                        _seedImage.GetComponent<Image>().sprite = Sprite.Create(_texture14, new Rect(0, 0, _texture14.width, _texture14.height), new Vector2(0.5f, 0.5f));
                    }
                    if (myDropdown.value == 14)
                    {
                        Color color = _texture15.GetPixelBilinear(j * tn, i * tm);

                        if (color.grayscale > _threshold)
                            state[i, j] = 1;
                        else
                            state[i, j] = 0;
                        _seedImage = GameObject.FindGameObjectWithTag("SeedImage");
                        _seedImage.GetComponent<Image>().sprite = Sprite.Create(_texture15, new Rect(0, 0, _texture15.width, _texture15.height), new Vector2(0.5f, 0.5f));
                    }
                    if (myDropdown.value == 15)
                    {
                        Color color = _texture15.GetPixelBilinear(j * tn, i * tm);

                        if (color.grayscale > _threshold)
                            state[i, j] = 1;
                        else
                            state[i, j] = 0;
                        _seedImage = GameObject.FindGameObjectWithTag("SeedImage");
                        _seedImage.GetComponent<Image>().sprite = Sprite.Create(_texture16, new Rect(0, 0, _texture15.width, _texture15.height), new Vector2(0.5f, 0.5f));
                    }
                    if (myDropdown.value == 16)
                    {
                        Color color = _texture15.GetPixelBilinear(j * tn, i * tm);

                        if (color.grayscale > _threshold)
                            state[i, j] = 1;
                        else
                            state[i, j] = 0;
                        _seedImage = GameObject.FindGameObjectWithTag("SeedImage");
                        _seedImage.GetComponent<Image>().sprite = Sprite.Create(_texture17, new Rect(0, 0, _texture15.width, _texture15.height), new Vector2(0.5f, 0.5f));
                    }
                    if (myDropdown.value == 17)
                    {
                        Color color = _texture15.GetPixelBilinear(j * tn, i * tm);

                        if (color.grayscale > _threshold)
                            state[i, j] = 1;
                        else
                            state[i, j] = 0;
                        _seedImage = GameObject.FindGameObjectWithTag("SeedImage");
                        _seedImage.GetComponent<Image>().sprite = Sprite.Create(_texture18, new Rect(0, 0, _texture15.width, _texture15.height), new Vector2(0.5f, 0.5f));
                    }

                }
            }
        }
    }
}
