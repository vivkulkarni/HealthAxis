namespace BTAHL7Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://microsoft.com/HealthCare/HL7/2X",@"ACK_24_GLO_DEF")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::BTAHL7Schemas.MSA1), XPath = @"/*[local-name()='ACK_24_GLO_DEF' and namespace-uri()='http://microsoft.com/HealthCare/HL7/2X']/*[local-name()='MSA_MessageAcknowledgment' and namespace-uri()='']/*[local-name()='MSA.1_AcknowledgmentCode' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ACK_24_GLO_DEF"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTAHL7Schemas.HL7PropertySchema", typeof(global::BTAHL7Schemas.HL7PropertySchema))]
    public sealed class ACK_24_GLO_DEF : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://microsoft.com/HealthCare/HL7/2X"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://HL7Schemas.HeaderPropertySchema"" targetNamespace=""http://microsoft.com/HealthCare/HL7/2X"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo root_reference=""ACK_24_GLO_DEF"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""http://HL7Schemas.HeaderPropertySchema"" location=""BTAHL7Schemas.HL7PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""ACK_24_GLO_DEF"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:MSA1"" xpath=""/*[local-name()='ACK_24_GLO_DEF' and namespace-uri()='http://microsoft.com/HealthCare/HL7/2X']/*[local-name()='MSA_MessageAcknowledgment' and namespace-uri()='']/*[local-name()='MSA.1_AcknowledgmentCode' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""MSA_MessageAcknowledgment"" type=""MSA"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ERR_Error"" type=""ERR"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:complexType name=""MSA"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""MSA.1_AcknowledgmentCode"" type=""ID_8"" />
      <xs:element minOccurs=""1"" name=""MSA.2_MessageControlId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""MSA.3_TextMessage"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""MSA.4_ExpectedSequenceNumber"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""MSA.5_DelayedAcknowledgmentType"" type=""ID_102"" />
      <xs:element minOccurs=""0"" name=""MSA.6_ErrorCondition"" type=""CE_0357_357"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ERR"">
    <xs:sequence>
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""ERR.1_ErrorCodeAndLocation"" type=""CM_ELD"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0357_357"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0357.0_IdentifierId"" type=""ID_357"" />
      <xs:element minOccurs=""0"" name=""CE_0357.1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0357.2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0357.3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0357.4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0357.5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CM_ELD"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CM_ELD.0_SegmentId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CM_ELD.1_Sequence"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""CM_ELD.2_FieldPosition"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""CM_ELD.3_CodeIdentifyingError"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CM_ELD.3.0_CodeIdentifyingError"" type=""ID"" />
            <xs:element minOccurs=""0"" name=""CM_ELD.3.1_CodeIdentifyingError"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""CM_ELD.3.2_CodeIdentifyingError"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""CM_ELD.3.3_CodeIdentifyingError"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""CM_ELD.3.4_CodeIdentifyingError"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""CM_ELD.3.5_CodeIdentifyingError"" type=""IS_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:simpleType name=""ID_8"">
    <xs:restriction base=""Table8"" />
  </xs:simpleType>
  <xs:simpleType name=""ST"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""NM"">
    <xs:restriction base=""xs:integer"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_102"">
    <xs:restriction base=""Table102"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_357"">
    <xs:restriction base=""Table357"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_396"">
    <xs:restriction base=""Table396"" />
  </xs:simpleType>
  <xs:simpleType name=""ID"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table8"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AE"" />
      <xs:enumeration value=""AR"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""CR"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table102"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""F"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table357"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""0"" />
      <xs:enumeration value=""100"" />
      <xs:enumeration value=""101"" />
      <xs:enumeration value=""102"" />
      <xs:enumeration value=""103"" />
      <xs:enumeration value=""200"" />
      <xs:enumeration value=""201"" />
      <xs:enumeration value=""202"" />
      <xs:enumeration value=""203"" />
      <xs:enumeration value=""204"" />
      <xs:enumeration value=""205"" />
      <xs:enumeration value=""206"" />
      <xs:enumeration value=""207"" />
      <xs:enumeration value=""Errors"" />
      <xs:enumeration value=""Rejection"" />
      <xs:enumeration value=""Success"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table396"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""99zzz or L"" />
      <xs:enumeration value=""ACR"" />
      <xs:enumeration value=""ART"" />
      <xs:enumeration value=""AS4"" />
      <xs:enumeration value=""AS4E"" />
      <xs:enumeration value=""ATC"" />
      <xs:enumeration value=""C4"" />
      <xs:enumeration value=""C5"" />
      <xs:enumeration value=""CAS"" />
      <xs:enumeration value=""CD2"" />
      <xs:enumeration value=""CDCA"" />
      <xs:enumeration value=""CDCM"" />
      <xs:enumeration value=""CDS"" />
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""CLP"" />
      <xs:enumeration value=""CPTM"" />
      <xs:enumeration value=""CST"" />
      <xs:enumeration value=""CVX"" />
      <xs:enumeration value=""DCL"" />
      <xs:enumeration value=""DCM"" />
      <xs:enumeration value=""DQL"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""E5"" />
      <xs:enumeration value=""E6"" />
      <xs:enumeration value=""E7"" />
      <xs:enumeration value=""ENZC"" />
      <xs:enumeration value=""FDDC"" />
      <xs:enumeration value=""FDDX"" />
      <xs:enumeration value=""FDK"" />
      <xs:enumeration value=""HB"" />
      <xs:enumeration value=""HCPCS"" />
      <xs:enumeration value=""HHC"" />
      <xs:enumeration value=""HI"" />
      <xs:enumeration value=""HL7nnnn"" />
      <xs:enumeration value=""HL7-BTA"" />
      <xs:enumeration value=""HPC"" />
      <xs:enumeration value=""I10"" />
      <xs:enumeration value=""I10P"" />
      <xs:enumeration value=""I9"" />
      <xs:enumeration value=""I9C"" />
      <xs:enumeration value=""IBT"" />
      <xs:enumeration value=""IC2"" />
      <xs:enumeration value=""ICDO"" />
      <xs:enumeration value=""ICS"" />
      <xs:enumeration value=""ICSD"" />
      <xs:enumeration value=""ISOnnnn"" />
      <xs:enumeration value=""IUPC"" />
      <xs:enumeration value=""IUPP"" />
      <xs:enumeration value=""JC8"" />
      <xs:enumeration value=""LB"" />
      <xs:enumeration value=""LN"" />
      <xs:enumeration value=""MCD"" />
      <xs:enumeration value=""MCR"" />
      <xs:enumeration value=""MDDX"" />
      <xs:enumeration value=""MEDC"" />
      <xs:enumeration value=""MEDR"" />
      <xs:enumeration value=""MEDX"" />
      <xs:enumeration value=""MGPI"" />
      <xs:enumeration value=""MVX"" />
      <xs:enumeration value=""NDA"" />
      <xs:enumeration value=""NDC"" />
      <xs:enumeration value=""NIC"" />
      <xs:enumeration value=""NPI"" />
      <xs:enumeration value=""OHA"" />
      <xs:enumeration value=""POS"" />
      <xs:enumeration value=""RC"" />
      <xs:enumeration value=""SDM"" />
      <xs:enumeration value=""SNM"" />
      <xs:enumeration value=""SNM3"" />
      <xs:enumeration value=""SNT"" />
      <xs:enumeration value=""UC"" />
      <xs:enumeration value=""UMD"" />
      <xs:enumeration value=""UML"" />
      <xs:enumeration value=""UPC"" />
      <xs:enumeration value=""UPIN"" />
      <xs:enumeration value=""W1"" />
      <xs:enumeration value=""W2"" />
      <xs:enumeration value=""W4"" />
      <xs:enumeration value=""WC"" />
    </xs:restriction>
  </xs:simpleType>
</xs:schema>";
        
        private const global::BTAHL7Schemas.HL7PropertySchema  __DummyVar0 = null;
        
        public ACK_24_GLO_DEF() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ACK_24_GLO_DEF";
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
