// This class was generated on Mon, 08 Jan 2018 16:45:09 CST by version 0.1 of Braintree SDK Generator
// InvoiceNumber.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/6SQMUv0QBCG++9XDFPnO6zTCTYiqEiwEYu55D0zsJmNs5PDIPffJQRznJaW++zs+z47n9zMI7jmWztmbUE2DXs4V/wsrrJPuJdhueeK7zCfDzcoresYmm0F1+4yr2FXFT9BugdLM9cHSQULeJ/U0W3g0fMID0Xh+mXTKOFqb7/rN62zxIYuVZoeZPgI0osfUfQSpIXkKJqWZIpM0YMGeNuLxY6aXsv3+DI5Rf6v1joGWKCjg+dhfZJLkKOF/azZ/XETNqV0ej39+wIAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    [DataContract]
    public class InvoiceNumber {

        /// <summary>
        /// Required default constructor
        /// </summary>
        public InvoiceNumber() {}

        /// <summary>
        /// The next invoice number that is available to the merchant. This number is auto-incremented from the most recent invoice number.
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue = false)]
        public string Number { get; set; }
    }
}

