using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[assembly: ContractNamespace("http://KnockKnock.readify.net", ClrNamespace = "knockknock.readify.net")]
namespace Readify.KnockKnock.Webservice
{
    [DataContract(Name = "TriangleType", Namespace = "http://KnockKnock.readify.net")]
    public enum TriangleType : int
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Error = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Equilateral = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Isosceles = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Scalene = 3,
    }

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Namespace = "http://KnockKnock.readify.net", ConfigurationName = "IRedPill")]
    public interface IRedPill
    {
        [OperationContract(Action = "http://KnockKnock.readify.net/IRedPill/WhatIsYourToken", ReplyAction = "http://KnockKnock.readify.net/IRedPill/WhatIsYourTokenResponse")]
        Guid WhatIsYourToken();

        [OperationContract(Action = "http://KnockKnock.readify.net/IRedPill/FibonacciNumber", ReplyAction = "http://KnockKnock.readify.net/IRedPill/FibonacciNumberResponse")]
        [FaultContract(typeof(System.ArgumentOutOfRangeException), Action = "http://KnockKnock.readify.net/IRedPill/FibonacciNumberArgumentOutOfRangeException" +
        "Fault", Name = "ArgumentOutOfRangeException", Namespace = "http://schemas.datacontract.org/2004/07/System")]
        long FibonacciNumber(long n);

        [OperationContract(Action = "http://KnockKnock.readify.net/IRedPill/WhatShapeIsThis", ReplyAction = "http://KnockKnock.readify.net/IRedPill/WhatShapeIsThisResponse")]
        TriangleType WhatShapeIsThis(int a, int b, int c);

        [OperationContract(Action = "http://KnockKnock.readify.net/IRedPill/ReverseWords", ReplyAction = "http://KnockKnock.readify.net/IRedPill/ReverseWordsResponse")]
        [FaultContract(typeof(System.ArgumentNullException), Action = "http://KnockKnock.readify.net/IRedPill/ReverseWordsArgumentNullExceptionFault", Name = "ArgumentNullException", Namespace = "http://schemas.datacontract.org/2004/07/System")]
        string ReverseWords(string s);
    }
}