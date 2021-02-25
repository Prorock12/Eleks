using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Prism.Commands;

namespace Modules.Redactor.Views
{
    /// <summary>
    /// Interaction logic for ViewA.xaml
    /// </summary>
    public partial class ElementContainerView : UserControl
    {
        #region Fields

        private bool _isMoving;

        #endregion

        public ElementContainerView()
        {
            InitializeComponent();
        }
        private void ElementsListBox_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            _isMoving = true;
        }

        private void ElementsListBox_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            _isMoving = false;
        }

        private void ElementsListBox_OnMouseMove(object sender, MouseEventArgs e)
        {
            //if (_isMoving)
            //{
            //    TranslateTransform transform = new TranslateTransform();
            //    transform.X = Mouse.GetPosition(ElementsShell).X;
            //    transform.Y = Mouse.GetPosition(ElementsShell).Y;
            //    this.ElementsListBox.RenderTransform = transform;
            //}
        }
    }
}