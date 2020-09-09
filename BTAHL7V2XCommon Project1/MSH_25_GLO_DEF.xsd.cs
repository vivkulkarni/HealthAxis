namespace BTAHL7Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://microsoft.com/HealthCare/HL7/2X",@"MSH_25_GLO_DEF")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"MSH_25_GLO_DEF"})]
    public sealed class MSH_25_GLO_DEF : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://microsoft.com/HealthCare/HL7/2X"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://microsoft.com/HealthCare/HL7/2X"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo root_reference=""MSH_25_GLO_DEF"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""MSH_25_GLO_DEF"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""MSH"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""1"" name=""MSH.2_EncodingCharacters"" type=""ST"" />
              <xs:element minOccurs=""0"" name=""MSH.3_SendingApplication"" type=""HD_361"" />
              <xs:element minOccurs=""0"" name=""MSH.4_SendingFacility"" type=""HD_362"" />
              <xs:element minOccurs=""0"" name=""MSH.5_ReceivingApplication"" type=""HD_361"" />
              <xs:element minOccurs=""0"" name=""MSH.6_ReceivingFacility"" type=""HD_362"" />
              <xs:element minOccurs=""0"" name=""MSH.7_DateTimeOfMessage"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" name=""TS.1"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""TS.2"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""MSH.8_Security"" type=""ST"" />
              <xs:element minOccurs=""1"" name=""MSH.9_MessageType"" type=""CM_MSG_76"" />
              <xs:element minOccurs=""1"" name=""MSH.10_MessageControlId"" type=""ST"" />
              <xs:element minOccurs=""1"" name=""MSH.11_ProcessingId"" type=""PT"" />
              <xs:element minOccurs=""1"" name=""MSH.12_VersionId"" type=""VID"" />
              <xs:element minOccurs=""0"" name=""MSH.13_SequenceNumber"" type=""NM"" />
              <xs:element minOccurs=""0"" name=""MSH.14_ContinuationPointer"" type=""ST"" />
              <xs:element minOccurs=""0"" name=""MSH.15_AcceptAcknowledgmentType"" type=""ID_155"" />
              <xs:element minOccurs=""0"" name=""MSH.16_ApplicationAcknowledgmentType"" type=""ID_155"" />
              <xs:element minOccurs=""0"" name=""MSH.17_CountryCode"" type=""ID_399"" />
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""MSH.18_CharacterSet"" type=""ID_211"" />
              <xs:element minOccurs=""0"" name=""MSH.19_PrincipalLanguageOfMessage"" type=""CE"" />
              <xs:element minOccurs=""0"" name=""MSH.20_AlternateCharacterSetHandlingScheme"" type=""ID_356"" />
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""MSH.21_ConformanceStatementId"" type=""EI"" />
              <xs:element minOccurs=""0"" name=""MSH.22_SendingResponsibleOrganization"" type=""XON"" />
              <xs:element minOccurs=""0"" name=""MSH.23_ReceivingResponsibleOrganization"" type=""XON"" />
              <xs:element minOccurs=""0"" name=""MSH.24_SendingNetworkAddress"" type=""HD_361"" />
              <xs:element minOccurs=""0"" name=""MSH.25_ReceivingNetworkAddress"" type=""HD_361"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:complexType name=""HD_361"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""HD.0_NamespaceId"" type=""IS_300"" />
      <xs:element minOccurs=""0"" name=""HD.1_UniversalId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""HD.2_UniversalIdType"" type=""ID_301"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""HD_362"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""HD.0_NamespaceId"" type=""IS_300"" />
      <xs:element minOccurs=""0"" name=""HD.1_UniversalId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""HD.2_UniversalIdType"" type=""ID_301"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CM_MSG_76"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CM_MSG.0_MessageType"" type=""ID_76"" />
      <xs:element minOccurs=""0"" name=""CM_MSG.1_TriggerEvent"" type=""ID_3"" />
      <xs:element minOccurs=""0"" name=""CM_MSG.2_MessageStructure"" type=""ID_354"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PT"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""PT.0_ProcessingId"" type=""ID_103"" />
      <xs:element minOccurs=""0"" name=""PT.1_ProcessingMode"" type=""ID_207"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""VID"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""VID_0_VersionId"" type=""ID_104"" />
      <xs:element minOccurs=""0"" name=""VID_1_InternationalizationCode"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""VID_1_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""VID_1_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""VID_1_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""VID_1_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""VID_1_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""VID_1_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""VID_2_InternationalVersionId"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""VID_2_0_Identifier"" type=""ST_0"" />
            <xs:element minOccurs=""0"" name=""VID_2_1_Text"" type=""ST_1"" />
            <xs:element minOccurs=""0"" name=""VID_2_2_NameOfCodingSystem"" type=""ID_2_396"" />
            <xs:element minOccurs=""0"" name=""VID_2_3_AlternateIdentifier"" type=""ST_3"" />
            <xs:element minOccurs=""0"" name=""VID_2_4_AlternateText"" type=""ST_4"" />
            <xs:element minOccurs=""0"" name=""VID_2_5_NameOfAlternateCodingSystem"" type=""ID_5_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""XON"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""XON_0_OrganizationName"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XON_1_OrganizationNameTypeCode"" type=""IS_204"" />
      <xs:element minOccurs=""0"" name=""XON_2_IdNumber"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""XON_3_IdentifierCheckDigit"" type=""NM"" />
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
  <xs:complexType name=""CE"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_Identifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""ID_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""ID_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""EI"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""EI_0_EntityIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""EI_1_NamespaceId"" type=""IS_363"" />
      <xs:element minOccurs=""0"" name=""EI_2_UniversalId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""EI_3_UniversalIdType"" type=""ID_301"" />
    </xs:sequence>
  </xs:complexType>
  <xs:simpleType name=""IS_204"">
    <xs:restriction base=""Table204"" />
  </xs:simpleType>
  <xs:simpleType name=""ST"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ST_0"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ST_1"">
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
  <xs:simpleType name=""IS_363"">
    <xs:restriction base=""Table363"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_5_396"">
    <xs:restriction base=""Table396"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_396"">
    <xs:restriction base=""Table396"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_300"">
    <xs:restriction base=""Table300"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_301"">
    <xs:restriction base=""Table301"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_2_301"">
    <xs:restriction base=""Table301"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_2_396"">
    <xs:restriction base=""Table396"" />
  </xs:simpleType>
  <xs:simpleType name=""TS"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ID_61"">
    <xs:restriction base=""Table61"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_76"">
    <xs:restriction base=""Table76"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_3"">
    <xs:restriction base=""Table3"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_354"">
    <xs:restriction base=""Table354"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_103"">
    <xs:restriction base=""Table103"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_203"">
    <xs:restriction base=""Table203"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_207"">
    <xs:restriction base=""Table207"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_104"">
    <xs:restriction base=""Table104"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_465"">
    <xs:restriction base=""Table465"" />
  </xs:simpleType>
  <xs:simpleType name=""ID"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""IS_0_300"">
    <xs:restriction base=""Table300"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_396"">
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
  <xs:simpleType name=""NM"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""[-+]?[\d]*|[-+]?[\d]+.[\d]*|[-+]?[\d]*.[\d]+"" />
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ID_155"">
    <xs:restriction base=""Table155"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_399"">
    <xs:restriction base=""Table399"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_211"">
    <xs:restriction base=""Table211"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_356"">
    <xs:restriction base=""Table356"" />
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
  <xs:simpleType name=""Table61"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""BCV"" />
      <xs:enumeration value=""ISO"" />
      <xs:enumeration value=""M10"" />
      <xs:enumeration value=""M11"" />
      <xs:enumeration value=""NPI"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table76"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""ACK"" />
      <xs:enumeration value=""ADR"" />
      <xs:enumeration value=""ADT"" />
      <xs:enumeration value=""ARD"" />
      <xs:enumeration value=""BAR"" />
      <xs:enumeration value=""BPS"" />
      <xs:enumeration value=""BRP"" />
      <xs:enumeration value=""BRT"" />
      <xs:enumeration value=""BTAHL7"" />
      <xs:enumeration value=""BTS"" />
      <xs:enumeration value=""CRM"" />
      <xs:enumeration value=""CSU"" />
      <xs:enumeration value=""DFT"" />
      <xs:enumeration value=""DOC"" />
      <xs:enumeration value=""DSR"" />
      <xs:enumeration value=""EAC"" />
      <xs:enumeration value=""EAN"" />
      <xs:enumeration value=""EAR"" />
      <xs:enumeration value=""EDR"" />
      <xs:enumeration value=""EQQ"" />
      <xs:enumeration value=""ERP"" />
      <xs:enumeration value=""ESR"" />
      <xs:enumeration value=""ESU"" />
      <xs:enumeration value=""INR"" />
      <xs:enumeration value=""INU"" />
      <xs:enumeration value=""LSR"" />
      <xs:enumeration value=""LSU"" />
      <xs:enumeration value=""MCF"" />
      <xs:enumeration value=""MDM"" />
      <xs:enumeration value=""MFD"" />
      <xs:enumeration value=""MFK"" />
      <xs:enumeration value=""MFN"" />
      <xs:enumeration value=""MFQ"" />
      <xs:enumeration value=""MFR"" />
      <xs:enumeration value=""NMD"" />
      <xs:enumeration value=""NMQ"" />
      <xs:enumeration value=""NMR"" />
      <xs:enumeration value=""OMB"" />
      <xs:enumeration value=""OMD"" />
      <xs:enumeration value=""OMG"" />
      <xs:enumeration value=""OMI"" />
      <xs:enumeration value=""OML"" />
      <xs:enumeration value=""OMN"" />
      <xs:enumeration value=""OMP"" />
      <xs:enumeration value=""OMS"" />
      <xs:enumeration value=""OPL"" />
      <xs:enumeration value=""OPR"" />
      <xs:enumeration value=""OPU"" />
      <xs:enumeration value=""ORB"" />
      <xs:enumeration value=""ORD"" />
      <xs:enumeration value=""ORF"" />
      <xs:enumeration value=""ORG"" />
      <xs:enumeration value=""ORI"" />
      <xs:enumeration value=""ORL"" />
      <xs:enumeration value=""ORM"" />
      <xs:enumeration value=""ORN"" />
      <xs:enumeration value=""ORP"" />
      <xs:enumeration value=""ORR"" />
      <xs:enumeration value=""ORS"" />
      <xs:enumeration value=""ORU"" />
      <xs:enumeration value=""OSQ"" />
      <xs:enumeration value=""OSR"" />
      <xs:enumeration value=""OUL"" />
      <xs:enumeration value=""PEX"" />
      <xs:enumeration value=""PGL"" />
      <xs:enumeration value=""PIN"" />
      <xs:enumeration value=""PMU"" />
      <xs:enumeration value=""PPG"" />
      <xs:enumeration value=""PPP"" />
      <xs:enumeration value=""PPR"" />
      <xs:enumeration value=""PPT"" />
      <xs:enumeration value=""PPV"" />
      <xs:enumeration value=""PRR"" />
      <xs:enumeration value=""PTR"" />
      <xs:enumeration value=""QBP"" />
      <xs:enumeration value=""QCK"" />
      <xs:enumeration value=""QCN"" />
      <xs:enumeration value=""QRY"" />
      <xs:enumeration value=""QSB"" />
      <xs:enumeration value=""QSX"" />
      <xs:enumeration value=""QVR"" />
      <xs:enumeration value=""RAR"" />
      <xs:enumeration value=""RAS"" />
      <xs:enumeration value=""RCI"" />
      <xs:enumeration value=""RCL"" />
      <xs:enumeration value=""RDE"" />
      <xs:enumeration value=""RDO"" />
      <xs:enumeration value=""RDR"" />
      <xs:enumeration value=""RDS"" />
      <xs:enumeration value=""RDY"" />
      <xs:enumeration value=""REF"" />
      <xs:enumeration value=""RER"" />
      <xs:enumeration value=""RGR"" />
      <xs:enumeration value=""RGV"" />
      <xs:enumeration value=""ROR"" />
      <xs:enumeration value=""RPA"" />
      <xs:enumeration value=""RPI"" />
      <xs:enumeration value=""RPL"" />
      <xs:enumeration value=""RPR"" />
      <xs:enumeration value=""RQA"" />
      <xs:enumeration value=""RQC"" />
      <xs:enumeration value=""RQI"" />
      <xs:enumeration value=""RQP"" />
      <xs:enumeration value=""RQQ"" />
      <xs:enumeration value=""RRA"" />
      <xs:enumeration value=""RRD"" />
      <xs:enumeration value=""RRE"" />
      <xs:enumeration value=""RRG"" />
      <xs:enumeration value=""RRI"" />
      <xs:enumeration value=""RRO"" />
      <xs:enumeration value=""RSP"" />
      <xs:enumeration value=""RTB"" />
      <xs:enumeration value=""SIU"" />
      <xs:enumeration value=""SPQ"" />
      <xs:enumeration value=""SQM"" />
      <xs:enumeration value=""SQR"" />
      <xs:enumeration value=""SRM"" />
      <xs:enumeration value=""SRR"" />
      <xs:enumeration value=""SSR"" />
      <xs:enumeration value=""SSU"" />
      <xs:enumeration value=""SUR"" />
      <xs:enumeration value=""TBR"" />
      <xs:enumeration value=""TCR"" />
      <xs:enumeration value=""TCU"" />
      <xs:enumeration value=""UDM"" />
      <xs:enumeration value=""VQQ"" />
      <xs:enumeration value=""VXQ"" />
      <xs:enumeration value=""VXR"" />
      <xs:enumeration value=""VXU"" />
      <xs:enumeration value=""VXX"" />
    </xs:restriction>
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
  <xs:simpleType name=""Table354"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""ACK"" />
      <xs:enumeration value=""ADR_A19"" />
      <xs:enumeration value=""ADT_A01"" />
      <xs:enumeration value=""ADT_A02"" />
      <xs:enumeration value=""ADT_A03"" />
      <xs:enumeration value=""ADT_A05"" />
      <xs:enumeration value=""ADT_A06"" />
      <xs:enumeration value=""ADT_A09"" />
      <xs:enumeration value=""ADT_A15"" />
      <xs:enumeration value=""ADT_A16"" />
      <xs:enumeration value=""ADT_A17"" />
      <xs:enumeration value=""ADT_A18"" />
      <xs:enumeration value=""ADT_A20"" />
      <xs:enumeration value=""ADT_A21"" />
      <xs:enumeration value=""ADT_A24"" />
      <xs:enumeration value=""ADT_A30"" />
      <xs:enumeration value=""ADT_A37"" />
      <xs:enumeration value=""ADT_A38"" />
      <xs:enumeration value=""ADT_A39"" />
      <xs:enumeration value=""ADT_A43"" />
      <xs:enumeration value=""ADT_A45"" />
      <xs:enumeration value=""ADT_A50"" />
      <xs:enumeration value=""ADT_A52"" />
      <xs:enumeration value=""ADT_A54"" />
      <xs:enumeration value=""ADT_A60"" />
      <xs:enumeration value=""ADT_A61"" />
      <xs:enumeration value=""ARD_A19"" />
      <xs:enumeration value=""BAR_P01"" />
      <xs:enumeration value=""BAR_P02"" />
      <xs:enumeration value=""BAR_P05"" />
      <xs:enumeration value=""BAR_P06"" />
      <xs:enumeration value=""BAR_P10"" />
      <xs:enumeration value=""BAR_P12"" />
      <xs:enumeration value=""BPS_O29"" />
      <xs:enumeration value=""BRP_030"" />
      <xs:enumeration value=""BRT_O32"" />
      <xs:enumeration value=""BTAHL7_BatchActivation"" />
      <xs:enumeration value=""BTAHL7_BatchRequest"" />
      <xs:enumeration value=""BTAHL7_BatchTermination"" />
      <xs:enumeration value=""BTS_O31"" />
      <xs:enumeration value=""CRM_C01"" />
      <xs:enumeration value=""CSU_C09"" />
      <xs:enumeration value=""DFT_P03"" />
      <xs:enumeration value=""DFT_P11"" />
      <xs:enumeration value=""DOC_T12"" />
      <xs:enumeration value=""DSR_P04"" />
      <xs:enumeration value=""DSR_Q01"" />
      <xs:enumeration value=""DSR_Q03"" />
      <xs:enumeration value=""EAC_U07"" />
      <xs:enumeration value=""EAN_U09"" />
      <xs:enumeration value=""EAR_U08"" />
      <xs:enumeration value=""EDR_R07"" />
      <xs:enumeration value=""EQQ_Q04"" />
      <xs:enumeration value=""ERP_R09"" />
      <xs:enumeration value=""ESR_U02"" />
      <xs:enumeration value=""ESU_U01"" />
      <xs:enumeration value=""INR_U06"" />
      <xs:enumeration value=""INU_U05"" />
      <xs:enumeration value=""LSU_U12"" />
      <xs:enumeration value=""MDM_T01"" />
      <xs:enumeration value=""MDM_T02"" />
      <xs:enumeration value=""MFD_MFA"" />
      <xs:enumeration value=""MFK_M01"" />
      <xs:enumeration value=""MFN_M01"" />
      <xs:enumeration value=""MFN_M02"" />
      <xs:enumeration value=""MFN_M03"" />
      <xs:enumeration value=""MFN_M04"" />
      <xs:enumeration value=""MFN_M05"" />
      <xs:enumeration value=""MFN_M06"" />
      <xs:enumeration value=""MFN_M07"" />
      <xs:enumeration value=""MFN_M08"" />
      <xs:enumeration value=""MFN_M09"" />
      <xs:enumeration value=""MFN_M10"" />
      <xs:enumeration value=""MFN_M11"" />
      <xs:enumeration value=""MFN_M12"" />
      <xs:enumeration value=""MFN_M13"" />
      <xs:enumeration value=""MFN_M15"" />
      <xs:enumeration value=""MFQ_M01"" />
      <xs:enumeration value=""MFR_M01"" />
      <xs:enumeration value=""NMD_N02"" />
      <xs:enumeration value=""NMQ_N01"" />
      <xs:enumeration value=""NMR_N01"" />
      <xs:enumeration value=""OMB_O27"" />
      <xs:enumeration value=""OMD_O03"" />
      <xs:enumeration value=""OMG_O19"" />
      <xs:enumeration value=""OMI_O23"" />
      <xs:enumeration value=""OML_O21"" />
      <xs:enumeration value=""OML_O33"" />
      <xs:enumeration value=""OML_O35"" />
      <xs:enumeration value=""OMN_O07"" />
      <xs:enumeration value=""OMP_O09"" />
      <xs:enumeration value=""OMS_O05"" />
      <xs:enumeration value=""ORB_O28"" />
      <xs:enumeration value=""ORD_O04"" />
      <xs:enumeration value=""ORF_R04"" />
      <xs:enumeration value=""ORG_O20"" />
      <xs:enumeration value=""ORI_O24"" />
      <xs:enumeration value=""ORL_O22"" />
      <xs:enumeration value=""ORL_O34"" />
      <xs:enumeration value=""ORL_O36"" />
      <xs:enumeration value=""ORM_O01"" />
      <xs:enumeration value=""ORN_O08"" />
      <xs:enumeration value=""ORP_O10"" />
      <xs:enumeration value=""ORR_O02"" />
      <xs:enumeration value=""ORS_O06"" />
      <xs:enumeration value=""ORU_R01"" />
      <xs:enumeration value=""ORU_R30"" />
      <xs:enumeration value=""ORU_R31"" />
      <xs:enumeration value=""ORU_R32"" />
      <xs:enumeration value=""ORU_W01"" />
      <xs:enumeration value=""OSQ_Q06"" />
      <xs:enumeration value=""OSR_Q06"" />
      <xs:enumeration value=""OUL_R21"" />
      <xs:enumeration value=""OUL_R22"" />
      <xs:enumeration value=""OUL_R23"" />
      <xs:enumeration value=""OUL_R24"" />
      <xs:enumeration value=""PEX_P07"" />
      <xs:enumeration value=""PGL_PC6"" />
      <xs:enumeration value=""PMU_B01"" />
      <xs:enumeration value=""PMU_B03"" />
      <xs:enumeration value=""PMU_B04"" />
      <xs:enumeration value=""PMU_B07"" />
      <xs:enumeration value=""PMU_B08"" />
      <xs:enumeration value=""PPG_PCG"" />
      <xs:enumeration value=""PPP_PCB"" />
      <xs:enumeration value=""PPR_PC1"" />
      <xs:enumeration value=""PPT_PCL"" />
      <xs:enumeration value=""PPV_PCA"" />
      <xs:enumeration value=""PRR_PC5"" />
      <xs:enumeration value=""PTR_PCF"" />
      <xs:enumeration value=""QBP_Q11"" />
      <xs:enumeration value=""QBP_Q13"" />
      <xs:enumeration value=""QBP_Q15"" />
      <xs:enumeration value=""QBP_Q21"" />
      <xs:enumeration value=""QBP_Z73"" />
      <xs:enumeration value=""QBP_Z75"" />
      <xs:enumeration value=""QBP_Z77"" />
      <xs:enumeration value=""QBP_Z79"" />
      <xs:enumeration value=""QBP_Z81"" />
      <xs:enumeration value=""QBP_Z85"" />
      <xs:enumeration value=""QBP_Z87"" />
      <xs:enumeration value=""QBP_Z89"" />
      <xs:enumeration value=""QBP_Z91"" />
      <xs:enumeration value=""QBP_Z93"" />
      <xs:enumeration value=""QBP_Z95"" />
      <xs:enumeration value=""QBP_Z97"" />
      <xs:enumeration value=""QCK_Q02"" />
      <xs:enumeration value=""QCN_J01"" />
      <xs:enumeration value=""QRF_W02"" />
      <xs:enumeration value=""QRY_A19"" />
      <xs:enumeration value=""QRY_P04"" />
      <xs:enumeration value=""QRY_PC4"" />
      <xs:enumeration value=""QRY_Q01"" />
      <xs:enumeration value=""QRY_Q02"" />
      <xs:enumeration value=""QRY_R02"" />
      <xs:enumeration value=""QRY_T12"" />
      <xs:enumeration value=""QSB_Q16"" />
      <xs:enumeration value=""QSB_Z83"" />
      <xs:enumeration value=""QVR_Q17"" />
      <xs:enumeration value=""RAR_RAR"" />
      <xs:enumeration value=""RAS_O17"" />
      <xs:enumeration value=""RCI_I05"" />
      <xs:enumeration value=""RCL_I06"" />
      <xs:enumeration value=""RDE_O01"" />
      <xs:enumeration value=""RDE_O11"" />
      <xs:enumeration value=""RDR_RDR"" />
      <xs:enumeration value=""RDS_O13"" />
      <xs:enumeration value=""RDY_K15"" />
      <xs:enumeration value=""RDY_Z80"" />
      <xs:enumeration value=""RDY_Z98"" />
      <xs:enumeration value=""REF_I12"" />
      <xs:enumeration value=""RER_RER"" />
      <xs:enumeration value=""RGR_RGR"" />
      <xs:enumeration value=""RGV_O15"" />
      <xs:enumeration value=""ROR_ROR"" />
      <xs:enumeration value=""RPA_I08"" />
      <xs:enumeration value=""RPI_I01"" />
      <xs:enumeration value=""RPL_I02"" />
      <xs:enumeration value=""RPR_I03"" />
      <xs:enumeration value=""RQA_I08"" />
      <xs:enumeration value=""RQC_I05"" />
      <xs:enumeration value=""RQI_I01"" />
      <xs:enumeration value=""RQP_I04"" />
      <xs:enumeration value=""RQQ_Q09"" />
      <xs:enumeration value=""RRA_O02"" />
      <xs:enumeration value=""RRA_O18"" />
      <xs:enumeration value=""RRD_O14"" />
      <xs:enumeration value=""RRE_O12"" />
      <xs:enumeration value=""RRG_O16"" />
      <xs:enumeration value=""RRI_I12"" />
      <xs:enumeration value=""RSP_K11"" />
      <xs:enumeration value=""RSP_K21"" />
      <xs:enumeration value=""RSP_K22"" />
      <xs:enumeration value=""RSP_K23"" />
      <xs:enumeration value=""RSP_Z82"" />
      <xs:enumeration value=""RSP_Z88"" />
      <xs:enumeration value=""RSP_Z90"" />
      <xs:enumeration value=""RTB_K13"" />
      <xs:enumeration value=""RTB_Z74"" />
      <xs:enumeration value=""RTB_Z76"" />
      <xs:enumeration value=""RTB_Z78"" />
      <xs:enumeration value=""RTB_Z92"" />
      <xs:enumeration value=""RTB_Z94"" />
      <xs:enumeration value=""RTB_Z96"" />
      <xs:enumeration value=""SIU_S12"" />
      <xs:enumeration value=""SPQ_Q08"" />
      <xs:enumeration value=""SQM_S25"" />
      <xs:enumeration value=""SQR_S25"" />
      <xs:enumeration value=""SRM_S01"" />
      <xs:enumeration value=""SRR_S01"" />
      <xs:enumeration value=""SSR_U04"" />
      <xs:enumeration value=""SSU_U03"" />
      <xs:enumeration value=""SUR_P09"" />
      <xs:enumeration value=""TBR_R08"" />
      <xs:enumeration value=""TBR_R09"" />
      <xs:enumeration value=""TCU_U10"" />
      <xs:enumeration value=""UDM_Q05"" />
      <xs:enumeration value=""VQQ_Q07"" />
      <xs:enumeration value=""VXQ_V01"" />
      <xs:enumeration value=""VXR_V03"" />
      <xs:enumeration value=""VXU_V04"" />
      <xs:enumeration value=""VXX_V02"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table3"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A01"" />
      <xs:enumeration value=""A02"" />
      <xs:enumeration value=""A03"" />
      <xs:enumeration value=""A04"" />
      <xs:enumeration value=""A05"" />
      <xs:enumeration value=""A06"" />
      <xs:enumeration value=""A07"" />
      <xs:enumeration value=""A08"" />
      <xs:enumeration value=""A09"" />
      <xs:enumeration value=""A10"" />
      <xs:enumeration value=""A11"" />
      <xs:enumeration value=""A12"" />
      <xs:enumeration value=""A13"" />
      <xs:enumeration value=""A14"" />
      <xs:enumeration value=""A15"" />
      <xs:enumeration value=""A16"" />
      <xs:enumeration value=""A17"" />
      <xs:enumeration value=""A18"" />
      <xs:enumeration value=""A19"" />
      <xs:enumeration value=""A20"" />
      <xs:enumeration value=""A21"" />
      <xs:enumeration value=""A22"" />
      <xs:enumeration value=""A23"" />
      <xs:enumeration value=""A24"" />
      <xs:enumeration value=""A25"" />
      <xs:enumeration value=""A26"" />
      <xs:enumeration value=""A27"" />
      <xs:enumeration value=""A28"" />
      <xs:enumeration value=""A29"" />
      <xs:enumeration value=""A30"" />
      <xs:enumeration value=""A31"" />
      <xs:enumeration value=""A32"" />
      <xs:enumeration value=""A33"" />
      <xs:enumeration value=""A34"" />
      <xs:enumeration value=""A35"" />
      <xs:enumeration value=""A36"" />
      <xs:enumeration value=""A37"" />
      <xs:enumeration value=""A38"" />
      <xs:enumeration value=""A39"" />
      <xs:enumeration value=""A40"" />
      <xs:enumeration value=""A41"" />
      <xs:enumeration value=""A42"" />
      <xs:enumeration value=""A43"" />
      <xs:enumeration value=""A44"" />
      <xs:enumeration value=""A45"" />
      <xs:enumeration value=""A46"" />
      <xs:enumeration value=""A47"" />
      <xs:enumeration value=""A48"" />
      <xs:enumeration value=""A49"" />
      <xs:enumeration value=""A50"" />
      <xs:enumeration value=""A51"" />
      <xs:enumeration value=""A52"" />
      <xs:enumeration value=""A53"" />
      <xs:enumeration value=""A54"" />
      <xs:enumeration value=""A55"" />
      <xs:enumeration value=""A60"" />
      <xs:enumeration value=""A61"" />
      <xs:enumeration value=""A62"" />
      <xs:enumeration value=""BatchActivation"" />
      <xs:enumeration value=""BatchRequest"" />
      <xs:enumeration value=""BatchTermination"" />
      <xs:enumeration value=""B01"" />
      <xs:enumeration value=""B02"" />
      <xs:enumeration value=""B03"" />
      <xs:enumeration value=""B04"" />
      <xs:enumeration value=""B05"" />
      <xs:enumeration value=""B06"" />
      <xs:enumeration value=""B07"" />
      <xs:enumeration value=""B08"" />
      <xs:enumeration value=""C01"" />
      <xs:enumeration value=""C02"" />
      <xs:enumeration value=""C03"" />
      <xs:enumeration value=""C04"" />
      <xs:enumeration value=""C05"" />
      <xs:enumeration value=""C06"" />
      <xs:enumeration value=""C07"" />
      <xs:enumeration value=""C08"" />
      <xs:enumeration value=""C09"" />
      <xs:enumeration value=""C10"" />
      <xs:enumeration value=""C11"" />
      <xs:enumeration value=""C12"" />
      <xs:enumeration value=""CNQ"" />
      <xs:enumeration value=""I01"" />
      <xs:enumeration value=""I02"" />
      <xs:enumeration value=""I03"" />
      <xs:enumeration value=""I04"" />
      <xs:enumeration value=""I05"" />
      <xs:enumeration value=""I06"" />
      <xs:enumeration value=""I07"" />
      <xs:enumeration value=""I08"" />
      <xs:enumeration value=""I09"" />
      <xs:enumeration value=""I10"" />
      <xs:enumeration value=""I11"" />
      <xs:enumeration value=""I12"" />
      <xs:enumeration value=""I13"" />
      <xs:enumeration value=""I14"" />
      <xs:enumeration value=""I15"" />
      <xs:enumeration value=""J01"" />
      <xs:enumeration value=""J02"" />
      <xs:enumeration value=""K11"" />
      <xs:enumeration value=""K13"" />
      <xs:enumeration value=""K15"" />
      <xs:enumeration value=""K21"" />
      <xs:enumeration value=""K22"" />
      <xs:enumeration value=""K23"" />
      <xs:enumeration value=""K24"" />
      <xs:enumeration value=""K25"" />
      <xs:enumeration value=""M01"" />
      <xs:enumeration value=""M02"" />
      <xs:enumeration value=""M03"" />
      <xs:enumeration value=""M04"" />
      <xs:enumeration value=""M05"" />
      <xs:enumeration value=""M06"" />
      <xs:enumeration value=""M07"" />
      <xs:enumeration value=""M08"" />
      <xs:enumeration value=""M09"" />
      <xs:enumeration value=""M10"" />
      <xs:enumeration value=""M11"" />
      <xs:enumeration value=""M12"" />
      <xs:enumeration value=""M13"" />
      <xs:enumeration value=""M14"" />
      <xs:enumeration value=""M15"" />
      <xs:enumeration value=""MFA"" />
      <xs:enumeration value=""N01"" />
      <xs:enumeration value=""N02"" />
      <xs:enumeration value=""O01"" />
      <xs:enumeration value=""O02"" />
      <xs:enumeration value=""O03"" />
      <xs:enumeration value=""O04"" />
      <xs:enumeration value=""O05"" />
      <xs:enumeration value=""O06"" />
      <xs:enumeration value=""O07"" />
      <xs:enumeration value=""O08"" />
      <xs:enumeration value=""O09"" />
      <xs:enumeration value=""O10"" />
      <xs:enumeration value=""O11"" />
      <xs:enumeration value=""O12"" />
      <xs:enumeration value=""O13"" />
      <xs:enumeration value=""O14"" />
      <xs:enumeration value=""O15"" />
      <xs:enumeration value=""O16"" />
      <xs:enumeration value=""O17"" />
      <xs:enumeration value=""O18"" />
      <xs:enumeration value=""O19"" />
      <xs:enumeration value=""O20"" />
      <xs:enumeration value=""O21"" />
      <xs:enumeration value=""O22"" />
      <xs:enumeration value=""O23"" />
      <xs:enumeration value=""O24"" />
      <xs:enumeration value=""O25"" />
      <xs:enumeration value=""O26"" />
      <xs:enumeration value=""O27"" />
      <xs:enumeration value=""O28"" />
      <xs:enumeration value=""O29"" />
      <xs:enumeration value=""O30"" />
      <xs:enumeration value=""O31"" />
      <xs:enumeration value=""O32"" />
      <xs:enumeration value=""O33"" />
      <xs:enumeration value=""O34"" />
      <xs:enumeration value=""O35"" />
      <xs:enumeration value=""O36"" />
      <xs:enumeration value=""O37"" />
      <xs:enumeration value=""O38"" />
      <xs:enumeration value=""P01"" />
      <xs:enumeration value=""P02"" />
      <xs:enumeration value=""P03"" />
      <xs:enumeration value=""P04"" />
      <xs:enumeration value=""P05"" />
      <xs:enumeration value=""P06"" />
      <xs:enumeration value=""P07"" />
      <xs:enumeration value=""P08"" />
      <xs:enumeration value=""P09"" />
      <xs:enumeration value=""P10"" />
      <xs:enumeration value=""P11"" />
      <xs:enumeration value=""P12"" />
      <xs:enumeration value=""PC1"" />
      <xs:enumeration value=""PC2"" />
      <xs:enumeration value=""PC3"" />
      <xs:enumeration value=""PC4"" />
      <xs:enumeration value=""PC5"" />
      <xs:enumeration value=""PC6"" />
      <xs:enumeration value=""PC7"" />
      <xs:enumeration value=""PC8"" />
      <xs:enumeration value=""PC9"" />
      <xs:enumeration value=""PCA"" />
      <xs:enumeration value=""PCB"" />
      <xs:enumeration value=""PCC"" />
      <xs:enumeration value=""PCD"" />
      <xs:enumeration value=""PCE"" />
      <xs:enumeration value=""PCF"" />
      <xs:enumeration value=""PCG"" />
      <xs:enumeration value=""PCH"" />
      <xs:enumeration value=""PCJ"" />
      <xs:enumeration value=""PCK"" />
      <xs:enumeration value=""PCL"" />
      <xs:enumeration value=""Q01"" />
      <xs:enumeration value=""Q02"" />
      <xs:enumeration value=""Q03"" />
      <xs:enumeration value=""Q04"" />
      <xs:enumeration value=""Q05"" />
      <xs:enumeration value=""Q06"" />
      <xs:enumeration value=""Q07"" />
      <xs:enumeration value=""Q08"" />
      <xs:enumeration value=""Q09"" />
      <xs:enumeration value=""Q11"" />
      <xs:enumeration value=""Q13"" />
      <xs:enumeration value=""Q15"" />
      <xs:enumeration value=""Q16"" />
      <xs:enumeration value=""Q17"" />
      <xs:enumeration value=""Q21"" />
      <xs:enumeration value=""Q22"" />
      <xs:enumeration value=""Q23"" />
      <xs:enumeration value=""Q24"" />
      <xs:enumeration value=""Q25"" />
      <xs:enumeration value=""Q26"" />
      <xs:enumeration value=""Q27"" />
      <xs:enumeration value=""Q28"" />
      <xs:enumeration value=""Q29"" />
      <xs:enumeration value=""Q30"" />
      <xs:enumeration value=""Q31"" />
      <xs:enumeration value=""RAR"" />
      <xs:enumeration value=""RDR"" />
      <xs:enumeration value=""RER"" />
      <xs:enumeration value=""RGR"" />
      <xs:enumeration value=""R01"" />
      <xs:enumeration value=""R02"" />
      <xs:enumeration value=""R03"" />
      <xs:enumeration value=""R04"" />
      <xs:enumeration value=""R05"" />
      <xs:enumeration value=""R06"" />
      <xs:enumeration value=""R07"" />
      <xs:enumeration value=""R08"" />
      <xs:enumeration value=""R09"" />
      <xs:enumeration value=""R21"" />
      <xs:enumeration value=""R22"" />
      <xs:enumeration value=""R23"" />
      <xs:enumeration value=""R24"" />
      <xs:enumeration value=""R25"" />
      <xs:enumeration value=""R30"" />
      <xs:enumeration value=""R31"" />
      <xs:enumeration value=""R32"" />
      <xs:enumeration value=""ROR"" />
      <xs:enumeration value=""S01"" />
      <xs:enumeration value=""S02"" />
      <xs:enumeration value=""S03"" />
      <xs:enumeration value=""S04"" />
      <xs:enumeration value=""S05"" />
      <xs:enumeration value=""S06"" />
      <xs:enumeration value=""S07"" />
      <xs:enumeration value=""S08"" />
      <xs:enumeration value=""S09"" />
      <xs:enumeration value=""S10"" />
      <xs:enumeration value=""S11"" />
      <xs:enumeration value=""S12"" />
      <xs:enumeration value=""S13"" />
      <xs:enumeration value=""S14"" />
      <xs:enumeration value=""S15"" />
      <xs:enumeration value=""S16"" />
      <xs:enumeration value=""S17"" />
      <xs:enumeration value=""S18"" />
      <xs:enumeration value=""S19"" />
      <xs:enumeration value=""S20"" />
      <xs:enumeration value=""S21"" />
      <xs:enumeration value=""S22"" />
      <xs:enumeration value=""S23"" />
      <xs:enumeration value=""S24"" />
      <xs:enumeration value=""S25"" />
      <xs:enumeration value=""S26"" />
      <xs:enumeration value=""T01"" />
      <xs:enumeration value=""T02"" />
      <xs:enumeration value=""T03"" />
      <xs:enumeration value=""T04"" />
      <xs:enumeration value=""T05"" />
      <xs:enumeration value=""T06"" />
      <xs:enumeration value=""T07"" />
      <xs:enumeration value=""T08"" />
      <xs:enumeration value=""T09"" />
      <xs:enumeration value=""T10"" />
      <xs:enumeration value=""T11"" />
      <xs:enumeration value=""T12"" />
      <xs:enumeration value=""U01"" />
      <xs:enumeration value=""U02"" />
      <xs:enumeration value=""U03"" />
      <xs:enumeration value=""U04"" />
      <xs:enumeration value=""U05"" />
      <xs:enumeration value=""U06"" />
      <xs:enumeration value=""U07"" />
      <xs:enumeration value=""U08"" />
      <xs:enumeration value=""U09"" />
      <xs:enumeration value=""U10"" />
      <xs:enumeration value=""U11"" />
      <xs:enumeration value=""U12"" />
      <xs:enumeration value=""U13"" />
      <xs:enumeration value=""V01"" />
      <xs:enumeration value=""V02"" />
      <xs:enumeration value=""V03"" />
      <xs:enumeration value=""V04"" />
      <xs:enumeration value=""Varies"" />
      <xs:enumeration value=""W01"" />
      <xs:enumeration value=""W02"" />
      <xs:enumeration value=""Z73"" />
      <xs:enumeration value=""Z74"" />
      <xs:enumeration value=""Z75"" />
      <xs:enumeration value=""Z76"" />
      <xs:enumeration value=""Z77"" />
      <xs:enumeration value=""Z78"" />
      <xs:enumeration value=""Z79"" />
      <xs:enumeration value=""Z80"" />
      <xs:enumeration value=""Z81"" />
      <xs:enumeration value=""Z82"" />
      <xs:enumeration value=""Z83"" />
      <xs:enumeration value=""Z84"" />
      <xs:enumeration value=""Z85"" />
      <xs:enumeration value=""Z86"" />
      <xs:enumeration value=""Z87"" />
      <xs:enumeration value=""Z88"" />
      <xs:enumeration value=""Z89"" />
      <xs:enumeration value=""Z90"" />
      <xs:enumeration value=""Z91"" />
      <xs:enumeration value=""Z92"" />
      <xs:enumeration value=""Z93"" />
      <xs:enumeration value=""Z94"" />
      <xs:enumeration value=""Z95"" />
      <xs:enumeration value=""Z96"" />
      <xs:enumeration value=""Z97"" />
      <xs:enumeration value=""Z98"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table103"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""T"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table104"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""2.0"" />
      <xs:enumeration value=""2.0D"" />
      <xs:enumeration value=""2.1"" />
      <xs:enumeration value=""2.2"" />
      <xs:enumeration value=""2.3"" />
      <xs:enumeration value=""2.3.1"" />
      <xs:enumeration value=""2.4"" />
      <xs:enumeration value=""2.5"" />
      <xs:enumeration value=""2.5.1"" />
      <xs:enumeration value=""2.6"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table207"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""Not present"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""T"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table396"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""99zzz or L"" />
      <xs:enumeration value=""ACR"" />
      <xs:enumeration value=""ANS+"" />
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
      <xs:enumeration value=""HCPT"" />
      <xs:enumeration value=""HHC"" />
      <xs:enumeration value=""HI"" />
      <xs:enumeration value=""HL7nnnn"" />
      <xs:enumeration value=""HOT"" />
      <xs:enumeration value=""HPC"" />
      <xs:enumeration value=""I10"" />
      <xs:enumeration value=""I10P"" />
      <xs:enumeration value=""I9"" />
      <xs:enumeration value=""I9C"" />
      <xs:enumeration value=""IBT"" />
      <xs:enumeration value=""IBTnnnn"" />
      <xs:enumeration value=""IC2"" />
      <xs:enumeration value=""ICD10AM"" />
      <xs:enumeration value=""ICD10CA"" />
      <xs:enumeration value=""ICDO"" />
      <xs:enumeration value=""ICS"" />
      <xs:enumeration value=""ICSD"" />
      <xs:enumeration value=""ISO+"" />
      <xs:enumeration value=""ISOnnnn"" />
      <xs:enumeration value=""IUPC"" />
      <xs:enumeration value=""IUPP"" />
      <xs:enumeration value=""JC10"" />
      <xs:enumeration value=""JC8"" />
      <xs:enumeration value=""JJ1017"" />
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
      <xs:enumeration value=""NUBC"" />
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
      <xs:enumeration value=""USPS"" />
      <xs:enumeration value=""W1"" />
      <xs:enumeration value=""W2"" />
      <xs:enumeration value=""W4"" />
      <xs:enumeration value=""WC"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table155"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AL"" />
      <xs:enumeration value=""ER"" />
      <xs:enumeration value=""NE"" />
      <xs:enumeration value=""SU"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table204"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""SL"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table399"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""ABW"" />
      <xs:enumeration value=""AFG"" />
      <xs:enumeration value=""AFT"" />
      <xs:enumeration value=""AGO"" />
      <xs:enumeration value=""AIA"" />
      <xs:enumeration value=""ALB"" />
      <xs:enumeration value=""AND"" />
      <xs:enumeration value=""ANT"" />
      <xs:enumeration value=""ARE"" />
      <xs:enumeration value=""ARG"" />
      <xs:enumeration value=""ARM"" />
      <xs:enumeration value=""ASM"" />
      <xs:enumeration value=""ATA"" />
      <xs:enumeration value=""ATG"" />
      <xs:enumeration value=""AUS"" />
      <xs:enumeration value=""AUT"" />
      <xs:enumeration value=""AZE"" />
      <xs:enumeration value=""BDI"" />
      <xs:enumeration value=""BEL"" />
      <xs:enumeration value=""BEN"" />
      <xs:enumeration value=""BFA"" />
      <xs:enumeration value=""BGD"" />
      <xs:enumeration value=""BGR"" />
      <xs:enumeration value=""BHR"" />
      <xs:enumeration value=""BHS"" />
      <xs:enumeration value=""BIH"" />
      <xs:enumeration value=""BLR"" />
      <xs:enumeration value=""BLZ"" />
      <xs:enumeration value=""BMU"" />
      <xs:enumeration value=""BOL"" />
      <xs:enumeration value=""BRA"" />
      <xs:enumeration value=""BRB"" />
      <xs:enumeration value=""BRN"" />
      <xs:enumeration value=""BTN"" />
      <xs:enumeration value=""BVT"" />
      <xs:enumeration value=""BWA"" />
      <xs:enumeration value=""CAF"" />
      <xs:enumeration value=""CAN"" />
      <xs:enumeration value=""CCK"" />
      <xs:enumeration value=""CHE"" />
      <xs:enumeration value=""CHL"" />
      <xs:enumeration value=""CHN"" />
      <xs:enumeration value=""CIV"" />
      <xs:enumeration value=""CMR"" />
      <xs:enumeration value=""COD"" />
      <xs:enumeration value=""COG"" />
      <xs:enumeration value=""COK"" />
      <xs:enumeration value=""COL"" />
      <xs:enumeration value=""COM"" />
      <xs:enumeration value=""CPV"" />
      <xs:enumeration value=""CRI"" />
      <xs:enumeration value=""CUB"" />
      <xs:enumeration value=""CXR"" />
      <xs:enumeration value=""CYM"" />
      <xs:enumeration value=""CYP"" />
      <xs:enumeration value=""CZE"" />
      <xs:enumeration value=""DEU"" />
      <xs:enumeration value=""DJI"" />
      <xs:enumeration value=""DMA"" />
      <xs:enumeration value=""DNK"" />
      <xs:enumeration value=""DOM"" />
      <xs:enumeration value=""DZA"" />
      <xs:enumeration value=""ECU"" />
      <xs:enumeration value=""EGY"" />
      <xs:enumeration value=""ERI"" />
      <xs:enumeration value=""ESH"" />
      <xs:enumeration value=""ESP"" />
      <xs:enumeration value=""EST"" />
      <xs:enumeration value=""ETH"" />
      <xs:enumeration value=""FIN"" />
      <xs:enumeration value=""FJI"" />
      <xs:enumeration value=""FLK"" />
      <xs:enumeration value=""FRA"" />
      <xs:enumeration value=""FRO"" />
      <xs:enumeration value=""FSM"" />
      <xs:enumeration value=""GAB"" />
      <xs:enumeration value=""GBR"" />
      <xs:enumeration value=""GEO"" />
      <xs:enumeration value=""GHA"" />
      <xs:enumeration value=""GIB"" />
      <xs:enumeration value=""GIN"" />
      <xs:enumeration value=""GLP"" />
      <xs:enumeration value=""GMB"" />
      <xs:enumeration value=""GNB"" />
      <xs:enumeration value=""GNQ"" />
      <xs:enumeration value=""GRC"" />
      <xs:enumeration value=""GRD"" />
      <xs:enumeration value=""GRL"" />
      <xs:enumeration value=""GTM"" />
      <xs:enumeration value=""GUF"" />
      <xs:enumeration value=""GUM"" />
      <xs:enumeration value=""GUY"" />
      <xs:enumeration value=""HKG"" />
      <xs:enumeration value=""HMD"" />
      <xs:enumeration value=""HND"" />
      <xs:enumeration value=""HRV"" />
      <xs:enumeration value=""HTI"" />
      <xs:enumeration value=""HUN"" />
      <xs:enumeration value=""IDN"" />
      <xs:enumeration value=""IND"" />
      <xs:enumeration value=""IOT"" />
      <xs:enumeration value=""IRL"" />
      <xs:enumeration value=""IRN"" />
      <xs:enumeration value=""IRQ"" />
      <xs:enumeration value=""ISL"" />
      <xs:enumeration value=""ISR"" />
      <xs:enumeration value=""ITA"" />
      <xs:enumeration value=""JAM"" />
      <xs:enumeration value=""JOR"" />
      <xs:enumeration value=""JPN"" />
      <xs:enumeration value=""KAZ"" />
      <xs:enumeration value=""KEN"" />
      <xs:enumeration value=""KGZ"" />
      <xs:enumeration value=""KHM"" />
      <xs:enumeration value=""KIR"" />
      <xs:enumeration value=""KNA"" />
      <xs:enumeration value=""KOR"" />
      <xs:enumeration value=""KWT"" />
      <xs:enumeration value=""LAO"" />
      <xs:enumeration value=""LBN"" />
      <xs:enumeration value=""LBR"" />
      <xs:enumeration value=""LBY"" />
      <xs:enumeration value=""LCA"" />
      <xs:enumeration value=""LIE"" />
      <xs:enumeration value=""LKA"" />
      <xs:enumeration value=""LSO"" />
      <xs:enumeration value=""LTU"" />
      <xs:enumeration value=""LUX"" />
      <xs:enumeration value=""LVA"" />
      <xs:enumeration value=""MAC"" />
      <xs:enumeration value=""MAR"" />
      <xs:enumeration value=""MCO"" />
      <xs:enumeration value=""MDA"" />
      <xs:enumeration value=""MDG"" />
      <xs:enumeration value=""MDV"" />
      <xs:enumeration value=""MEX"" />
      <xs:enumeration value=""MHL"" />
      <xs:enumeration value=""MKD"" />
      <xs:enumeration value=""MLI"" />
      <xs:enumeration value=""MLT"" />
      <xs:enumeration value=""MMR"" />
      <xs:enumeration value=""MNG"" />
      <xs:enumeration value=""MNP"" />
      <xs:enumeration value=""MOZ"" />
      <xs:enumeration value=""MRT"" />
      <xs:enumeration value=""MSR"" />
      <xs:enumeration value=""MTQ"" />
      <xs:enumeration value=""MUS"" />
      <xs:enumeration value=""MWI"" />
      <xs:enumeration value=""MYS"" />
      <xs:enumeration value=""MYT"" />
      <xs:enumeration value=""NAM"" />
      <xs:enumeration value=""NCL"" />
      <xs:enumeration value=""NER"" />
      <xs:enumeration value=""NFK"" />
      <xs:enumeration value=""NGA"" />
      <xs:enumeration value=""NIC"" />
      <xs:enumeration value=""NIU"" />
      <xs:enumeration value=""NLD"" />
      <xs:enumeration value=""NOR"" />
      <xs:enumeration value=""NPL"" />
      <xs:enumeration value=""NRU"" />
      <xs:enumeration value=""NZL"" />
      <xs:enumeration value=""OMN"" />
      <xs:enumeration value=""PAK"" />
      <xs:enumeration value=""PAN"" />
      <xs:enumeration value=""PCN"" />
      <xs:enumeration value=""PER"" />
      <xs:enumeration value=""PHL"" />
      <xs:enumeration value=""PLW"" />
      <xs:enumeration value=""PNG"" />
      <xs:enumeration value=""POL"" />
      <xs:enumeration value=""PRI"" />
      <xs:enumeration value=""PRK"" />
      <xs:enumeration value=""PRT"" />
      <xs:enumeration value=""PRY"" />
      <xs:enumeration value=""PYF"" />
      <xs:enumeration value=""QAT"" />
      <xs:enumeration value=""REU"" />
      <xs:enumeration value=""ROM"" />
      <xs:enumeration value=""RUS"" />
      <xs:enumeration value=""RWA"" />
      <xs:enumeration value=""SAU"" />
      <xs:enumeration value=""SDN"" />
      <xs:enumeration value=""SEN"" />
      <xs:enumeration value=""SGP"" />
      <xs:enumeration value=""SGS"" />
      <xs:enumeration value=""SHN"" />
      <xs:enumeration value=""SJM"" />
      <xs:enumeration value=""SLB"" />
      <xs:enumeration value=""SLE"" />
      <xs:enumeration value=""SLV"" />
      <xs:enumeration value=""SMR"" />
      <xs:enumeration value=""SOM"" />
      <xs:enumeration value=""SPM"" />
      <xs:enumeration value=""STP"" />
      <xs:enumeration value=""SUR"" />
      <xs:enumeration value=""SVK"" />
      <xs:enumeration value=""SVN"" />
      <xs:enumeration value=""SWE"" />
      <xs:enumeration value=""SWZ"" />
      <xs:enumeration value=""SYC"" />
      <xs:enumeration value=""SYR"" />
      <xs:enumeration value=""TCA"" />
      <xs:enumeration value=""TCD"" />
      <xs:enumeration value=""TGO"" />
      <xs:enumeration value=""THA"" />
      <xs:enumeration value=""TJK"" />
      <xs:enumeration value=""TKL"" />
      <xs:enumeration value=""TKM"" />
      <xs:enumeration value=""TMP"" />
      <xs:enumeration value=""TON"" />
      <xs:enumeration value=""TTO"" />
      <xs:enumeration value=""TUN"" />
      <xs:enumeration value=""TUR"" />
      <xs:enumeration value=""TUV"" />
      <xs:enumeration value=""TWN"" />
      <xs:enumeration value=""TZA"" />
      <xs:enumeration value=""UGA"" />
      <xs:enumeration value=""UKR"" />
      <xs:enumeration value=""UMI"" />
      <xs:enumeration value=""URY"" />
      <xs:enumeration value=""USA"" />
      <xs:enumeration value=""UZB"" />
      <xs:enumeration value=""VAT"" />
      <xs:enumeration value=""VCT"" />
      <xs:enumeration value=""VEN"" />
      <xs:enumeration value=""VGB"" />
      <xs:enumeration value=""VIR"" />
      <xs:enumeration value=""VNM"" />
      <xs:enumeration value=""VUT"" />
      <xs:enumeration value=""WLF"" />
      <xs:enumeration value=""WSM"" />
      <xs:enumeration value=""YEM"" />
      <xs:enumeration value=""YUG"" />
      <xs:enumeration value=""ZAF"" />
      <xs:enumeration value=""ZMB"" />
      <xs:enumeration value=""ZWE"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table211"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""8859/1"" />
      <xs:enumeration value=""8859/2"" />
      <xs:enumeration value=""8859/3"" />
      <xs:enumeration value=""8859/4"" />
      <xs:enumeration value=""8859/5"" />
      <xs:enumeration value=""8859/6"" />
      <xs:enumeration value=""8859/7"" />
      <xs:enumeration value=""8859/8"" />
      <xs:enumeration value=""8859/9"" />
      <xs:enumeration value=""ASCII"" />
      <xs:enumeration value=""BIG-5"" />
      <xs:enumeration value=""CNS 11643-1992"" />
      <xs:enumeration value=""GB 18030-2000"" />
      <xs:enumeration value=""ISO IR14"" />
      <xs:enumeration value=""ISO IR159"" />
      <xs:enumeration value=""ISO IR87"" />
      <xs:enumeration value=""KS X 1001"" />
      <xs:enumeration value=""UNICODE"" />
      <xs:enumeration value=""UNICODE UTF-16"" />
      <xs:enumeration value=""UNICODE UTF-32"" />
      <xs:enumeration value=""UNICODE UTF-8"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table356"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""&lt;null&gt;"" />
      <xs:enumeration value=""2.3"" />
      <xs:enumeration value=""ISO 2022-1994"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table363"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table465"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""P"" />
    </xs:restriction>
  </xs:simpleType>
</xs:schema>";
        
        public MSH_25_GLO_DEF() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "MSH_25_GLO_DEF";
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
