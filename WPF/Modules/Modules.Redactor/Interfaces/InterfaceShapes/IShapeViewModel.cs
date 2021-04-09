using Models.Interfaces.ShapeModels;

namespace Modules.Redactor.Interfaces.InterfaceShapes
{
    public interface IShapeViewModel : IVisualElementViewModel
    {
        IShape Shape { get; set; }
    }
}