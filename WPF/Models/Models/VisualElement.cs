using Models.Interfaces.Models;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace Models.Models
{
    public abstract class VisualElement : Element, IVisualElement
    {
        #region Fields

        #region position

        private double _x;
        private double _y;
        private double _width;
        private double _height;
        private double _angle;

        #endregion position

        #region blur

        private int _radius;
        private KernelType _kernelType;
        private RenderingBias _renderingBias;

        #endregion blur

        #region border

        private Color _background;
        private Color _borderBrush;
        private int _borderThickness;
        private int _cornerRadius;
        private int _padding;

        #endregion border

        #region dropShadow

        private Color _color;
        private int _blurRadius;
        private double _opacity;
        private int _direction;
        private int _shadowDepth;

        #endregion dropShadow

        #region margin

        private Thickness _margin;

        #endregion margin

        #endregion Fields

        #region Properties

        #region position

        public double X
        {
            get => _x;
            set => SetProperty(ref _x, value);
        }

        public double Y
        {
            get => _y;
            set => SetProperty(ref _y, value);
        }

        public double Width
        {
            get => _width;

            set => SetProperty(ref _width, value);
        }

        public double Height
        {
            get => _height;

            set => SetProperty(ref _height, value);
        }

        public double Angle
        {
            get => _angle;

            set => SetProperty(ref _angle, value);
        }

        #endregion position

        #region blur

        public int Radius
        {
            get => _radius;
            set => SetProperty(ref _radius, value);
        }

        public KernelType KernelType
        {
            get => _kernelType;
            set => SetProperty(ref _kernelType, value);
        }

        public RenderingBias RenderingBias
        {
            get => _renderingBias;
            set => SetProperty(ref _renderingBias, value);
        }

        #endregion blur

        #region border

        public Color Background
        {
            get => _background;
            set => SetProperty(ref _background, value);
        }

        public Color BorderBrush
        {
            get => _borderBrush;
            set => SetProperty(ref _borderBrush, value);
        }

        public int BorderThickness
        {
            get => _borderThickness;
            set => SetProperty(ref _borderThickness, value);
        }

        public int CornerRadius
        {
            get => _cornerRadius;
            set => SetProperty(ref _cornerRadius, value);
        }

        public int Padding
        {
            get => _padding;
            set => SetProperty(ref _padding, value);
        }

        #endregion border

        #region dropShadow

        public Color Color
        {
            get => _color;
            set => SetProperty(ref _color, value);
        }

        public int BlurRadius
        {
            get => _blurRadius;
            set => SetProperty(ref _blurRadius, value);
        }

        public double Opacity
        {
            get => _opacity;
            set => SetProperty(ref _opacity, value);
        }

        public int Direction
        {
            get => _direction;
            set => SetProperty(ref _direction, value);
        }

        public int ShadowDepth
        {
            get => _shadowDepth;
            set => SetProperty(ref _shadowDepth, value);
        }

        #endregion dropShadow

        #region Margin

        public Thickness Margin
        {
            get => _margin;
            set => SetProperty(ref _margin, value);
        }

        #endregion Margin

        #endregion Properties

        #region Constructor

        protected VisualElement(string name) : base(name)
        {
            Background = Colors.Transparent;
            Width = 100;
            Height = 100;
            RenderingBias = RenderingBias.Quality;
        }

        #endregion Constructor
    }
}