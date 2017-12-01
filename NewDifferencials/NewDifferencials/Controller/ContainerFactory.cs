using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewDifferencials.Model;

namespace NewDifferencials.Controller
{
    public static class ContainerFactory
    {
        public static IDataContainer CreateContainer(ModelType type)
        {
            switch (type)
            {
                case ModelType.First:
                    return new FirstDataContainer();
                case ModelType.Second:
                    return new SecondDataContainer();
                case ModelType.Third:
                    return new ThirdDataContainer();
                default:
                    throw new Exception("Неизвестный тип контейнера");
            }
        }
    }
}
