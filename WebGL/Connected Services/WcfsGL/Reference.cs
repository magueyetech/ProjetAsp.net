﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebGL.WcfsGL {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfsGL.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        WcfGL.CompositeType GetDataUsingDataContract(WcfGL.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WcfGL.CompositeType> GetDataUsingDataContractAsync(WcfGL.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetListePersonne", ReplyAction="http://tempuri.org/IService1/GetListePersonneResponse")]
        WcfGL.Models.Personne[] GetListePersonne();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetListePersonne", ReplyAction="http://tempuri.org/IService1/GetListePersonneResponse")]
        System.Threading.Tasks.Task<WcfGL.Models.Personne[]> GetListePersonneAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddPersonne", ReplyAction="http://tempuri.org/IService1/AddPersonneResponse")]
        bool AddPersonne(WcfGL.Models.Personne personne);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddPersonne", ReplyAction="http://tempuri.org/IService1/AddPersonneResponse")]
        System.Threading.Tasks.Task<bool> AddPersonneAsync(WcfGL.Models.Personne personne);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdatePersonne", ReplyAction="http://tempuri.org/IService1/UpdatePersonneResponse")]
        bool UpdatePersonne(WcfGL.Models.Personne personne);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdatePersonne", ReplyAction="http://tempuri.org/IService1/UpdatePersonneResponse")]
        System.Threading.Tasks.Task<bool> UpdatePersonneAsync(WcfGL.Models.Personne personne);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeletePersonne", ReplyAction="http://tempuri.org/IService1/DeletePersonneResponse")]
        bool DeletePersonne(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeletePersonne", ReplyAction="http://tempuri.org/IService1/DeletePersonneResponse")]
        System.Threading.Tasks.Task<bool> DeletePersonneAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPersonneById", ReplyAction="http://tempuri.org/IService1/GetPersonneByIdResponse")]
        WcfGL.Models.Personne GetPersonneById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPersonneById", ReplyAction="http://tempuri.org/IService1/GetPersonneByIdResponse")]
        System.Threading.Tasks.Task<WcfGL.Models.Personne> GetPersonneByIdAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebGL.WcfsGL.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebGL.WcfsGL.IService1>, WebGL.WcfsGL.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public WcfGL.CompositeType GetDataUsingDataContract(WcfGL.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WcfGL.CompositeType> GetDataUsingDataContractAsync(WcfGL.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public WcfGL.Models.Personne[] GetListePersonne() {
            return base.Channel.GetListePersonne();
        }
        
        public System.Threading.Tasks.Task<WcfGL.Models.Personne[]> GetListePersonneAsync() {
            return base.Channel.GetListePersonneAsync();
        }
        
        public bool AddPersonne(WcfGL.Models.Personne personne) {
            return base.Channel.AddPersonne(personne);
        }
        
        public System.Threading.Tasks.Task<bool> AddPersonneAsync(WcfGL.Models.Personne personne) {
            return base.Channel.AddPersonneAsync(personne);
        }
        
        public bool UpdatePersonne(WcfGL.Models.Personne personne) {
            return base.Channel.UpdatePersonne(personne);
        }
        
        public System.Threading.Tasks.Task<bool> UpdatePersonneAsync(WcfGL.Models.Personne personne) {
            return base.Channel.UpdatePersonneAsync(personne);
        }
        
        public bool DeletePersonne(int id) {
            return base.Channel.DeletePersonne(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeletePersonneAsync(int id) {
            return base.Channel.DeletePersonneAsync(id);
        }
        
        public WcfGL.Models.Personne GetPersonneById(int id) {
            return base.Channel.GetPersonneById(id);
        }
        
        public System.Threading.Tasks.Task<WcfGL.Models.Personne> GetPersonneByIdAsync(int id) {
            return base.Channel.GetPersonneByIdAsync(id);
        }
    }
}