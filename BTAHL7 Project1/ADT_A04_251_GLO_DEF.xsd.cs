namespace BTAHL7Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://microsoft.com/HealthCare/HL7/2X",@"ADT_A04_251_GLO_DEF")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ADT_A04_251_GLO_DEF"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTAHL7Schemas.segments_251", typeof(global::BTAHL7Schemas.segments_251))]
    public sealed class ADT_A04_251_GLO_DEF : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://microsoft.com/HealthCare/HL7/2X"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://microsoft.com/HealthCare/HL7/2X/2.5.1/Segments"" targetNamespace=""http://microsoft.com/HealthCare/HL7/2X"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""BTAHL7Schemas.segments_251"" namespace=""http://microsoft.com/HealthCare/HL7/2X/2.5.1/Segments"" />
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo standards_version=""HL7.DBVersion.1_5"" document_type=""HL7 2X Schema"" version=""0.0.0.0.2.0"" root_reference=""ADT_A04_251_GLO_DEF"" />
      <b:references>
        <b:reference targetNamespace=""http://microsoft.com/HealthCare/HL7/2X/2.5.1/Tables"" />
        <b:reference targetNamespace=""http://microsoft.com/HealthCare/HL7/2X/2.5.1/DataTypes"" />
        <b:reference targetNamespace=""http://microsoft.com/HealthCare/HL7/2X/2.5.1/Segments"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""ADT_A04_251_GLO_DEF"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SFT_SoftwareSegment"" type=""ns0:SFT"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""EVN_EventType"" type=""ns0:EVN"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""PID_PatientIdentification"" type=""ns0:PID"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""PD1_PatientAdditionalDemographic"" type=""ns0:PD1"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ROL_Role"" type=""ns0:ROL"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""NK1_NextOfKinAssociatedParties"" type=""ns0:NK1"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""PV1_PatientVisit"" type=""ns0:PV1"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""PV2_PatientVisitAdditionalInformation"" type=""ns0:PV2"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ROL_Role"" type=""ns0:ROL"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""DB1_Disability"" type=""ns0:DB1"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OBX_ObservationResult"" type=""ns0:OBX"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AL1_PatientAllergyInformation"" type=""ns0:AL1"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""DG1_Diagnosis"" type=""ns0:DG1"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DRG_DiagnosisRelatedGroup"" type=""ns0:DRG"" />
        <xs:sequence minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""PR1_Procedures"" type=""ns0:PR1"" />
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ROL_Role"" type=""ns0:ROL"" />
        </xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GT1_Guarantor"" type=""ns0:GT1"" />
        <xs:sequence minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""IN1_Insurance"" type=""ns0:IN1"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""IN2_InsuranceAdditionalInformation"" type=""ns0:IN2"" />
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN3_InsuranceAdditionalInformationCertification"" type=""ns0:IN3"" />
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ROL_Role"" type=""ns0:ROL"" />
        </xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ACC_Accident"" type=""ns0:ACC"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""UB1_Ub82"" type=""ns0:UB1"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""UB2_Ub92Data"" type=""ns0:UB2"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""PDA_PatientDeathAndAutopsy"" type=""ns0:PDA"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        private const global::BTAHL7Schemas.segments_251  __DummyVar0 = null;
        
        public ADT_A04_251_GLO_DEF() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ADT_A04_251_GLO_DEF";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
