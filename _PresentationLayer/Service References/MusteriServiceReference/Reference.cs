﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _PresentationLayer.MusteriServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MusteriServiceReference.IMusteri")]
    public interface IMusteri {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMusteri/CustomerAdd", ReplyAction="http://tempuri.org/IMusteri/CustomerAddResponse")]
        _BusinessLayer.Model.Status CustomerAdd(_DataLayer.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMusteri/CustomerAdd", ReplyAction="http://tempuri.org/IMusteri/CustomerAddResponse")]
        System.Threading.Tasks.Task<_BusinessLayer.Model.Status> CustomerAddAsync(_DataLayer.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMusteri/CustomerDelete", ReplyAction="http://tempuri.org/IMusteri/CustomerDeleteResponse")]
        _BusinessLayer.Model.Status CustomerDelete(_DataLayer.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMusteri/CustomerDelete", ReplyAction="http://tempuri.org/IMusteri/CustomerDeleteResponse")]
        System.Threading.Tasks.Task<_BusinessLayer.Model.Status> CustomerDeleteAsync(_DataLayer.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMusteri/CustomerUpdate", ReplyAction="http://tempuri.org/IMusteri/CustomerUpdateResponse")]
        _BusinessLayer.Model.Status CustomerUpdate(_DataLayer.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMusteri/CustomerUpdate", ReplyAction="http://tempuri.org/IMusteri/CustomerUpdateResponse")]
        System.Threading.Tasks.Task<_BusinessLayer.Model.Status> CustomerUpdateAsync(_DataLayer.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMusteri/Login", ReplyAction="http://tempuri.org/IMusteri/LoginResponse")]
        _BusinessLayer.LoginResult Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMusteri/Login", ReplyAction="http://tempuri.org/IMusteri/LoginResponse")]
        System.Threading.Tasks.Task<_BusinessLayer.LoginResult> LoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMusteri/CustomerAsJson", ReplyAction="http://tempuri.org/IMusteri/CustomerAsJsonResponse")]
        _DataLayer.Customer[] CustomerAsJson();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMusteri/CustomerAsJson", ReplyAction="http://tempuri.org/IMusteri/CustomerAsJsonResponse")]
        System.Threading.Tasks.Task<_DataLayer.Customer[]> CustomerAsJsonAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMusteriChannel : _PresentationLayer.MusteriServiceReference.IMusteri, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MusteriClient : System.ServiceModel.ClientBase<_PresentationLayer.MusteriServiceReference.IMusteri>, _PresentationLayer.MusteriServiceReference.IMusteri {
        
        public MusteriClient() {
        }
        
        public MusteriClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MusteriClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MusteriClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MusteriClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public _BusinessLayer.Model.Status CustomerAdd(_DataLayer.Customer customer) {
            return base.Channel.CustomerAdd(customer);
        }
        
        public System.Threading.Tasks.Task<_BusinessLayer.Model.Status> CustomerAddAsync(_DataLayer.Customer customer) {
            return base.Channel.CustomerAddAsync(customer);
        }
        
        public _BusinessLayer.Model.Status CustomerDelete(_DataLayer.Customer customer) {
            return base.Channel.CustomerDelete(customer);
        }
        
        public System.Threading.Tasks.Task<_BusinessLayer.Model.Status> CustomerDeleteAsync(_DataLayer.Customer customer) {
            return base.Channel.CustomerDeleteAsync(customer);
        }
        
        public _BusinessLayer.Model.Status CustomerUpdate(_DataLayer.Customer customer) {
            return base.Channel.CustomerUpdate(customer);
        }
        
        public System.Threading.Tasks.Task<_BusinessLayer.Model.Status> CustomerUpdateAsync(_DataLayer.Customer customer) {
            return base.Channel.CustomerUpdateAsync(customer);
        }
        
        public _BusinessLayer.LoginResult Login(string username, string password) {
            return base.Channel.Login(username, password);
        }
        
        public System.Threading.Tasks.Task<_BusinessLayer.LoginResult> LoginAsync(string username, string password) {
            return base.Channel.LoginAsync(username, password);
        }
        
        public _DataLayer.Customer[] CustomerAsJson() {
            return base.Channel.CustomerAsJson();
        }
        
        public System.Threading.Tasks.Task<_DataLayer.Customer[]> CustomerAsJsonAsync() {
            return base.Channel.CustomerAsJsonAsync();
        }
    }
}
