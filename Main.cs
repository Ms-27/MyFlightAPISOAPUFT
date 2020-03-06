/***************************************************************
    *  DO NOT EDIT THIS FILE!
    *         
    *  This file is automatically generated by HP Service Test.
    *  Manually changing the contents of this file may result in 
    *  loss of information.
    *          
    *  To edit the test, open the file ‘APITest MyFlightSOAP.st’ 
    *  in HP Service Test.
     ***************************************************************/
    
    namespace Script
    {
    using System;
    using System.Text;
    using System.Threading;
    using System.Xml;
    using System.Xml.Schema;
    using HP.ST.Fwk.ReporterFWK;
    using HP.ST.Shared.Utilities;
    using HP.ST.Ext.BindingImpl.Getters;
    using HP.ST.Ext.BindingImpl.Setters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.PropInfo;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Getters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Setters;
    using HP.ST.Fwk.RunTimeFWK;
    using HP.ST.Fwk.RunTimeFWK.Utilities;
    using HP.ST.Fwk.RunTimeFWK.HelperClasses;
    using HP.ST.Fwk.RunTimeFWK.CompositeActivities;
    using HP.ST.Ext.BindingImpl.Setters.DataSourceSetters;
    using HP.ST.Fwk.JVMLoader;
    using System.IO;
    using System.Collections.Generic;
    using System.Reflection;
    using HP.ST.Fwk.SOAReplayAPI;
    using HP.ST.Fwk.UFTLicensing;
    
    
    
    public partial class WorkFlowScript : STWorkFlowScriptBase
    {    
    	TestUserCode _userCode = null;
    	TestEntities _flow = null;
    	static Reporter reporter;
    	int reportLevelInTree;
        HP.ST.Fwk.ReportCreator.QTPEngine.QTPEngineReportCreator reportCreator;
    	
    	public BindDirection bind_dir1 = null;
        public BindDirection bind_dir2 = null;
        
        public IEnumerable<FeaturesGroup> LicensedFeatures
        {
        
        get
        {
        List<FeaturesGroup> features = new List<FeaturesGroup>();
        return features;
        
        }
        
        }
        
        public WorkFlowScript()
            : base(VuserClass.CommandLineArguments, new STRunTimeContext(), "test")
        {	
        	UpdateContextWithActionFolder(String.Empty);
        	
        }
        
        public WorkFlowScript(ISTRunTimeContext ctx)
            : base(VuserClass.CommandLineArguments, ctx, "test")
            
        {
        	this._context = ctx;
        	UpdateContextWithActionFolder(String.Empty);
        	UpdateTestSettings(ctx);
        }
        
        internal void InitializeComponent()
        {
        	LoadInput();
        	
        	InitReport();
        	
        	InitializeEncryptionManagerValues();
        
        	_userCode = new TestUserCode();
            _flow = _userCode;
            _flow.Context=this._context;
            
            
        
        	_flow.StartActivity1 = new HP.ST.Ext.BasicActivities.StartActivity(_context,"StartActivity1");
            _flow.Loop2 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop2Input>(_context,"Loop2",LoopType.For);
            _flow.EndActivity3 = new HP.ST.Ext.BasicActivities.EndActivity(_context,"EndActivity3");
            _flow.Sequence12 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence(_context,"Sequence12");
            _flow.HTTPActivity11 = new HP.ST.Ext.HTTPActivity.HTTPActivity(_context,"HTTPActivity11");
            _flow.StServiceCallActivity6 = new HP.ST.Ext.WebServicesActivities.StServiceCallActivity(_context,"StServiceCallActivity6");
            _flow.StServiceCallActivity7 = new HP.ST.Ext.WebServicesActivities.StServiceCallActivity(_context,"StServiceCallActivity7");
            _flow.StServiceCallActivity9 = new HP.ST.Ext.WebServicesActivities.StServiceCallActivity(_context,"StServiceCallActivity9");
            _flow.StServiceCallActivity10 = new HP.ST.Ext.WebServicesActivities.StServiceCallActivity(_context,"StServiceCallActivity10");
            _flow.StartActivity1.Comment = @"";
            _flow.StartActivity1.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_code_activity.png";
            _flow.StartActivity1.Name = @"Start";
            _flow.StartActivity1.JVM = new HP.ST.Ext.BasicActivities.JVMProperties();
            _flow.StartActivity1.IsJavaUsed = false;
            _flow.StartActivity1.JVM.Classpath = @"%CLASSPATH%";
            _flow.StartActivity1.JVM.AdditionalVMParameters = @"";
            _flow.StartActivity1.JMS = new HP.ST.Ext.BasicActivities.JMSProperties();
            _flow.StartActivity1.IsJmsUsed = false;
            _flow.StartActivity1.JMS.JNDIContextFactory = @"<Select...>";
            _flow.StartActivity1.JMS.JNDIProviderUrl = @"";
            _flow.StartActivity1.JMS.JMSConnectionFactory = @"";
            _flow.StartActivity1.JMS.SecurityPrincipal = @"";
            _flow.StartActivity1.JMS.SecurityCredentials = @"";
            _flow.StartActivity1.JMS.JMSClientID = @"";
            _flow.StartActivity1.JMS.SSLPassword = @"";
            _flow.StartActivity1.JMS.SSLTrustedCertificate = @"";
            _flow.StartActivity1.JMS.SSLIdentity = @"";
            _flow.StartActivity1.JMS.ConnectionsPerProcess = @"1";
            _flow.StartActivity1.JMS.TimeoutOptions = @"DN_User_defined_Timeout";
            _flow.StartActivity1.JMS.UserTimeout = @"20";
            _flow.StartActivity1.JMS.GenerateAutoSelector = @"No";
            this.Activities.Add (_flow.StartActivity1);
            _flow.Loop2.ConditionAsString = @"Run for 1 iteration";
            _flow.Loop2.NumberOfIterations = (int)1;
            _flow.Loop2.Comment = @"";
            _flow.Loop2.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_loop.png";
            _flow.Loop2.Name = @"Test Flow";
            _flow.Loop2.Activities.Add (_flow.Sequence12);
            this.Activities.Add (_flow.Loop2);
            _flow.EndActivity3.Comment = @"";
            _flow.EndActivity3.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_code_activity.png";
            _flow.EndActivity3.Name = @"End";
            this.Activities.Add (_flow.EndActivity3);
            _flow.Sequence12.Comment = @"";
            _flow.Sequence12.IconPath = @"";
            _flow.Sequence12.Name = @"Sequence12";
            _flow.Sequence12.Activities.Add (_flow.HTTPActivity11);
            _flow.Sequence12.Activities.Add (_flow.StServiceCallActivity6);
            _flow.Sequence12.Activities.Add (_flow.StServiceCallActivity7);
            _flow.Sequence12.Activities.Add (_flow.StServiceCallActivity9);
            _flow.Sequence12.Activities.Add (_flow.StServiceCallActivity10);
            _flow.HTTPActivity11.TextBody = @"";
            _flow.HTTPActivity11.TextXmlBody = @"";
            _flow.HTTPActivity11.FileBody = @"";
            _flow.HTTPActivity11.PostBody = @"";
            _flow.HTTPActivity11.Url = @"http://localhost:8000/Flights_SOAP?WSDL";
            _flow.HTTPActivity11.HttpMethod = @"GET";
            _flow.HTTPActivity11.HttpVersion = @"1.1";
            _flow.HTTPActivity11.Comment = @"";
            _flow.HTTPActivity11.IconPath = @"AddIns\ServiceTest\HTTPActivity\toolbox_http.png";
            _flow.HTTPActivity11.RequestBodyType = @"Text";
            _flow.HTTPActivity11.ResponseType = @"Text";
            _flow.HTTPActivity11.Name = @"HTTP Request11";
            _flow.HTTPActivity11.Proxy.Server = @"";
            _flow.HTTPActivity11.Proxy.Username = @"";
            _flow.HTTPActivity11.Proxy.Password = @"";
            _flow.HTTPActivity11.Authentication.Username = @"";
            _flow.HTTPActivity11.Authentication.Password = @"";
            _flow.HTTPActivity11.Authentication.PreemptiveAuthentication = false;
            _flow.HTTPActivity11.ConnectionType = @"Keep-Alive";
            _flow.HTTPActivity11.Timeout = (int)100000;
            _flow.HTTPActivity11.ClientCertificate.Password = @"";
            _flow.HTTPActivity11.ClientCertificate.FileSystem.Path = @"";
            _flow.HTTPActivity11.UseClientCertificate = false;
            _flow.HTTPActivity11.MaximumAutomaticRedirections = (int)3;
            _flow.HTTPActivity11.AllowRedirections = true;
            _flow.HTTPActivity11.ReuseCookies = false;
            _flow.HTTPActivity11.ExpectServerError = false;
            _flow.HTTPActivity11.HanaRequest = false;
            XmlDocument HTTPActivity11_XMLBody_Document = new XmlDocument();
            HTTPActivity11_XMLBody_Document.PreserveWhitespace = true;
            HTTPActivity11_XMLBody_Document.LoadXml(
@"<F6DA54ED-92F5-4c5c-9795-170905F25080 />");
            _flow.HTTPActivity11.XMLBody = HTTPActivity11_XMLBody_Document;
            XmlDocument HTTPActivity11_RequestMultipartInfoXml_Document = new XmlDocument();
            HTTPActivity11_RequestMultipartInfoXml_Document.PreserveWhitespace = true;
            HTTPActivity11_RequestMultipartInfoXml_Document.LoadXml(
@"<RequestMultipartInfo><Type>Related</Type></RequestMultipartInfo>");
            _flow.HTTPActivity11.RequestMultipartInfoXml = HTTPActivity11_RequestMultipartInfoXml_Document;
            _flow.HTTPActivity11.Multipart=false;
            XmlDocument HTTPActivity11_ExpectedResponseXmlBody_Document = new XmlDocument();
            HTTPActivity11_ExpectedResponseXmlBody_Document.PreserveWhitespace = true;
            HTTPActivity11_ExpectedResponseXmlBody_Document.LoadXml(
@"<F6DA54ED-92F5-4c5c-9795-170905F25080 />");
            _flow.HTTPActivity11.ExpectedResponseXmlBody = HTTPActivity11_ExpectedResponseXmlBody_Document;
            XmlDocument HTTPActivity11_ExpectedResponseJsonBody_Document = new XmlDocument();
            HTTPActivity11_ExpectedResponseJsonBody_Document.PreserveWhitespace = true;
            HTTPActivity11_ExpectedResponseJsonBody_Document.LoadXml(
@"<F6DA54ED-92F5-4c5c-9795-170905F25080 />");
            _flow.HTTPActivity11.ExpectedResponseJsonBody = HTTPActivity11_ExpectedResponseJsonBody_Document;
            XmlDocument HTTPActivity11_ExpectedOutputProperties_Document = new XmlDocument();
            HTTPActivity11_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            HTTPActivity11_ExpectedOutputProperties_Document.LoadXml(
@"<Arguments><ResponseHttpVersion /><StatusCode>200</StatusCode><StatusDescription /><ResponseBody /><ResponseBodyAsBase64 /></Arguments>");
            _flow.HTTPActivity11.ExpectedOutputProperties = HTTPActivity11_ExpectedOutputProperties_Document;
            set_HTTPActivity11_checkpoints(_flow.HTTPActivity11);
            XmlDocument StServiceCallActivity6_InputEnvelope_Document = new XmlDocument();
            StServiceCallActivity6_InputEnvelope_Document.PreserveWhitespace = true;
            StServiceCallActivity6_InputEnvelope_Document.LoadXml(
@"<?xml version=""1.0"" encoding=""utf-8""?>
<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"">
  <Header />
  <Body>
    <GetFlights xmlns=""HP.SOAQ.SampleApp"">
      <DepartureCity>London</DepartureCity>
      <ArrivalCity>Paris</ArrivalCity>
      <FlightDate>2020-03-07T00:00:00+01:00</FlightDate>
    </GetFlights>
  </Body>
</Envelope>");
            _flow.StServiceCallActivity6.InputEnvelope = StServiceCallActivity6_InputEnvelope_Document;
            _flow.StServiceCallActivity6.Comment = @"";
            _flow.StServiceCallActivity6.IconPath = @"AddIns\ServiceTest\WSImportTechnology\ictb_service_operations_16.png";
            _flow.StServiceCallActivity6.Name = @"GetFlights";
            _flow.StServiceCallActivity6.TransportProtocol.SOAPProperties.EndpointAddress = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity6.TransportProtocol.SOAPProperties.EndpointAddress}")) ? @"http://localhost:8000/Flights_SOAP" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity6.TransportProtocol.SOAPProperties.EndpointAddress}");
            _flow.StServiceCallActivity6.TransportProtocol.SOAPProperties.SoapAction = @"HP.SOAQ.SampleApp/IFlightsSoapService/GetFlights";
            _flow.StServiceCallActivity6.TransportProtocol.SOAPProperties.ContentType = @"text/xml; charset=utf-8";
            _flow.StServiceCallActivity6.TransportProtocol.SOAPProperties.Timeout = (int)100000;
            _flow.StServiceCallActivity6.Service = @"Flights_Service";
            _flow.StServiceCallActivity6.Port = @"FlightsServiceMethods";
            _flow.StServiceCallActivity6.Operation = @"GetFlights";
            _flow.StServiceCallActivity6.IsOneWay = false;
            _flow.StServiceCallActivity6.SendRequestToService=true;
            _flow.StServiceCallActivity6.FaultExpected=false;
            _flow.StServiceCallActivity6.IsAsync=false;
            _flow.StServiceCallActivity6.TargetNamespace=@"http://tempuri.org/";
            _flow.StServiceCallActivity6.ListenOnPort = (int)0;
            XmlDocument StServiceCallActivity6_ChannelBindingXml = new XmlDocument();
            StServiceCallActivity6_ChannelBindingXml.PreserveWhitespace = true;
            StServiceCallActivity6_ChannelBindingXml.LoadXml(@"<?xml version=""1.0""?>
            <ArrayOfChannelBindingBase xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
              <ChannelBindingBase xsi:type=""HttpChannelBinding"">
                <IsKeepAlive>false</IsKeepAlive>
                <IsPreemptiveAuthentication>false</IsPreemptiveAuthentication>
                <ConnectionTimeout>0</ConnectionTimeout>
              </ChannelBindingBase>
            </ArrayOfChannelBindingBase>");
            _flow.StServiceCallActivity6.ChannelBindingXml = StServiceCallActivity6_ChannelBindingXml;
            XmlDocument StServiceCallActivity6_ExpectedOutputProperties_Document = new XmlDocument();
            StServiceCallActivity6_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity6_ExpectedOutputProperties_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:p1=""http://www.w3.org/2001/XMLSchema-instance""><Body><GetFlightsResponse xmlns=""HP.SOAQ.SampleApp""><GetFlightsResult></GetFlightsResult></GetFlightsResponse></Body></Envelope>");
            _flow.StServiceCallActivity6.ExpectedOutputProperties = StServiceCallActivity6_ExpectedOutputProperties_Document;
            XmlDocument StServiceCallActivity6_ExpectedFaultProperties_Document = new XmlDocument();
            StServiceCallActivity6_ExpectedFaultProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity6_ExpectedFaultProperties_Document.LoadXml(
@"<tns:Envelope xmlns:tns=""http://schemas.xmlsoap.org/soap/envelope/""><tns:Body><tns:Fault><faultcode /><faultstring /></tns:Fault></tns:Body></tns:Envelope>");
            _flow.StServiceCallActivity6.ExpectedFaultProperties = StServiceCallActivity6_ExpectedFaultProperties_Document;
            XmlDocument StServiceCallActivity6_ExpectedOutputAttachments_Document = new XmlDocument();
            StServiceCallActivity6_ExpectedOutputAttachments_Document.PreserveWhitespace = true;
            StServiceCallActivity6_ExpectedOutputAttachments_Document.LoadXml(
@"<OutputAttachments />");
            _flow.StServiceCallActivity6.ExpectedOutputAttachments = StServiceCallActivity6_ExpectedOutputAttachments_Document;
            set_StServiceCallActivity6_checkpoints(_flow.StServiceCallActivity6);
            XmlDocument StServiceCallActivity7_InputEnvelope_Document = new XmlDocument();
            StServiceCallActivity7_InputEnvelope_Document.PreserveWhitespace = true;
            StServiceCallActivity7_InputEnvelope_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:p1=""http://www.w3.org/2001/XMLSchema-instance""><Body><CreateFlightOrder xmlns=""HP.SOAQ.SampleApp""><FlightOrder><Class>Economy</Class><CustomerName>Pawan</CustomerName><DepartureDate>2020-03-07T00:00:00+01:00</DepartureDate><FlightNumber>10436</FlightNumber><NumberOfTickets>1</NumberOfTickets></FlightOrder></CreateFlightOrder></Body></Envelope>");
            _flow.StServiceCallActivity7.InputEnvelope = StServiceCallActivity7_InputEnvelope_Document;
            _flow.StServiceCallActivity7.Comment = @"";
            _flow.StServiceCallActivity7.IconPath = @"AddIns\ServiceTest\WSImportTechnology\ictb_service_operations_16.png";
            _flow.StServiceCallActivity7.Name = @"CreateFlightOrder";
            _flow.StServiceCallActivity7.TransportProtocol.SOAPProperties.EndpointAddress = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity7.TransportProtocol.SOAPProperties.EndpointAddress}")) ? @"http://localhost:8000/Flights_SOAP" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity7.TransportProtocol.SOAPProperties.EndpointAddress}");
            _flow.StServiceCallActivity7.TransportProtocol.SOAPProperties.SoapAction = @"HP.SOAQ.SampleApp/IFlightsSoapService/CreateFlightOrder";
            _flow.StServiceCallActivity7.TransportProtocol.SOAPProperties.ContentType = @"text/xml; charset=utf-8";
            _flow.StServiceCallActivity7.TransportProtocol.SOAPProperties.Timeout = (int)100000;
            _flow.StServiceCallActivity7.Service = @"Flights_Service";
            _flow.StServiceCallActivity7.Port = @"FlightsServiceMethods";
            _flow.StServiceCallActivity7.Operation = @"CreateFlightOrder";
            _flow.StServiceCallActivity7.IsOneWay = false;
            _flow.StServiceCallActivity7.SendRequestToService=true;
            _flow.StServiceCallActivity7.FaultExpected=false;
            _flow.StServiceCallActivity7.IsAsync=false;
            _flow.StServiceCallActivity7.TargetNamespace=@"http://tempuri.org/";
            _flow.StServiceCallActivity7.ListenOnPort = (int)0;
            XmlDocument StServiceCallActivity7_ChannelBindingXml = new XmlDocument();
            StServiceCallActivity7_ChannelBindingXml.PreserveWhitespace = true;
            StServiceCallActivity7_ChannelBindingXml.LoadXml(@"<?xml version=""1.0""?>
            <ArrayOfChannelBindingBase xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
              <ChannelBindingBase xsi:type=""HttpChannelBinding"">
                <IsKeepAlive>false</IsKeepAlive>
                <IsPreemptiveAuthentication>false</IsPreemptiveAuthentication>
                <ConnectionTimeout>0</ConnectionTimeout>
              </ChannelBindingBase>
            </ArrayOfChannelBindingBase>");
            _flow.StServiceCallActivity7.ChannelBindingXml = StServiceCallActivity7_ChannelBindingXml;
            XmlDocument StServiceCallActivity7_ExpectedOutputProperties_Document = new XmlDocument();
            StServiceCallActivity7_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity7_ExpectedOutputProperties_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/""><Body><CreateFlightOrderResponse xmlns=""HP.SOAQ.SampleApp""><CreateFlightOrderResult><OrderNumber /></CreateFlightOrderResult></CreateFlightOrderResponse></Body></Envelope>");
            _flow.StServiceCallActivity7.ExpectedOutputProperties = StServiceCallActivity7_ExpectedOutputProperties_Document;
            XmlDocument StServiceCallActivity7_ExpectedFaultProperties_Document = new XmlDocument();
            StServiceCallActivity7_ExpectedFaultProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity7_ExpectedFaultProperties_Document.LoadXml(
@"<tns:Envelope xmlns:tns=""http://schemas.xmlsoap.org/soap/envelope/""><tns:Body><tns:Fault><faultcode /><faultstring /></tns:Fault></tns:Body></tns:Envelope>");
            _flow.StServiceCallActivity7.ExpectedFaultProperties = StServiceCallActivity7_ExpectedFaultProperties_Document;
            XmlDocument StServiceCallActivity7_ExpectedOutputAttachments_Document = new XmlDocument();
            StServiceCallActivity7_ExpectedOutputAttachments_Document.PreserveWhitespace = true;
            StServiceCallActivity7_ExpectedOutputAttachments_Document.LoadXml(
@"<OutputAttachments />");
            _flow.StServiceCallActivity7.ExpectedOutputAttachments = StServiceCallActivity7_ExpectedOutputAttachments_Document;
            set_StServiceCallActivity7_checkpoints(_flow.StServiceCallActivity7);
            XmlDocument StServiceCallActivity9_InputEnvelope_Document = new XmlDocument();
            StServiceCallActivity9_InputEnvelope_Document.PreserveWhitespace = true;
            StServiceCallActivity9_InputEnvelope_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:p1=""http://www.w3.org/2001/XMLSchema-instance""><Body><UpdateFlightOrder xmlns=""HP.SOAQ.SampleApp""><UpdateFlightOrderDetails><Class>Economy</Class><CustomerName>Pawan</CustomerName><NumberOfTickets>2</NumberOfTickets><OrderNumber>{Step.OutputProperties.StServiceCallActivity7.Body.CreateFlightOrderResponse.CreateFlightOrderResult.OrderNumber}</OrderNumber></UpdateFlightOrderDetails></UpdateFlightOrder></Body></Envelope>");
            _flow.StServiceCallActivity9.InputEnvelope = StServiceCallActivity9_InputEnvelope_Document;
            _flow.StServiceCallActivity9.Comment = @"";
            _flow.StServiceCallActivity9.IconPath = @"AddIns\ServiceTest\WSImportTechnology\ictb_service_operations_16.png";
            _flow.StServiceCallActivity9.Name = @"UpdateFlightOrder";
            _flow.StServiceCallActivity9.TransportProtocol.SOAPProperties.EndpointAddress = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity9.TransportProtocol.SOAPProperties.EndpointAddress}")) ? @"http://localhost:8000/Flights_SOAP" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity9.TransportProtocol.SOAPProperties.EndpointAddress}");
            _flow.StServiceCallActivity9.TransportProtocol.SOAPProperties.SoapAction = @"HP.SOAQ.SampleApp/IFlightsSoapService/UpdateFlightOrder";
            _flow.StServiceCallActivity9.TransportProtocol.SOAPProperties.ContentType = @"text/xml; charset=utf-8";
            _flow.StServiceCallActivity9.TransportProtocol.SOAPProperties.Timeout = (int)100000;
            _flow.StServiceCallActivity9.Service = @"Flights_Service";
            _flow.StServiceCallActivity9.Port = @"FlightsServiceMethods";
            _flow.StServiceCallActivity9.Operation = @"UpdateFlightOrder";
            _flow.StServiceCallActivity9.IsOneWay = false;
            _flow.StServiceCallActivity9.SendRequestToService=true;
            _flow.StServiceCallActivity9.FaultExpected=false;
            _flow.StServiceCallActivity9.IsAsync=false;
            _flow.StServiceCallActivity9.TargetNamespace=@"http://tempuri.org/";
            _flow.StServiceCallActivity9.ListenOnPort = (int)0;
            XmlDocument StServiceCallActivity9_ChannelBindingXml = new XmlDocument();
            StServiceCallActivity9_ChannelBindingXml.PreserveWhitespace = true;
            StServiceCallActivity9_ChannelBindingXml.LoadXml(@"<?xml version=""1.0""?>
            <ArrayOfChannelBindingBase xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
              <ChannelBindingBase xsi:type=""HttpChannelBinding"">
                <IsKeepAlive>false</IsKeepAlive>
                <IsPreemptiveAuthentication>false</IsPreemptiveAuthentication>
                <ConnectionTimeout>0</ConnectionTimeout>
              </ChannelBindingBase>
            </ArrayOfChannelBindingBase>");
            _flow.StServiceCallActivity9.ChannelBindingXml = StServiceCallActivity9_ChannelBindingXml;
            VTDPropertyInfoBase pi1 = new VTDPropertyInfoBase("OutputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='CreateFlightOrderResponse'][1]/*[local-name(.)='CreateFlightOrderResult'][1]/*[local-name(.)='OrderNumber'][1]");
            VTDBaseGetter binding_getter1 = new VTDXPathGetter(pi1,XmlTypeCode.Int);
            VTDPropertyInfoBase pi2 = new VTDPropertyInfoBase("InputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='UpdateFlightOrder'][1]/*[local-name(.)='UpdateFlightOrderDetails'][1]/*[local-name(.)='OrderNumber'][1]");
            VTDBaseSetter binding_setter1 = new VTDXPathSetter(pi2,XmlTypeCode.Int);
            bind_dir1 = new BindDirection(_flow.StServiceCallActivity7,binding_getter1,binding_setter1,BindTargetType.ToInProperty);
            _flow.StServiceCallActivity9.InDirections.Add(bind_dir1);
            XmlDocument StServiceCallActivity9_ExpectedOutputProperties_Document = new XmlDocument();
            StServiceCallActivity9_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity9_ExpectedOutputProperties_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/""><Body><UpdateFlightOrderResponse xmlns=""HP.SOAQ.SampleApp"" /></Body></Envelope>");
            _flow.StServiceCallActivity9.ExpectedOutputProperties = StServiceCallActivity9_ExpectedOutputProperties_Document;
            XmlDocument StServiceCallActivity9_ExpectedFaultProperties_Document = new XmlDocument();
            StServiceCallActivity9_ExpectedFaultProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity9_ExpectedFaultProperties_Document.LoadXml(
@"<tns:Envelope xmlns:tns=""http://schemas.xmlsoap.org/soap/envelope/""><tns:Body><tns:Fault><faultcode /><faultstring /></tns:Fault></tns:Body></tns:Envelope>");
            _flow.StServiceCallActivity9.ExpectedFaultProperties = StServiceCallActivity9_ExpectedFaultProperties_Document;
            XmlDocument StServiceCallActivity9_ExpectedOutputAttachments_Document = new XmlDocument();
            StServiceCallActivity9_ExpectedOutputAttachments_Document.PreserveWhitespace = true;
            StServiceCallActivity9_ExpectedOutputAttachments_Document.LoadXml(
@"<OutputAttachments />");
            _flow.StServiceCallActivity9.ExpectedOutputAttachments = StServiceCallActivity9_ExpectedOutputAttachments_Document;
            set_StServiceCallActivity9_checkpoints(_flow.StServiceCallActivity9);
            XmlDocument StServiceCallActivity10_InputEnvelope_Document = new XmlDocument();
            StServiceCallActivity10_InputEnvelope_Document.PreserveWhitespace = true;
            StServiceCallActivity10_InputEnvelope_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/""><Body><DeleteFlightOrder xmlns=""HP.SOAQ.SampleApp""><OrderNumber>{Step.InputProperties.StServiceCallActivity9.Body.UpdateFlightOrder.UpdateFlightOrderDetails.OrderNumber}</OrderNumber></DeleteFlightOrder></Body></Envelope>");
            _flow.StServiceCallActivity10.InputEnvelope = StServiceCallActivity10_InputEnvelope_Document;
            _flow.StServiceCallActivity10.Comment = @"";
            _flow.StServiceCallActivity10.IconPath = @"AddIns\ServiceTest\WSImportTechnology\ictb_service_operations_16.png";
            _flow.StServiceCallActivity10.Name = @"DeleteFlightOrder";
            _flow.StServiceCallActivity10.TransportProtocol.SOAPProperties.EndpointAddress = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity10.TransportProtocol.SOAPProperties.EndpointAddress}")) ? @"http://localhost:8000/Flights_SOAP" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity10.TransportProtocol.SOAPProperties.EndpointAddress}");
            _flow.StServiceCallActivity10.TransportProtocol.SOAPProperties.SoapAction = @"HP.SOAQ.SampleApp/IFlightsSoapService/DeleteFlightOrder";
            _flow.StServiceCallActivity10.TransportProtocol.SOAPProperties.ContentType = @"text/xml; charset=utf-8";
            _flow.StServiceCallActivity10.TransportProtocol.SOAPProperties.Timeout = (int)100000;
            _flow.StServiceCallActivity10.Service = @"Flights_Service";
            _flow.StServiceCallActivity10.Port = @"FlightsServiceMethods";
            _flow.StServiceCallActivity10.Operation = @"DeleteFlightOrder";
            _flow.StServiceCallActivity10.IsOneWay = false;
            _flow.StServiceCallActivity10.SendRequestToService=true;
            _flow.StServiceCallActivity10.FaultExpected=false;
            _flow.StServiceCallActivity10.IsAsync=false;
            _flow.StServiceCallActivity10.TargetNamespace=@"http://tempuri.org/";
            _flow.StServiceCallActivity10.ListenOnPort = (int)0;
            XmlDocument StServiceCallActivity10_ChannelBindingXml = new XmlDocument();
            StServiceCallActivity10_ChannelBindingXml.PreserveWhitespace = true;
            StServiceCallActivity10_ChannelBindingXml.LoadXml(@"<?xml version=""1.0""?>
            <ArrayOfChannelBindingBase xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
              <ChannelBindingBase xsi:type=""HttpChannelBinding"">
                <IsKeepAlive>false</IsKeepAlive>
                <IsPreemptiveAuthentication>false</IsPreemptiveAuthentication>
                <ConnectionTimeout>0</ConnectionTimeout>
              </ChannelBindingBase>
            </ArrayOfChannelBindingBase>");
            _flow.StServiceCallActivity10.ChannelBindingXml = StServiceCallActivity10_ChannelBindingXml;
            VTDPropertyInfoBase pi3 = new VTDPropertyInfoBase("InputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='UpdateFlightOrder'][1]/*[local-name(.)='UpdateFlightOrderDetails'][1]/*[local-name(.)='OrderNumber'][1]");
            VTDBaseGetter binding_getter2 = new VTDXPathGetter(pi3,XmlTypeCode.Int);
            VTDPropertyInfoBase pi4 = new VTDPropertyInfoBase("InputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='DeleteFlightOrder'][1]/*[local-name(.)='OrderNumber'][1]");
            VTDBaseSetter binding_setter2 = new VTDXPathSetter(pi4,XmlTypeCode.Int);
            bind_dir2 = new BindDirection(_flow.StServiceCallActivity9,binding_getter2,binding_setter2,BindTargetType.ToInProperty);
            _flow.StServiceCallActivity10.InDirections.Add(bind_dir2);
            XmlDocument StServiceCallActivity10_ExpectedOutputProperties_Document = new XmlDocument();
            StServiceCallActivity10_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity10_ExpectedOutputProperties_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/""><Body><DeleteFlightOrderResponse xmlns=""HP.SOAQ.SampleApp"" /></Body></Envelope>");
            _flow.StServiceCallActivity10.ExpectedOutputProperties = StServiceCallActivity10_ExpectedOutputProperties_Document;
            XmlDocument StServiceCallActivity10_ExpectedFaultProperties_Document = new XmlDocument();
            StServiceCallActivity10_ExpectedFaultProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity10_ExpectedFaultProperties_Document.LoadXml(
@"<tns:Envelope xmlns:tns=""http://schemas.xmlsoap.org/soap/envelope/""><tns:Body><tns:Fault><faultcode /><faultstring /></tns:Fault></tns:Body></tns:Envelope>");
            _flow.StServiceCallActivity10.ExpectedFaultProperties = StServiceCallActivity10_ExpectedFaultProperties_Document;
            XmlDocument StServiceCallActivity10_ExpectedOutputAttachments_Document = new XmlDocument();
            StServiceCallActivity10_ExpectedOutputAttachments_Document.PreserveWhitespace = true;
            StServiceCallActivity10_ExpectedOutputAttachments_Document.LoadXml(
@"<OutputAttachments />");
            _flow.StServiceCallActivity10.ExpectedOutputAttachments = StServiceCallActivity10_ExpectedOutputAttachments_Document;
            set_StServiceCallActivity10_checkpoints(_flow.StServiceCallActivity10);
            
        }
        
        internal void InitializeEncryptionManagerValues()
        {
        
        }
        	
    	bool useReport = true;
    
    	protected override STExecutionResult ExecuteStep()
        {
            return base.ExecuteStep();
        }
    
        public void Start()
        {
    	    try
    		{
    		  Workflow_Executing();
    		  this.ExecuteStep();
    		}
    		finally
    		{
    		  WorkFlowScript_Completed();
    		}
        }
    
    	private void InitReport()
    	{
    		if (useReport)
    		{	
    			// Intialize Reporter
    			string reportDBDir = Path.Combine(this._context.ReportDirectory, @"Report");
    			CleanupReport(reportDBDir);        	
    			string reportDBPath = Path.Combine(reportDBDir, "VTDReport.mdb");        	
    			if (reporter == null)
    			{
    				reporter = new Reporter(reportDBPath);
    			}
    			_context.Reporter = reporter;
    		}
    	}
    
        public static void CopyDirectory(string Src, string Dst)
        {
            String[] Files;
    
            if (Dst[Dst.Length - 1] != Path.DirectorySeparatorChar)
                Dst += Path.DirectorySeparatorChar;
            if (!Directory.Exists(Dst)) Directory.CreateDirectory(Dst);
            Files = Directory.GetFileSystemEntries(Src);
            foreach (string Element in Files)
            {
                // Sub directories
                if (Directory.Exists(Element))
                    CopyDirectory(Element, Dst + Path.GetFileName(Element));
                // Files in directory
                else
                    File.Copy(Element, Dst + Path.GetFileName(Element), true);
            }
        }
        
        private void CleanupReport(string reportDBDir)
        {   
    		if (useReport)
    		{             
    			string reportTemplateDir = Path.Combine(ServiceTestRunner.GetInstallPath(),@"bin\ReportResources");                
    			try
    			{
            		CopyDirectory(reportTemplateDir, reportDBDir);
    			}
    			catch //(Exception ex)
    			{
    				//ToDo: LoggingService.Warn("Report Cleanup Error", ex);
    			}
    		}
        }
    
        void Workflow_Executing()
        {   
        	InitReportNode();
                       
        }
    
    	private void InitReportNode()
    	{
    		if (useReport)
    		{	
        		// Init report creator
    			this.reportCreator = new HP.ST.Fwk.ReportCreator.QTPEngine.QTPEngineReportCreator();
    			this.reportLevelInTree = reportCreator.Init(_context.EnvironmentProfile.GetVariableValue("TestName"), _context);
                
    			STActivityBase activity = this;
    			string workflowID = activity.GetHashCode().ToString();
    			ReportNodeCreationData newNodeData =
    			new ReportNodeCreationData(workflowID, workflowID, DateTime.Now);
    			reporter.CreateReportNode(newNodeData);
            
    			ReportInfoData newReportData = new ReportInfoData(workflowID, ReportKeywords.TypeKeywordTag, this.GetType().ToString());
    			reporter.SendReportData(newReportData);
    			newReportData = new ReportInfoData(workflowID, ReportKeywords.NameKeywordTag, this.Name);
    			//TrackData(ReportInfoData.InfoDataTag, newReportData);
    			reporter.SendReportData(newReportData);            
            }
    	}
        
        void WorkFlowScript_Completed()
        {   
    		
    
    		CreateReportFiles();
    					
        	// Write all snapshots to disk
    		this._context.SnapshotManager.WriteSnapshotsToDisk();
    
    		OnExecutionCompleted();
    		
        }
    
    	private void CreateReportFiles()
    	{
    		if (useReport)
    		{	
    			//Dispose reporter inorder to close connection to report DB
           		this._context.Reporter.Dispose();
            	
           		// Run report creator
    			reportCreator.RunOnDBAndCreateFiles();
    		}
    	}
    
        
        void Workflow_Faulting()
        {
    		
    
    		CreateReportFiles();
            // Write all snapshots to disk
    		this._context.SnapshotManager.WriteSnapshotsToDisk();
           
    		OnExecutionCompleted();
        }
    
    	protected override QcSystemVariables GetRuntimeQcVariables(ISTRunTimeContext context)
    	{
    		return new HP.ST.Ext.BasicActivities.RuntimeQcVariables(this._context);
    	}
            
    	protected override TestSystemVariables GetTestSystemVariables(ISTRunTimeContext context)
    	{
    		return new HP.ST.Ext.BasicActivities.RuntimeTestVariables(this._context);
    	}
    
    	private void UpdateTestSettings(ISTRunTimeContext ctx)
        {
    		ctx.PropertyBag["StopTestOnStepFailure"] = true;
    	}
    }
    
    public partial class VuserClass
    {
    	public static string[] CommandLineArguments;
    	public static string[] DotNetResolverPaths;
    	
        public VuserClass()
        {
    				
    		AssemblyResolver.AddSTPathsToResolutionPaths();
    		AssemblyResolver.AttachToAppdomain();
        }
    
        private void AddAssemblyResolver()
        {
    		AssemblyResolver.AddTestPathToResolutionPaths(GetTestPath());
    		AssemblyResolver.AddPathsForAssemblyResolution(DotNetResolverPaths);
        }
    	
        public int STAction()
        {	
            AddAssemblyResolver();
            STRunTimeContext ctx = new STRunTimeContext(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName, string.Empty);
            WorkFlowScript script = new WorkFlowScript(ctx);
            script.InitializeComponent();
            script.Start();       
            
            return 0;
        }
        
        public void NotifyLicenseException(string msg)
        {
        		
    		try
    		{
    		    STRunTimeContext ctx = new STRunTimeContext(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName, string.Empty);
                WorkFlowScript script = new WorkFlowScript(ctx);
                script.InitializeComponent();
                script.Context.ReplayClient.OnLicenseFailure(msg);
                
            }
            catch (Exception)
            {
    			// ToDo: log the error message
            }        
        }
    
    	 protected string GetTestPath()
            {
                if (CommandLineArguments != null)
                {
                    for (int i = 0; i < CommandLineArguments.Length; i++)
                    {
                        if (CommandLineArguments[i].Equals("-test", StringComparison.OrdinalIgnoreCase))
                        {
                            return CommandLineArguments[i + 1];
                        }
                    }
                }
                return String.Empty;
            }
        
    }
    
    }
    