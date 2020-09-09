namespace BTAHL7Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://microsoft.com/HealthCare/HL7/2X",@"ACK_26_GLO_DEF")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::BTAHL7Schemas.MSA1), XPath = @"/*[local-name()='ACK_26_GLO_DEF' and namespace-uri()='http://microsoft.com/HealthCare/HL7/2X']/*[local-name()='MSA_MessageAcknowledgment' and namespace-uri()='']/*[local-name()='MSA.1_AcknowledgmentCode' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ACK_26_GLO_DEF"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTAHL7Schemas.HL7PropertySchema", typeof(global::BTAHL7Schemas.HL7PropertySchema))]
    public sealed class ACK_26_GLO_DEF : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://microsoft.com/HealthCare/HL7/2X"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://HL7Schemas.HeaderPropertySchema"" targetNamespace=""http://microsoft.com/HealthCare/HL7/2X"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo root_reference=""ACK_26_GLO_DEF"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""http://HL7Schemas.HeaderPropertySchema"" location=""BTAHL7Schemas.HL7PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""ACK_26_GLO_DEF"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:MSA1"" xpath=""/*[local-name()='ACK_26_GLO_DEF' and namespace-uri()='http://microsoft.com/HealthCare/HL7/2X']/*[local-name()='MSA_MessageAcknowledgment' and namespace-uri()='']/*[local-name()='MSA.1_AcknowledgmentCode' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""MSA_MessageAcknowledgment"" type=""MSA"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SFT_SoftwareSegment"" type=""SFT"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""UAC_UserAuthenticationCredentialSegment"" type=""UAC"" />
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
      <xs:element minOccurs=""0"" name=""MSA.7_MessageWaitingNumber"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""MSA.8_MessageWaitingPriority"" type=""ID_520"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""SFT"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""SFT_1_SoftwareVendorOrganization"" type=""XON"" />
      <xs:element minOccurs=""1"" name=""SFT_2_SoftwareCertifiedVersionOrReleaseNumber"" type=""ST"" />
      <xs:element minOccurs=""1"" name=""SFT_3_SoftwareProductName"" type=""ST"" />
      <xs:element minOccurs=""1"" name=""SFT_4_SoftwareBinaryId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""SFT_5_SoftwareProductInformation"" type=""TX"" />
      <xs:element minOccurs=""0"" name=""SFT_6_SoftwareInstallDate"" type=""DTM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ED"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ED_0_SourceApplication"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""ED_0_0_NamespaceId"" type=""IS_0_300"" />
            <xs:element minOccurs=""0"" name=""ED_0_1_UniversalId"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""ED_0_2_UniversalIdType"" type=""ID_2_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ED_1_TypeOfData"" type=""ID_834"" />
      <xs:element minOccurs=""0"" name=""ED_2_DataSubtype"" type=""ID_291"" />
      <xs:element minOccurs=""0"" name=""ED_3_Encoding"" type=""ID_299"" />
      <xs:element minOccurs=""0"" name=""ED_4_Data"" type=""TX"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ERR"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ERR_1_ErrorCodeAndLocation"" type=""ELD"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ERR_2_ErrorLocation"" type=""ERL"" />
      <xs:element minOccurs=""1"" name=""ERR_3_Hl7ErrorCode"" type=""CWE_357"" />
      <xs:element minOccurs=""1"" name=""ERR_4_Severity"" type=""ID_516"" />
      <xs:element minOccurs=""0"" name=""ERR_5_ApplicationErrorCode"" type=""CWE_533"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ERR_6_ApplicationErrorParameter"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""ERR_7_DiagnosticInformation"" type=""TX"" />
      <xs:element minOccurs=""0"" name=""ERR_8_UserMessage"" type=""TX"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ERR_9_InformPersonIndicator"" type=""IS_517"" />
      <xs:element minOccurs=""0"" name=""ERR_10_OverrideType"" type=""CWE_518"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ERR_11_OverrideReasonCode"" type=""CWE_519"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ERR_12_HelpDeskContactPoint"" type=""XTN"" />
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
            <xs:element minOccurs=""0"" name=""CM_ELD.3.2_CodeIdentifyingError"" type=""IS_396"" />
            <xs:element minOccurs=""0"" name=""CM_ELD.3.3_CodeIdentifyingError"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""CM_ELD.3.4_CodeIdentifyingError"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""CM_ELD.3.5_CodeIdentifyingError"" type=""IS_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""UAC"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""UAC_1_UserAuthenticationCredentialTypeCode"" type=""CWE_615"" />
      <xs:element minOccurs=""1"" name=""UAC_2_UserAuthenticationCredential"" type=""ED"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_357"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_0_0_StringData"" type=""ID_0_357"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_1_Text"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_1_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_2_0_CodedValueForHl7DefinedTables"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_3_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_4_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_5_0_CodedValueForHl7DefinedTables"" type=""ID_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_6_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_7_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_8_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_518"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_0_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_1_Text"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_1_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_2_0_CodedValueForHl7DefinedTables"" type=""ID_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_3_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_4_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_5_0_CodedValueForHl7DefinedTables"" type=""ID_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_6_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_7_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_8_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_519"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_0_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_1_Text"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_1_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_2_0_CodedValueForHl7DefinedTables"" type=""ID_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_3_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_4_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_5_0_CodedValueForHl7DefinedTables"" type=""ID_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_6_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_7_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_8_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_533"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_0_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_1_Text"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_1_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_2_0_CodedValueForHl7DefinedTables"" type=""ID_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_3_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_4_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_5_0_CodedValueForHl7DefinedTables"" type=""ID_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_6_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_7_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CWE_8_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ELD"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ELD_0_SegmentId"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""ELD_0_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ELD_1_SegmentSequence"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""ELD_1_0_Numeric"" type=""NM_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ELD_2_FieldPosition"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""ELD_2_0_Numeric"" type=""NM_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ELD_3_CodeIdentifyingError"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""ELD_3_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""ELD_3_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""ELD_3_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""ELD_3_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""ELD_3_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""ELD_3_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ERL"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ERL_0_SegmentId"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""ERL_0_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ERL_1_SegmentSequence"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""ERL_1_0_Numeric"" type=""NM_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ERL_2_FieldPosition"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""ERL_2_0_Numeric"" type=""NM_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ERL_3_FieldRepetition"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""ERL_3_0_Numeric"" type=""NM_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ERL_4_ComponentNumber"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""ERL_4_0_Numeric"" type=""NM_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ERL_5_SubComponentNumber"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""ERL_5_0_Numeric"" type=""NM_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ID_516"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ID_0_CodedValueForHl7DefinedTables"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""ID_0_0_CodedValueForHl7DefinedTables"" type=""ID_0_516"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""IS_517"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""IS_0_CodedValueForUserDefinedTables"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""IS_0_0_CodedValueForUserDefinedTables"" type=""IS_0_517"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""TS"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""TS_0_Time"" type=""DTM_0"" />
      <xs:element minOccurs=""0"" name=""TS_1_DegreeOfPrecision"" type=""ID_0"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""XON"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""XON_0_OrganizationName"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XON_1_OrganizationNameTypeCode"" type=""IS_204"" />
      <xs:element minOccurs=""0"" name=""XON_2_IdNumber"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""XON_3_CheckDigit"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""XON_4_CheckDigitScheme"" type=""ID_61"" />
      <xs:element minOccurs=""0"" name=""XON_5_AssigningAuthority"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XON_5_0_NamespaceId"" type=""IS_0_300"" />
            <xs:element minOccurs=""0"" name=""XON_5_1_UniversalId"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XON_5_2_UniversalIdType"" type=""ID_2_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XON_6_IdentifierTypeCode"" type=""ID_203"" />
      <xs:element minOccurs=""0"" name=""XON_7_AssigningFacility"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XON_7_0_NamespaceId"" type=""IS_0_300"" />
            <xs:element minOccurs=""0"" name=""XON_7_1_UniversalId"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""XON_7_2_UniversalIdType"" type=""ID_2_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XON_8_NameRepresentationCode"" type=""ID_465"" />
      <xs:element minOccurs=""0"" name=""XON_9_OrganizationIdentifier"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""XTN"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""XTN_0_TelephoneNumber"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XTN_0_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XTN_1_TelecommunicationUseCode"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XTN_1_0_CodedValueForHl7DefinedTables"" type=""ID_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XTN_2_TelecommunicationEquipmentType"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XTN_2_0_CodedValueForHl7DefinedTables"" type=""ID_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XTN_3_EmailAddress"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XTN_3_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XTN_4_CountryCode"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XTN_4_0_Numeric"" type=""NM_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XTN_5_AreaCityCode"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XTN_5_0_Numeric"" type=""NM_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XTN_6_LocalNumber"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XTN_6_0_Numeric"" type=""NM_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XTN_7_Extension"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XTN_7_0_Numeric"" type=""NM_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XTN_8_AnyText"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XTN_8_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XTN_9_ExtensionPrefix"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XTN_9_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XTN_10_SpeedDialCode"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XTN_10_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XTN_11_UnformattedTelephoneNumber"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XTN_11_0_StringData"" type=""ST_0"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE_615"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:simpleType name=""DTM"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""DTM_0"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ID_0_357"">
    <xs:restriction base=""Table357"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_0_516"">
    <xs:restriction base=""Table516"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_0"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ID_2_301"">
    <xs:restriction base=""Table301"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_2_396"">
    <xs:restriction base=""Table396"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_5_396"">
    <xs:restriction base=""Table396"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_8"">
    <xs:restriction base=""Table8"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_520"">
    <xs:restriction base=""Table520"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_0_517"">
    <xs:restriction base=""Table517"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_0"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""NM_0"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""NM"">
    <xs:restriction base=""xs:integer"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_0"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ST_3"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ST_4"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ST"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""TX"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ID_102"">
    <xs:restriction base=""Table102"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_357"">
    <xs:restriction base=""Table357"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_0_300"">
    <xs:restriction base=""Table300"" />
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
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table516"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""W"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table517"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""HD"" />
      <xs:enumeration value=""NPAT"" />
      <xs:enumeration value=""PAT"" />
      <xs:enumeration value=""USR"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table520"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""H"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""M"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""IS_204"">
    <xs:restriction base=""Table204"" />
  </xs:simpleType>
  <xs:simpleType name=""Table204"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""SL"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ID_61"">
    <xs:restriction base=""Table61"" />
  </xs:simpleType>
  <xs:simpleType name=""Table61"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""ISO"" />
      <xs:enumeration value=""M10"" />
      <xs:enumeration value=""M11"" />
      <xs:enumeration value=""NPI"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ID_203"">
    <xs:restriction base=""Table203"" />
  </xs:simpleType>
  <xs:simpleType name=""Table203"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AM"" />
      <xs:enumeration value=""AMA"" />
      <xs:enumeration value=""AN"" />
      <xs:enumeration value=""An Identifier for a provi"" />
      <xs:enumeration value=""ANC"" />
      <xs:enumeration value=""AND"" />
      <xs:enumeration value=""ANON"" />
      <xs:enumeration value=""ANT"" />
      <xs:enumeration value=""APRN"" />
      <xs:enumeration value=""BA"" />
      <xs:enumeration value=""BC"" />
      <xs:enumeration value=""BCT"" />
      <xs:enumeration value=""BR"" />
      <xs:enumeration value=""BRN"" />
      <xs:enumeration value=""CC"" />
      <xs:enumeration value=""CONM"" />
      <xs:enumeration value=""CY"" />
      <xs:enumeration value=""CZ"" />
      <xs:enumeration value=""DDS"" />
      <xs:enumeration value=""DEA"" />
      <xs:enumeration value=""DFN"" />
      <xs:enumeration value=""DI"" />
      <xs:enumeration value=""DL"" />
      <xs:enumeration value=""DN"" />
      <xs:enumeration value=""DO"" />
      <xs:enumeration value=""DP"" />
      <xs:enumeration value=""DPM"" />
      <xs:enumeration value=""DR"" />
      <xs:enumeration value=""DS"" />
      <xs:enumeration value=""EI"" />
      <xs:enumeration value=""EN"" />
      <xs:enumeration value=""ESN"" />
      <xs:enumeration value=""FI"" />
      <xs:enumeration value=""GI"" />
      <xs:enumeration value=""GL"" />
      <xs:enumeration value=""GN"" />
      <xs:enumeration value=""HC"" />
      <xs:enumeration value=""IND"" />
      <xs:enumeration value=""JHN"" />
      <xs:enumeration value=""LI"" />
      <xs:enumeration value=""LN"" />
      <xs:enumeration value=""LR"" />
      <xs:enumeration value=""MA"" />
      <xs:enumeration value=""MB"" />
      <xs:enumeration value=""MC"" />
      <xs:enumeration value=""MCD"" />
      <xs:enumeration value=""MCN"" />
      <xs:enumeration value=""MCR"" />
      <xs:enumeration value=""MCT"" />
      <xs:enumeration value=""MD"" />
      <xs:enumeration value=""MI"" />
      <xs:enumeration value=""MR"" />
      <xs:enumeration value=""MRT"" />
      <xs:enumeration value=""MS"" />
      <xs:enumeration value=""NCT"" />
      <xs:enumeration value=""NE"" />
      <xs:enumeration value=""NH"" />
      <xs:enumeration value=""NI"" />
      <xs:enumeration value=""NII"" />
      <xs:enumeration value=""NIIP"" />
      <xs:enumeration value=""NNxxx"" />
      <xs:enumeration value=""NP"" />
      <xs:enumeration value=""NPI"" />
      <xs:enumeration value=""OD"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""PCN"" />
      <xs:enumeration value=""PE"" />
      <xs:enumeration value=""PEN"" />
      <xs:enumeration value=""PI"" />
      <xs:enumeration value=""PN"" />
      <xs:enumeration value=""PNT"" />
      <xs:enumeration value=""PPIN"" />
      <xs:enumeration value=""PPN"" />
      <xs:enumeration value=""PRC"" />
      <xs:enumeration value=""PRN"" />
      <xs:enumeration value=""PT"" />
      <xs:enumeration value=""QA"" />
      <xs:enumeration value=""RI"" />
      <xs:enumeration value=""RN"" />
      <xs:enumeration value=""RPH"" />
      <xs:enumeration value=""RR"" />
      <xs:enumeration value=""RRI"" />
      <xs:enumeration value=""RRP"" />
      <xs:enumeration value=""SL"" />
      <xs:enumeration value=""SN"" />
      <xs:enumeration value=""SP"" />
      <xs:enumeration value=""SR"" />
      <xs:enumeration value=""SS"" />
      <xs:enumeration value=""TAX"" />
      <xs:enumeration value=""TN"" />
      <xs:enumeration value=""TPR"" />
      <xs:enumeration value=""U"" />
      <xs:enumeration value=""UPIN"" />
      <xs:enumeration value=""VN"" />
      <xs:enumeration value=""VP"" />
      <xs:enumeration value=""VS"" />
      <xs:enumeration value=""WC"" />
      <xs:enumeration value=""WCN"" />
      <xs:enumeration value=""WP"" />
      <xs:enumeration value=""XX"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ID_465"">
    <xs:restriction base=""Table465"" />
  </xs:simpleType>
  <xs:simpleType name=""Table465"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""P"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ST_1"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ID_834"">
    <xs:restriction base=""Table834"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_291"">
    <xs:restriction base=""Table291"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_299"">
    <xs:restriction base=""Table299"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_396"">
    <xs:restriction base=""Table396"" />
  </xs:simpleType>
  <xs:simpleType name=""Table300"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table301"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""DNS"" />
      <xs:enumeration value=""GUID"" />
      <xs:enumeration value=""HCD"" />
      <xs:enumeration value=""HL7"" />
      <xs:enumeration value=""ISO"" />
      <xs:enumeration value=""L,M,N"" />
      <xs:enumeration value=""Random"" />
      <xs:enumeration value=""URI"" />
      <xs:enumeration value=""UUID"" />
      <xs:enumeration value=""x400"" />
      <xs:enumeration value=""x500"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table291"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""x-hl7-cda-level-one"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table299"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""Base64"" />
      <xs:enumeration value=""Hex"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table396"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""99zzz or L"" />
      <xs:enumeration value=""ACR"" />
      <xs:enumeration value=""ALPHAID2006"" />
      <xs:enumeration value=""ALPHAID2007"" />
      <xs:enumeration value=""ALPHAID2008"" />
      <xs:enumeration value=""ANS+"" />
      <xs:enumeration value=""ART"" />
      <xs:enumeration value=""AS4"" />
      <xs:enumeration value=""AS4E"" />
      <xs:enumeration value=""ATC"" />
      <xs:enumeration value=""C4"" />
      <xs:enumeration value=""C5"" />
      <xs:enumeration value=""CAS"" />
      <xs:enumeration value=""CCC"" />
      <xs:enumeration value=""CD2"" />
      <xs:enumeration value=""CDCA"" />
      <xs:enumeration value=""CDCM"" />
      <xs:enumeration value=""CDS"" />
      <xs:enumeration value=""CE (obsolete)"" />
      <xs:enumeration value=""CLP"" />
      <xs:enumeration value=""CPTM"" />
      <xs:enumeration value=""CST"" />
      <xs:enumeration value=""CVX"" />
      <xs:enumeration value=""DCM"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""E5"" />
      <xs:enumeration value=""E6"" />
      <xs:enumeration value=""E7"" />
      <xs:enumeration value=""ENZC"" />
      <xs:enumeration value=""FDDC"" />
      <xs:enumeration value=""FDDX"" />
      <xs:enumeration value=""FDK"" />
      <xs:enumeration value=""GDRG2004"" />
      <xs:enumeration value=""GDRG2005"" />
      <xs:enumeration value=""GDRG2006"" />
      <xs:enumeration value=""GDRG2007"" />
      <xs:enumeration value=""GDRG2008"" />
      <xs:enumeration value=""GMDC2004"" />
      <xs:enumeration value=""GMDC2005"" />
      <xs:enumeration value=""GMDC2006"" />
      <xs:enumeration value=""GMDC2007"" />
      <xs:enumeration value=""GMDC2008"" />
      <xs:enumeration value=""HB"" />
      <xs:enumeration value=""HCPCS"" />
      <xs:enumeration value=""HCPT"" />
      <xs:enumeration value=""HHC"" />
      <xs:enumeration value=""HI"" />
      <xs:enumeration value=""HL7nnnn"" />
      <xs:enumeration value=""HOT"" />
      <xs:enumeration value=""HPC"" />
      <xs:enumeration value=""I10"" />
      <xs:enumeration value=""I10G2004"" />
      <xs:enumeration value=""I10G2005"" />
      <xs:enumeration value=""I10G2006"" />
      <xs:enumeration value=""I10P"" />
      <xs:enumeration value=""I9"" />
      <xs:enumeration value=""I9C"" />
      <xs:enumeration value=""I9CDX"" />
      <xs:enumeration value=""I9CP"" />
      <xs:enumeration value=""IBT"" />
      <xs:enumeration value=""IBTnnnn"" />
      <xs:enumeration value=""ICD10AM"" />
      <xs:enumeration value=""ICD10CA"" />
      <xs:enumeration value=""ICD10GM2007"" />
      <xs:enumeration value=""ICD10GM2008"" />
      <xs:enumeration value=""ICDO"" />
      <xs:enumeration value=""ICS"" />
      <xs:enumeration value=""ICSD"" />
      <xs:enumeration value=""ISO+"" />
      <xs:enumeration value=""ISOnnnn"" />
      <xs:enumeration value=""ITIS"" />
      <xs:enumeration value=""IUPC"" />
      <xs:enumeration value=""IUPP"" />
      <xs:enumeration value=""JC10"" />
      <xs:enumeration value=""JC8"" />
      <xs:enumeration value=""JJ1017"" />
      <xs:enumeration value=""LB"" />
      <xs:enumeration value=""LN"" />
      <xs:enumeration value=""MCD"" />
      <xs:enumeration value=""MCR"" />
      <xs:enumeration value=""MDC"" />
      <xs:enumeration value=""MDDX"" />
      <xs:enumeration value=""MEDC"" />
      <xs:enumeration value=""MEDR"" />
      <xs:enumeration value=""MEDX"" />
      <xs:enumeration value=""MGPI"" />
      <xs:enumeration value=""MVX"" />
      <xs:enumeration value=""NCPDPnnnnsss"" />
      <xs:enumeration value=""NDA"" />
      <xs:enumeration value=""NDC"" />
      <xs:enumeration value=""NIC"" />
      <xs:enumeration value=""NPI"" />
      <xs:enumeration value=""NUBC"" />
      <xs:enumeration value=""O301"" />
      <xs:enumeration value=""O3012004"" />
      <xs:enumeration value=""O3012005"" />
      <xs:enumeration value=""O3012006"" />
      <xs:enumeration value=""OHA"" />
      <xs:enumeration value=""OPS2007"" />
      <xs:enumeration value=""OPS2008"" />
      <xs:enumeration value=""POS"" />
      <xs:enumeration value=""RC"" />
      <xs:enumeration value=""SCT"" />
      <xs:enumeration value=""SCT2"" />
      <xs:enumeration value=""SDM"" />
      <xs:enumeration value=""SNM"" />
      <xs:enumeration value=""SNM3"" />
      <xs:enumeration value=""SNT"" />
      <xs:enumeration value=""UB04FL14"" />
      <xs:enumeration value=""UB04FL15"" />
      <xs:enumeration value=""UB04FL17"" />
      <xs:enumeration value=""UC"" />
      <xs:enumeration value=""UCUM"" />
      <xs:enumeration value=""UMD"" />
      <xs:enumeration value=""UML"" />
      <xs:enumeration value=""UPC"" />
      <xs:enumeration value=""UPIN"" />
      <xs:enumeration value=""USPS"" />
      <xs:enumeration value=""W1"" />
      <xs:enumeration value=""W2"" />
      <xs:enumeration value=""W4"" />
      <xs:enumeration value=""WC"" />
      <xs:enumeration value=""X12DEnnnn"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table834"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""application"" />
      <xs:enumeration value=""audio"" />
      <xs:enumeration value=""image"" />
      <xs:enumeration value=""model"" />
      <xs:enumeration value=""multipart"" />
      <xs:enumeration value=""text"" />
      <xs:enumeration value=""video"" />
    </xs:restriction>
  </xs:simpleType>
</xs:schema>";
        
        private const global::BTAHL7Schemas.HL7PropertySchema  __DummyVar0 = null;
        
        public ACK_26_GLO_DEF() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ACK_26_GLO_DEF";
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
