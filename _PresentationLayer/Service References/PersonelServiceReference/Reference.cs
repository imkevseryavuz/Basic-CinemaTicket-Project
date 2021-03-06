//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _PresentationLayer.PersonelServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PersonelServiceReference.IPersonel")]
    public interface IPersonel {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonel/EmplooyesAdd", ReplyAction="http://tempuri.org/IPersonel/EmplooyesAddResponse")]
        _BusinessLayer.Model.Status EmplooyesAdd(_DataLayer.Emplooye emplooye);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonel/EmplooyesAdd", ReplyAction="http://tempuri.org/IPersonel/EmplooyesAddResponse")]
        System.Threading.Tasks.Task<_BusinessLayer.Model.Status> EmplooyesAddAsync(_DataLayer.Emplooye emplooye);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonel/OgretmenSil", ReplyAction="http://tempuri.org/IPersonel/OgretmenSilResponse")]
        _BusinessLayer.Model.Status OgretmenSil(_DataLayer.Emplooye emplooye);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonel/OgretmenSil", ReplyAction="http://tempuri.org/IPersonel/OgretmenSilResponse")]
        System.Threading.Tasks.Task<_BusinessLayer.Model.Status> OgretmenSilAsync(_DataLayer.Emplooye emplooye);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonel/UpdateExam", ReplyAction="http://tempuri.org/IPersonel/UpdateExamResponse")]
        _BusinessLayer.Model.Status UpdateExam(_DataLayer.Emplooye emplooye);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonel/UpdateExam", ReplyAction="http://tempuri.org/IPersonel/UpdateExamResponse")]
        System.Threading.Tasks.Task<_BusinessLayer.Model.Status> UpdateExamAsync(_DataLayer.Emplooye emplooye);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonel/Login", ReplyAction="http://tempuri.org/IPersonel/LoginResponse")]
        _BusinessLayer.Model.Status Login(_DataLayer.Emplooye emplooyee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonel/Login", ReplyAction="http://tempuri.org/IPersonel/LoginResponse")]
        System.Threading.Tasks.Task<_BusinessLayer.Model.Status> LoginAsync(_DataLayer.Emplooye emplooyee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonel/EmplooyeAsJson", ReplyAction="http://tempuri.org/IPersonel/EmplooyeAsJsonResponse")]
        _DataLayer.Emplooye[] EmplooyeAsJson();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonel/EmplooyeAsJson", ReplyAction="http://tempuri.org/IPersonel/EmplooyeAsJsonResponse")]
        System.Threading.Tasks.Task<_DataLayer.Emplooye[]> EmplooyeAsJsonAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPersonelChannel : _PresentationLayer.PersonelServiceReference.IPersonel, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PersonelClient : System.ServiceModel.ClientBase<_PresentationLayer.PersonelServiceReference.IPersonel>, _PresentationLayer.PersonelServiceReference.IPersonel {
        
        public PersonelClient() {
        }
        
        public PersonelClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PersonelClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonelClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonelClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public _BusinessLayer.Model.Status EmplooyesAdd(_DataLayer.Emplooye emplooye) {
            return base.Channel.EmplooyesAdd(emplooye);
        }
        
        public System.Threading.Tasks.Task<_BusinessLayer.Model.Status> EmplooyesAddAsync(_DataLayer.Emplooye emplooye) {
            return base.Channel.EmplooyesAddAsync(emplooye);
        }
        
        public _BusinessLayer.Model.Status OgretmenSil(_DataLayer.Emplooye emplooye) {
            return base.Channel.OgretmenSil(emplooye);
        }
        
        public System.Threading.Tasks.Task<_BusinessLayer.Model.Status> OgretmenSilAsync(_DataLayer.Emplooye emplooye) {
            return base.Channel.OgretmenSilAsync(emplooye);
        }
        
        public _BusinessLayer.Model.Status UpdateExam(_DataLayer.Emplooye emplooye) {
            return base.Channel.UpdateExam(emplooye);
        }
        
        public System.Threading.Tasks.Task<_BusinessLayer.Model.Status> UpdateExamAsync(_DataLayer.Emplooye emplooye) {
            return base.Channel.UpdateExamAsync(emplooye);
        }
        
        public _BusinessLayer.Model.Status Login(_DataLayer.Emplooye emplooyee) {
            return base.Channel.Login(emplooyee);
        }
        
        public System.Threading.Tasks.Task<_BusinessLayer.Model.Status> LoginAsync(_DataLayer.Emplooye emplooyee) {
            return base.Channel.LoginAsync(emplooyee);
        }
        
        public _DataLayer.Emplooye[] EmplooyeAsJson() {
            return base.Channel.EmplooyeAsJson();
        }
        
        public System.Threading.Tasks.Task<_DataLayer.Emplooye[]> EmplooyeAsJsonAsync() {
            return base.Channel.EmplooyeAsJsonAsync();
        }
    }
}
