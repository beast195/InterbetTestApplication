using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace InterbetTestAppplication.ApplicationLogic.Models
{
        [XmlRoot(ElementName = "CorporatePayments")]
        public class CorporatePayments
        {
            [XmlElement(ElementName = "UniqueInstanceID")]
            public Guid UniqueInstanceID { get; set; }
            [XmlElement(ElementName = "EffectiveDate")]
            public int EffectiveDate { get; set; }
            [XmlElement(ElementName = "TransactionCode")]
            public int TransactionCode { get; set; }
            [XmlElement(ElementName = "TransactionAmount")]
            public double TransactionAmount { get; set; }
            [XmlElement(ElementName = "TransactionDate")]
            public int TransactionDate { get; set; }
            [XmlElement(ElementName = "TransactionTime")]
            public int TransactionTime { get; set; }
            [XmlElement(ElementName = "ChequeNumber")]
            public string ChequeNumber { get; set; }
            [XmlElement(ElementName = "DrCrIndicator")]
            public string DrCrIndicator { get; set; }
            [XmlElement(ElementName = "BankName")]
            public string BankName { get; set; }
            [XmlElement(ElementName = "BranchCode")]
            public string BranchCode { get; set; }
            [XmlElement(ElementName = "ReferenceNumber")]
            public string ReferenceNumber { get; set; }
            [XmlElement(ElementName = "AccountNumber")]
            public int AccountNumber { get; set; }
            [XmlElement(ElementName = "Identifier")]
            public string Identifier { get; set; }
        }
    }

