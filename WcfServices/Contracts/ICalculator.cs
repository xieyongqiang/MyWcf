﻿using System.ServiceModel;
namespace Contracts
{
    [ServiceContract(Name = "CalculatorService", Namespace = "http://www.srx.com/")]
    public interface ICalculator
    {
        [OperationContract]
        double Add(double x, double y);

        [OperationContract]
        double Subtract(double x, double y);

        [OperationContract]
        double Multiply(double x, double y);

        [OperationContract]
        double Divide(double x, double y);
    }
}