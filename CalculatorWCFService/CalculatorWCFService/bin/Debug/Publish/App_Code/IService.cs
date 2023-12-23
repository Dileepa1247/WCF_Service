using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{

	[OperationContract]
	double Add(double n1, double n2);
    [OperationContract]
    double Mul(double n1, double n2);
    [OperationContract]
    double Sub(double n1, double n2);
    [OperationContract]
    double Div(double n1, double n2);

}


	