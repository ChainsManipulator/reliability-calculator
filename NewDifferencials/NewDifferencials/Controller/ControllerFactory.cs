using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewDifferencials.Model;

namespace NewDifferencials.Controller
{
    public static class ControllerFactory
    {
        public static IController CreateController(ModelType type)
        {
            switch (type)
            {
                case ModelType.First:
                    return new FirstController();
                case ModelType.Second:
                    return new SecondController();
                case ModelType.Third:
                    return new ThirdController();
                default:
                    throw new Exception("Неизвестный тип контроллера");
            }
        }
    }
}
