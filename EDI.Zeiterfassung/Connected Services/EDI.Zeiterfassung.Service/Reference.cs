﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EDI.Zeiterfassung.Service
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://WHEDI1/PersonalDataExchange")]
    public partial class ParseException
    {
        
        private int errorOffsetField;
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int errorOffset
        {
            get
            {
                return this.errorOffsetField;
            }
            set
            {
                this.errorOffsetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://WHEDI1/PersonalDataExchange")]
    public partial class personalStatus
    {
        
        private error[] errorListField;
        
        private int pnbtrmField;
        
        private bool pnbtrmFieldSpecified;
        
        private long pnpernField;
        
        private bool pnpernFieldSpecified;
        
        private string z1aht1Field;
        
        private long z1dateField;
        
        private bool z1dateFieldSpecified;
        
        private string z1statField;
        
        private string z1timeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("errors", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public error[] errorList
        {
            get
            {
                return this.errorListField;
            }
            set
            {
                this.errorListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int pnbtrm
        {
            get
            {
                return this.pnbtrmField;
            }
            set
            {
                this.pnbtrmField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pnbtrmSpecified
        {
            get
            {
                return this.pnbtrmFieldSpecified;
            }
            set
            {
                this.pnbtrmFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public long pnpern
        {
            get
            {
                return this.pnpernField;
            }
            set
            {
                this.pnpernField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pnpernSpecified
        {
            get
            {
                return this.pnpernFieldSpecified;
            }
            set
            {
                this.pnpernFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string z1aht1
        {
            get
            {
                return this.z1aht1Field;
            }
            set
            {
                this.z1aht1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public long z1date
        {
            get
            {
                return this.z1dateField;
            }
            set
            {
                this.z1dateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool z1dateSpecified
        {
            get
            {
                return this.z1dateFieldSpecified;
            }
            set
            {
                this.z1dateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string z1stat
        {
            get
            {
                return this.z1statField;
            }
            set
            {
                this.z1statField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string z1time
        {
            get
            {
                return this.z1timeField;
            }
            set
            {
                this.z1timeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://WHEDI1/PersonalDataExchange")]
    public partial class error
    {
        
        private int ercoField;
        
        private string ertxField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int erco
        {
            get
            {
                return this.ercoField;
            }
            set
            {
                this.ercoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string ertx
        {
            get
            {
                return this.ertxField;
            }
            set
            {
                this.ertxField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://WHEDI1/PersonalDataExchange")]
    public partial class zeiterfassung
    {
        
        private int pnbtrmField;
        
        private long pnpernField;
        
        private string zeaht1Field;
        
        private string zeaht2Field;
        
        private double zeazbrField;
        
        private double zeazdbField;
        
        private double zeazdiField;
        
        private double zeazdnField;
        
        private double zeaznaField;
        
        private double zeazsbField;
        
        private double zeazsoField;
        
        private double zeazssField;
        
        private double zeazueField;
        
        private long zedat2Field;
        
        private long zedateField;
        
        private long zefkalField;
        
        private int zesartField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int pnbtrm
        {
            get
            {
                return this.pnbtrmField;
            }
            set
            {
                this.pnbtrmField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public long pnpern
        {
            get
            {
                return this.pnpernField;
            }
            set
            {
                this.pnpernField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string zeaht1
        {
            get
            {
                return this.zeaht1Field;
            }
            set
            {
                this.zeaht1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string zeaht2
        {
            get
            {
                return this.zeaht2Field;
            }
            set
            {
                this.zeaht2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public double zeazbr
        {
            get
            {
                return this.zeazbrField;
            }
            set
            {
                this.zeazbrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public double zeazdb
        {
            get
            {
                return this.zeazdbField;
            }
            set
            {
                this.zeazdbField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public double zeazdi
        {
            get
            {
                return this.zeazdiField;
            }
            set
            {
                this.zeazdiField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public double zeazdn
        {
            get
            {
                return this.zeazdnField;
            }
            set
            {
                this.zeazdnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public double zeazna
        {
            get
            {
                return this.zeaznaField;
            }
            set
            {
                this.zeaznaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public double zeazsb
        {
            get
            {
                return this.zeazsbField;
            }
            set
            {
                this.zeazsbField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public double zeazso
        {
            get
            {
                return this.zeazsoField;
            }
            set
            {
                this.zeazsoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public double zeazss
        {
            get
            {
                return this.zeazssField;
            }
            set
            {
                this.zeazssField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public double zeazue
        {
            get
            {
                return this.zeazueField;
            }
            set
            {
                this.zeazueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public long zedat2
        {
            get
            {
                return this.zedat2Field;
            }
            set
            {
                this.zedat2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public long zedate
        {
            get
            {
                return this.zedateField;
            }
            set
            {
                this.zedateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public long zefkal
        {
            get
            {
                return this.zefkalField;
            }
            set
            {
                this.zefkalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public int zesart
        {
            get
            {
                return this.zesartField;
            }
            set
            {
                this.zesartField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://WHEDI1/PersonalDataExchange")]
    public partial class zeiterfassungList
    {
        
        private error[] errorListField;
        
        private zeiterfassung[] zeiterfassungList1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("errors", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public error[] errorList
        {
            get
            {
                return this.errorListField;
            }
            set
            {
                this.errorListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("zeiterfassungList", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=1)]
        public zeiterfassung[] zeiterfassungList1
        {
            get
            {
                return this.zeiterfassungList1Field;
            }
            set
            {
                this.zeiterfassungList1Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://WHEDI1/PersonalDataExchange")]
    public partial class personalList
    {
        
        private error[] errorListField;
        
        private personal[] personalList1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("errors", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public error[] errorList
        {
            get
            {
                return this.errorListField;
            }
            set
            {
                this.errorListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("personalList", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=1)]
        public personal[] personalList1
        {
            get
            {
                return this.personalList1Field;
            }
            set
            {
                this.personalList1Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://WHEDI1/PersonalDataExchange")]
    public partial class personal
    {
        
        private error[] errorListField;
        
        private double pnazssField;
        
        private bool pnazssFieldSpecified;
        
        private int pnbtrmField;
        
        private bool pnbtrmFieldSpecified;
        
        private long pneindField;
        
        private bool pneindFieldSpecified;
        
        private double pnfzopField;
        
        private bool pnfzopFieldSpecified;
        
        private string pnnameField;
        
        private long pnpernField;
        
        private bool pnpernFieldSpecified;
        
        private int pnurlgField;
        
        private bool pnurlgFieldSpecified;
        
        private int pnurlvField;
        
        private bool pnurlvFieldSpecified;
        
        private long pnvgsdField;
        
        private bool pnvgsdFieldSpecified;
        
        private long pnvgsfField;
        
        private bool pnvgsfFieldSpecified;
        
        private string pnvnamField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("errors", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public error[] errorList
        {
            get
            {
                return this.errorListField;
            }
            set
            {
                this.errorListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public double pnazss
        {
            get
            {
                return this.pnazssField;
            }
            set
            {
                this.pnazssField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pnazssSpecified
        {
            get
            {
                return this.pnazssFieldSpecified;
            }
            set
            {
                this.pnazssFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int pnbtrm
        {
            get
            {
                return this.pnbtrmField;
            }
            set
            {
                this.pnbtrmField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pnbtrmSpecified
        {
            get
            {
                return this.pnbtrmFieldSpecified;
            }
            set
            {
                this.pnbtrmFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public long pneind
        {
            get
            {
                return this.pneindField;
            }
            set
            {
                this.pneindField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pneindSpecified
        {
            get
            {
                return this.pneindFieldSpecified;
            }
            set
            {
                this.pneindFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public double pnfzop
        {
            get
            {
                return this.pnfzopField;
            }
            set
            {
                this.pnfzopField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pnfzopSpecified
        {
            get
            {
                return this.pnfzopFieldSpecified;
            }
            set
            {
                this.pnfzopFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string pnname
        {
            get
            {
                return this.pnnameField;
            }
            set
            {
                this.pnnameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public long pnpern
        {
            get
            {
                return this.pnpernField;
            }
            set
            {
                this.pnpernField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pnpernSpecified
        {
            get
            {
                return this.pnpernFieldSpecified;
            }
            set
            {
                this.pnpernFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int pnurlg
        {
            get
            {
                return this.pnurlgField;
            }
            set
            {
                this.pnurlgField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pnurlgSpecified
        {
            get
            {
                return this.pnurlgFieldSpecified;
            }
            set
            {
                this.pnurlgFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public int pnurlv
        {
            get
            {
                return this.pnurlvField;
            }
            set
            {
                this.pnurlvField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pnurlvSpecified
        {
            get
            {
                return this.pnurlvFieldSpecified;
            }
            set
            {
                this.pnurlvFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public long pnvgsd
        {
            get
            {
                return this.pnvgsdField;
            }
            set
            {
                this.pnvgsdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pnvgsdSpecified
        {
            get
            {
                return this.pnvgsdFieldSpecified;
            }
            set
            {
                this.pnvgsdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public long pnvgsf
        {
            get
            {
                return this.pnvgsfField;
            }
            set
            {
                this.pnvgsfField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pnvgsfSpecified
        {
            get
            {
                return this.pnvgsfFieldSpecified;
            }
            set
            {
                this.pnvgsfFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string pnvnam
        {
            get
            {
                return this.pnvnamField;
            }
            set
            {
                this.pnvnamField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://WHEDI1/PersonalDataExchange", ConfigurationName="EDI.Zeiterfassung.Service.PersonalDataProvider")]
    public interface PersonalDataProvider
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WHEDI1/PersonalDataExchange/PersonalDataProvider/getPersonalRequest", ReplyAction="http://WHEDI1/PersonalDataExchange/PersonalDataProvider/getPersonalResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Document, SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="getPersonal")]
        System.Threading.Tasks.Task<EDI.Zeiterfassung.Service.personal> getPersonalAsync(int btrm, int pern);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WHEDI1/PersonalDataExchange/PersonalDataProvider/getPersonalListRequest", ReplyAction="http://WHEDI1/PersonalDataExchange/PersonalDataProvider/getPersonalListResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Document, SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="getPersonalList")]
        System.Threading.Tasks.Task<EDI.Zeiterfassung.Service.personalList> getPersonalListAsync(int btrm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WHEDI1/PersonalDataExchange/PersonalDataProvider/getZeiterfassungRequest", ReplyAction="http://WHEDI1/PersonalDataExchange/PersonalDataProvider/getZeiterfassungResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Document, SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="getZeiterfassung")]
        System.Threading.Tasks.Task<EDI.Zeiterfassung.Service.zeiterfassungList> getZeiterfassungAsync(int btrm, long pern, long datv, long datb, string sart);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WHEDI1/PersonalDataExchange/PersonalDataProvider/getPersonalStatusRequest", ReplyAction="http://WHEDI1/PersonalDataExchange/PersonalDataProvider/getPersonalStatusResponse" +
            "")]
        [System.ServiceModel.FaultContractAttribute(typeof(EDI.Zeiterfassung.Service.ParseException), Action="http://WHEDI1/PersonalDataExchange/PersonalDataProvider/getPersonalStatus/Fault/P" +
            "arseException", Name="ParseException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Document, SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="getPersonalStatus")]
        System.Threading.Tasks.Task<EDI.Zeiterfassung.Service.personalStatus> getPersonalStatusAsync(int btrm, long pern);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WHEDI1/PersonalDataExchange/PersonalDataProvider/getPersonalStatusListRequ" +
            "est", ReplyAction="http://WHEDI1/PersonalDataExchange/PersonalDataProvider/getPersonalStatusListResp" +
            "onse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EDI.Zeiterfassung.Service.ParseException), Action="http://WHEDI1/PersonalDataExchange/PersonalDataProvider/getPersonalStatusList/Fau" +
            "lt/ParseException", Name="ParseException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Document, SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="getPersonalStatusList")]
        System.Threading.Tasks.Task<EDI.Zeiterfassung.Service.personalStatusList> getPersonalStatusListAsync(int btrm, long pern, long date);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://WHEDI1/PersonalDataExchange")]
    public partial class personalStatusList
    {
        
        private error[] errorListField;
        
        private personalStatus[] personalStautsListField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("errors", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public error[] errorList
        {
            get
            {
                return this.errorListField;
            }
            set
            {
                this.errorListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("personalStautsList", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=1)]
        public personalStatus[] personalStautsList
        {
            get
            {
                return this.personalStautsListField;
            }
            set
            {
                this.personalStautsListField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface PersonalDataProviderChannel : EDI.Zeiterfassung.Service.PersonalDataProvider, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class PersonalDataProviderClient : System.ServiceModel.ClientBase<EDI.Zeiterfassung.Service.PersonalDataProvider>, EDI.Zeiterfassung.Service.PersonalDataProvider
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public PersonalDataProviderClient() : 
                base(PersonalDataProviderClient.GetDefaultBinding(), PersonalDataProviderClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.PersonalDataProviderPort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PersonalDataProviderClient(EndpointConfiguration endpointConfiguration) : 
                base(PersonalDataProviderClient.GetBindingForEndpoint(endpointConfiguration), PersonalDataProviderClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PersonalDataProviderClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(PersonalDataProviderClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PersonalDataProviderClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(PersonalDataProviderClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PersonalDataProviderClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<EDI.Zeiterfassung.Service.personal> getPersonalAsync(int btrm, int pern)
        {
            return base.Channel.getPersonalAsync(btrm, pern);
        }
        
        public System.Threading.Tasks.Task<EDI.Zeiterfassung.Service.personalList> getPersonalListAsync(int btrm)
        {
            return base.Channel.getPersonalListAsync(btrm);
        }
        
        public System.Threading.Tasks.Task<EDI.Zeiterfassung.Service.zeiterfassungList> getZeiterfassungAsync(int btrm, long pern, long datv, long datb, string sart)
        {
            return base.Channel.getZeiterfassungAsync(btrm, pern, datv, datb, sart);
        }
        
        public System.Threading.Tasks.Task<EDI.Zeiterfassung.Service.personalStatus> getPersonalStatusAsync(int btrm, long pern)
        {
            return base.Channel.getPersonalStatusAsync(btrm, pern);
        }
        
        public System.Threading.Tasks.Task<EDI.Zeiterfassung.Service.personalStatusList> getPersonalStatusListAsync(int btrm, long pern, long date)
        {
            return base.Channel.getPersonalStatusListAsync(btrm, pern, date);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.PersonalDataProviderPort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.PersonalDataProviderPort))
            {
                return new System.ServiceModel.EndpointAddress("http://hitsrvtedi2:20304/PersonalDataExchange");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return PersonalDataProviderClient.GetBindingForEndpoint(EndpointConfiguration.PersonalDataProviderPort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return PersonalDataProviderClient.GetEndpointAddress(EndpointConfiguration.PersonalDataProviderPort);
        }
        
        public enum EndpointConfiguration
        {
            
            PersonalDataProviderPort,
        }
    }
}
