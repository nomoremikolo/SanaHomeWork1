using Microsoft.AspNetCore.Mvc.ApplicationModels;
namespace SanaHomeWork1.Conventions
{
    public class PashaConventions : IControllerModelConvention
    {
        public readonly string controllerName = "ControllerPasha";
        public void Apply(ControllerModel controller)
        {
            controller.ControllerName = controller.ControllerName.Replace(controllerName,string.Empty);
        }
    }
}
