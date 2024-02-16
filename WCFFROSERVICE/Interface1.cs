using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFFROSERVICE
{
        [ServiceContract]
        public interface ITransferObject
        {
            [OperationContract]
            double Calculate(double x, double y, double b, double a);
            [OperationContract]
            double Factorial(int n);
        }
}
