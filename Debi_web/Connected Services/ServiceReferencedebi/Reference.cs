﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Debi_web.ServiceReferencedebi {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferencedebi.WebServicedebiSoap")]
    public interface WebServicedebiSoap {
        
        // CODEGEN: Generating message contract since element name Username from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Register", ReplyAction="*")]
        Debi_web.ServiceReferencedebi.RegisterResponse Register(Debi_web.ServiceReferencedebi.RegisterRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Register", ReplyAction="*")]
        System.Threading.Tasks.Task<Debi_web.ServiceReferencedebi.RegisterResponse> RegisterAsync(Debi_web.ServiceReferencedebi.RegisterRequest request);
        
        // CODEGEN: Generating message contract since element name Username from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Admin_Register", ReplyAction="*")]
        Debi_web.ServiceReferencedebi.Admin_RegisterResponse Admin_Register(Debi_web.ServiceReferencedebi.Admin_RegisterRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Admin_Register", ReplyAction="*")]
        System.Threading.Tasks.Task<Debi_web.ServiceReferencedebi.Admin_RegisterResponse> Admin_RegisterAsync(Debi_web.ServiceReferencedebi.Admin_RegisterRequest request);
        
        // CODEGEN: Generating message contract since element name Hotelname from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Hotel_Register", ReplyAction="*")]
        Debi_web.ServiceReferencedebi.Hotel_RegisterResponse Hotel_Register(Debi_web.ServiceReferencedebi.Hotel_RegisterRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Hotel_Register", ReplyAction="*")]
        System.Threading.Tasks.Task<Debi_web.ServiceReferencedebi.Hotel_RegisterResponse> Hotel_RegisterAsync(Debi_web.ServiceReferencedebi.Hotel_RegisterRequest request);
        
        // CODEGEN: Generating message contract since element name type from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add_Room", ReplyAction="*")]
        Debi_web.ServiceReferencedebi.Add_RoomResponse Add_Room(Debi_web.ServiceReferencedebi.Add_RoomRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add_Room", ReplyAction="*")]
        System.Threading.Tasks.Task<Debi_web.ServiceReferencedebi.Add_RoomResponse> Add_RoomAsync(Debi_web.ServiceReferencedebi.Add_RoomRequest request);
        
        // CODEGEN: Generating message contract since element name hotelId from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Udate_Hotels", ReplyAction="*")]
        Debi_web.ServiceReferencedebi.Udate_HotelsResponse Udate_Hotels(Debi_web.ServiceReferencedebi.Udate_HotelsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Udate_Hotels", ReplyAction="*")]
        System.Threading.Tasks.Task<Debi_web.ServiceReferencedebi.Udate_HotelsResponse> Udate_HotelsAsync(Debi_web.ServiceReferencedebi.Udate_HotelsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RegisterRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Register", Namespace="http://tempuri.org/", Order=0)]
        public Debi_web.ServiceReferencedebi.RegisterRequestBody Body;
        
        public RegisterRequest() {
        }
        
        public RegisterRequest(Debi_web.ServiceReferencedebi.RegisterRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RegisterRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Username;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Email;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Address;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string District;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string PhoneNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string Password;
        
        public RegisterRequestBody() {
        }
        
        public RegisterRequestBody(string Username, string Email, string Address, string District, string PhoneNo, string Password) {
            this.Username = Username;
            this.Email = Email;
            this.Address = Address;
            this.District = District;
            this.PhoneNo = PhoneNo;
            this.Password = Password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RegisterResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RegisterResponse", Namespace="http://tempuri.org/", Order=0)]
        public Debi_web.ServiceReferencedebi.RegisterResponseBody Body;
        
        public RegisterResponse() {
        }
        
        public RegisterResponse(Debi_web.ServiceReferencedebi.RegisterResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RegisterResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string RegisterResult;
        
        public RegisterResponseBody() {
        }
        
        public RegisterResponseBody(string RegisterResult) {
            this.RegisterResult = RegisterResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Admin_RegisterRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Admin_Register", Namespace="http://tempuri.org/", Order=0)]
        public Debi_web.ServiceReferencedebi.Admin_RegisterRequestBody Body;
        
        public Admin_RegisterRequest() {
        }
        
        public Admin_RegisterRequest(Debi_web.ServiceReferencedebi.Admin_RegisterRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Admin_RegisterRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Username;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Email;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Address;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string District;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string PhoneNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string Password;
        
        public Admin_RegisterRequestBody() {
        }
        
        public Admin_RegisterRequestBody(string Username, string Email, string Address, string District, string PhoneNo, string Password) {
            this.Username = Username;
            this.Email = Email;
            this.Address = Address;
            this.District = District;
            this.PhoneNo = PhoneNo;
            this.Password = Password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Admin_RegisterResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Admin_RegisterResponse", Namespace="http://tempuri.org/", Order=0)]
        public Debi_web.ServiceReferencedebi.Admin_RegisterResponseBody Body;
        
        public Admin_RegisterResponse() {
        }
        
        public Admin_RegisterResponse(Debi_web.ServiceReferencedebi.Admin_RegisterResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Admin_RegisterResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Admin_RegisterResult;
        
        public Admin_RegisterResponseBody() {
        }
        
        public Admin_RegisterResponseBody(string Admin_RegisterResult) {
            this.Admin_RegisterResult = Admin_RegisterResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Hotel_RegisterRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Hotel_Register", Namespace="http://tempuri.org/", Order=0)]
        public Debi_web.ServiceReferencedebi.Hotel_RegisterRequestBody Body;
        
        public Hotel_RegisterRequest() {
        }
        
        public Hotel_RegisterRequest(Debi_web.ServiceReferencedebi.Hotel_RegisterRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Hotel_RegisterRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Hotelname;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Email;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string TelNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Address;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string District;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string Description;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string img;
        
        public Hotel_RegisterRequestBody() {
        }
        
        public Hotel_RegisterRequestBody(string Hotelname, string Email, string TelNo, string Address, string District, string Description, string img) {
            this.Hotelname = Hotelname;
            this.Email = Email;
            this.TelNo = TelNo;
            this.Address = Address;
            this.District = District;
            this.Description = Description;
            this.img = img;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Hotel_RegisterResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Hotel_RegisterResponse", Namespace="http://tempuri.org/", Order=0)]
        public Debi_web.ServiceReferencedebi.Hotel_RegisterResponseBody Body;
        
        public Hotel_RegisterResponse() {
        }
        
        public Hotel_RegisterResponse(Debi_web.ServiceReferencedebi.Hotel_RegisterResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Hotel_RegisterResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Hotel_RegisterResult;
        
        public Hotel_RegisterResponseBody() {
        }
        
        public Hotel_RegisterResponseBody(string Hotel_RegisterResult) {
            this.Hotel_RegisterResult = Hotel_RegisterResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Add_RoomRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Add_Room", Namespace="http://tempuri.org/", Order=0)]
        public Debi_web.ServiceReferencedebi.Add_RoomRequestBody Body;
        
        public Add_RoomRequest() {
        }
        
        public Add_RoomRequest(Debi_web.ServiceReferencedebi.Add_RoomRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Add_RoomRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string type;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string price;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Hid;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Hname;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string City;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string country;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string details;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string img;
        
        public Add_RoomRequestBody() {
        }
        
        public Add_RoomRequestBody(string type, string price, string Hid, string Hname, string City, string country, string details, string img) {
            this.type = type;
            this.price = price;
            this.Hid = Hid;
            this.Hname = Hname;
            this.City = City;
            this.country = country;
            this.details = details;
            this.img = img;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Add_RoomResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Add_RoomResponse", Namespace="http://tempuri.org/", Order=0)]
        public Debi_web.ServiceReferencedebi.Add_RoomResponseBody Body;
        
        public Add_RoomResponse() {
        }
        
        public Add_RoomResponse(Debi_web.ServiceReferencedebi.Add_RoomResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Add_RoomResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Add_RoomResult;
        
        public Add_RoomResponseBody() {
        }
        
        public Add_RoomResponseBody(string Add_RoomResult) {
            this.Add_RoomResult = Add_RoomResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Udate_HotelsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Udate_Hotels", Namespace="http://tempuri.org/", Order=0)]
        public Debi_web.ServiceReferencedebi.Udate_HotelsRequestBody Body;
        
        public Udate_HotelsRequest() {
        }
        
        public Udate_HotelsRequest(Debi_web.ServiceReferencedebi.Udate_HotelsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Udate_HotelsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string hotelId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Hotelname;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Email;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string TelNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Address;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string District;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string Description;
        
        public Udate_HotelsRequestBody() {
        }
        
        public Udate_HotelsRequestBody(string hotelId, string Hotelname, string Email, string TelNo, string Address, string District, string Description) {
            this.hotelId = hotelId;
            this.Hotelname = Hotelname;
            this.Email = Email;
            this.TelNo = TelNo;
            this.Address = Address;
            this.District = District;
            this.Description = Description;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Udate_HotelsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Udate_HotelsResponse", Namespace="http://tempuri.org/", Order=0)]
        public Debi_web.ServiceReferencedebi.Udate_HotelsResponseBody Body;
        
        public Udate_HotelsResponse() {
        }
        
        public Udate_HotelsResponse(Debi_web.ServiceReferencedebi.Udate_HotelsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Udate_HotelsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Udate_HotelsResult;
        
        public Udate_HotelsResponseBody() {
        }
        
        public Udate_HotelsResponseBody(string Udate_HotelsResult) {
            this.Udate_HotelsResult = Udate_HotelsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServicedebiSoapChannel : Debi_web.ServiceReferencedebi.WebServicedebiSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServicedebiSoapClient : System.ServiceModel.ClientBase<Debi_web.ServiceReferencedebi.WebServicedebiSoap>, Debi_web.ServiceReferencedebi.WebServicedebiSoap {
        
        public WebServicedebiSoapClient() {
        }
        
        public WebServicedebiSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServicedebiSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServicedebiSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServicedebiSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Debi_web.ServiceReferencedebi.RegisterResponse Debi_web.ServiceReferencedebi.WebServicedebiSoap.Register(Debi_web.ServiceReferencedebi.RegisterRequest request) {
            return base.Channel.Register(request);
        }
        
        public string Register(string Username, string Email, string Address, string District, string PhoneNo, string Password) {
            Debi_web.ServiceReferencedebi.RegisterRequest inValue = new Debi_web.ServiceReferencedebi.RegisterRequest();
            inValue.Body = new Debi_web.ServiceReferencedebi.RegisterRequestBody();
            inValue.Body.Username = Username;
            inValue.Body.Email = Email;
            inValue.Body.Address = Address;
            inValue.Body.District = District;
            inValue.Body.PhoneNo = PhoneNo;
            inValue.Body.Password = Password;
            Debi_web.ServiceReferencedebi.RegisterResponse retVal = ((Debi_web.ServiceReferencedebi.WebServicedebiSoap)(this)).Register(inValue);
            return retVal.Body.RegisterResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Debi_web.ServiceReferencedebi.RegisterResponse> Debi_web.ServiceReferencedebi.WebServicedebiSoap.RegisterAsync(Debi_web.ServiceReferencedebi.RegisterRequest request) {
            return base.Channel.RegisterAsync(request);
        }
        
        public System.Threading.Tasks.Task<Debi_web.ServiceReferencedebi.RegisterResponse> RegisterAsync(string Username, string Email, string Address, string District, string PhoneNo, string Password) {
            Debi_web.ServiceReferencedebi.RegisterRequest inValue = new Debi_web.ServiceReferencedebi.RegisterRequest();
            inValue.Body = new Debi_web.ServiceReferencedebi.RegisterRequestBody();
            inValue.Body.Username = Username;
            inValue.Body.Email = Email;
            inValue.Body.Address = Address;
            inValue.Body.District = District;
            inValue.Body.PhoneNo = PhoneNo;
            inValue.Body.Password = Password;
            return ((Debi_web.ServiceReferencedebi.WebServicedebiSoap)(this)).RegisterAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Debi_web.ServiceReferencedebi.Admin_RegisterResponse Debi_web.ServiceReferencedebi.WebServicedebiSoap.Admin_Register(Debi_web.ServiceReferencedebi.Admin_RegisterRequest request) {
            return base.Channel.Admin_Register(request);
        }
        
        public string Admin_Register(string Username, string Email, string Address, string District, string PhoneNo, string Password) {
            Debi_web.ServiceReferencedebi.Admin_RegisterRequest inValue = new Debi_web.ServiceReferencedebi.Admin_RegisterRequest();
            inValue.Body = new Debi_web.ServiceReferencedebi.Admin_RegisterRequestBody();
            inValue.Body.Username = Username;
            inValue.Body.Email = Email;
            inValue.Body.Address = Address;
            inValue.Body.District = District;
            inValue.Body.PhoneNo = PhoneNo;
            inValue.Body.Password = Password;
            Debi_web.ServiceReferencedebi.Admin_RegisterResponse retVal = ((Debi_web.ServiceReferencedebi.WebServicedebiSoap)(this)).Admin_Register(inValue);
            return retVal.Body.Admin_RegisterResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Debi_web.ServiceReferencedebi.Admin_RegisterResponse> Debi_web.ServiceReferencedebi.WebServicedebiSoap.Admin_RegisterAsync(Debi_web.ServiceReferencedebi.Admin_RegisterRequest request) {
            return base.Channel.Admin_RegisterAsync(request);
        }
        
        public System.Threading.Tasks.Task<Debi_web.ServiceReferencedebi.Admin_RegisterResponse> Admin_RegisterAsync(string Username, string Email, string Address, string District, string PhoneNo, string Password) {
            Debi_web.ServiceReferencedebi.Admin_RegisterRequest inValue = new Debi_web.ServiceReferencedebi.Admin_RegisterRequest();
            inValue.Body = new Debi_web.ServiceReferencedebi.Admin_RegisterRequestBody();
            inValue.Body.Username = Username;
            inValue.Body.Email = Email;
            inValue.Body.Address = Address;
            inValue.Body.District = District;
            inValue.Body.PhoneNo = PhoneNo;
            inValue.Body.Password = Password;
            return ((Debi_web.ServiceReferencedebi.WebServicedebiSoap)(this)).Admin_RegisterAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Debi_web.ServiceReferencedebi.Hotel_RegisterResponse Debi_web.ServiceReferencedebi.WebServicedebiSoap.Hotel_Register(Debi_web.ServiceReferencedebi.Hotel_RegisterRequest request) {
            return base.Channel.Hotel_Register(request);
        }
        
        public string Hotel_Register(string Hotelname, string Email, string TelNo, string Address, string District, string Description, string img) {
            Debi_web.ServiceReferencedebi.Hotel_RegisterRequest inValue = new Debi_web.ServiceReferencedebi.Hotel_RegisterRequest();
            inValue.Body = new Debi_web.ServiceReferencedebi.Hotel_RegisterRequestBody();
            inValue.Body.Hotelname = Hotelname;
            inValue.Body.Email = Email;
            inValue.Body.TelNo = TelNo;
            inValue.Body.Address = Address;
            inValue.Body.District = District;
            inValue.Body.Description = Description;
            inValue.Body.img = img;
            Debi_web.ServiceReferencedebi.Hotel_RegisterResponse retVal = ((Debi_web.ServiceReferencedebi.WebServicedebiSoap)(this)).Hotel_Register(inValue);
            return retVal.Body.Hotel_RegisterResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Debi_web.ServiceReferencedebi.Hotel_RegisterResponse> Debi_web.ServiceReferencedebi.WebServicedebiSoap.Hotel_RegisterAsync(Debi_web.ServiceReferencedebi.Hotel_RegisterRequest request) {
            return base.Channel.Hotel_RegisterAsync(request);
        }
        
        public System.Threading.Tasks.Task<Debi_web.ServiceReferencedebi.Hotel_RegisterResponse> Hotel_RegisterAsync(string Hotelname, string Email, string TelNo, string Address, string District, string Description, string img) {
            Debi_web.ServiceReferencedebi.Hotel_RegisterRequest inValue = new Debi_web.ServiceReferencedebi.Hotel_RegisterRequest();
            inValue.Body = new Debi_web.ServiceReferencedebi.Hotel_RegisterRequestBody();
            inValue.Body.Hotelname = Hotelname;
            inValue.Body.Email = Email;
            inValue.Body.TelNo = TelNo;
            inValue.Body.Address = Address;
            inValue.Body.District = District;
            inValue.Body.Description = Description;
            inValue.Body.img = img;
            return ((Debi_web.ServiceReferencedebi.WebServicedebiSoap)(this)).Hotel_RegisterAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Debi_web.ServiceReferencedebi.Add_RoomResponse Debi_web.ServiceReferencedebi.WebServicedebiSoap.Add_Room(Debi_web.ServiceReferencedebi.Add_RoomRequest request) {
            return base.Channel.Add_Room(request);
        }
        
        public string Add_Room(string type, string price, string Hid, string Hname, string City, string country, string details, string img) {
            Debi_web.ServiceReferencedebi.Add_RoomRequest inValue = new Debi_web.ServiceReferencedebi.Add_RoomRequest();
            inValue.Body = new Debi_web.ServiceReferencedebi.Add_RoomRequestBody();
            inValue.Body.type = type;
            inValue.Body.price = price;
            inValue.Body.Hid = Hid;
            inValue.Body.Hname = Hname;
            inValue.Body.City = City;
            inValue.Body.country = country;
            inValue.Body.details = details;
            inValue.Body.img = img;
            Debi_web.ServiceReferencedebi.Add_RoomResponse retVal = ((Debi_web.ServiceReferencedebi.WebServicedebiSoap)(this)).Add_Room(inValue);
            return retVal.Body.Add_RoomResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Debi_web.ServiceReferencedebi.Add_RoomResponse> Debi_web.ServiceReferencedebi.WebServicedebiSoap.Add_RoomAsync(Debi_web.ServiceReferencedebi.Add_RoomRequest request) {
            return base.Channel.Add_RoomAsync(request);
        }
        
        public System.Threading.Tasks.Task<Debi_web.ServiceReferencedebi.Add_RoomResponse> Add_RoomAsync(string type, string price, string Hid, string Hname, string City, string country, string details, string img) {
            Debi_web.ServiceReferencedebi.Add_RoomRequest inValue = new Debi_web.ServiceReferencedebi.Add_RoomRequest();
            inValue.Body = new Debi_web.ServiceReferencedebi.Add_RoomRequestBody();
            inValue.Body.type = type;
            inValue.Body.price = price;
            inValue.Body.Hid = Hid;
            inValue.Body.Hname = Hname;
            inValue.Body.City = City;
            inValue.Body.country = country;
            inValue.Body.details = details;
            inValue.Body.img = img;
            return ((Debi_web.ServiceReferencedebi.WebServicedebiSoap)(this)).Add_RoomAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Debi_web.ServiceReferencedebi.Udate_HotelsResponse Debi_web.ServiceReferencedebi.WebServicedebiSoap.Udate_Hotels(Debi_web.ServiceReferencedebi.Udate_HotelsRequest request) {
            return base.Channel.Udate_Hotels(request);
        }
        
        public string Udate_Hotels(string hotelId, string Hotelname, string Email, string TelNo, string Address, string District, string Description) {
            Debi_web.ServiceReferencedebi.Udate_HotelsRequest inValue = new Debi_web.ServiceReferencedebi.Udate_HotelsRequest();
            inValue.Body = new Debi_web.ServiceReferencedebi.Udate_HotelsRequestBody();
            inValue.Body.hotelId = hotelId;
            inValue.Body.Hotelname = Hotelname;
            inValue.Body.Email = Email;
            inValue.Body.TelNo = TelNo;
            inValue.Body.Address = Address;
            inValue.Body.District = District;
            inValue.Body.Description = Description;
            Debi_web.ServiceReferencedebi.Udate_HotelsResponse retVal = ((Debi_web.ServiceReferencedebi.WebServicedebiSoap)(this)).Udate_Hotels(inValue);
            return retVal.Body.Udate_HotelsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Debi_web.ServiceReferencedebi.Udate_HotelsResponse> Debi_web.ServiceReferencedebi.WebServicedebiSoap.Udate_HotelsAsync(Debi_web.ServiceReferencedebi.Udate_HotelsRequest request) {
            return base.Channel.Udate_HotelsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Debi_web.ServiceReferencedebi.Udate_HotelsResponse> Udate_HotelsAsync(string hotelId, string Hotelname, string Email, string TelNo, string Address, string District, string Description) {
            Debi_web.ServiceReferencedebi.Udate_HotelsRequest inValue = new Debi_web.ServiceReferencedebi.Udate_HotelsRequest();
            inValue.Body = new Debi_web.ServiceReferencedebi.Udate_HotelsRequestBody();
            inValue.Body.hotelId = hotelId;
            inValue.Body.Hotelname = Hotelname;
            inValue.Body.Email = Email;
            inValue.Body.TelNo = TelNo;
            inValue.Body.Address = Address;
            inValue.Body.District = District;
            inValue.Body.Description = Description;
            return ((Debi_web.ServiceReferencedebi.WebServicedebiSoap)(this)).Udate_HotelsAsync(inValue);
        }
    }
}
