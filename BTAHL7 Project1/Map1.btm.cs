namespace BTAHL7Schemas {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTAHL7Schemas.ORU_R01_251_GLO_DEF", typeof(global::BTAHL7Schemas.ORU_R01_251_GLO_DEF))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTAHL7Schemas.ORU_R01_24_GLO_DEF", typeof(global::BTAHL7Schemas.ORU_R01_24_GLO_DEF))]
    public sealed class Map1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1 s2"" version=""1.0"" xmlns:s2=""http://microsoft.com/HealthCare/HL7/2X/2.5.1/Tables"" xmlns:s1=""http://microsoft.com/HealthCare/HL7/2X/2.5.1/DataTypes"" xmlns:ns0=""http://microsoft.com/HealthCare/HL7/2X/2.4/Segments"" xmlns:ns3=""http://microsoft.com/HealthCare/HL7/2X/2.4/DataTypes"" xmlns:ns1=""http://microsoft.com/HealthCare/HL7/2X"" xmlns:s0=""http://microsoft.com/HealthCare/HL7/2X/2.5.1/Segments"" xmlns:ns2=""http://microsoft.com/HealthCare/HL7/2X/2.4/Tables"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns1:ORU_R01_251_GLO_DEF"" />
  </xsl:template>
  <xsl:template match=""/ns1:ORU_R01_251_GLO_DEF"">
    <ns1:ORU_R01_24_GLO_DEF>
      <xsl:for-each select=""PID_PatientIdentification"">
        <PID_PatientIdentification>
          <xsl:value-of select=""./text()"" />
        </PID_PatientIdentification>
      </xsl:for-each>
      <xsl:for-each select=""PD1_PatientAdditionalDemographic"">
        <PD1_PatientAdditionalDemographic>
          <xsl:value-of select=""./text()"" />
        </PD1_PatientAdditionalDemographic>
      </xsl:for-each>
      <xsl:for-each select=""NK1_NextOfKinAssociatedParties"">
        <NK1_NextOfKinAssociatedParties>
          <xsl:value-of select=""./text()"" />
        </NK1_NextOfKinAssociatedParties>
      </xsl:for-each>
      <xsl:for-each select=""NTE_NotesAndComments[1]"">
        <NTE_NotesAndComments>
          <xsl:value-of select=""./text()"" />
        </NTE_NotesAndComments>
      </xsl:for-each>
      <xsl:for-each select=""PV1_PatientVisit"">
        <PV1_PatientVisit>
          <xsl:value-of select=""./text()"" />
        </PV1_PatientVisit>
      </xsl:for-each>
      <xsl:for-each select=""PV2_PatientVisitAdditionalInformation"">
        <PV2_PatientVisitAdditionalInformation>
          <xsl:value-of select=""./text()"" />
        </PV2_PatientVisitAdditionalInformation>
      </xsl:for-each>
      <xsl:for-each select=""ORC_CommonOrder"">
        <ORC_CommonOrder>
          <xsl:value-of select=""./text()"" />
        </ORC_CommonOrder>
      </xsl:for-each>
      <xsl:for-each select=""OBR_ObservationRequest"">
        <OBR_ObservationRequest>
          <xsl:value-of select=""./text()"" />
        </OBR_ObservationRequest>
      </xsl:for-each>
      <xsl:for-each select=""CTD_ContactData"">
        <CTD_ContactData>
          <xsl:value-of select=""./text()"" />
        </CTD_ContactData>
      </xsl:for-each>
      <xsl:for-each select=""OBX_ObservationResult[1]"">
        <OBX_ObservationResult>
          <xsl:value-of select=""./text()"" />
        </OBX_ObservationResult>
      </xsl:for-each>
      <xsl:for-each select=""FT1_FinancialTransaction"">
        <FT1_FinancialTransaction>
          <xsl:value-of select=""./text()"" />
        </FT1_FinancialTransaction>
      </xsl:for-each>
      <xsl:for-each select=""CTI_ClinicalTrialIdentification"">
        <CTI_ClinicalTrialIdentification>
          <xsl:value-of select=""./text()"" />
        </CTI_ClinicalTrialIdentification>
      </xsl:for-each>
      <xsl:for-each select=""DSC_ContinuationPointer"">
        <DSC_ContinuationPointer>
          <xsl:value-of select=""./text()"" />
        </DSC_ContinuationPointer>
      </xsl:for-each>
    </ns1:ORU_R01_24_GLO_DEF>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BTAHL7Schemas.ORU_R01_251_GLO_DEF";
        
        private const global::BTAHL7Schemas.ORU_R01_251_GLO_DEF _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BTAHL7Schemas.ORU_R01_24_GLO_DEF";
        
        private const global::BTAHL7Schemas.ORU_R01_24_GLO_DEF _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"BTAHL7Schemas.ORU_R01_251_GLO_DEF";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BTAHL7Schemas.ORU_R01_24_GLO_DEF";
                return _TrgSchemas;
            }
        }
    }
}
