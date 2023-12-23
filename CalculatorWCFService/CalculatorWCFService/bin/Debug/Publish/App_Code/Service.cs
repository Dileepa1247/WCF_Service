using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public double Add(double n1, double n2)
    {
        return n1 + n2; 
    }

    public double Div(double n1, double n2)
    {
        return n1/n2;
    }

    public double Mul(double n1, double n2)
    {
        return n1 * n2; 
    }

    public double Sub(double n1, double n2)
    {
        return n1-n2;
    }
}

	