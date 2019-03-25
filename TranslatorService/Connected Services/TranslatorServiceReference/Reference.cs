﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TranslatorService.TranslatorServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://luka.com/webservice", ConfigurationName="TranslatorServiceReference.TranslateWebServiceSoap")]
    public interface TranslateWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name sentence from namespace http://luka.com/webservice is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://luka.com/webservice/Translate", ReplyAction="*")]
        TranslatorService.TranslatorServiceReference.TranslateResponse Translate(TranslatorService.TranslatorServiceReference.TranslateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://luka.com/webservice/Translate", ReplyAction="*")]
        System.Threading.Tasks.Task<TranslatorService.TranslatorServiceReference.TranslateResponse> TranslateAsync(TranslatorService.TranslatorServiceReference.TranslateRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TranslateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Translate", Namespace="http://luka.com/webservice", Order=0)]
        public TranslatorService.TranslatorServiceReference.TranslateRequestBody Body;
        
        public TranslateRequest() {
        }
        
        public TranslateRequest(TranslatorService.TranslatorServiceReference.TranslateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://luka.com/webservice")]
    public partial class TranslateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sentence;
        
        public TranslateRequestBody() {
        }
        
        public TranslateRequestBody(string sentence) {
            this.sentence = sentence;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TranslateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TranslateResponse", Namespace="http://luka.com/webservice", Order=0)]
        public TranslatorService.TranslatorServiceReference.TranslateResponseBody Body;
        
        public TranslateResponse() {
        }
        
        public TranslateResponse(TranslatorService.TranslatorServiceReference.TranslateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://luka.com/webservice")]
    public partial class TranslateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string TranslateResult;
        
        public TranslateResponseBody() {
        }
        
        public TranslateResponseBody(string TranslateResult) {
            this.TranslateResult = TranslateResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TranslateWebServiceSoapChannel : TranslatorService.TranslatorServiceReference.TranslateWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TranslateWebServiceSoapClient : System.ServiceModel.ClientBase<TranslatorService.TranslatorServiceReference.TranslateWebServiceSoap>, TranslatorService.TranslatorServiceReference.TranslateWebServiceSoap {
        
        public TranslateWebServiceSoapClient() {
        }
        
        public TranslateWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TranslateWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TranslateWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TranslateWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TranslatorService.TranslatorServiceReference.TranslateResponse TranslatorService.TranslatorServiceReference.TranslateWebServiceSoap.Translate(TranslatorService.TranslatorServiceReference.TranslateRequest request) {
            return base.Channel.Translate(request);
        }
        
        public string Translate(string sentence) {
            TranslatorService.TranslatorServiceReference.TranslateRequest inValue = new TranslatorService.TranslatorServiceReference.TranslateRequest();
            inValue.Body = new TranslatorService.TranslatorServiceReference.TranslateRequestBody();
            inValue.Body.sentence = sentence;
            TranslatorService.TranslatorServiceReference.TranslateResponse retVal = ((TranslatorService.TranslatorServiceReference.TranslateWebServiceSoap)(this)).Translate(inValue);
            return retVal.Body.TranslateResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TranslatorService.TranslatorServiceReference.TranslateResponse> TranslatorService.TranslatorServiceReference.TranslateWebServiceSoap.TranslateAsync(TranslatorService.TranslatorServiceReference.TranslateRequest request) {
            return base.Channel.TranslateAsync(request);
        }
        
        public System.Threading.Tasks.Task<TranslatorService.TranslatorServiceReference.TranslateResponse> TranslateAsync(string sentence) {
            TranslatorService.TranslatorServiceReference.TranslateRequest inValue = new TranslatorService.TranslatorServiceReference.TranslateRequest();
            inValue.Body = new TranslatorService.TranslatorServiceReference.TranslateRequestBody();
            inValue.Body.sentence = sentence;
            return ((TranslatorService.TranslatorServiceReference.TranslateWebServiceSoap)(this)).TranslateAsync(inValue);
        }
    }
}
