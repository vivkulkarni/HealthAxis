namespace BTAHL7Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://microsoft.com/HealthCare/HL7/2X/2.4/DataTypes",@"HL7DefinedDataTypes")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"HL7DefinedDataTypes"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTAHL7Schemas.tablevalues_24", typeof(global::BTAHL7Schemas.tablevalues_24))]
    public sealed class datatypes_24 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://microsoft.com/HealthCare/HL7/2X/2.4/DataTypes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://microsoft.com/HealthCare/HL7/2X/2.4/Tables"" targetNamespace=""http://microsoft.com/HealthCare/HL7/2X/2.4/DataTypes"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""BTAHL7Schemas.tablevalues_24"" namespace=""http://microsoft.com/HealthCare/HL7/2X/2.4/Tables"" />
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo standards_version=""HL7.DBVersion.1_5"" document_type=""HL7 2X Schema"" version=""2.0.0104.0.2.0"" root_reference=""HL7DefinedDataTypes"" />
      <b:references>
        <b:reference targetNamespace=""http://microsoft.com/HealthCare/HL7/2X/2.4/Tables"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:simpleType name=""ID_202"">
    <xs:restriction base=""ns0:Table202"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_201"">
    <xs:restriction base=""ns0:Table201"" />
  </xs:simpleType>
  <xs:simpleType name=""TN"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""IS_204"">
    <xs:restriction base=""ns0:Table204"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_188"">
    <xs:restriction base=""ns0:Table188"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_84"">
    <xs:restriction base=""ns0:Table84"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_10"">
    <xs:restriction base=""ns0:Table10"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_288"">
    <xs:restriction base=""ns0:Table288"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_104"">
    <xs:restriction base=""ns0:Table104"" />
  </xs:simpleType>
  <xs:simpleType name=""TM"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ID_267"">
    <xs:restriction base=""ns0:Table267"" />
  </xs:simpleType>
  <xs:simpleType name=""varies"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""IS_153"">
    <xs:restriction base=""ns0:Table153"" />
  </xs:simpleType>
  <xs:simpleType name=""TX_256"">
    <xs:restriction base=""ns0:Table256"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_472"">
    <xs:restriction base=""ns0:Table472"" />
  </xs:simpleType>
  <xs:simpleType name=""CE_1"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ID_397"">
    <xs:restriction base=""ns0:Table397"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_369"">
    <xs:restriction base=""ns0:Table369"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_70"">
    <xs:restriction base=""ns0:Table70"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_337"">
    <xs:restriction base=""ns0:Table337"" />
  </xs:simpleType>
  <xs:simpleType name=""SI"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""[+]?[\d]+"" />
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""IS_294"">
    <xs:restriction base=""ns0:Table294"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_294"">
    <xs:restriction base=""ns0:Table294"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_146"">
    <xs:restriction base=""ns0:Table146"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_145"">
    <xs:restriction base=""ns0:Table145"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_440"">
    <xs:restriction base=""ns0:Table440"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_210"">
    <xs:restriction base=""ns0:Table210"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_209"">
    <xs:restriction base=""ns0:Table209"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_193"">
    <xs:restriction base=""ns0:Table193"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_147"">
    <xs:restriction base=""ns0:Table147"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_207"">
    <xs:restriction base=""ns0:Table207"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_103"">
    <xs:restriction base=""ns0:Table103"" />
  </xs:simpleType>
  <xs:simpleType name=""TX"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ID_444"">
    <xs:restriction base=""ns0:Table444"" />
  </xs:simpleType>
  <xs:simpleType name=""TS_1"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""TS_0"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ID_465"">
    <xs:restriction base=""ns0:Table465"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_200"">
    <xs:restriction base=""ns0:Table200"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_338"">
    <xs:restriction base=""ns0:Table338"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_302"">
    <xs:restriction base=""ns0:Table302"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_150"">
    <xs:restriction base=""ns0:Table150"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_350"">
    <xs:restriction base=""ns0:Table350"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_363"">
    <xs:restriction base=""ns0:Table363"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_297"">
    <xs:restriction base=""ns0:Table297"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_354"">
    <xs:restriction base=""ns0:Table354"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_76"">
    <xs:restriction base=""ns0:Table76"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_148"">
    <xs:restriction base=""ns0:Table148"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_190"">
    <xs:restriction base=""ns0:Table190"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_308"">
    <xs:restriction base=""ns0:Table308"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_307"">
    <xs:restriction base=""ns0:Table307"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_305"">
    <xs:restriction base=""ns0:Table305"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_306"">
    <xs:restriction base=""ns0:Table306"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_304"">
    <xs:restriction base=""ns0:Table304"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_303"">
    <xs:restriction base=""ns0:Table303"" />
  </xs:simpleType>
  <xs:simpleType name=""IS"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""IS_328"">
    <xs:restriction base=""ns0:Table328"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_327"">
    <xs:restriction base=""ns0:Table327"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_473"">
    <xs:restriction base=""ns0:Table473"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_470"">
    <xs:restriction base=""ns0:Table470"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_469"">
    <xs:restriction base=""ns0:Table469"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_468"">
    <xs:restriction base=""ns0:Table468"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_467"">
    <xs:restriction base=""ns0:Table467"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_460"">
    <xs:restriction base=""ns0:Table460"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_459"">
    <xs:restriction base=""ns0:Table459"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_458"">
    <xs:restriction base=""ns0:Table458"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_457"">
    <xs:restriction base=""ns0:Table457"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_456"">
    <xs:restriction base=""ns0:Table456"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_455"">
    <xs:restriction base=""ns0:Table455"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_445"">
    <xs:restriction base=""ns0:Table445"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_442"">
    <xs:restriction base=""ns0:Table442"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_441"">
    <xs:restriction base=""ns0:Table441"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_416"">
    <xs:restriction base=""ns0:Table416"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_415"">
    <xs:restriction base=""ns0:Table415"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_409"">
    <xs:restriction base=""ns0:Table409"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_392"">
    <xs:restriction base=""ns0:Table392"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_360"">
    <xs:restriction base=""ns0:Table360"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_335"">
    <xs:restriction base=""ns0:Table335"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_334"">
    <xs:restriction base=""ns0:Table334"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_326"">
    <xs:restriction base=""ns0:Table326"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_320"">
    <xs:restriction base=""ns0:Table320"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_319"">
    <xs:restriction base=""ns0:Table319"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_316"">
    <xs:restriction base=""ns0:Table316"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_315"">
    <xs:restriction base=""ns0:Table315"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_313"">
    <xs:restriction base=""ns0:Table313"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_312"">
    <xs:restriction base=""ns0:Table312"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_311"">
    <xs:restriction base=""ns0:Table311"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_309"">
    <xs:restriction base=""ns0:Table309"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_295"">
    <xs:restriction base=""ns0:Table295"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_289"">
    <xs:restriction base=""ns0:Table289"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_279"">
    <xs:restriction base=""ns0:Table279"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_270"">
    <xs:restriction base=""ns0:Table270"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_269"">
    <xs:restriction base=""ns0:Table269"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_268"">
    <xs:restriction base=""ns0:Table268"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_261"">
    <xs:restriction base=""ns0:Table261"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_260"">
    <xs:restriction base=""ns0:Table260"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_249"">
    <xs:restriction base=""ns0:Table249"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_246"">
    <xs:restriction base=""ns0:Table246"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_245"">
    <xs:restriction base=""ns0:Table245"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_244"">
    <xs:restriction base=""ns0:Table244"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_232"">
    <xs:restriction base=""ns0:Table232"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_231"">
    <xs:restriction base=""ns0:Table231"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_230"">
    <xs:restriction base=""ns0:Table230"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_229"">
    <xs:restriction base=""ns0:Table229"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_228"">
    <xs:restriction base=""ns0:Table228"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_223"">
    <xs:restriction base=""ns0:Table223"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_220"">
    <xs:restriction base=""ns0:Table220"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_219"">
    <xs:restriction base=""ns0:Table219"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_217"">
    <xs:restriction base=""ns0:Table217"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_216"">
    <xs:restriction base=""ns0:Table216"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_214"">
    <xs:restriction base=""ns0:Table214"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_213"">
    <xs:restriction base=""ns0:Table213"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_186"">
    <xs:restriction base=""ns0:Table186"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_182"">
    <xs:restriction base=""ns0:Table182"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_177"">
    <xs:restriction base=""ns0:Table177"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_174"">
    <xs:restriction base=""ns0:Table174"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_173"">
    <xs:restriction base=""ns0:Table173"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_152"">
    <xs:restriction base=""ns0:Table152"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_151"">
    <xs:restriction base=""ns0:Table151"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_144"">
    <xs:restriction base=""ns0:Table144"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_143"">
    <xs:restriction base=""ns0:Table143"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_142"">
    <xs:restriction base=""ns0:Table142"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_141"">
    <xs:restriction base=""ns0:Table141"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_140"">
    <xs:restriction base=""ns0:Table140"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_139"">
    <xs:restriction base=""ns0:Table139"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_137"">
    <xs:restriction base=""ns0:Table137"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_135"">
    <xs:restriction base=""ns0:Table135"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_130"">
    <xs:restriction base=""ns0:Table130"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_117"">
    <xs:restriction base=""ns0:Table117"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_116"">
    <xs:restriction base=""ns0:Table116"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_115"">
    <xs:restriction base=""ns0:Table115"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_112"">
    <xs:restriction base=""ns0:Table112"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_111"">
    <xs:restriction base=""ns0:Table111"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_110"">
    <xs:restriction base=""ns0:Table110"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_99"">
    <xs:restriction base=""ns0:Table99"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_98"">
    <xs:restriction base=""ns0:Table98"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_93"">
    <xs:restriction base=""ns0:Table93"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_92"">
    <xs:restriction base=""ns0:Table92"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_89"">
    <xs:restriction base=""ns0:Table89"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_87"">
    <xs:restriction base=""ns0:Table87"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_86"">
    <xs:restriction base=""ns0:Table86"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_78"">
    <xs:restriction base=""ns0:Table78"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_73"">
    <xs:restriction base=""ns0:Table73"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_68"">
    <xs:restriction base=""ns0:Table68"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_62"">
    <xs:restriction base=""ns0:Table62"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_56"">
    <xs:restriction base=""ns0:Table56"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_52"">
    <xs:restriction base=""ns0:Table52"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_46"">
    <xs:restriction base=""ns0:Table46"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_45"">
    <xs:restriction base=""ns0:Table45"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_44"">
    <xs:restriction base=""ns0:Table44"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_43"">
    <xs:restriction base=""ns0:Table43"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_42"">
    <xs:restriction base=""ns0:Table42"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_32"">
    <xs:restriction base=""ns0:Table32"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_24"">
    <xs:restriction base=""ns0:Table24"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_23"">
    <xs:restriction base=""ns0:Table23"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_22"">
    <xs:restriction base=""ns0:Table22"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_21"">
    <xs:restriction base=""ns0:Table21"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_19"">
    <xs:restriction base=""ns0:Table19"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_18"">
    <xs:restriction base=""ns0:Table18"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_17"">
    <xs:restriction base=""ns0:Table17"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_9"">
    <xs:restriction base=""ns0:Table9"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_7"">
    <xs:restriction base=""ns0:Table7"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_4"">
    <xs:restriction base=""ns0:Table4"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_1"">
    <xs:restriction base=""ns0:Table1"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_449"">
    <xs:restriction base=""ns0:Table449"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_418"">
    <xs:restriction base=""ns0:Table418"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_399"">
    <xs:restriction base=""ns0:Table399"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_398"">
    <xs:restriction base=""ns0:Table398"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_395"">
    <xs:restriction base=""ns0:Table395"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_359"">
    <xs:restriction base=""ns0:Table359"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_356"">
    <xs:restriction base=""ns0:Table356"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_355"">
    <xs:restriction base=""ns0:Table355"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_332"">
    <xs:restriction base=""ns0:Table332"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_331"">
    <xs:restriction base=""ns0:Table331"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_330"">
    <xs:restriction base=""ns0:Table330"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_329"">
    <xs:restriction base=""ns0:Table329"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_323"">
    <xs:restriction base=""ns0:Table323"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_322"">
    <xs:restriction base=""ns0:Table322"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_321"">
    <xs:restriction base=""ns0:Table321"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_287"">
    <xs:restriction base=""ns0:Table287"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_275"">
    <xs:restriction base=""ns0:Table275"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_273"">
    <xs:restriction base=""ns0:Table273"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_272"">
    <xs:restriction base=""ns0:Table272"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_271"">
    <xs:restriction base=""ns0:Table271"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_253"">
    <xs:restriction base=""ns0:Table253"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_252"">
    <xs:restriction base=""ns0:Table252"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_251"">
    <xs:restriction base=""ns0:Table251"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_250"">
    <xs:restriction base=""ns0:Table250"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_248"">
    <xs:restriction base=""ns0:Table248"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_243"">
    <xs:restriction base=""ns0:Table243"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_242"">
    <xs:restriction base=""ns0:Table242"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_241"">
    <xs:restriction base=""ns0:Table241"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_240"">
    <xs:restriction base=""ns0:Table240"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_239"">
    <xs:restriction base=""ns0:Table239"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_238"">
    <xs:restriction base=""ns0:Table238"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_237"">
    <xs:restriction base=""ns0:Table237"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_236"">
    <xs:restriction base=""ns0:Table236"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_235"">
    <xs:restriction base=""ns0:Table235"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_234"">
    <xs:restriction base=""ns0:Table234"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_225"">
    <xs:restriction base=""ns0:Table225"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_224"">
    <xs:restriction base=""ns0:Table224"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_211"">
    <xs:restriction base=""ns0:Table211"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_208"">
    <xs:restriction base=""ns0:Table208"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_206"">
    <xs:restriction base=""ns0:Table206"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_191"">
    <xs:restriction base=""ns0:Table191"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_187"">
    <xs:restriction base=""ns0:Table187"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_183"">
    <xs:restriction base=""ns0:Table183"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_180"">
    <xs:restriction base=""ns0:Table180"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_179"">
    <xs:restriction base=""ns0:Table179"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_178"">
    <xs:restriction base=""ns0:Table178"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_170"">
    <xs:restriction base=""ns0:Table170"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_169"">
    <xs:restriction base=""ns0:Table169"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_168"">
    <xs:restriction base=""ns0:Table168"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_167"">
    <xs:restriction base=""ns0:Table167"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_166"">
    <xs:restriction base=""ns0:Table166"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_161"">
    <xs:restriction base=""ns0:Table161"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_159"">
    <xs:restriction base=""ns0:Table159"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_158"">
    <xs:restriction base=""ns0:Table158"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_157"">
    <xs:restriction base=""ns0:Table157"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_156"">
    <xs:restriction base=""ns0:Table156"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_155"">
    <xs:restriction base=""ns0:Table155"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_136"">
    <xs:restriction base=""ns0:Table136"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_125"">
    <xs:restriction base=""ns0:Table125"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_124"">
    <xs:restriction base=""ns0:Table124"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_123"">
    <xs:restriction base=""ns0:Table123"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_122"">
    <xs:restriction base=""ns0:Table122"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_121"">
    <xs:restriction base=""ns0:Table121"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_119"">
    <xs:restriction base=""ns0:Table119"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_109"">
    <xs:restriction base=""ns0:Table109"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_108"">
    <xs:restriction base=""ns0:Table108"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_107"">
    <xs:restriction base=""ns0:Table107"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_106"">
    <xs:restriction base=""ns0:Table106"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_105"">
    <xs:restriction base=""ns0:Table105"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_102"">
    <xs:restriction base=""ns0:Table102"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_91"">
    <xs:restriction base=""ns0:Table91"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_85"">
    <xs:restriction base=""ns0:Table85"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_80"">
    <xs:restriction base=""ns0:Table80"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_74"">
    <xs:restriction base=""ns0:Table74"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_65"">
    <xs:restriction base=""ns0:Table65"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_53"">
    <xs:restriction base=""ns0:Table53"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_38"">
    <xs:restriction base=""ns0:Table38"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_27"">
    <xs:restriction base=""ns0:Table27"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_8"">
    <xs:restriction base=""ns0:Table8"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_3"">
    <xs:restriction base=""ns0:Table3"" />
  </xs:simpleType>
  <xs:simpleType name=""FT"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""IS_64"">
    <xs:restriction base=""ns0:Table64"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_149"">
    <xs:restriction base=""ns0:Table149"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_333"">
    <xs:restriction base=""ns0:Table333"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_203"">
    <xs:restriction base=""ns0:Table203"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_203"">
    <xs:restriction base=""ns0:Table203"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_298"">
    <xs:restriction base=""ns0:Table298"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_205"">
    <xs:restriction base=""ns0:Table205"" />
  </xs:simpleType>
  <xs:simpleType name=""ID"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ID_301"">
    <xs:restriction base=""ns0:Table301"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_300"">
    <xs:restriction base=""ns0:Table300"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_61"">
    <xs:restriction base=""ns0:Table61"" />
  </xs:simpleType>
  <xs:simpleType name=""NM"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""[-+]?[\d]*|[-+]?[\d]+.[\d]*|[-+]?[\d]*.[\d]+"" />
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""IS_474"">
    <xs:restriction base=""ns0:Table474"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_474"">
    <xs:restriction base=""ns0:Table474"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_471"">
    <xs:restriction base=""ns0:Table471"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_471"">
    <xs:restriction base=""ns0:Table471"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_466"">
    <xs:restriction base=""ns0:Table466"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_466"">
    <xs:restriction base=""ns0:Table466"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_464"">
    <xs:restriction base=""ns0:Table464"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_464"">
    <xs:restriction base=""ns0:Table464"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_463"">
    <xs:restriction base=""ns0:Table463"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_463"">
    <xs:restriction base=""ns0:Table463"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_462"">
    <xs:restriction base=""ns0:Table462"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_462"">
    <xs:restriction base=""ns0:Table462"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_461"">
    <xs:restriction base=""ns0:Table461"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_461"">
    <xs:restriction base=""ns0:Table461"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_454"">
    <xs:restriction base=""ns0:Table454"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_453"">
    <xs:restriction base=""ns0:Table453"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_452"">
    <xs:restriction base=""ns0:Table452"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_451"">
    <xs:restriction base=""ns0:Table451"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_451"">
    <xs:restriction base=""ns0:Table451"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_450"">
    <xs:restriction base=""ns0:Table450"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_447"">
    <xs:restriction base=""ns0:Table447"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_447"">
    <xs:restriction base=""ns0:Table447"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_446"">
    <xs:restriction base=""ns0:Table446"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_446"">
    <xs:restriction base=""ns0:Table446"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_443"">
    <xs:restriction base=""ns0:Table443"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_438"">
    <xs:restriction base=""ns0:Table438"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_438"">
    <xs:restriction base=""ns0:Table438"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_437"">
    <xs:restriction base=""ns0:Table437"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_437"">
    <xs:restriction base=""ns0:Table437"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_436"">
    <xs:restriction base=""ns0:Table436"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_436"">
    <xs:restriction base=""ns0:Table436"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_435"">
    <xs:restriction base=""ns0:Table435"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_435"">
    <xs:restriction base=""ns0:Table435"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_434"">
    <xs:restriction base=""ns0:Table434"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_434"">
    <xs:restriction base=""ns0:Table434"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_433"">
    <xs:restriction base=""ns0:Table433"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_433"">
    <xs:restriction base=""ns0:Table433"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_432"">
    <xs:restriction base=""ns0:Table432"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_432"">
    <xs:restriction base=""ns0:Table432"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_431"">
    <xs:restriction base=""ns0:Table431"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_431"">
    <xs:restriction base=""ns0:Table431"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_430"">
    <xs:restriction base=""ns0:Table430"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_430"">
    <xs:restriction base=""ns0:Table430"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_429"">
    <xs:restriction base=""ns0:Table429"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_429"">
    <xs:restriction base=""ns0:Table429"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_428"">
    <xs:restriction base=""ns0:Table428"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_428"">
    <xs:restriction base=""ns0:Table428"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_427"">
    <xs:restriction base=""ns0:Table427"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_427"">
    <xs:restriction base=""ns0:Table427"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_426"">
    <xs:restriction base=""ns0:Table426"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_426"">
    <xs:restriction base=""ns0:Table426"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_425"">
    <xs:restriction base=""ns0:Table425"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_425"">
    <xs:restriction base=""ns0:Table425"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_424"">
    <xs:restriction base=""ns0:Table424"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_424"">
    <xs:restriction base=""ns0:Table424"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_423"">
    <xs:restriction base=""ns0:Table423"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_423"">
    <xs:restriction base=""ns0:Table423"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_422"">
    <xs:restriction base=""ns0:Table422"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_422"">
    <xs:restriction base=""ns0:Table422"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_421"">
    <xs:restriction base=""ns0:Table421"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_421"">
    <xs:restriction base=""ns0:Table421"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_417"">
    <xs:restriction base=""ns0:Table417"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_417"">
    <xs:restriction base=""ns0:Table417"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_414"">
    <xs:restriction base=""ns0:Table414"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_414"">
    <xs:restriction base=""ns0:Table414"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_413"">
    <xs:restriction base=""ns0:Table413"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_413"">
    <xs:restriction base=""ns0:Table413"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_412"">
    <xs:restriction base=""ns0:Table412"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_412"">
    <xs:restriction base=""ns0:Table412"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_411"">
    <xs:restriction base=""ns0:Table411"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_411"">
    <xs:restriction base=""ns0:Table411"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_406"">
    <xs:restriction base=""ns0:Table406"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_406"">
    <xs:restriction base=""ns0:Table406"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_405"">
    <xs:restriction base=""ns0:Table405"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_405"">
    <xs:restriction base=""ns0:Table405"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_404"">
    <xs:restriction base=""ns0:Table404"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_403"">
    <xs:restriction base=""ns0:Table403"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_402"">
    <xs:restriction base=""ns0:Table402"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_402"">
    <xs:restriction base=""ns0:Table402"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_401"">
    <xs:restriction base=""ns0:Table401"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_401"">
    <xs:restriction base=""ns0:Table401"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_394"">
    <xs:restriction base=""ns0:Table394"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_393"">
    <xs:restriction base=""ns0:Table393"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_393"">
    <xs:restriction base=""ns0:Table393"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_389"">
    <xs:restriction base=""ns0:Table389"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_388"">
    <xs:restriction base=""ns0:Table388"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_387"">
    <xs:restriction base=""ns0:Table387"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_386"">
    <xs:restriction base=""ns0:Table386"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_386"">
    <xs:restriction base=""ns0:Table386"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_385"">
    <xs:restriction base=""ns0:Table385"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_385"">
    <xs:restriction base=""ns0:Table385"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_384"">
    <xs:restriction base=""ns0:Table384"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_383"">
    <xs:restriction base=""ns0:Table383"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_382"">
    <xs:restriction base=""ns0:Table382"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_382"">
    <xs:restriction base=""ns0:Table382"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_381"">
    <xs:restriction base=""ns0:Table381"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_381"">
    <xs:restriction base=""ns0:Table381"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_380"">
    <xs:restriction base=""ns0:Table380"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_380"">
    <xs:restriction base=""ns0:Table380"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_379"">
    <xs:restriction base=""ns0:Table379"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_379"">
    <xs:restriction base=""ns0:Table379"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_378"">
    <xs:restriction base=""ns0:Table378"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_378"">
    <xs:restriction base=""ns0:Table378"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_377"">
    <xs:restriction base=""ns0:Table377"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_376"">
    <xs:restriction base=""ns0:Table376"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_375"">
    <xs:restriction base=""ns0:Table375"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_374"">
    <xs:restriction base=""ns0:Table374"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_373"">
    <xs:restriction base=""ns0:Table373"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_371"">
    <xs:restriction base=""ns0:Table371"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_370"">
    <xs:restriction base=""ns0:Table370"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_368"">
    <xs:restriction base=""ns0:Table368"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_367"">
    <xs:restriction base=""ns0:Table367"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_366"">
    <xs:restriction base=""ns0:Table366"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_365"">
    <xs:restriction base=""ns0:Table365"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_364"">
    <xs:restriction base=""ns0:Table364"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_364"">
    <xs:restriction base=""ns0:Table364"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_358"">
    <xs:restriction base=""ns0:Table358"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_358"">
    <xs:restriction base=""ns0:Table358"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_357"">
    <xs:restriction base=""ns0:Table357"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_351"">
    <xs:restriction base=""ns0:Table351"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_351"">
    <xs:restriction base=""ns0:Table351"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_349"">
    <xs:restriction base=""ns0:Table349"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_349"">
    <xs:restriction base=""ns0:Table349"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_348"">
    <xs:restriction base=""ns0:Table348"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_348"">
    <xs:restriction base=""ns0:Table348"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_347"">
    <xs:restriction base=""ns0:Table347"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_347"">
    <xs:restriction base=""ns0:Table347"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_346"">
    <xs:restriction base=""ns0:Table346"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_346"">
    <xs:restriction base=""ns0:Table346"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_345"">
    <xs:restriction base=""ns0:Table345"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_345"">
    <xs:restriction base=""ns0:Table345"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_344"">
    <xs:restriction base=""ns0:Table344"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_344"">
    <xs:restriction base=""ns0:Table344"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_343"">
    <xs:restriction base=""ns0:Table343"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_343"">
    <xs:restriction base=""ns0:Table343"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_342"">
    <xs:restriction base=""ns0:Table342"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_342"">
    <xs:restriction base=""ns0:Table342"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_341"">
    <xs:restriction base=""ns0:Table341"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_341"">
    <xs:restriction base=""ns0:Table341"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_340"">
    <xs:restriction base=""ns0:Table340"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_340"">
    <xs:restriction base=""ns0:Table340"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_339"">
    <xs:restriction base=""ns0:Table339"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_339"">
    <xs:restriction base=""ns0:Table339"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_336"">
    <xs:restriction base=""ns0:Table336"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_336"">
    <xs:restriction base=""ns0:Table336"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_325"">
    <xs:restriction base=""ns0:Table325"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_325"">
    <xs:restriction base=""ns0:Table325"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_324"">
    <xs:restriction base=""ns0:Table324"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_324"">
    <xs:restriction base=""ns0:Table324"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_296"">
    <xs:restriction base=""ns0:Table296"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_296"">
    <xs:restriction base=""ns0:Table296"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_293"">
    <xs:restriction base=""ns0:Table293"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_293"">
    <xs:restriction base=""ns0:Table293"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_292"">
    <xs:restriction base=""ns0:Table292"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_286"">
    <xs:restriction base=""ns0:Table286"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_286"">
    <xs:restriction base=""ns0:Table286"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_285"">
    <xs:restriction base=""ns0:Table285"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_285"">
    <xs:restriction base=""ns0:Table285"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_284"">
    <xs:restriction base=""ns0:Table284"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_284"">
    <xs:restriction base=""ns0:Table284"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_283"">
    <xs:restriction base=""ns0:Table283"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_283"">
    <xs:restriction base=""ns0:Table283"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_282"">
    <xs:restriction base=""ns0:Table282"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_282"">
    <xs:restriction base=""ns0:Table282"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_281"">
    <xs:restriction base=""ns0:Table281"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_281"">
    <xs:restriction base=""ns0:Table281"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_280"">
    <xs:restriction base=""ns0:Table280"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_280"">
    <xs:restriction base=""ns0:Table280"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_278"">
    <xs:restriction base=""ns0:Table278"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_278"">
    <xs:restriction base=""ns0:Table278"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_277"">
    <xs:restriction base=""ns0:Table277"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_277"">
    <xs:restriction base=""ns0:Table277"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_276"">
    <xs:restriction base=""ns0:Table276"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_276"">
    <xs:restriction base=""ns0:Table276"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_265"">
    <xs:restriction base=""ns0:Table265"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_265"">
    <xs:restriction base=""ns0:Table265"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_264"">
    <xs:restriction base=""ns0:Table264"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_264"">
    <xs:restriction base=""ns0:Table264"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_259"">
    <xs:restriction base=""ns0:Table259"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_259"">
    <xs:restriction base=""ns0:Table259"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_258"">
    <xs:restriction base=""ns0:Table258"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_255"">
    <xs:restriction base=""ns0:Table255"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_255"">
    <xs:restriction base=""ns0:Table255"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_254"">
    <xs:restriction base=""ns0:Table254"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_247"">
    <xs:restriction base=""ns0:Table247"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_233"">
    <xs:restriction base=""ns0:Table233"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_233"">
    <xs:restriction base=""ns0:Table233"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_227"">
    <xs:restriction base=""ns0:Table227"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_222"">
    <xs:restriction base=""ns0:Table222"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_222"">
    <xs:restriction base=""ns0:Table222"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_218"">
    <xs:restriction base=""ns0:Table218"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_218"">
    <xs:restriction base=""ns0:Table218"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_215"">
    <xs:restriction base=""ns0:Table215"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_215"">
    <xs:restriction base=""ns0:Table215"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_212"">
    <xs:restriction base=""ns0:Table212"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_212"">
    <xs:restriction base=""ns0:Table212"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_189"">
    <xs:restriction base=""ns0:Table189"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_189"">
    <xs:restriction base=""ns0:Table189"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_185"">
    <xs:restriction base=""ns0:Table185"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_184"">
    <xs:restriction base=""ns0:Table184"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_184"">
    <xs:restriction base=""ns0:Table184"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_181"">
    <xs:restriction base=""ns0:Table181"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_181"">
    <xs:restriction base=""ns0:Table181"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_175"">
    <xs:restriction base=""ns0:Table175"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_172"">
    <xs:restriction base=""ns0:Table172"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_172"">
    <xs:restriction base=""ns0:Table172"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_171"">
    <xs:restriction base=""ns0:Table171"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_171"">
    <xs:restriction base=""ns0:Table171"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_165"">
    <xs:restriction base=""ns0:Table165"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_164"">
    <xs:restriction base=""ns0:Table164"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_163"">
    <xs:restriction base=""ns0:Table163"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_162"">
    <xs:restriction base=""ns0:Table162"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_160"">
    <xs:restriction base=""ns0:Table160"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_136"">
    <xs:restriction base=""ns0:Table136"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_132"">
    <xs:restriction base=""ns0:Table132"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_132"">
    <xs:restriction base=""ns0:Table132"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_131"">
    <xs:restriction base=""ns0:Table131"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_129"">
    <xs:restriction base=""ns0:Table129"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_129"">
    <xs:restriction base=""ns0:Table129"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_128"">
    <xs:restriction base=""ns0:Table128"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_128"">
    <xs:restriction base=""ns0:Table128"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_127"">
    <xs:restriction base=""ns0:Table127"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_127"">
    <xs:restriction base=""ns0:Table127"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_118"">
    <xs:restriction base=""ns0:Table118"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_118"">
    <xs:restriction base=""ns0:Table118"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_114"">
    <xs:restriction base=""ns0:Table114"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_114"">
    <xs:restriction base=""ns0:Table114"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_88"">
    <xs:restriction base=""ns0:Table88"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_88"">
    <xs:restriction base=""ns0:Table88"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_83"">
    <xs:restriction base=""ns0:Table83"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_83"">
    <xs:restriction base=""ns0:Table83"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_72"">
    <xs:restriction base=""ns0:Table72"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_72"">
    <xs:restriction base=""ns0:Table72"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_69"">
    <xs:restriction base=""ns0:Table69"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_69"">
    <xs:restriction base=""ns0:Table69"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_66"">
    <xs:restriction base=""ns0:Table66"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_66"">
    <xs:restriction base=""ns0:Table66"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_63"">
    <xs:restriction base=""ns0:Table63"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_63"">
    <xs:restriction base=""ns0:Table63"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_59"">
    <xs:restriction base=""ns0:Table59"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_59"">
    <xs:restriction base=""ns0:Table59"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_55"">
    <xs:restriction base=""ns0:Table55"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_55"">
    <xs:restriction base=""ns0:Table55"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_51"">
    <xs:restriction base=""ns0:Table51"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_51"">
    <xs:restriction base=""ns0:Table51"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_50"">
    <xs:restriction base=""ns0:Table50"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_50"">
    <xs:restriction base=""ns0:Table50"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_49"">
    <xs:restriction base=""ns0:Table49"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_49"">
    <xs:restriction base=""ns0:Table49"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_48"">
    <xs:restriction base=""ns0:Table48"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_6"">
    <xs:restriction base=""ns0:Table6"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_6"">
    <xs:restriction base=""ns0:Table6"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_5"">
    <xs:restriction base=""ns0:Table5"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_5"">
    <xs:restriction base=""ns0:Table5"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_2"">
    <xs:restriction base=""ns0:Table2"" />
  </xs:simpleType>
  <xs:simpleType name=""ST_2"">
    <xs:restriction base=""ns0:Table2"" />
  </xs:simpleType>
  <xs:simpleType name=""IS_396"">
    <xs:restriction base=""ns0:Table396"" />
  </xs:simpleType>
  <xs:simpleType name=""ID_100"">
    <xs:restriction base=""ns0:Table100"" />
  </xs:simpleType>
  <xs:simpleType name=""DT"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ST"">
    <xs:restriction base=""xs:string"">
      <xs:whiteSpace value=""preserve"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""HL7DefinedDataTypes"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""AUI"" type=""AUI"" />
        <xs:element name=""CCD_100"" type=""CCD_100"" />
        <xs:element name=""CE"" type=""CE"" />
        <xs:element name=""CE_0002_2"" type=""CE_0002_2"" />
        <xs:element name=""CE_0005_5"" type=""CE_0005_5"" />
        <xs:element name=""CE_0006_6"" type=""CE_0006_6"" />
        <xs:element name=""CE_0048_48"" type=""CE_0048_48"" />
        <xs:element name=""CE_0049_49"" type=""CE_0049_49"" />
        <xs:element name=""CE_0050_50"" type=""CE_0050_50"" />
        <xs:element name=""CE_0051_51"" type=""CE_0051_51"" />
        <xs:element name=""CE_0055_55"" type=""CE_0055_55"" />
        <xs:element name=""CE_0059_59"" type=""CE_0059_59"" />
        <xs:element name=""CE_0063_63"" type=""CE_0063_63"" />
        <xs:element name=""CE_0066_66"" type=""CE_0066_66"" />
        <xs:element name=""CE_0069_69"" type=""CE_0069_69"" />
        <xs:element name=""CE_0072_72"" type=""CE_0072_72"" />
        <xs:element name=""CE_0083_83"" type=""CE_0083_83"" />
        <xs:element name=""CE_0088_88"" type=""CE_0088_88"" />
        <xs:element name=""CE_0114_114"" type=""CE_0114_114"" />
        <xs:element name=""CE_0118_118"" type=""CE_0118_118"" />
        <xs:element name=""CE_0127_127"" type=""CE_0127_127"" />
        <xs:element name=""CE_0128_128"" type=""CE_0128_128"" />
        <xs:element name=""CE_0129_129"" type=""CE_0129_129"" />
        <xs:element name=""CE_0131_131"" type=""CE_0131_131"" />
        <xs:element name=""CE_0132_132"" type=""CE_0132_132"" />
        <xs:element name=""CE_0136_136"" type=""CE_0136_136"" />
        <xs:element name=""CE_0160_160"" type=""CE_0160_160"" />
        <xs:element name=""CE_0162_162"" type=""CE_0162_162"" />
        <xs:element name=""CE_0163_163"" type=""CE_0163_163"" />
        <xs:element name=""CE_0164_164"" type=""CE_0164_164"" />
        <xs:element name=""CE_0165_165"" type=""CE_0165_165"" />
        <xs:element name=""CE_0171_171"" type=""CE_0171_171"" />
        <xs:element name=""CE_0172_172"" type=""CE_0172_172"" />
        <xs:element name=""CE_0175_175"" type=""CE_0175_175"" />
        <xs:element name=""CE_0181_181"" type=""CE_0181_181"" />
        <xs:element name=""CE_0184_184"" type=""CE_0184_184"" />
        <xs:element name=""CE_0185_185"" type=""CE_0185_185"" />
        <xs:element name=""CE_0189_189"" type=""CE_0189_189"" />
        <xs:element name=""CE_0212_212"" type=""CE_0212_212"" />
        <xs:element name=""CE_0215_215"" type=""CE_0215_215"" />
        <xs:element name=""CE_0218_218"" type=""CE_0218_218"" />
        <xs:element name=""CE_0222_222"" type=""CE_0222_222"" />
        <xs:element name=""CE_0227_227"" type=""CE_0227_227"" />
        <xs:element name=""CE_0233_233"" type=""CE_0233_233"" />
        <xs:element name=""CE_0247_247"" type=""CE_0247_247"" />
        <xs:element name=""CE_0254_254"" type=""CE_0254_254"" />
        <xs:element name=""CE_0255_255"" type=""CE_0255_255"" />
        <xs:element name=""CE_0258_258"" type=""CE_0258_258"" />
        <xs:element name=""CE_0259_259"" type=""CE_0259_259"" />
        <xs:element name=""CE_0264_264"" type=""CE_0264_264"" />
        <xs:element name=""CE_0265_265"" type=""CE_0265_265"" />
        <xs:element name=""CE_0276_276"" type=""CE_0276_276"" />
        <xs:element name=""CE_0277_277"" type=""CE_0277_277"" />
        <xs:element name=""CE_0278_278"" type=""CE_0278_278"" />
        <xs:element name=""CE_0280_280"" type=""CE_0280_280"" />
        <xs:element name=""CE_0281_281"" type=""CE_0281_281"" />
        <xs:element name=""CE_0282_282"" type=""CE_0282_282"" />
        <xs:element name=""CE_0283_283"" type=""CE_0283_283"" />
        <xs:element name=""CE_0284_284"" type=""CE_0284_284"" />
        <xs:element name=""CE_0285_285"" type=""CE_0285_285"" />
        <xs:element name=""CE_0286_286"" type=""CE_0286_286"" />
        <xs:element name=""CE_0292_292"" type=""CE_0292_292"" />
        <xs:element name=""CE_0293_293"" type=""CE_0293_293"" />
        <xs:element name=""CE_0296_296"" type=""CE_0296_296"" />
        <xs:element name=""CE_0324_324"" type=""CE_0324_324"" />
        <xs:element name=""CE_0325_325"" type=""CE_0325_325"" />
        <xs:element name=""CE_0336_336"" type=""CE_0336_336"" />
        <xs:element name=""CE_0339_339"" type=""CE_0339_339"" />
        <xs:element name=""CE_0340_340"" type=""CE_0340_340"" />
        <xs:element name=""CE_0341_341"" type=""CE_0341_341"" />
        <xs:element name=""CE_0342_342"" type=""CE_0342_342"" />
        <xs:element name=""CE_0343_343"" type=""CE_0343_343"" />
        <xs:element name=""CE_0344_344"" type=""CE_0344_344"" />
        <xs:element name=""CE_0345_345"" type=""CE_0345_345"" />
        <xs:element name=""CE_0346_346"" type=""CE_0346_346"" />
        <xs:element name=""CE_0347_347"" type=""CE_0347_347"" />
        <xs:element name=""CE_0348_348"" type=""CE_0348_348"" />
        <xs:element name=""CE_0349_349"" type=""CE_0349_349"" />
        <xs:element name=""CE_0351_351"" type=""CE_0351_351"" />
        <xs:element name=""CE_0357_357"" type=""CE_0357_357"" />
        <xs:element name=""CE_0358_358"" type=""CE_0358_358"" />
        <xs:element name=""CE_0364_364"" type=""CE_0364_364"" />
        <xs:element name=""CE_0365_365"" type=""CE_0365_365"" />
        <xs:element name=""CE_0366_366"" type=""CE_0366_366"" />
        <xs:element name=""CE_0367_367"" type=""CE_0367_367"" />
        <xs:element name=""CE_0368_368"" type=""CE_0368_368"" />
        <xs:element name=""CE_0370_370"" type=""CE_0370_370"" />
        <xs:element name=""CE_0371_371"" type=""CE_0371_371"" />
        <xs:element name=""CE_0373_373"" type=""CE_0373_373"" />
        <xs:element name=""CE_0374_374"" type=""CE_0374_374"" />
        <xs:element name=""CE_0375_375"" type=""CE_0375_375"" />
        <xs:element name=""CE_0376_376"" type=""CE_0376_376"" />
        <xs:element name=""CE_0377_377"" type=""CE_0377_377"" />
        <xs:element name=""CE_0378_378"" type=""CE_0378_378"" />
        <xs:element name=""CE_0379_379"" type=""CE_0379_379"" />
        <xs:element name=""CE_0380_380"" type=""CE_0380_380"" />
        <xs:element name=""CE_0381_381"" type=""CE_0381_381"" />
        <xs:element name=""CE_0382_382"" type=""CE_0382_382"" />
        <xs:element name=""CE_0383_383"" type=""CE_0383_383"" />
        <xs:element name=""CE_0384_384"" type=""CE_0384_384"" />
        <xs:element name=""CE_0385_385"" type=""CE_0385_385"" />
        <xs:element name=""CE_0386_386"" type=""CE_0386_386"" />
        <xs:element name=""CE_0387_387"" type=""CE_0387_387"" />
        <xs:element name=""CE_0388_388"" type=""CE_0388_388"" />
        <xs:element name=""CE_0389_389"" type=""CE_0389_389"" />
        <xs:element name=""CE_0393_393"" type=""CE_0393_393"" />
        <xs:element name=""CE_0394_394"" type=""CE_0394_394"" />
        <xs:element name=""CE_0401_401"" type=""CE_0401_401"" />
        <xs:element name=""CE_0402_402"" type=""CE_0402_402"" />
        <xs:element name=""CE_0403_403"" type=""CE_0403_403"" />
        <xs:element name=""CE_0404_404"" type=""CE_0404_404"" />
        <xs:element name=""CE_0405_405"" type=""CE_0405_405"" />
        <xs:element name=""CE_0406_406"" type=""CE_0406_406"" />
        <xs:element name=""CE_0411_411"" type=""CE_0411_411"" />
        <xs:element name=""CE_0412_412"" type=""CE_0412_412"" />
        <xs:element name=""CE_0413_413"" type=""CE_0413_413"" />
        <xs:element name=""CE_0414_414"" type=""CE_0414_414"" />
        <xs:element name=""CE_0417_417"" type=""CE_0417_417"" />
        <xs:element name=""CE_0421_421"" type=""CE_0421_421"" />
        <xs:element name=""CE_0422_422"" type=""CE_0422_422"" />
        <xs:element name=""CE_0423_423"" type=""CE_0423_423"" />
        <xs:element name=""CE_0424_424"" type=""CE_0424_424"" />
        <xs:element name=""CE_0425_425"" type=""CE_0425_425"" />
        <xs:element name=""CE_0426_426"" type=""CE_0426_426"" />
        <xs:element name=""CE_0427_427"" type=""CE_0427_427"" />
        <xs:element name=""CE_0428_428"" type=""CE_0428_428"" />
        <xs:element name=""CE_0429_429"" type=""CE_0429_429"" />
        <xs:element name=""CE_0430_430"" type=""CE_0430_430"" />
        <xs:element name=""CE_0431_431"" type=""CE_0431_431"" />
        <xs:element name=""CE_0432_432"" type=""CE_0432_432"" />
        <xs:element name=""CE_0433_433"" type=""CE_0433_433"" />
        <xs:element name=""CE_0434_434"" type=""CE_0434_434"" />
        <xs:element name=""CE_0435_435"" type=""CE_0435_435"" />
        <xs:element name=""CE_0436_436"" type=""CE_0436_436"" />
        <xs:element name=""CE_0437_437"" type=""CE_0437_437"" />
        <xs:element name=""CE_0438_438"" type=""CE_0438_438"" />
        <xs:element name=""CE_0443_443"" type=""CE_0443_443"" />
        <xs:element name=""CE_0446_446"" type=""CE_0446_446"" />
        <xs:element name=""CE_0447_447"" type=""CE_0447_447"" />
        <xs:element name=""CE_0450_450"" type=""CE_0450_450"" />
        <xs:element name=""CE_0451_451"" type=""CE_0451_451"" />
        <xs:element name=""CE_0452_452"" type=""CE_0452_452"" />
        <xs:element name=""CE_0453_453"" type=""CE_0453_453"" />
        <xs:element name=""CE_0454_454"" type=""CE_0454_454"" />
        <xs:element name=""CE_0461_461"" type=""CE_0461_461"" />
        <xs:element name=""CE_0462_462"" type=""CE_0462_462"" />
        <xs:element name=""CE_0463_463"" type=""CE_0463_463"" />
        <xs:element name=""CE_0464_464"" type=""CE_0464_464"" />
        <xs:element name=""CE_0466_466"" type=""CE_0466_466"" />
        <xs:element name=""CE_0471_471"" type=""CE_0471_471"" />
        <xs:element name=""CE_0474_474"" type=""CE_0474_474"" />
        <xs:element name=""CE_1"" type=""CE_1"" />
        <xs:element name=""CE_9999"" type=""CE_9999"" />
        <xs:element name=""CK"" type=""CK"" />
        <xs:element name=""CNE_323"" type=""CNE_323"" />
        <xs:element name=""CP"" type=""CP"" />
        <xs:element name=""CQ"" type=""CQ"" />
        <xs:element name=""CQ_126"" type=""CQ_126"" />
        <xs:element name=""CWE"" type=""CWE"" />
        <xs:element name=""CX"" type=""CX"" />
        <xs:element name=""CX_203"" type=""CX_203"" />
        <xs:element name=""DDI"" type=""DDI"" />
        <xs:element name=""DIN"" type=""DIN"" />
        <xs:element name=""DLD_113"" type=""DLD_113"" />
        <xs:element name=""DLN"" type=""DLN"" />
        <xs:element name=""DLT"" type=""DLT"" />
        <xs:element name=""DR"" type=""DR"" />
        <xs:element name=""DT"" type=""DT"" />
        <xs:element name=""DTN_149"" type=""DTN_149"" />
        <xs:element name=""EI"" type=""EI"" />
        <xs:element name=""EIP"" type=""EIP"" />
        <xs:element name=""ELD"" type=""ELD"" />
        <xs:element name=""FC_64"" type=""FC_64"" />
        <xs:element name=""FT"" type=""FT"" />
        <xs:element name=""HD"" type=""HD"" />
        <xs:element name=""HD_361"" type=""HD_361"" />
        <xs:element name=""HD_362"" type=""HD_362"" />
        <xs:element name=""ID"" type=""ID"" />
        <xs:element name=""ID_100"" type=""ID_100"" />
        <xs:element name=""ID_102"" type=""ID_102"" />
        <xs:element name=""ID_103"" type=""ID_103"" />
        <xs:element name=""ID_104"" type=""ID_104"" />
        <xs:element name=""ID_105"" type=""ID_105"" />
        <xs:element name=""ID_106"" type=""ID_106"" />
        <xs:element name=""ID_107"" type=""ID_107"" />
        <xs:element name=""ID_108"" type=""ID_108"" />
        <xs:element name=""ID_109"" type=""ID_109"" />
        <xs:element name=""ID_119"" type=""ID_119"" />
        <xs:element name=""ID_121"" type=""ID_121"" />
        <xs:element name=""ID_122"" type=""ID_122"" />
        <xs:element name=""ID_123"" type=""ID_123"" />
        <xs:element name=""ID_124"" type=""ID_124"" />
        <xs:element name=""ID_125"" type=""ID_125"" />
        <xs:element name=""ID_136"" type=""ID_136"" />
        <xs:element name=""ID_155"" type=""ID_155"" />
        <xs:element name=""ID_156"" type=""ID_156"" />
        <xs:element name=""ID_157"" type=""ID_157"" />
        <xs:element name=""ID_158"" type=""ID_158"" />
        <xs:element name=""ID_159"" type=""ID_159"" />
        <xs:element name=""ID_161"" type=""ID_161"" />
        <xs:element name=""ID_166"" type=""ID_166"" />
        <xs:element name=""ID_167"" type=""ID_167"" />
        <xs:element name=""ID_168"" type=""ID_168"" />
        <xs:element name=""ID_169"" type=""ID_169"" />
        <xs:element name=""ID_170"" type=""ID_170"" />
        <xs:element name=""ID_178"" type=""ID_178"" />
        <xs:element name=""ID_179"" type=""ID_179"" />
        <xs:element name=""ID_180"" type=""ID_180"" />
        <xs:element name=""ID_183"" type=""ID_183"" />
        <xs:element name=""ID_187"" type=""ID_187"" />
        <xs:element name=""ID_190"" type=""ID_190"" />
        <xs:element name=""ID_191"" type=""ID_191"" />
        <xs:element name=""ID_200"" type=""ID_200"" />
        <xs:element name=""ID_201"" type=""ID_201"" />
        <xs:element name=""ID_202"" type=""ID_202"" />
        <xs:element name=""ID_203"" type=""ID_203"" />
        <xs:element name=""ID_205"" type=""ID_205"" />
        <xs:element name=""ID_206"" type=""ID_206"" />
        <xs:element name=""ID_207"" type=""ID_207"" />
        <xs:element name=""ID_208"" type=""ID_208"" />
        <xs:element name=""ID_209"" type=""ID_209"" />
        <xs:element name=""ID_210"" type=""ID_210"" />
        <xs:element name=""ID_211"" type=""ID_211"" />
        <xs:element name=""ID_224"" type=""ID_224"" />
        <xs:element name=""ID_225"" type=""ID_225"" />
        <xs:element name=""ID_234"" type=""ID_234"" />
        <xs:element name=""ID_235"" type=""ID_235"" />
        <xs:element name=""ID_236"" type=""ID_236"" />
        <xs:element name=""ID_237"" type=""ID_237"" />
        <xs:element name=""ID_238"" type=""ID_238"" />
        <xs:element name=""ID_239"" type=""ID_239"" />
        <xs:element name=""ID_240"" type=""ID_240"" />
        <xs:element name=""ID_241"" type=""ID_241"" />
        <xs:element name=""ID_242"" type=""ID_242"" />
        <xs:element name=""ID_243"" type=""ID_243"" />
        <xs:element name=""ID_248"" type=""ID_248"" />
        <xs:element name=""ID_250"" type=""ID_250"" />
        <xs:element name=""ID_251"" type=""ID_251"" />
        <xs:element name=""ID_252"" type=""ID_252"" />
        <xs:element name=""ID_253"" type=""ID_253"" />
        <xs:element name=""ID_267"" type=""ID_267"" />
        <xs:element name=""ID_27"" type=""ID_27"" />
        <xs:element name=""ID_271"" type=""ID_271"" />
        <xs:element name=""ID_272"" type=""ID_272"" />
        <xs:element name=""ID_273"" type=""ID_273"" />
        <xs:element name=""ID_275"" type=""ID_275"" />
        <xs:element name=""ID_287"" type=""ID_287"" />
        <xs:element name=""ID_298"" type=""ID_298"" />
        <xs:element name=""ID_3"" type=""ID_3"" />
        <xs:element name=""ID_301"" type=""ID_301"" />
        <xs:element name=""ID_321"" type=""ID_321"" />
        <xs:element name=""ID_322"" type=""ID_322"" />
        <xs:element name=""ID_323"" type=""ID_323"" />
        <xs:element name=""ID_329"" type=""ID_329"" />
        <xs:element name=""ID_330"" type=""ID_330"" />
        <xs:element name=""ID_331"" type=""ID_331"" />
        <xs:element name=""ID_332"" type=""ID_332"" />
        <xs:element name=""ID_337"" type=""ID_337"" />
        <xs:element name=""ID_354"" type=""ID_354"" />
        <xs:element name=""ID_355"" type=""ID_355"" />
        <xs:element name=""ID_356"" type=""ID_356"" />
        <xs:element name=""ID_359"" type=""ID_359"" />
        <xs:element name=""ID_38"" type=""ID_38"" />
        <xs:element name=""ID_395"" type=""ID_395"" />
        <xs:element name=""ID_397"" type=""ID_397"" />
        <xs:element name=""ID_398"" type=""ID_398"" />
        <xs:element name=""ID_399"" type=""ID_399"" />
        <xs:element name=""ID_418"" type=""ID_418"" />
        <xs:element name=""ID_444"" type=""ID_444"" />
        <xs:element name=""ID_449"" type=""ID_449"" />
        <xs:element name=""ID_465"" type=""ID_465"" />
        <xs:element name=""ID_472"" type=""ID_472"" />
        <xs:element name=""ID_53"" type=""ID_53"" />
        <xs:element name=""ID_61"" type=""ID_61"" />
        <xs:element name=""ID_65"" type=""ID_65"" />
        <xs:element name=""ID_74"" type=""ID_74"" />
        <xs:element name=""ID_76"" type=""ID_76"" />
        <xs:element name=""ID_8"" type=""ID_8"" />
        <xs:element name=""ID_80"" type=""ID_80"" />
        <xs:element name=""ID_85"" type=""ID_85"" />
        <xs:element name=""ID_91"" type=""ID_91"" />
        <xs:element name=""IS"" type=""IS"" />
        <xs:element name=""IS_1"" type=""IS_1"" />
        <xs:element name=""IS_10"" type=""IS_10"" />
        <xs:element name=""IS_110"" type=""IS_110"" />
        <xs:element name=""IS_111"" type=""IS_111"" />
        <xs:element name=""IS_112"" type=""IS_112"" />
        <xs:element name=""IS_114"" type=""IS_114"" />
        <xs:element name=""IS_115"" type=""IS_115"" />
        <xs:element name=""IS_116"" type=""IS_116"" />
        <xs:element name=""IS_117"" type=""IS_117"" />
        <xs:element name=""IS_118"" type=""IS_118"" />
        <xs:element name=""IS_127"" type=""IS_127"" />
        <xs:element name=""IS_128"" type=""IS_128"" />
        <xs:element name=""IS_129"" type=""IS_129"" />
        <xs:element name=""IS_130"" type=""IS_130"" />
        <xs:element name=""IS_132"" type=""IS_132"" />
        <xs:element name=""IS_135"" type=""IS_135"" />
        <xs:element name=""IS_137"" type=""IS_137"" />
        <xs:element name=""IS_139"" type=""IS_139"" />
        <xs:element name=""IS_140"" type=""IS_140"" />
        <xs:element name=""IS_141"" type=""IS_141"" />
        <xs:element name=""IS_142"" type=""IS_142"" />
        <xs:element name=""IS_143"" type=""IS_143"" />
        <xs:element name=""IS_144"" type=""IS_144"" />
        <xs:element name=""IS_145"" type=""IS_145"" />
        <xs:element name=""IS_146"" type=""IS_146"" />
        <xs:element name=""IS_147"" type=""IS_147"" />
        <xs:element name=""IS_148"" type=""IS_148"" />
        <xs:element name=""IS_149"" type=""IS_149"" />
        <xs:element name=""IS_150"" type=""IS_150"" />
        <xs:element name=""IS_151"" type=""IS_151"" />
        <xs:element name=""IS_152"" type=""IS_152"" />
        <xs:element name=""IS_153"" type=""IS_153"" />
        <xs:element name=""IS_17"" type=""IS_17"" />
        <xs:element name=""IS_171"" type=""IS_171"" />
        <xs:element name=""IS_172"" type=""IS_172"" />
        <xs:element name=""IS_173"" type=""IS_173"" />
        <xs:element name=""IS_174"" type=""IS_174"" />
        <xs:element name=""IS_177"" type=""IS_177"" />
        <xs:element name=""IS_18"" type=""IS_18"" />
        <xs:element name=""IS_181"" type=""IS_181"" />
        <xs:element name=""IS_182"" type=""IS_182"" />
        <xs:element name=""IS_184"" type=""IS_184"" />
        <xs:element name=""IS_186"" type=""IS_186"" />
        <xs:element name=""IS_188"" type=""IS_188"" />
        <xs:element name=""IS_189"" type=""IS_189"" />
        <xs:element name=""IS_19"" type=""IS_19"" />
        <xs:element name=""IS_193"" type=""IS_193"" />
        <xs:element name=""IS_2"" type=""IS_2"" />
        <xs:element name=""IS_203"" type=""IS_203"" />
        <xs:element name=""IS_204"" type=""IS_204"" />
        <xs:element name=""IS_21"" type=""IS_21"" />
        <xs:element name=""IS_212"" type=""IS_212"" />
        <xs:element name=""IS_213"" type=""IS_213"" />
        <xs:element name=""IS_214"" type=""IS_214"" />
        <xs:element name=""IS_215"" type=""IS_215"" />
        <xs:element name=""IS_216"" type=""IS_216"" />
        <xs:element name=""IS_217"" type=""IS_217"" />
        <xs:element name=""IS_218"" type=""IS_218"" />
        <xs:element name=""IS_219"" type=""IS_219"" />
        <xs:element name=""IS_22"" type=""IS_22"" />
        <xs:element name=""IS_220"" type=""IS_220"" />
        <xs:element name=""IS_222"" type=""IS_222"" />
        <xs:element name=""IS_223"" type=""IS_223"" />
        <xs:element name=""IS_228"" type=""IS_228"" />
        <xs:element name=""IS_229"" type=""IS_229"" />
        <xs:element name=""IS_23"" type=""IS_23"" />
        <xs:element name=""IS_230"" type=""IS_230"" />
        <xs:element name=""IS_231"" type=""IS_231"" />
        <xs:element name=""IS_232"" type=""IS_232"" />
        <xs:element name=""IS_233"" type=""IS_233"" />
        <xs:element name=""IS_24"" type=""IS_24"" />
        <xs:element name=""IS_244"" type=""IS_244"" />
        <xs:element name=""IS_245"" type=""IS_245"" />
        <xs:element name=""IS_246"" type=""IS_246"" />
        <xs:element name=""IS_249"" type=""IS_249"" />
        <xs:element name=""IS_255"" type=""IS_255"" />
        <xs:element name=""IS_259"" type=""IS_259"" />
        <xs:element name=""IS_260"" type=""IS_260"" />
        <xs:element name=""IS_261"" type=""IS_261"" />
        <xs:element name=""IS_264"" type=""IS_264"" />
        <xs:element name=""IS_265"" type=""IS_265"" />
        <xs:element name=""IS_268"" type=""IS_268"" />
        <xs:element name=""IS_269"" type=""IS_269"" />
        <xs:element name=""IS_270"" type=""IS_270"" />
        <xs:element name=""IS_276"" type=""IS_276"" />
        <xs:element name=""IS_277"" type=""IS_277"" />
        <xs:element name=""IS_278"" type=""IS_278"" />
        <xs:element name=""IS_279"" type=""IS_279"" />
        <xs:element name=""IS_280"" type=""IS_280"" />
        <xs:element name=""IS_281"" type=""IS_281"" />
        <xs:element name=""IS_282"" type=""IS_282"" />
        <xs:element name=""IS_283"" type=""IS_283"" />
        <xs:element name=""IS_284"" type=""IS_284"" />
        <xs:element name=""IS_285"" type=""IS_285"" />
        <xs:element name=""IS_286"" type=""IS_286"" />
        <xs:element name=""IS_288"" type=""IS_288"" />
        <xs:element name=""IS_289"" type=""IS_289"" />
        <xs:element name=""IS_293"" type=""IS_293"" />
        <xs:element name=""IS_294"" type=""IS_294"" />
        <xs:element name=""IS_295"" type=""IS_295"" />
        <xs:element name=""IS_296"" type=""IS_296"" />
        <xs:element name=""IS_297"" type=""IS_297"" />
        <xs:element name=""IS_300"" type=""IS_300"" />
        <xs:element name=""IS_302"" type=""IS_302"" />
        <xs:element name=""IS_303"" type=""IS_303"" />
        <xs:element name=""IS_304"" type=""IS_304"" />
        <xs:element name=""IS_305"" type=""IS_305"" />
        <xs:element name=""IS_306"" type=""IS_306"" />
        <xs:element name=""IS_307"" type=""IS_307"" />
        <xs:element name=""IS_308"" type=""IS_308"" />
        <xs:element name=""IS_309"" type=""IS_309"" />
        <xs:element name=""IS_311"" type=""IS_311"" />
        <xs:element name=""IS_312"" type=""IS_312"" />
        <xs:element name=""IS_313"" type=""IS_313"" />
        <xs:element name=""IS_315"" type=""IS_315"" />
        <xs:element name=""IS_316"" type=""IS_316"" />
        <xs:element name=""IS_319"" type=""IS_319"" />
        <xs:element name=""IS_32"" type=""IS_32"" />
        <xs:element name=""IS_320"" type=""IS_320"" />
        <xs:element name=""IS_324"" type=""IS_324"" />
        <xs:element name=""IS_325"" type=""IS_325"" />
        <xs:element name=""IS_326"" type=""IS_326"" />
        <xs:element name=""IS_327"" type=""IS_327"" />
        <xs:element name=""IS_328"" type=""IS_328"" />
        <xs:element name=""IS_333"" type=""IS_333"" />
        <xs:element name=""IS_334"" type=""IS_334"" />
        <xs:element name=""IS_335"" type=""IS_335"" />
        <xs:element name=""IS_336"" type=""IS_336"" />
        <xs:element name=""IS_338"" type=""IS_338"" />
        <xs:element name=""IS_339"" type=""IS_339"" />
        <xs:element name=""IS_340"" type=""IS_340"" />
        <xs:element name=""IS_341"" type=""IS_341"" />
        <xs:element name=""IS_342"" type=""IS_342"" />
        <xs:element name=""IS_343"" type=""IS_343"" />
        <xs:element name=""IS_344"" type=""IS_344"" />
        <xs:element name=""IS_345"" type=""IS_345"" />
        <xs:element name=""IS_346"" type=""IS_346"" />
        <xs:element name=""IS_347"" type=""IS_347"" />
        <xs:element name=""IS_348"" type=""IS_348"" />
        <xs:element name=""IS_349"" type=""IS_349"" />
        <xs:element name=""IS_350"" type=""IS_350"" />
        <xs:element name=""IS_351"" type=""IS_351"" />
        <xs:element name=""IS_358"" type=""IS_358"" />
        <xs:element name=""IS_360"" type=""IS_360"" />
        <xs:element name=""IS_363"" type=""IS_363"" />
        <xs:element name=""IS_364"" type=""IS_364"" />
        <xs:element name=""IS_378"" type=""IS_378"" />
        <xs:element name=""IS_379"" type=""IS_379"" />
        <xs:element name=""IS_380"" type=""IS_380"" />
        <xs:element name=""IS_381"" type=""IS_381"" />
        <xs:element name=""IS_382"" type=""IS_382"" />
        <xs:element name=""IS_385"" type=""IS_385"" />
        <xs:element name=""IS_386"" type=""IS_386"" />
        <xs:element name=""IS_392"" type=""IS_392"" />
        <xs:element name=""IS_393"" type=""IS_393"" />
        <xs:element name=""IS_396"" type=""IS_396"" />
        <xs:element name=""IS_4"" type=""IS_4"" />
        <xs:element name=""IS_401"" type=""IS_401"" />
        <xs:element name=""IS_402"" type=""IS_402"" />
        <xs:element name=""IS_405"" type=""IS_405"" />
        <xs:element name=""IS_406"" type=""IS_406"" />
        <xs:element name=""IS_409"" type=""IS_409"" />
        <xs:element name=""IS_411"" type=""IS_411"" />
        <xs:element name=""IS_412"" type=""IS_412"" />
        <xs:element name=""IS_413"" type=""IS_413"" />
        <xs:element name=""IS_414"" type=""IS_414"" />
        <xs:element name=""IS_415"" type=""IS_415"" />
        <xs:element name=""IS_416"" type=""IS_416"" />
        <xs:element name=""IS_417"" type=""IS_417"" />
        <xs:element name=""IS_42"" type=""IS_42"" />
        <xs:element name=""IS_421"" type=""IS_421"" />
        <xs:element name=""IS_422"" type=""IS_422"" />
        <xs:element name=""IS_423"" type=""IS_423"" />
        <xs:element name=""IS_424"" type=""IS_424"" />
        <xs:element name=""IS_425"" type=""IS_425"" />
        <xs:element name=""IS_426"" type=""IS_426"" />
        <xs:element name=""IS_427"" type=""IS_427"" />
        <xs:element name=""IS_428"" type=""IS_428"" />
        <xs:element name=""IS_429"" type=""IS_429"" />
        <xs:element name=""IS_43"" type=""IS_43"" />
        <xs:element name=""IS_430"" type=""IS_430"" />
        <xs:element name=""IS_431"" type=""IS_431"" />
        <xs:element name=""IS_432"" type=""IS_432"" />
        <xs:element name=""IS_433"" type=""IS_433"" />
        <xs:element name=""IS_434"" type=""IS_434"" />
        <xs:element name=""IS_435"" type=""IS_435"" />
        <xs:element name=""IS_436"" type=""IS_436"" />
        <xs:element name=""IS_437"" type=""IS_437"" />
        <xs:element name=""IS_438"" type=""IS_438"" />
        <xs:element name=""IS_44"" type=""IS_44"" />
        <xs:element name=""IS_441"" type=""IS_441"" />
        <xs:element name=""IS_442"" type=""IS_442"" />
        <xs:element name=""IS_445"" type=""IS_445"" />
        <xs:element name=""IS_446"" type=""IS_446"" />
        <xs:element name=""IS_447"" type=""IS_447"" />
        <xs:element name=""IS_45"" type=""IS_45"" />
        <xs:element name=""IS_451"" type=""IS_451"" />
        <xs:element name=""IS_455"" type=""IS_455"" />
        <xs:element name=""IS_456"" type=""IS_456"" />
        <xs:element name=""IS_457"" type=""IS_457"" />
        <xs:element name=""IS_458"" type=""IS_458"" />
        <xs:element name=""IS_459"" type=""IS_459"" />
        <xs:element name=""IS_46"" type=""IS_46"" />
        <xs:element name=""IS_460"" type=""IS_460"" />
        <xs:element name=""IS_461"" type=""IS_461"" />
        <xs:element name=""IS_462"" type=""IS_462"" />
        <xs:element name=""IS_463"" type=""IS_463"" />
        <xs:element name=""IS_464"" type=""IS_464"" />
        <xs:element name=""IS_466"" type=""IS_466"" />
        <xs:element name=""IS_467"" type=""IS_467"" />
        <xs:element name=""IS_468"" type=""IS_468"" />
        <xs:element name=""IS_469"" type=""IS_469"" />
        <xs:element name=""IS_470"" type=""IS_470"" />
        <xs:element name=""IS_471"" type=""IS_471"" />
        <xs:element name=""IS_473"" type=""IS_473"" />
        <xs:element name=""IS_474"" type=""IS_474"" />
        <xs:element name=""IS_49"" type=""IS_49"" />
        <xs:element name=""IS_5"" type=""IS_5"" />
        <xs:element name=""IS_50"" type=""IS_50"" />
        <xs:element name=""IS_51"" type=""IS_51"" />
        <xs:element name=""IS_52"" type=""IS_52"" />
        <xs:element name=""IS_55"" type=""IS_55"" />
        <xs:element name=""IS_56"" type=""IS_56"" />
        <xs:element name=""IS_59"" type=""IS_59"" />
        <xs:element name=""IS_6"" type=""IS_6"" />
        <xs:element name=""IS_62"" type=""IS_62"" />
        <xs:element name=""IS_63"" type=""IS_63"" />
        <xs:element name=""IS_64"" type=""IS_64"" />
        <xs:element name=""IS_66"" type=""IS_66"" />
        <xs:element name=""IS_68"" type=""IS_68"" />
        <xs:element name=""IS_69"" type=""IS_69"" />
        <xs:element name=""IS_7"" type=""IS_7"" />
        <xs:element name=""IS_72"" type=""IS_72"" />
        <xs:element name=""IS_73"" type=""IS_73"" />
        <xs:element name=""IS_78"" type=""IS_78"" />
        <xs:element name=""IS_83"" type=""IS_83"" />
        <xs:element name=""IS_84"" type=""IS_84"" />
        <xs:element name=""IS_86"" type=""IS_86"" />
        <xs:element name=""IS_87"" type=""IS_87"" />
        <xs:element name=""IS_88"" type=""IS_88"" />
        <xs:element name=""IS_89"" type=""IS_89"" />
        <xs:element name=""IS_9"" type=""IS_9"" />
        <xs:element name=""IS_92"" type=""IS_92"" />
        <xs:element name=""IS_93"" type=""IS_93"" />
        <xs:element name=""IS_98"" type=""IS_98"" />
        <xs:element name=""IS_99"" type=""IS_99"" />
        <xs:element name=""JCC_327"" type=""JCC_327"" />
        <xs:element name=""LA1"" type=""LA1"" />
        <xs:element name=""LA2"" type=""LA2"" />
        <xs:element name=""MO"" type=""MO"" />
        <xs:element name=""MOC"" type=""MOC"" />
        <xs:element name=""MOP_148"" type=""MOP_148"" />
        <xs:element name=""MSG_76"" type=""MSG_76"" />
        <xs:element name=""NA"" type=""NA"" />
        <xs:element name=""NDL"" type=""NDL"" />
        <xs:element name=""NM"" type=""NM"" />
        <xs:element name=""NR"" type=""NR"" />
        <xs:element name=""OCD_350"" type=""OCD_350"" />
        <xs:element name=""OSP_351"" type=""OSP_351"" />
        <xs:element name=""PCF_150"" type=""PCF_150"" />
        <xs:element name=""PI"" type=""PI"" />
        <xs:element name=""PIP"" type=""PIP"" />
        <xs:element name=""PL"" type=""PL"" />
        <xs:element name=""PLN_338"" type=""PLN_338"" />
        <xs:element name=""PPN"" type=""PPN"" />
        <xs:element name=""PRL"" type=""PRL"" />
        <xs:element name=""PT"" type=""PT"" />
        <xs:element name=""PTA_147"" type=""PTA_147"" />
        <xs:element name=""QIP"" type=""QIP"" />
        <xs:element name=""QSC"" type=""QSC"" />
        <xs:element name=""RCD_440"" type=""RCD_440"" />
        <xs:element name=""RFR"" type=""RFR"" />
        <xs:element name=""RI"" type=""RI"" />
        <xs:element name=""RMC_145"" type=""RMC_145"" />
        <xs:element name=""SCV"" type=""SCV"" />
        <xs:element name=""SCV_294"" type=""SCV_294"" />
        <xs:element name=""SI"" type=""SI"" />
        <xs:element name=""SN"" type=""SN"" />
        <xs:element name=""SPD_337"" type=""SPD_337"" />
        <xs:element name=""SPS_70"" type=""SPS_70"" />
        <xs:element name=""SRT"" type=""SRT"" />
        <xs:element name=""ST"" type=""ST"" />
        <xs:element name=""ST_114"" type=""ST_114"" />
        <xs:element name=""ST_118"" type=""ST_118"" />
        <xs:element name=""ST_127"" type=""ST_127"" />
        <xs:element name=""ST_128"" type=""ST_128"" />
        <xs:element name=""ST_129"" type=""ST_129"" />
        <xs:element name=""ST_131"" type=""ST_131"" />
        <xs:element name=""ST_132"" type=""ST_132"" />
        <xs:element name=""ST_136"" type=""ST_136"" />
        <xs:element name=""ST_160"" type=""ST_160"" />
        <xs:element name=""ST_162"" type=""ST_162"" />
        <xs:element name=""ST_163"" type=""ST_163"" />
        <xs:element name=""ST_164"" type=""ST_164"" />
        <xs:element name=""ST_165"" type=""ST_165"" />
        <xs:element name=""ST_171"" type=""ST_171"" />
        <xs:element name=""ST_172"" type=""ST_172"" />
        <xs:element name=""ST_175"" type=""ST_175"" />
        <xs:element name=""ST_181"" type=""ST_181"" />
        <xs:element name=""ST_184"" type=""ST_184"" />
        <xs:element name=""ST_185"" type=""ST_185"" />
        <xs:element name=""ST_189"" type=""ST_189"" />
        <xs:element name=""ST_2"" type=""ST_2"" />
        <xs:element name=""ST_212"" type=""ST_212"" />
        <xs:element name=""ST_215"" type=""ST_215"" />
        <xs:element name=""ST_218"" type=""ST_218"" />
        <xs:element name=""ST_222"" type=""ST_222"" />
        <xs:element name=""ST_227"" type=""ST_227"" />
        <xs:element name=""ST_233"" type=""ST_233"" />
        <xs:element name=""ST_247"" type=""ST_247"" />
        <xs:element name=""ST_254"" type=""ST_254"" />
        <xs:element name=""ST_255"" type=""ST_255"" />
        <xs:element name=""ST_258"" type=""ST_258"" />
        <xs:element name=""ST_259"" type=""ST_259"" />
        <xs:element name=""ST_264"" type=""ST_264"" />
        <xs:element name=""ST_265"" type=""ST_265"" />
        <xs:element name=""ST_276"" type=""ST_276"" />
        <xs:element name=""ST_277"" type=""ST_277"" />
        <xs:element name=""ST_278"" type=""ST_278"" />
        <xs:element name=""ST_280"" type=""ST_280"" />
        <xs:element name=""ST_281"" type=""ST_281"" />
        <xs:element name=""ST_282"" type=""ST_282"" />
        <xs:element name=""ST_283"" type=""ST_283"" />
        <xs:element name=""ST_284"" type=""ST_284"" />
        <xs:element name=""ST_285"" type=""ST_285"" />
        <xs:element name=""ST_286"" type=""ST_286"" />
        <xs:element name=""ST_292"" type=""ST_292"" />
        <xs:element name=""ST_293"" type=""ST_293"" />
        <xs:element name=""ST_294"" type=""ST_294"" />
        <xs:element name=""ST_296"" type=""ST_296"" />
        <xs:element name=""ST_324"" type=""ST_324"" />
        <xs:element name=""ST_325"" type=""ST_325"" />
        <xs:element name=""ST_336"" type=""ST_336"" />
        <xs:element name=""ST_339"" type=""ST_339"" />
        <xs:element name=""ST_340"" type=""ST_340"" />
        <xs:element name=""ST_341"" type=""ST_341"" />
        <xs:element name=""ST_342"" type=""ST_342"" />
        <xs:element name=""ST_343"" type=""ST_343"" />
        <xs:element name=""ST_344"" type=""ST_344"" />
        <xs:element name=""ST_345"" type=""ST_345"" />
        <xs:element name=""ST_346"" type=""ST_346"" />
        <xs:element name=""ST_347"" type=""ST_347"" />
        <xs:element name=""ST_348"" type=""ST_348"" />
        <xs:element name=""ST_349"" type=""ST_349"" />
        <xs:element name=""ST_351"" type=""ST_351"" />
        <xs:element name=""ST_357"" type=""ST_357"" />
        <xs:element name=""ST_358"" type=""ST_358"" />
        <xs:element name=""ST_364"" type=""ST_364"" />
        <xs:element name=""ST_365"" type=""ST_365"" />
        <xs:element name=""ST_366"" type=""ST_366"" />
        <xs:element name=""ST_367"" type=""ST_367"" />
        <xs:element name=""ST_368"" type=""ST_368"" />
        <xs:element name=""ST_369"" type=""ST_369"" />
        <xs:element name=""ST_370"" type=""ST_370"" />
        <xs:element name=""ST_371"" type=""ST_371"" />
        <xs:element name=""ST_373"" type=""ST_373"" />
        <xs:element name=""ST_374"" type=""ST_374"" />
        <xs:element name=""ST_375"" type=""ST_375"" />
        <xs:element name=""ST_376"" type=""ST_376"" />
        <xs:element name=""ST_377"" type=""ST_377"" />
        <xs:element name=""ST_378"" type=""ST_378"" />
        <xs:element name=""ST_379"" type=""ST_379"" />
        <xs:element name=""ST_380"" type=""ST_380"" />
        <xs:element name=""ST_381"" type=""ST_381"" />
        <xs:element name=""ST_382"" type=""ST_382"" />
        <xs:element name=""ST_383"" type=""ST_383"" />
        <xs:element name=""ST_384"" type=""ST_384"" />
        <xs:element name=""ST_385"" type=""ST_385"" />
        <xs:element name=""ST_386"" type=""ST_386"" />
        <xs:element name=""ST_387"" type=""ST_387"" />
        <xs:element name=""ST_388"" type=""ST_388"" />
        <xs:element name=""ST_389"" type=""ST_389"" />
        <xs:element name=""ST_393"" type=""ST_393"" />
        <xs:element name=""ST_394"" type=""ST_394"" />
        <xs:element name=""ST_401"" type=""ST_401"" />
        <xs:element name=""ST_402"" type=""ST_402"" />
        <xs:element name=""ST_403"" type=""ST_403"" />
        <xs:element name=""ST_404"" type=""ST_404"" />
        <xs:element name=""ST_405"" type=""ST_405"" />
        <xs:element name=""ST_406"" type=""ST_406"" />
        <xs:element name=""ST_411"" type=""ST_411"" />
        <xs:element name=""ST_412"" type=""ST_412"" />
        <xs:element name=""ST_413"" type=""ST_413"" />
        <xs:element name=""ST_414"" type=""ST_414"" />
        <xs:element name=""ST_417"" type=""ST_417"" />
        <xs:element name=""ST_421"" type=""ST_421"" />
        <xs:element name=""ST_422"" type=""ST_422"" />
        <xs:element name=""ST_423"" type=""ST_423"" />
        <xs:element name=""ST_424"" type=""ST_424"" />
        <xs:element name=""ST_425"" type=""ST_425"" />
        <xs:element name=""ST_426"" type=""ST_426"" />
        <xs:element name=""ST_427"" type=""ST_427"" />
        <xs:element name=""ST_428"" type=""ST_428"" />
        <xs:element name=""ST_429"" type=""ST_429"" />
        <xs:element name=""ST_430"" type=""ST_430"" />
        <xs:element name=""ST_431"" type=""ST_431"" />
        <xs:element name=""ST_432"" type=""ST_432"" />
        <xs:element name=""ST_433"" type=""ST_433"" />
        <xs:element name=""ST_434"" type=""ST_434"" />
        <xs:element name=""ST_435"" type=""ST_435"" />
        <xs:element name=""ST_436"" type=""ST_436"" />
        <xs:element name=""ST_437"" type=""ST_437"" />
        <xs:element name=""ST_438"" type=""ST_438"" />
        <xs:element name=""ST_440"" type=""ST_440"" />
        <xs:element name=""ST_443"" type=""ST_443"" />
        <xs:element name=""ST_446"" type=""ST_446"" />
        <xs:element name=""ST_447"" type=""ST_447"" />
        <xs:element name=""ST_450"" type=""ST_450"" />
        <xs:element name=""ST_451"" type=""ST_451"" />
        <xs:element name=""ST_452"" type=""ST_452"" />
        <xs:element name=""ST_453"" type=""ST_453"" />
        <xs:element name=""ST_454"" type=""ST_454"" />
        <xs:element name=""ST_461"" type=""ST_461"" />
        <xs:element name=""ST_462"" type=""ST_462"" />
        <xs:element name=""ST_463"" type=""ST_463"" />
        <xs:element name=""ST_464"" type=""ST_464"" />
        <xs:element name=""ST_466"" type=""ST_466"" />
        <xs:element name=""ST_471"" type=""ST_471"" />
        <xs:element name=""ST_474"" type=""ST_474"" />
        <xs:element name=""ST_48"" type=""ST_48"" />
        <xs:element name=""ST_49"" type=""ST_49"" />
        <xs:element name=""ST_5"" type=""ST_5"" />
        <xs:element name=""ST_50"" type=""ST_50"" />
        <xs:element name=""ST_51"" type=""ST_51"" />
        <xs:element name=""ST_55"" type=""ST_55"" />
        <xs:element name=""ST_59"" type=""ST_59"" />
        <xs:element name=""ST_6"" type=""ST_6"" />
        <xs:element name=""ST_63"" type=""ST_63"" />
        <xs:element name=""ST_66"" type=""ST_66"" />
        <xs:element name=""ST_69"" type=""ST_69"" />
        <xs:element name=""ST_70"" type=""ST_70"" />
        <xs:element name=""ST_72"" type=""ST_72"" />
        <xs:element name=""ST_83"" type=""ST_83"" />
        <xs:element name=""ST_88"" type=""ST_88"" />
        <xs:element name=""TM"" type=""TM"" />
        <xs:element name=""TN"" type=""TN"" />
        <xs:element name=""TQ"" type=""TQ"" />
        <xs:element name=""TS"" type=""TS"" />
        <xs:element name=""TS_0"" type=""TS_0"" />
        <xs:element name=""TS_1"" type=""TS_1"" />
        <xs:element name=""TX"" type=""TX"" />
        <xs:element name=""TX_256"" type=""TX_256"" />
        <xs:element name=""UVC_153"" type=""UVC_153"" />
        <xs:element name=""varies"" type=""varies"" />
        <xs:element name=""VH_267"" type=""VH_267"" />
        <xs:element name=""VID_104"" type=""VID_104"" />
        <xs:element name=""VR"" type=""VR"" />
        <xs:element name=""XAD"" type=""XAD"" />
        <xs:element name=""XCN"" type=""XCN"" />
        <xs:element name=""XCN_10"" type=""XCN_10"" />
        <xs:element name=""XCN_188"" type=""XCN_188"" />
        <xs:element name=""XCN_84"" type=""XCN_84"" />
        <xs:element name=""XON"" type=""XON"" />
        <xs:element name=""XPN"" type=""XPN"" />
        <xs:element name=""XTN"" type=""XTN"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:complexType name=""AUI"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""AUI_0_AuthorizationNumber"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""AUI_1_Date"" type=""DT"" />
      <xs:element minOccurs=""0"" name=""AUI_2_Source"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CCD_100"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CCD_0_WhenToChargeCode"" type=""ID_100"" />
      <xs:element minOccurs=""0"" name=""CCD_1_DateTime"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CCD_1_0_TimeOfAnEvent"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""CCD_1_1_DegreeOfPrecision"" type=""ST"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_IdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_9999"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0_IdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0002_2"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0002_0_IdentifierSt"" type=""ST_2"" />
      <xs:element minOccurs=""0"" name=""CE_0002_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0002_2_NameOfCodingSystem"" type=""IS_2"" />
      <xs:element minOccurs=""0"" name=""CE_0002_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0002_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0002_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0005_5"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0005_0_IdentifierSt"" type=""ST_5"" />
      <xs:element minOccurs=""0"" name=""CE_0005_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0005_2_NameOfCodingSystem"" type=""IS_5"" />
      <xs:element minOccurs=""0"" name=""CE_0005_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0005_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0005_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0006_6"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0006_0_IdentifierSt"" type=""ST_6"" />
      <xs:element minOccurs=""0"" name=""CE_0006_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0006_2_NameOfCodingSystem"" type=""IS_6"" />
      <xs:element minOccurs=""0"" name=""CE_0006_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0006_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0006_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0048_48"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0048_0_IdentifierSt"" type=""ST_48"" />
      <xs:element minOccurs=""0"" name=""CE_0048_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0048_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0048_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0048_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0048_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0049_49"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0049_0_IdentifierSt"" type=""ST_49"" />
      <xs:element minOccurs=""0"" name=""CE_0049_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0049_2_NameOfCodingSystem"" type=""IS_49"" />
      <xs:element minOccurs=""0"" name=""CE_0049_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0049_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0049_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0050_50"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0050_0_IdentifierSt"" type=""ST_50"" />
      <xs:element minOccurs=""0"" name=""CE_0050_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0050_2_NameOfCodingSystem"" type=""IS_50"" />
      <xs:element minOccurs=""0"" name=""CE_0050_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0050_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0050_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0051_51"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0051_0_IdentifierSt"" type=""ST_51"" />
      <xs:element minOccurs=""0"" name=""CE_0051_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0051_2_NameOfCodingSystem"" type=""IS_51"" />
      <xs:element minOccurs=""0"" name=""CE_0051_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0051_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0051_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0055_55"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0055_0_IdentifierSt"" type=""ST_55"" />
      <xs:element minOccurs=""0"" name=""CE_0055_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0055_2_NameOfCodingSystem"" type=""IS_55"" />
      <xs:element minOccurs=""0"" name=""CE_0055_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0055_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0055_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0059_59"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0059_0_IdentifierSt"" type=""ST_59"" />
      <xs:element minOccurs=""0"" name=""CE_0059_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0059_2_NameOfCodingSystem"" type=""IS_59"" />
      <xs:element minOccurs=""0"" name=""CE_0059_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0059_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0059_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0063_63"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0063_0_IdentifierSt"" type=""ST_63"" />
      <xs:element minOccurs=""0"" name=""CE_0063_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0063_2_NameOfCodingSystem"" type=""IS_63"" />
      <xs:element minOccurs=""0"" name=""CE_0063_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0063_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0063_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0066_66"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0066_0_IdentifierSt"" type=""ST_66"" />
      <xs:element minOccurs=""0"" name=""CE_0066_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0066_2_NameOfCodingSystem"" type=""IS_66"" />
      <xs:element minOccurs=""0"" name=""CE_0066_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0066_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0066_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0069_69"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0069_0_IdentifierSt"" type=""ST_69"" />
      <xs:element minOccurs=""0"" name=""CE_0069_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0069_2_NameOfCodingSystem"" type=""IS_69"" />
      <xs:element minOccurs=""0"" name=""CE_0069_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0069_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0069_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0072_72"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0072_0_IdentifierSt"" type=""ST_72"" />
      <xs:element minOccurs=""0"" name=""CE_0072_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0072_2_NameOfCodingSystem"" type=""IS_72"" />
      <xs:element minOccurs=""0"" name=""CE_0072_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0072_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0072_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0083_83"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0083_0_IdentifierSt"" type=""ST_83"" />
      <xs:element minOccurs=""0"" name=""CE_0083_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0083_2_NameOfCodingSystem"" type=""IS_83"" />
      <xs:element minOccurs=""0"" name=""CE_0083_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0083_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0083_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0088_88"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0088_0_IdentifierSt"" type=""ST_88"" />
      <xs:element minOccurs=""0"" name=""CE_0088_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0088_2_NameOfCodingSystem"" type=""IS_88"" />
      <xs:element minOccurs=""0"" name=""CE_0088_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0088_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0088_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0114_114"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0114_0_IdentifierSt"" type=""ST_114"" />
      <xs:element minOccurs=""0"" name=""CE_0114_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0114_2_NameOfCodingSystem"" type=""IS_114"" />
      <xs:element minOccurs=""0"" name=""CE_0114_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0114_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0114_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0118_118"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0118_0_IdentifierSt"" type=""ST_118"" />
      <xs:element minOccurs=""0"" name=""CE_0118_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0118_2_NameOfCodingSystem"" type=""IS_118"" />
      <xs:element minOccurs=""0"" name=""CE_0118_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0118_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0118_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0127_127"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0127_0_IdentifierSt"" type=""ST_127"" />
      <xs:element minOccurs=""0"" name=""CE_0127_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0127_2_NameOfCodingSystem"" type=""IS_127"" />
      <xs:element minOccurs=""0"" name=""CE_0127_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0127_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0127_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0128_128"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0128_0_IdentifierSt"" type=""ST_128"" />
      <xs:element minOccurs=""0"" name=""CE_0128_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0128_2_NameOfCodingSystem"" type=""IS_128"" />
      <xs:element minOccurs=""0"" name=""CE_0128_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0128_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0128_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0129_129"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0129_0_IdentifierSt"" type=""ST_129"" />
      <xs:element minOccurs=""0"" name=""CE_0129_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0129_2_NameOfCodingSystem"" type=""IS_129"" />
      <xs:element minOccurs=""0"" name=""CE_0129_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0129_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0129_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0131_131"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0131_0_IdentifierSt"" type=""ST_131"" />
      <xs:element minOccurs=""0"" name=""CE_0131_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0131_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0131_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0131_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0131_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0132_132"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0132_0_IdentifierSt"" type=""ST_132"" />
      <xs:element minOccurs=""0"" name=""CE_0132_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0132_2_NameOfCodingSystem"" type=""IS_132"" />
      <xs:element minOccurs=""0"" name=""CE_0132_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0132_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0132_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0136_136"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0136_0_IdentifierSt"" type=""ST_136"" />
      <xs:element minOccurs=""0"" name=""CE_0136_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0136_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0136_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0136_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0136_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0160_160"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0160_0_IdentifierSt"" type=""ST_160"" />
      <xs:element minOccurs=""0"" name=""CE_0160_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0160_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0160_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0160_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0160_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0162_162"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0162_0_IdentifierSt"" type=""ST_162"" />
      <xs:element minOccurs=""0"" name=""CE_0162_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0162_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0162_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0162_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0162_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0163_163"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0163_0_IdentifierSt"" type=""ST_163"" />
      <xs:element minOccurs=""0"" name=""CE_0163_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0163_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0163_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0163_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0163_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0164_164"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0164_0_IdentifierSt"" type=""ST_164"" />
      <xs:element minOccurs=""0"" name=""CE_0164_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0164_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0164_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0164_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0164_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0165_165"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0165_0_IdentifierSt"" type=""ST_165"" />
      <xs:element minOccurs=""0"" name=""CE_0165_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0165_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0165_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0165_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0165_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0171_171"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0171_0_IdentifierSt"" type=""ST_171"" />
      <xs:element minOccurs=""0"" name=""CE_0171_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0171_2_NameOfCodingSystem"" type=""IS_171"" />
      <xs:element minOccurs=""0"" name=""CE_0171_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0171_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0171_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0172_172"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0172_0_IdentifierSt"" type=""ST_172"" />
      <xs:element minOccurs=""0"" name=""CE_0172_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0172_2_NameOfCodingSystem"" type=""IS_172"" />
      <xs:element minOccurs=""0"" name=""CE_0172_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0172_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0172_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0175_175"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0175_0_IdentifierSt"" type=""ST_175"" />
      <xs:element minOccurs=""0"" name=""CE_0175_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0175_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0175_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0175_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0175_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0181_181"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0181_0_IdentifierSt"" type=""ST_181"" />
      <xs:element minOccurs=""0"" name=""CE_0181_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0181_2_NameOfCodingSystem"" type=""IS_181"" />
      <xs:element minOccurs=""0"" name=""CE_0181_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0181_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0181_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0184_184"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0184_0_IdentifierSt"" type=""ST_184"" />
      <xs:element minOccurs=""0"" name=""CE_0184_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0184_2_NameOfCodingSystem"" type=""IS_184"" />
      <xs:element minOccurs=""0"" name=""CE_0184_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0184_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0184_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0185_185"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0185_0_IdentifierSt"" type=""ST_185"" />
      <xs:element minOccurs=""0"" name=""CE_0185_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0185_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0185_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0185_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0185_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0189_189"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0189_0_IdentifierSt"" type=""ST_189"" />
      <xs:element minOccurs=""0"" name=""CE_0189_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0189_2_NameOfCodingSystem"" type=""IS_189"" />
      <xs:element minOccurs=""0"" name=""CE_0189_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0189_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0189_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0212_212"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0212_0_IdentifierSt"" type=""ST_212"" />
      <xs:element minOccurs=""0"" name=""CE_0212_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0212_2_NameOfCodingSystem"" type=""IS_212"" />
      <xs:element minOccurs=""0"" name=""CE_0212_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0212_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0212_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0215_215"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0215_0_IdentifierSt"" type=""ST_215"" />
      <xs:element minOccurs=""0"" name=""CE_0215_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0215_2_NameOfCodingSystem"" type=""IS_215"" />
      <xs:element minOccurs=""0"" name=""CE_0215_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0215_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0215_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0218_218"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0218_0_IdentifierSt"" type=""ST_218"" />
      <xs:element minOccurs=""0"" name=""CE_0218_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0218_2_NameOfCodingSystem"" type=""IS_218"" />
      <xs:element minOccurs=""0"" name=""CE_0218_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0218_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0218_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0222_222"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0222_0_IdentifierSt"" type=""ST_222"" />
      <xs:element minOccurs=""0"" name=""CE_0222_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0222_2_NameOfCodingSystem"" type=""IS_222"" />
      <xs:element minOccurs=""0"" name=""CE_0222_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0222_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0222_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0227_227"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0227_0_IdentifierSt"" type=""ST_227"" />
      <xs:element minOccurs=""0"" name=""CE_0227_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0227_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0227_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0227_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0227_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0233_233"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0233_0_IdentifierSt"" type=""ST_233"" />
      <xs:element minOccurs=""0"" name=""CE_0233_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0233_2_NameOfCodingSystem"" type=""IS_233"" />
      <xs:element minOccurs=""0"" name=""CE_0233_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0233_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0233_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0247_247"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0247_0_IdentifierSt"" type=""ST_247"" />
      <xs:element minOccurs=""0"" name=""CE_0247_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0247_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0247_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0247_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0247_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0254_254"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0254_0_IdentifierSt"" type=""ST_254"" />
      <xs:element minOccurs=""0"" name=""CE_0254_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0254_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0254_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0254_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0254_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0255_255"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0255_0_IdentifierSt"" type=""ST_255"" />
      <xs:element minOccurs=""0"" name=""CE_0255_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0255_2_NameOfCodingSystem"" type=""IS_255"" />
      <xs:element minOccurs=""0"" name=""CE_0255_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0255_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0255_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0258_258"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0258_0_IdentifierSt"" type=""ST_258"" />
      <xs:element minOccurs=""0"" name=""CE_0258_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0258_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0258_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0258_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0258_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0259_259"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0259_0_IdentifierSt"" type=""ST_259"" />
      <xs:element minOccurs=""0"" name=""CE_0259_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0259_2_NameOfCodingSystem"" type=""IS_259"" />
      <xs:element minOccurs=""0"" name=""CE_0259_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0259_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0259_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0264_264"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0264_0_IdentifierSt"" type=""ST_264"" />
      <xs:element minOccurs=""0"" name=""CE_0264_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0264_2_NameOfCodingSystem"" type=""IS_264"" />
      <xs:element minOccurs=""0"" name=""CE_0264_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0264_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0264_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0265_265"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0265_0_IdentifierSt"" type=""ST_265"" />
      <xs:element minOccurs=""0"" name=""CE_0265_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0265_2_NameOfCodingSystem"" type=""IS_265"" />
      <xs:element minOccurs=""0"" name=""CE_0265_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0265_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0265_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0276_276"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0276_0_IdentifierSt"" type=""ST_276"" />
      <xs:element minOccurs=""0"" name=""CE_0276_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0276_2_NameOfCodingSystem"" type=""IS_276"" />
      <xs:element minOccurs=""0"" name=""CE_0276_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0276_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0276_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0277_277"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0277_0_IdentifierSt"" type=""ST_277"" />
      <xs:element minOccurs=""0"" name=""CE_0277_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0277_2_NameOfCodingSystem"" type=""IS_277"" />
      <xs:element minOccurs=""0"" name=""CE_0277_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0277_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0277_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0278_278"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0278_0_IdentifierSt"" type=""ST_278"" />
      <xs:element minOccurs=""0"" name=""CE_0278_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0278_2_NameOfCodingSystem"" type=""IS_278"" />
      <xs:element minOccurs=""0"" name=""CE_0278_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0278_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0278_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0280_280"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0280_0_IdentifierSt"" type=""ST_280"" />
      <xs:element minOccurs=""0"" name=""CE_0280_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0280_2_NameOfCodingSystem"" type=""IS_280"" />
      <xs:element minOccurs=""0"" name=""CE_0280_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0280_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0280_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0281_281"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0281_0_IdentifierSt"" type=""ST_281"" />
      <xs:element minOccurs=""0"" name=""CE_0281_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0281_2_NameOfCodingSystem"" type=""IS_281"" />
      <xs:element minOccurs=""0"" name=""CE_0281_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0281_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0281_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0282_282"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0282_0_IdentifierSt"" type=""ST_282"" />
      <xs:element minOccurs=""0"" name=""CE_0282_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0282_2_NameOfCodingSystem"" type=""IS_282"" />
      <xs:element minOccurs=""0"" name=""CE_0282_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0282_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0282_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0283_283"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0283_0_IdentifierSt"" type=""ST_283"" />
      <xs:element minOccurs=""0"" name=""CE_0283_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0283_2_NameOfCodingSystem"" type=""IS_283"" />
      <xs:element minOccurs=""0"" name=""CE_0283_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0283_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0283_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0284_284"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0284_0_IdentifierSt"" type=""ST_284"" />
      <xs:element minOccurs=""0"" name=""CE_0284_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0284_2_NameOfCodingSystem"" type=""IS_284"" />
      <xs:element minOccurs=""0"" name=""CE_0284_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0284_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0284_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0285_285"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0285_0_IdentifierSt"" type=""ST_285"" />
      <xs:element minOccurs=""0"" name=""CE_0285_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0285_2_NameOfCodingSystem"" type=""IS_285"" />
      <xs:element minOccurs=""0"" name=""CE_0285_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0285_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0285_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0286_286"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0286_0_IdentifierSt"" type=""ST_286"" />
      <xs:element minOccurs=""0"" name=""CE_0286_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0286_2_NameOfCodingSystem"" type=""IS_286"" />
      <xs:element minOccurs=""0"" name=""CE_0286_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0286_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0286_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0292_292"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0292_0_IdentifierSt"" type=""ST_292"" />
      <xs:element minOccurs=""0"" name=""CE_0292_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0292_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0292_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0292_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0292_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0293_293"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0293_0_IdentifierSt"" type=""ST_293"" />
      <xs:element minOccurs=""0"" name=""CE_0293_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0293_2_NameOfCodingSystem"" type=""IS_293"" />
      <xs:element minOccurs=""0"" name=""CE_0293_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0293_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0293_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0296_296"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0296_0_IdentifierSt"" type=""ST_296"" />
      <xs:element minOccurs=""0"" name=""CE_0296_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0296_2_NameOfCodingSystem"" type=""IS_296"" />
      <xs:element minOccurs=""0"" name=""CE_0296_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0296_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0296_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0324_324"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0324_0_IdentifierSt"" type=""ST_324"" />
      <xs:element minOccurs=""0"" name=""CE_0324_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0324_2_NameOfCodingSystem"" type=""IS_324"" />
      <xs:element minOccurs=""0"" name=""CE_0324_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0324_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0324_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0325_325"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0325_0_IdentifierSt"" type=""ST_325"" />
      <xs:element minOccurs=""0"" name=""CE_0325_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0325_2_NameOfCodingSystem"" type=""IS_325"" />
      <xs:element minOccurs=""0"" name=""CE_0325_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0325_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0325_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0336_336"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0336_0_IdentifierSt"" type=""ST_336"" />
      <xs:element minOccurs=""0"" name=""CE_0336_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0336_2_NameOfCodingSystem"" type=""IS_336"" />
      <xs:element minOccurs=""0"" name=""CE_0336_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0336_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0336_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0339_339"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0339_0_IdentifierSt"" type=""ST_339"" />
      <xs:element minOccurs=""0"" name=""CE_0339_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0339_2_NameOfCodingSystem"" type=""IS_339"" />
      <xs:element minOccurs=""0"" name=""CE_0339_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0339_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0339_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0340_340"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0340_0_IdentifierSt"" type=""ST_340"" />
      <xs:element minOccurs=""0"" name=""CE_0340_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0340_2_NameOfCodingSystem"" type=""IS_340"" />
      <xs:element minOccurs=""0"" name=""CE_0340_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0340_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0340_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0341_341"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0341_0_IdentifierSt"" type=""ST_341"" />
      <xs:element minOccurs=""0"" name=""CE_0341_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0341_2_NameOfCodingSystem"" type=""IS_341"" />
      <xs:element minOccurs=""0"" name=""CE_0341_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0341_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0341_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0342_342"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0342_0_IdentifierSt"" type=""ST_342"" />
      <xs:element minOccurs=""0"" name=""CE_0342_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0342_2_NameOfCodingSystem"" type=""IS_342"" />
      <xs:element minOccurs=""0"" name=""CE_0342_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0342_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0342_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0343_343"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0343_0_IdentifierSt"" type=""ST_343"" />
      <xs:element minOccurs=""0"" name=""CE_0343_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0343_2_NameOfCodingSystem"" type=""IS_343"" />
      <xs:element minOccurs=""0"" name=""CE_0343_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0343_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0343_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0344_344"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0344_0_IdentifierSt"" type=""ST_344"" />
      <xs:element minOccurs=""0"" name=""CE_0344_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0344_2_NameOfCodingSystem"" type=""IS_344"" />
      <xs:element minOccurs=""0"" name=""CE_0344_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0344_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0344_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0345_345"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0345_0_IdentifierSt"" type=""ST_345"" />
      <xs:element minOccurs=""0"" name=""CE_0345_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0345_2_NameOfCodingSystem"" type=""IS_345"" />
      <xs:element minOccurs=""0"" name=""CE_0345_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0345_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0345_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0346_346"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0346_0_IdentifierSt"" type=""ST_346"" />
      <xs:element minOccurs=""0"" name=""CE_0346_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0346_2_NameOfCodingSystem"" type=""IS_346"" />
      <xs:element minOccurs=""0"" name=""CE_0346_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0346_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0346_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0347_347"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0347_0_IdentifierSt"" type=""ST_347"" />
      <xs:element minOccurs=""0"" name=""CE_0347_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0347_2_NameOfCodingSystem"" type=""IS_347"" />
      <xs:element minOccurs=""0"" name=""CE_0347_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0347_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0347_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0348_348"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0348_0_IdentifierSt"" type=""ST_348"" />
      <xs:element minOccurs=""0"" name=""CE_0348_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0348_2_NameOfCodingSystem"" type=""IS_348"" />
      <xs:element minOccurs=""0"" name=""CE_0348_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0348_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0348_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0349_349"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0349_0_IdentifierSt"" type=""ST_349"" />
      <xs:element minOccurs=""0"" name=""CE_0349_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0349_2_NameOfCodingSystem"" type=""IS_349"" />
      <xs:element minOccurs=""0"" name=""CE_0349_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0349_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0349_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0351_351"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0351_0_IdentifierSt"" type=""ST_351"" />
      <xs:element minOccurs=""0"" name=""CE_0351_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0351_2_NameOfCodingSystem"" type=""IS_351"" />
      <xs:element minOccurs=""0"" name=""CE_0351_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0351_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0351_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0357_357"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0357_0_IdentifierSt"" type=""ST_357"" />
      <xs:element minOccurs=""0"" name=""CE_0357_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0357_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0357_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0357_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0357_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0358_358"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0358_0_IdentifierSt"" type=""ST_358"" />
      <xs:element minOccurs=""0"" name=""CE_0358_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0358_2_NameOfCodingSystem"" type=""IS_358"" />
      <xs:element minOccurs=""0"" name=""CE_0358_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0358_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0358_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0364_364"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0364_0_IdentifierSt"" type=""ST_364"" />
      <xs:element minOccurs=""0"" name=""CE_0364_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0364_2_NameOfCodingSystem"" type=""IS_364"" />
      <xs:element minOccurs=""0"" name=""CE_0364_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0364_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0364_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0365_365"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0365_0_IdentifierSt"" type=""ST_365"" />
      <xs:element minOccurs=""0"" name=""CE_0365_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0365_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0365_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0365_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0365_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0366_366"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0366_0_IdentifierSt"" type=""ST_366"" />
      <xs:element minOccurs=""0"" name=""CE_0366_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0366_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0366_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0366_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0366_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0367_367"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0367_0_IdentifierSt"" type=""ST_367"" />
      <xs:element minOccurs=""0"" name=""CE_0367_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0367_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0367_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0367_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0367_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0368_368"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0368_0_IdentifierSt"" type=""ST_368"" />
      <xs:element minOccurs=""0"" name=""CE_0368_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0368_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0368_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0368_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0368_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0370_370"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0370_0_IdentifierSt"" type=""ST_370"" />
      <xs:element minOccurs=""0"" name=""CE_0370_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0370_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0370_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0370_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0370_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0371_371"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0371_0_IdentifierSt"" type=""ST_371"" />
      <xs:element minOccurs=""0"" name=""CE_0371_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0371_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0371_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0371_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0371_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0373_373"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0373_0_IdentifierSt"" type=""ST_373"" />
      <xs:element minOccurs=""0"" name=""CE_0373_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0373_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0373_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0373_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0373_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0374_374"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0374_0_IdentifierSt"" type=""ST_374"" />
      <xs:element minOccurs=""0"" name=""CE_0374_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0374_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0374_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0374_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0374_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0375_375"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0375_0_IdentifierSt"" type=""ST_375"" />
      <xs:element minOccurs=""0"" name=""CE_0375_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0375_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0375_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0375_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0375_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0376_376"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0376_0_IdentifierSt"" type=""ST_376"" />
      <xs:element minOccurs=""0"" name=""CE_0376_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0376_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0376_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0376_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0376_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0377_377"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0377_0_IdentifierSt"" type=""ST_377"" />
      <xs:element minOccurs=""0"" name=""CE_0377_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0377_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0377_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0377_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0377_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0378_378"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0378_0_IdentifierSt"" type=""ST_378"" />
      <xs:element minOccurs=""0"" name=""CE_0378_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0378_2_NameOfCodingSystem"" type=""IS_378"" />
      <xs:element minOccurs=""0"" name=""CE_0378_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0378_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0378_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0379_379"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0379_0_IdentifierSt"" type=""ST_379"" />
      <xs:element minOccurs=""0"" name=""CE_0379_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0379_2_NameOfCodingSystem"" type=""IS_379"" />
      <xs:element minOccurs=""0"" name=""CE_0379_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0379_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0379_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0380_380"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0380_0_IdentifierSt"" type=""ST_380"" />
      <xs:element minOccurs=""0"" name=""CE_0380_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0380_2_NameOfCodingSystem"" type=""IS_380"" />
      <xs:element minOccurs=""0"" name=""CE_0380_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0380_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0380_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0381_381"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0381_0_IdentifierSt"" type=""ST_381"" />
      <xs:element minOccurs=""0"" name=""CE_0381_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0381_2_NameOfCodingSystem"" type=""IS_381"" />
      <xs:element minOccurs=""0"" name=""CE_0381_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0381_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0381_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0382_382"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0382_0_IdentifierSt"" type=""ST_382"" />
      <xs:element minOccurs=""0"" name=""CE_0382_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0382_2_NameOfCodingSystem"" type=""IS_382"" />
      <xs:element minOccurs=""0"" name=""CE_0382_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0382_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0382_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0383_383"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0383_0_IdentifierSt"" type=""ST_383"" />
      <xs:element minOccurs=""0"" name=""CE_0383_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0383_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0383_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0383_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0383_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0384_384"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0384_0_IdentifierSt"" type=""ST_384"" />
      <xs:element minOccurs=""0"" name=""CE_0384_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0384_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0384_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0384_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0384_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0385_385"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0385_0_IdentifierSt"" type=""ST_385"" />
      <xs:element minOccurs=""0"" name=""CE_0385_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0385_2_NameOfCodingSystem"" type=""IS_385"" />
      <xs:element minOccurs=""0"" name=""CE_0385_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0385_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0385_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0386_386"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0386_0_IdentifierSt"" type=""ST_386"" />
      <xs:element minOccurs=""0"" name=""CE_0386_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0386_2_NameOfCodingSystem"" type=""IS_386"" />
      <xs:element minOccurs=""0"" name=""CE_0386_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0386_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0386_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0387_387"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0387_0_IdentifierSt"" type=""ST_387"" />
      <xs:element minOccurs=""0"" name=""CE_0387_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0387_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0387_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0387_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0387_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0388_388"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0388_0_IdentifierSt"" type=""ST_388"" />
      <xs:element minOccurs=""0"" name=""CE_0388_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0388_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0388_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0388_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0388_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0389_389"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0389_0_IdentifierSt"" type=""ST_389"" />
      <xs:element minOccurs=""0"" name=""CE_0389_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0389_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0389_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0389_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0389_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0393_393"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0393_0_IdentifierSt"" type=""ST_393"" />
      <xs:element minOccurs=""0"" name=""CE_0393_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0393_2_NameOfCodingSystem"" type=""IS_393"" />
      <xs:element minOccurs=""0"" name=""CE_0393_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0393_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0393_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0394_394"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0394_0_IdentifierSt"" type=""ST_394"" />
      <xs:element minOccurs=""0"" name=""CE_0394_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0394_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0394_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0394_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0394_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0401_401"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0401_0_IdentifierSt"" type=""ST_401"" />
      <xs:element minOccurs=""0"" name=""CE_0401_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0401_2_NameOfCodingSystem"" type=""IS_401"" />
      <xs:element minOccurs=""0"" name=""CE_0401_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0401_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0401_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0402_402"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0402_0_IdentifierSt"" type=""ST_402"" />
      <xs:element minOccurs=""0"" name=""CE_0402_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0402_2_NameOfCodingSystem"" type=""IS_402"" />
      <xs:element minOccurs=""0"" name=""CE_0402_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0402_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0402_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0403_403"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0403_0_IdentifierSt"" type=""ST_403"" />
      <xs:element minOccurs=""0"" name=""CE_0403_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0403_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0403_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0403_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0403_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0404_404"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0404_0_IdentifierSt"" type=""ST_404"" />
      <xs:element minOccurs=""0"" name=""CE_0404_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0404_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0404_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0404_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0404_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0405_405"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0405_0_IdentifierSt"" type=""ST_405"" />
      <xs:element minOccurs=""0"" name=""CE_0405_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0405_2_NameOfCodingSystem"" type=""IS_405"" />
      <xs:element minOccurs=""0"" name=""CE_0405_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0405_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0405_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0406_406"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0406_0_IdentifierSt"" type=""ST_406"" />
      <xs:element minOccurs=""0"" name=""CE_0406_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0406_2_NameOfCodingSystem"" type=""IS_406"" />
      <xs:element minOccurs=""0"" name=""CE_0406_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0406_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0406_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0411_411"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0411_0_IdentifierSt"" type=""ST_411"" />
      <xs:element minOccurs=""0"" name=""CE_0411_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0411_2_NameOfCodingSystem"" type=""IS_411"" />
      <xs:element minOccurs=""0"" name=""CE_0411_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0411_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0411_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0412_412"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0412_0_IdentifierSt"" type=""ST_412"" />
      <xs:element minOccurs=""0"" name=""CE_0412_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0412_2_NameOfCodingSystem"" type=""IS_412"" />
      <xs:element minOccurs=""0"" name=""CE_0412_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0412_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0412_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0413_413"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0413_0_IdentifierSt"" type=""ST_413"" />
      <xs:element minOccurs=""0"" name=""CE_0413_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0413_2_NameOfCodingSystem"" type=""IS_413"" />
      <xs:element minOccurs=""0"" name=""CE_0413_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0413_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0413_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0414_414"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0414_0_IdentifierSt"" type=""ST_414"" />
      <xs:element minOccurs=""0"" name=""CE_0414_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0414_2_NameOfCodingSystem"" type=""IS_414"" />
      <xs:element minOccurs=""0"" name=""CE_0414_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0414_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0414_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0417_417"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0417_0_IdentifierSt"" type=""ST_417"" />
      <xs:element minOccurs=""0"" name=""CE_0417_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0417_2_NameOfCodingSystem"" type=""IS_417"" />
      <xs:element minOccurs=""0"" name=""CE_0417_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0417_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0417_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0421_421"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0421_0_IdentifierSt"" type=""ST_421"" />
      <xs:element minOccurs=""0"" name=""CE_0421_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0421_2_NameOfCodingSystem"" type=""IS_421"" />
      <xs:element minOccurs=""0"" name=""CE_0421_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0421_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0421_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0422_422"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0422_0_IdentifierSt"" type=""ST_422"" />
      <xs:element minOccurs=""0"" name=""CE_0422_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0422_2_NameOfCodingSystem"" type=""IS_422"" />
      <xs:element minOccurs=""0"" name=""CE_0422_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0422_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0422_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0423_423"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0423_0_IdentifierSt"" type=""ST_423"" />
      <xs:element minOccurs=""0"" name=""CE_0423_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0423_2_NameOfCodingSystem"" type=""IS_423"" />
      <xs:element minOccurs=""0"" name=""CE_0423_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0423_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0423_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0424_424"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0424_0_IdentifierSt"" type=""ST_424"" />
      <xs:element minOccurs=""0"" name=""CE_0424_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0424_2_NameOfCodingSystem"" type=""IS_424"" />
      <xs:element minOccurs=""0"" name=""CE_0424_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0424_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0424_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0425_425"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0425_0_IdentifierSt"" type=""ST_425"" />
      <xs:element minOccurs=""0"" name=""CE_0425_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0425_2_NameOfCodingSystem"" type=""IS_425"" />
      <xs:element minOccurs=""0"" name=""CE_0425_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0425_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0425_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0426_426"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0426_0_IdentifierSt"" type=""ST_426"" />
      <xs:element minOccurs=""0"" name=""CE_0426_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0426_2_NameOfCodingSystem"" type=""IS_426"" />
      <xs:element minOccurs=""0"" name=""CE_0426_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0426_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0426_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0427_427"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0427_0_IdentifierSt"" type=""ST_427"" />
      <xs:element minOccurs=""0"" name=""CE_0427_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0427_2_NameOfCodingSystem"" type=""IS_427"" />
      <xs:element minOccurs=""0"" name=""CE_0427_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0427_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0427_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0428_428"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0428_0_IdentifierSt"" type=""ST_428"" />
      <xs:element minOccurs=""0"" name=""CE_0428_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0428_2_NameOfCodingSystem"" type=""IS_428"" />
      <xs:element minOccurs=""0"" name=""CE_0428_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0428_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0428_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0429_429"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0429_0_IdentifierSt"" type=""ST_429"" />
      <xs:element minOccurs=""0"" name=""CE_0429_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0429_2_NameOfCodingSystem"" type=""IS_429"" />
      <xs:element minOccurs=""0"" name=""CE_0429_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0429_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0429_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0430_430"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0430_0_IdentifierSt"" type=""ST_430"" />
      <xs:element minOccurs=""0"" name=""CE_0430_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0430_2_NameOfCodingSystem"" type=""IS_430"" />
      <xs:element minOccurs=""0"" name=""CE_0430_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0430_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0430_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0431_431"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0431_0_IdentifierSt"" type=""ST_431"" />
      <xs:element minOccurs=""0"" name=""CE_0431_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0431_2_NameOfCodingSystem"" type=""IS_431"" />
      <xs:element minOccurs=""0"" name=""CE_0431_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0431_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0431_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0432_432"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0432_0_IdentifierSt"" type=""ST_432"" />
      <xs:element minOccurs=""0"" name=""CE_0432_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0432_2_NameOfCodingSystem"" type=""IS_432"" />
      <xs:element minOccurs=""0"" name=""CE_0432_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0432_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0432_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0433_433"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0433_0_IdentifierSt"" type=""ST_433"" />
      <xs:element minOccurs=""0"" name=""CE_0433_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0433_2_NameOfCodingSystem"" type=""IS_433"" />
      <xs:element minOccurs=""0"" name=""CE_0433_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0433_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0433_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0434_434"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0434_0_IdentifierSt"" type=""ST_434"" />
      <xs:element minOccurs=""0"" name=""CE_0434_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0434_2_NameOfCodingSystem"" type=""IS_434"" />
      <xs:element minOccurs=""0"" name=""CE_0434_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0434_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0434_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0435_435"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0435_0_IdentifierSt"" type=""ST_435"" />
      <xs:element minOccurs=""0"" name=""CE_0435_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0435_2_NameOfCodingSystem"" type=""IS_435"" />
      <xs:element minOccurs=""0"" name=""CE_0435_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0435_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0435_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0436_436"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0436_0_IdentifierSt"" type=""ST_436"" />
      <xs:element minOccurs=""0"" name=""CE_0436_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0436_2_NameOfCodingSystem"" type=""IS_436"" />
      <xs:element minOccurs=""0"" name=""CE_0436_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0436_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0436_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0437_437"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0437_0_IdentifierSt"" type=""ST_437"" />
      <xs:element minOccurs=""0"" name=""CE_0437_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0437_2_NameOfCodingSystem"" type=""IS_437"" />
      <xs:element minOccurs=""0"" name=""CE_0437_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0437_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0437_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0438_438"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0438_0_IdentifierSt"" type=""ST_438"" />
      <xs:element minOccurs=""0"" name=""CE_0438_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0438_2_NameOfCodingSystem"" type=""IS_438"" />
      <xs:element minOccurs=""0"" name=""CE_0438_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0438_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0438_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0443_443"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0443_0_IdentifierSt"" type=""ST_443"" />
      <xs:element minOccurs=""0"" name=""CE_0443_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0443_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0443_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0443_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0443_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0446_446"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0446_0_IdentifierSt"" type=""ST_446"" />
      <xs:element minOccurs=""0"" name=""CE_0446_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0446_2_NameOfCodingSystem"" type=""IS_446"" />
      <xs:element minOccurs=""0"" name=""CE_0446_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0446_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0446_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0447_447"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0447_0_IdentifierSt"" type=""ST_447"" />
      <xs:element minOccurs=""0"" name=""CE_0447_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0447_2_NameOfCodingSystem"" type=""IS_447"" />
      <xs:element minOccurs=""0"" name=""CE_0447_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0447_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0447_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0450_450"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0450_0_IdentifierSt"" type=""ST_450"" />
      <xs:element minOccurs=""0"" name=""CE_0450_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0450_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0450_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0450_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0450_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0451_451"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0451_0_IdentifierSt"" type=""ST_451"" />
      <xs:element minOccurs=""0"" name=""CE_0451_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0451_2_NameOfCodingSystem"" type=""IS_451"" />
      <xs:element minOccurs=""0"" name=""CE_0451_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0451_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0451_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0452_452"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0452_0_IdentifierSt"" type=""ST_452"" />
      <xs:element minOccurs=""0"" name=""CE_0452_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0452_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0452_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0452_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0452_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0453_453"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0453_0_IdentifierSt"" type=""ST_453"" />
      <xs:element minOccurs=""0"" name=""CE_0453_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0453_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0453_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0453_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0453_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0454_454"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0454_0_IdentifierSt"" type=""ST_454"" />
      <xs:element minOccurs=""0"" name=""CE_0454_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0454_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CE_0454_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0454_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0454_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0461_461"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0461_0_IdentifierSt"" type=""ST_461"" />
      <xs:element minOccurs=""0"" name=""CE_0461_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0461_2_NameOfCodingSystem"" type=""IS_461"" />
      <xs:element minOccurs=""0"" name=""CE_0461_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0461_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0461_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0462_462"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0462_0_IdentifierSt"" type=""ST_462"" />
      <xs:element minOccurs=""0"" name=""CE_0462_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0462_2_NameOfCodingSystem"" type=""IS_462"" />
      <xs:element minOccurs=""0"" name=""CE_0462_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0462_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0462_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0463_463"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0463_0_IdentifierSt"" type=""ST_463"" />
      <xs:element minOccurs=""0"" name=""CE_0463_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0463_2_NameOfCodingSystem"" type=""IS_463"" />
      <xs:element minOccurs=""0"" name=""CE_0463_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0463_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0463_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0464_464"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0464_0_IdentifierSt"" type=""ST_464"" />
      <xs:element minOccurs=""0"" name=""CE_0464_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0464_2_NameOfCodingSystem"" type=""IS_464"" />
      <xs:element minOccurs=""0"" name=""CE_0464_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0464_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0464_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0466_466"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0466_0_IdentifierSt"" type=""ST_466"" />
      <xs:element minOccurs=""0"" name=""CE_0466_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0466_2_NameOfCodingSystem"" type=""IS_466"" />
      <xs:element minOccurs=""0"" name=""CE_0466_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0466_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0466_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0471_471"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0471_0_IdentifierSt"" type=""ST_471"" />
      <xs:element minOccurs=""0"" name=""CE_0471_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0471_2_NameOfCodingSystem"" type=""IS_471"" />
      <xs:element minOccurs=""0"" name=""CE_0471_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0471_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0471_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CE_0474_474"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CE_0474_0_IdentifierSt"" type=""ST_474"" />
      <xs:element minOccurs=""0"" name=""CE_0474_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0474_2_NameOfCodingSystem"" type=""IS_474"" />
      <xs:element minOccurs=""0"" name=""CE_0474_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0474_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CE_0474_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CK"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CK_0_IdNumberNm"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""CK_1_CheckDigitNm"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""CK_2_CodeIdentifyingTheCheckDigitSchemeEmployed"" type=""ID_61"" />
      <xs:element minOccurs=""0"" name=""CK_3_AssigningAuthority"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CK_3_0_NamespaceId"" type=""IS_300"" />
            <xs:element minOccurs=""0"" name=""CK_3_1_UniversalId"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""CK_3_2_UniversalIdType"" type=""ID_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CNE_323"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CNE_0_IdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CNE_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CNE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CNE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CP"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CP_0_Price"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CP_0_0_Quantity"" type=""NM"" />
            <xs:element minOccurs=""0"" name=""CP_0_1_Denomination"" type=""ID"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CP_1_PriceType"" type=""ID_205"" />
      <xs:element minOccurs=""0"" name=""CP_2_FromValue"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""CP_3_ToValue"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""CP_4_RangeUnits"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CP_4_0_IdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""CP_4_1_Text"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""CP_4_2_NameOfCodingSystem"" type=""IS_396"" />
            <xs:element minOccurs=""0"" name=""CP_4_3_AlternateIdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""CP_4_4_AlternateText"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""CP_4_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CP_5_RangeType"" type=""ID_298"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CQ"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CQ_0_Quantity"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""CQ_1_Units"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CQ_1_0_IdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""CQ_1_1_Text"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""CQ_1_2_NameOfCodingSystem"" type=""IS_396"" />
            <xs:element minOccurs=""0"" name=""CQ_1_3_AlternateIdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""CQ_1_4_AlternateText"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""CQ_1_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CQ_126"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CQ_0_Quantity"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""CQ_1_Units"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CQ_1_0_IdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""CQ_1_1_Text"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""CQ_1_2_NameOfCodingSystem"" type=""IS_396"" />
            <xs:element minOccurs=""0"" name=""CQ_1_3_AlternateIdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""CQ_1_4_AlternateText"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""CQ_1_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CWE"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CWE_0_IdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_1_Text"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_2_NameOfCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CWE_3_AlternateIdentifierSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_4_AlternateText"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
      <xs:element minOccurs=""0"" name=""CWE_6_CodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_7_AlternateCodingSystemVersionId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CWE_8_OriginalText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CX"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CX_0_Id"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CX_1_CheckDigitSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CX_2_CodeIdentifyingTheCheckDigitSchemeEmployed"" type=""ID_61"" />
      <xs:element minOccurs=""0"" name=""CX_3_AssigningAuthority"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CX_3_0_NamespaceId"" type=""IS_300"" />
            <xs:element minOccurs=""0"" name=""CX_3_1_UniversalId"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""CX_3_2_UniversalIdType"" type=""ID_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CX_4_IdentifierTypeCodeId"" type=""ID_203"" />
      <xs:element minOccurs=""0"" name=""CX_5_AssigningFacility"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CX_5_0_NamespaceId"" type=""IS_300"" />
            <xs:element minOccurs=""0"" name=""CX_5_1_UniversalId"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""CX_5_2_UniversalIdType"" type=""ID_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CX_6_EffectiveDateDt"" type=""DT"" />
      <xs:element minOccurs=""0"" name=""CX_7_ExpirationDate"" type=""DT"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CX_203"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CX_0_Id"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CX_1_CheckDigitSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""CX_2_CodeIdentifyingTheCheckDigitSchemeEmployed"" type=""ID_61"" />
      <xs:element minOccurs=""0"" name=""CX_3_AssigningAuthority"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CX_3_0_NamespaceId"" type=""IS_203"" />
            <xs:element minOccurs=""0"" name=""CX_3_1_UniversalId"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""CX_3_2_UniversalIdType"" type=""ID_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CX_4_IdentifierTypeCodeId"" type=""ID_203"" />
      <xs:element minOccurs=""0"" name=""CX_5_AssigningFacility"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""CX_5_0_NamespaceId"" type=""IS_300"" />
            <xs:element minOccurs=""0"" name=""CX_5_1_UniversalId"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""CX_5_2_UniversalIdType"" type=""ID_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CX_6_EffectiveDateDt"" type=""DT"" />
      <xs:element minOccurs=""0"" name=""CX_7_ExpirationDate"" type=""DT"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""DDI"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""DDI_0_DelayDays"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""DDI_1_Amount"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""DDI_2_NumberOfDays"" type=""NM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""DIN"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""DIN_0_Date"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""DIN_0_0_TimeOfAnEvent"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""DIN_0_1_DegreeOfPrecision"" type=""ST"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""DIN_1_InstitutionName"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""DIN_1_0_IdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""DIN_1_1_Text"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""DIN_1_2_NameOfCodingSystem"" type=""IS_396"" />
            <xs:element minOccurs=""0"" name=""DIN_1_3_AlternateIdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""DIN_1_4_AlternateText"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""DIN_1_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""DLD_113"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""DLD_0_DischargeLocation"" type=""ID"" />
      <xs:element minOccurs=""0"" name=""DLD_1_EffectiveDate"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""DLD_1_0_TimeOfAnEvent"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""DLD_1_1_DegreeOfPrecision"" type=""ST"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""DLN"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""DLN_0_DriverSLicenseNumber"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""DLN_1_IssuingStateProvinceCountry"" type=""IS_333"" />
      <xs:element minOccurs=""0"" name=""DLN_2_ExpirationDate"" type=""DT"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""DLT"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""DLT_0_Range"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""DLT_0_0_LowValue"" type=""NM"" />
            <xs:element minOccurs=""0"" name=""DLT_0_1_HighValue"" type=""NM"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""DLT_1_NumericThreshold"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""DLT_2_ChangeComputation"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""DLT_3_LengthOfTimeDays"" type=""NM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""DR"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""DR_0_RangeStartDateTime"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""DR_0_0_TimeOfAnEvent"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""DR_0_1_DegreeOfPrecision"" type=""ST"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""DR_1_RangeEndDateTime"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""DR_1_0_TimeOfAnEvent"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""DR_1_1_DegreeOfPrecision"" type=""ST"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""DTN_149"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""DTN_0_DayType"" type=""IS_149"" />
      <xs:element minOccurs=""0"" name=""DTN_1_NumberOfDays"" type=""NM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""EI"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""EI_0_EntityIdentifier"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""EI_1_NamespaceId"" type=""IS_300"" />
      <xs:element minOccurs=""0"" name=""EI_2_UniversalId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""EI_3_UniversalIdType"" type=""ID_301"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""EIP"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""EIP_0_ParentSPlacerOrderNumber"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""EIP_0_0_EntityIdentifier"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""EIP_0_1_NamespaceId"" type=""IS_300"" />
            <xs:element minOccurs=""0"" name=""EIP_0_2_UniversalId"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""EIP_0_3_UniversalIdType"" type=""ID_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""EIP_1_ParentSFillerOrderNumber"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""EIP_1_0_EntityIdentifier"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""EIP_1_1_NamespaceId"" type=""IS_300"" />
            <xs:element minOccurs=""0"" name=""EIP_1_2_UniversalId"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""EIP_1_3_UniversalIdType"" type=""ID_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ELD"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ELD_0_SegmentId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""ELD_1_Sequence"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""ELD_2_FieldPosition"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""ELD_3_CodeIdentifyingError"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""ELD_3_0_IdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""ELD_3_1_Text"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""ELD_3_2_NameOfCodingSystem"" type=""IS_396"" />
            <xs:element minOccurs=""0"" name=""ELD_3_3_AlternateIdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""ELD_3_4_AlternateText"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""ELD_3_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""FC_64"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""FC_0_FinancialClass"" type=""IS_64"" />
      <xs:element minOccurs=""0"" name=""FC_1_EffectiveDateTs"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""FC_1_0_TimeOfAnEvent"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""FC_1_1_DegreeOfPrecision"" type=""ST"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""HD"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""HD_0_NamespaceId"" type=""IS_300"" />
      <xs:element minOccurs=""0"" name=""HD_1_UniversalId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""HD_2_UniversalIdType"" type=""ID_301"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""HD_361"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""HD_0_NamespaceId"" type=""IS_300"" />
      <xs:element minOccurs=""0"" name=""HD_1_UniversalId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""HD_2_UniversalIdType"" type=""ID_301"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""HD_362"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""HD_0_NamespaceId"" type=""IS_300"" />
      <xs:element minOccurs=""0"" name=""HD_1_UniversalId"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""HD_2_UniversalIdType"" type=""ID_301"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""JCC_327"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""JCC_0_JobCode"" type=""IS_327"" />
      <xs:element minOccurs=""0"" name=""JCC_1_JobClass"" type=""IS_328"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""LA1"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""LA1_0_PointOfCareIs"" type=""IS"" />
      <xs:element minOccurs=""0"" name=""LA1_1_Room"" type=""IS_303"" />
      <xs:element minOccurs=""0"" name=""LA1_2_Bed"" type=""IS_304"" />
      <xs:element minOccurs=""0"" name=""LA1_3_FacilityHd"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""LA1_3_0_NamespaceId"" type=""IS_300"" />
            <xs:element minOccurs=""0"" name=""LA1_3_1_UniversalId"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""LA1_3_2_UniversalIdType"" type=""ID_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""LA1_4_LocationStatus"" type=""IS_306"" />
      <xs:element minOccurs=""0"" name=""LA1_5_PersonLocationType"" type=""IS_305"" />
      <xs:element minOccurs=""0"" name=""LA1_6_Building"" type=""IS_307"" />
      <xs:element minOccurs=""0"" name=""LA1_7_Floor"" type=""IS_308"" />
      <xs:element minOccurs=""0"" name=""LA1_8_Address"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""LA1_8_0_StreetAddressSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""LA1_8_1_OtherDesignation"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""LA1_8_2_City"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""LA1_8_3_StateOrProvince"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""LA1_8_4_ZipOrPostalCode"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""LA1_8_5_Country"" type=""ID_399"" />
            <xs:element minOccurs=""0"" name=""LA1_8_6_AddressType"" type=""ID_190"" />
            <xs:element minOccurs=""0"" name=""LA1_8_7_OtherGeographicDesignation"" type=""ST"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""LA2"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""LA2_0_PointOfCareIs"" type=""IS"" />
      <xs:element minOccurs=""0"" name=""LA2_1_Room"" type=""IS_303"" />
      <xs:element minOccurs=""0"" name=""LA2_2_Bed"" type=""IS_304"" />
      <xs:element minOccurs=""0"" name=""LA2_3_FacilityHd"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""LA2_3_0_NamespaceId"" type=""IS_300"" />
            <xs:element minOccurs=""0"" name=""LA2_3_1_UniversalId"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""LA2_3_2_UniversalIdType"" type=""ID_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""LA2_4_LocationStatus"" type=""IS_306"" />
      <xs:element minOccurs=""0"" name=""LA2_5_PersonLocationType"" type=""IS_305"" />
      <xs:element minOccurs=""0"" name=""LA2_6_Building"" type=""IS_307"" />
      <xs:element minOccurs=""0"" name=""LA2_7_Floor"" type=""IS_308"" />
      <xs:element minOccurs=""0"" name=""LA2_8_StreetAddressSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""LA2_9_OtherDesignation"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""LA2_10_City"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""LA2_11_StateOrProvince"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""LA2_12_ZipOrPostalCode"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""LA2_13_Country"" type=""ID_399"" />
      <xs:element minOccurs=""0"" name=""LA2_14_AddressType"" type=""ID_190"" />
      <xs:element minOccurs=""0"" name=""LA2_15_OtherGeographicDesignation"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""MO"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""MO_0_Quantity"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""MO_1_Denomination"" type=""ID"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""MOC"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""MOC_0_DollarAmount"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""MOC_0_0_Quantity"" type=""NM"" />
            <xs:element minOccurs=""0"" name=""MOC_0_1_Denomination"" type=""ID"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""MOC_1_ChargeCode"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""MOC_1_0_IdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""MOC_1_1_Text"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""MOC_1_2_NameOfCodingSystem"" type=""IS_396"" />
            <xs:element minOccurs=""0"" name=""MOC_1_3_AlternateIdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""MOC_1_4_AlternateText"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""MOC_1_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""MOP_148"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""MOP_0_MoneyOrPercentageIndicator"" type=""IS_148"" />
      <xs:element minOccurs=""0"" name=""MOP_1_MoneyOrPercentageQuantity"" type=""NM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""MSG_76"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""MSG_0_MessageType"" type=""ID_76"" />
      <xs:element minOccurs=""0"" name=""MSG_1_TriggerEvent"" type=""ID_3"" />
      <xs:element minOccurs=""0"" name=""MSG_2_MessageStructure"" type=""ID_354"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""NA"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""NA_0_Value1"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""NA_1_Value2"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""NA_2_Value3"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""NA_3_Value4"" type=""NM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""NDL"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""NDL_0_Name"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""NDL_0_0_IdNumberSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""NDL_0_1_FamilyName"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""NDL_0_2_GivenName"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""NDL_0_3_SecondAndFurtherGivenNamesOrInitialsThereof"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""NDL_0_4_SuffixEGJrOrIii"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""NDL_0_5_PrefixEGDr"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""NDL_0_6_DegreeEGMd"" type=""IS_360"" />
            <xs:element minOccurs=""0"" name=""NDL_0_7_SourceTable"" type=""IS_297"" />
            <xs:element minOccurs=""0"" name=""NDL_0_8_AssigningAuthorityNamespaceId"" type=""IS_363"" />
            <xs:element minOccurs=""0"" name=""NDL_0_9_AssigningAuthorityUniversalId"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""NDL_0_10_AssigningAuthorityUniversalIdType"" type=""ID_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""NDL_1_StartDateTime"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""NDL_1_0_TimeOfAnEvent"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""NDL_1_1_DegreeOfPrecision"" type=""ST"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""NDL_2_EndDateTime"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""NDL_2_0_TimeOfAnEvent"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""NDL_2_1_DegreeOfPrecision"" type=""ST"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""NDL_3_PointOfCareIs"" type=""IS"" />
      <xs:element minOccurs=""0"" name=""NDL_4_Room"" type=""IS_303"" />
      <xs:element minOccurs=""0"" name=""NDL_5_Bed"" type=""IS_304"" />
      <xs:element minOccurs=""0"" name=""NDL_6_FacilityHd"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""NDL_6_0_NamespaceId"" type=""IS_300"" />
            <xs:element minOccurs=""0"" name=""NDL_6_1_UniversalId"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""NDL_6_2_UniversalIdType"" type=""ID_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""NDL_7_LocationStatus"" type=""IS_306"" />
      <xs:element minOccurs=""0"" name=""NDL_8_PersonLocationType"" type=""IS_305"" />
      <xs:element minOccurs=""0"" name=""NDL_9_Building"" type=""IS_307"" />
      <xs:element minOccurs=""0"" name=""NDL_10_Floor"" type=""IS_308"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""NR"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""NR_0_LowValue"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""NR_1_HighValue"" type=""NM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""OCD_350"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""OCD_0_OccurrenceCode"" type=""IS_350"" />
      <xs:element minOccurs=""0"" name=""OCD_1_OccurrenceDate"" type=""DT"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""OSP_351"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""OSP_0_OccurrenceSpanCode"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""OSP_0_0_IdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""OSP_0_1_Text"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""OSP_0_2_NameOfCodingSystem"" type=""IS_351"" />
            <xs:element minOccurs=""0"" name=""OSP_0_3_AlternateIdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""OSP_0_4_AlternateText"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""OSP_0_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""OSP_1_OccurrenceSpanStartDate"" type=""DT"" />
      <xs:element minOccurs=""0"" name=""OSP_2_OccurrenceSpanStopDate"" type=""DT"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PCF_150"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""PCF_0_PreCertificationPatientType"" type=""IS_150"" />
      <xs:element minOccurs=""0"" name=""PCF_1_PreCertificationRequired"" type=""ID_136"" />
      <xs:element minOccurs=""0"" name=""PCF_2_PreCertificationWindow"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""PCF_2_0_TimeOfAnEvent"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""PCF_2_1_DegreeOfPrecision"" type=""ST"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PI"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""PI_0_IdNumberSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""PI_1_TypeOfIdNumberIs"" type=""IS"" />
      <xs:element minOccurs=""0"" name=""PI_2_OtherQualifyingInfo"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PIP"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""PIP_0_Privilege"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""PIP_0_0_IdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""PIP_0_1_Text"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""PIP_0_2_NameOfCodingSystem"" type=""IS_396"" />
            <xs:element minOccurs=""0"" name=""PIP_0_3_AlternateIdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""PIP_0_4_AlternateText"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""PIP_0_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PIP_1_PrivilegeClass"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""PIP_1_0_IdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""PIP_1_1_Text"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""PIP_1_2_NameOfCodingSystem"" type=""IS_396"" />
            <xs:element minOccurs=""0"" name=""PIP_1_3_AlternateIdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""PIP_1_4_AlternateText"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""PIP_1_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PIP_2_ExpirationDate"" type=""DT"" />
      <xs:element minOccurs=""0"" name=""PIP_3_ActivationDate"" type=""DT"" />
      <xs:element minOccurs=""0"" name=""PIP_4_FacilityEi"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""PIP_4_0_EntityIdentifier"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""PIP_4_1_NamespaceId"" type=""IS_300"" />
            <xs:element minOccurs=""0"" name=""PIP_4_2_UniversalId"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""PIP_4_3_UniversalIdType"" type=""ID_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PL"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""PL_0_PointOfCare"" type=""IS_302"" />
      <xs:element minOccurs=""0"" name=""PL_1_Room"" type=""IS_303"" />
      <xs:element minOccurs=""0"" name=""PL_2_Bed"" type=""IS_304"" />
      <xs:element minOccurs=""0"" name=""PL_3_FacilityHd"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""PL_3_0_NamespaceId"" type=""IS_300"" />
            <xs:element minOccurs=""0"" name=""PL_3_1_UniversalId"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""PL_3_2_UniversalIdType"" type=""ID_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PL_4_LocationStatus"" type=""IS_306"" />
      <xs:element minOccurs=""0"" name=""PL_5_PersonLocationType"" type=""IS_305"" />
      <xs:element minOccurs=""0"" name=""PL_6_Building"" type=""IS_307"" />
      <xs:element minOccurs=""0"" name=""PL_7_Floor"" type=""IS_308"" />
      <xs:element minOccurs=""0"" name=""PL_8_LocationDescription"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PLN_338"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""PLN_0_IdNumberSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""PLN_1_TypeOfIdNumberIs"" type=""IS_338"" />
      <xs:element minOccurs=""0"" name=""PLN_2_StateOtherQualifyingInfo"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""PLN_3_ExpirationDate"" type=""DT"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PPN"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""PPN_0_IdNumberSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""PPN_1_FamilyName"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""PPN_1_0_Surname"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""PPN_1_1_OwnSurnamePrefix"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""PPN_1_2_OwnSurname"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""PPN_1_3_SurnamePrefixFromPartnerSpouse"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""PPN_1_4_SurnameFromPartnerSpouse"" type=""ST"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PPN_2_GivenName"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""PPN_3_SecondAndFurtherGivenNamesOrInitialsThereof"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""PPN_4_SuffixEGJrOrIii"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""PPN_5_PrefixEGDr"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""PPN_6_DegreeEGMd"" type=""IS_360"" />
      <xs:element minOccurs=""0"" name=""PPN_7_SourceTable"" type=""IS_297"" />
      <xs:element minOccurs=""0"" name=""PPN_8_AssigningAuthority"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""PPN_8_0_NamespaceId"" type=""IS_300"" />
            <xs:element minOccurs=""0"" name=""PPN_8_1_UniversalId"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""PPN_8_2_UniversalIdType"" type=""ID_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PPN_9_NameTypeCode"" type=""ID_200"" />
      <xs:element minOccurs=""0"" name=""PPN_10_IdentifierCheckDigit"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""PPN_11_CodeIdentifyingTheCheckDigitSchemeEmployed"" type=""ID_61"" />
      <xs:element minOccurs=""0"" name=""PPN_12_IdentifierTypeCodeIs"" type=""IS"" />
      <xs:element minOccurs=""0"" name=""PPN_13_AssigningFacility"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""PPN_13_0_NamespaceId"" type=""IS_300"" />
            <xs:element minOccurs=""0"" name=""PPN_13_1_UniversalId"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""PPN_13_2_UniversalIdType"" type=""ID_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PPN_14_DateTimeActionPerformed"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""PPN_14_0_TimeOfAnEvent"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""PPN_14_1_DegreeOfPrecision"" type=""ST"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PPN_15_NameRepresentationCode"" type=""ID_465"" />
      <xs:element minOccurs=""0"" name=""PPN_16_NameContext"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""PPN_16_0_IdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""PPN_16_1_Text"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""PPN_16_2_NameOfCodingSystem"" type=""IS_396"" />
            <xs:element minOccurs=""0"" name=""PPN_16_3_AlternateIdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""PPN_16_4_AlternateText"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""PPN_16_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PPN_17_NameValidityRange"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""PPN_17_0_RangeStartDateTime"" type=""TS_0"" />
            <xs:element minOccurs=""0"" name=""PPN_17_1_RangeEndDateTime"" type=""TS_1"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PPN_18_NameAssemblyOrder"" type=""ID_444"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PRL"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""PRL_0_Obx3ObservationIdentifierOfParentResult"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""PRL_0_0_IdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""PRL_0_1_Text"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""PRL_0_2_NameOfCodingSystem"" type=""IS_396"" />
            <xs:element minOccurs=""0"" name=""PRL_0_3_AlternateIdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""PRL_0_4_AlternateText"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""PRL_0_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PRL_1_Obx4SubIdOfParentResult"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""PRL_2_PartOfObx5ObservationResultFromParent"" type=""TX"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PT"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""PT_0_ProcessingId"" type=""ID_103"" />
      <xs:element minOccurs=""0"" name=""PT_1_ProcessingMode"" type=""ID_207"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PTA_147"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""PTA_0_PolicyType"" type=""IS_147"" />
      <xs:element minOccurs=""0"" name=""PTA_1_AmountClass"" type=""IS_193"" />
      <xs:element minOccurs=""0"" name=""PTA_2_Amount"" type=""NM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""QIP"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""QIP_0_SegmentFieldName"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""QIP_1_Value1Value2Value3"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""QSC"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""QSC_0_SegmentFieldName"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""QSC_1_RelationalOperator"" type=""ID_209"" />
      <xs:element minOccurs=""0"" name=""QSC_2_Value"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""QSC_3_RelationalConjunction"" type=""ID_210"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""RCD_440"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""RCD_0_SegmentFieldName"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""RCD_1_Hl7DateType"" type=""ST_440"" />
      <xs:element minOccurs=""0"" name=""RCD_2_MaximumColumnWidth"" type=""NM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""RFR"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""RFR_0_NumericRange"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""RFR_0_0_LowValue"" type=""NM"" />
            <xs:element minOccurs=""0"" name=""RFR_0_1_HighValue"" type=""NM"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""RFR_1_AdministrativeSex"" type=""IS"" />
      <xs:element minOccurs=""0"" name=""RFR_2_AgeRange"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""RFR_2_0_LowValue"" type=""NM"" />
            <xs:element minOccurs=""0"" name=""RFR_2_1_HighValue"" type=""NM"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""RFR_3_GestationalRange"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""RFR_3_0_LowValue"" type=""NM"" />
            <xs:element minOccurs=""0"" name=""RFR_3_1_HighValue"" type=""NM"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""RFR_4_Species"" type=""TX"" />
      <xs:element minOccurs=""0"" name=""RFR_5_RaceSubspecies"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""RFR_6_Conditions"" type=""TX"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""RI"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""RI_0_RepeatPattern"" type=""IS_335"" />
      <xs:element minOccurs=""0"" name=""RI_1_ExplicitTimeInterval"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""RMC_145"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""RMC_0_RoomType"" type=""IS_145"" />
      <xs:element minOccurs=""0"" name=""RMC_1_AmountType"" type=""IS_146"" />
      <xs:element minOccurs=""0"" name=""RMC_2_CoverageAmount"" type=""NM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""SCV"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""SCV_0_ParameterClass"" type=""IS"" />
      <xs:element minOccurs=""0"" name=""SCV_1_ParameterValue"" type=""ST_294"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""SCV_294"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""SCV_0_ParameterClass"" type=""IS_294"" />
      <xs:element minOccurs=""0"" name=""SCV_1_ParameterValue"" type=""ST_294"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""SN"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""SN_0_Comparator"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""SN_1_Num1"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""SN_2_SeparatorSuffix"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""SN_3_Num2"" type=""NM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""SPD_337"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""SPD_0_SpecialtyName"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""SPD_1_GoverningBoard"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""SPD_2_EligibleOrCertified"" type=""ID_337"" />
      <xs:element minOccurs=""0"" name=""SPD_3_DateOfCertification"" type=""DT"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""SPS_70"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""SPS_0_SpecimenSourceNameOrCode"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""SPS_0_0_IdentifierSt"" type=""ST_70"" />
            <xs:element minOccurs=""0"" name=""SPS_0_1_Text"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""SPS_0_2_NameOfCodingSystem"" type=""IS_396"" />
            <xs:element minOccurs=""0"" name=""SPS_0_3_AlternateIdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""SPS_0_4_AlternateText"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""SPS_0_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""SPS_1_Additives"" type=""TX"" />
      <xs:element minOccurs=""0"" name=""SPS_2_Freetext"" type=""TX"" />
      <xs:element minOccurs=""0"" name=""SPS_3_BodySite"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""SPS_3_0_IdentifierSt"" type=""ST_163"" />
            <xs:element minOccurs=""0"" name=""SPS_3_1_Text"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""SPS_3_2_NameOfCodingSystem"" type=""IS_396"" />
            <xs:element minOccurs=""0"" name=""SPS_3_3_AlternateIdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""SPS_3_4_AlternateText"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""SPS_3_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""SPS_4_SiteModifier"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""SPS_4_0_IdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""SPS_4_1_Text"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""SPS_4_2_NameOfCodingSystem"" type=""IS_396"" />
            <xs:element minOccurs=""0"" name=""SPS_4_3_AlternateIdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""SPS_4_4_AlternateText"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""SPS_4_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""SPS_5_CollectionModifierMethodCode"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""SPS_5_0_IdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""SPS_5_1_Text"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""SPS_5_2_NameOfCodingSystem"" type=""IS_396"" />
            <xs:element minOccurs=""0"" name=""SPS_5_3_AlternateIdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""SPS_5_4_AlternateText"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""SPS_5_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""SPS_6_SpecimenRole"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""SPS_6_0_IdentifierSt"" type=""ST_369"" />
            <xs:element minOccurs=""0"" name=""SPS_6_1_Text"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""SPS_6_2_NameOfCodingSystem"" type=""IS_396"" />
            <xs:element minOccurs=""0"" name=""SPS_6_3_AlternateIdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""SPS_6_4_AlternateText"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""SPS_6_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""SRT"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""SRT_0_SortByField"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""SRT_1_Sequencing"" type=""ID_397"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""TQ"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""TQ_0_Quantity"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""TQ_0_0_Quantity"" type=""NM"" />
            <xs:element minOccurs=""0"" name=""TQ_0_1_Units"" type=""CE_1"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""TQ_1_Interval"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""TQ_1_0_RepeatPattern"" type=""IS_335"" />
            <xs:element minOccurs=""0"" name=""TQ_1_1_ExplicitTimeInterval"" type=""ST"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""TQ_2_Duration"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""TQ_3_StartDateTime"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""TQ_3_0_TimeOfAnEvent"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""TQ_3_1_DegreeOfPrecision"" type=""ST"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""TQ_4_EndDateTime"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""TQ_4_0_TimeOfAnEvent"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""TQ_4_1_DegreeOfPrecision"" type=""ST"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""TQ_5_Priority"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""TQ_6_Condition"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""TQ_7_TextTx"" type=""TX"" />
      <xs:element minOccurs=""0"" name=""TQ_8_ConjunctionComponent"" type=""ID_472"" />
      <xs:element minOccurs=""0"" name=""TQ_9_OrderSequencing"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""TQ_9_0_SequenceResultsFlag"" type=""ID"" />
            <xs:element minOccurs=""0"" name=""TQ_9_1_PlacerOrderNumberEntityIdentifier"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""TQ_9_2_PlacerOrderNumberNamespaceId"" type=""IS"" />
            <xs:element minOccurs=""0"" name=""TQ_9_3_FillerOrderNumberEntityIdentifier"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""TQ_9_4_FillerOrderNumberNamespaceId"" type=""IS"" />
            <xs:element minOccurs=""0"" name=""TQ_9_5_SequenceConditionValue"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""TQ_9_6_MaximumNumberOfRepeats"" type=""NM"" />
            <xs:element minOccurs=""0"" name=""TQ_9_7_PlacerOrderNumberUniversalId"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""TQ_9_8_PlacerOrderNumberUniversalIdType"" type=""ID"" />
            <xs:element minOccurs=""0"" name=""TQ_9_9_FillerOrderNumberUniversalId"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""TQ_9_10_FillerOrderNumberUniversalIdType"" type=""ID"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""TQ_10_OccurrenceDuration"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""TQ_10_0_IdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""TQ_10_1_Text"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""TQ_10_2_NameOfCodingSystem"" type=""IS_396"" />
            <xs:element minOccurs=""0"" name=""TQ_10_3_AlternateIdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""TQ_10_4_AlternateText"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""TQ_10_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""TQ_11_TotalOccurences"" type=""NM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""TS"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""TS_0_TimeOfAnEvent"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""TS_1_DegreeOfPrecision"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""UVC_153"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""UVC_0_ValueCode"" type=""IS_153"" />
      <xs:element minOccurs=""0"" name=""UVC_1_ValueAmount"" type=""NM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""VH_267"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""VH_0_StartDayRange"" type=""ID_267"" />
      <xs:element minOccurs=""0"" name=""VH_1_EndDayRange"" type=""ID_267"" />
      <xs:element minOccurs=""0"" name=""VH_2_StartHourRange"" type=""TM"" />
      <xs:element minOccurs=""0"" name=""VH_3_EndHourRange"" type=""TM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""VID_104"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""VID_0_VersionId"" type=""ID_104"" />
      <xs:element minOccurs=""0"" name=""VID_1_InternationalizationCode"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""VID_1_0_IdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""VID_1_1_Text"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""VID_1_2_NameOfCodingSystem"" type=""IS_396"" />
            <xs:element minOccurs=""0"" name=""VID_1_3_AlternateIdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""VID_1_4_AlternateText"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""VID_1_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""VID_2_InternationalVersionId"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""VID_2_0_IdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""VID_2_1_Text"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""VID_2_2_NameOfCodingSystem"" type=""IS_396"" />
            <xs:element minOccurs=""0"" name=""VID_2_3_AlternateIdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""VID_2_4_AlternateText"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""VID_2_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""VR"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""VR_0_FirstDataCodeValue"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""VR_1_LastDataCodeCalue"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""XAD"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""XAD_0_StreetAddressSad"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XAD_0_0_StreetOrMailingAddress"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XAD_0_1_StreetName"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XAD_0_2_DwellingNumber"" type=""ST"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XAD_1_OtherDesignation"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XAD_2_City"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XAD_3_StateOrProvince"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XAD_4_ZipOrPostalCode"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XAD_5_Country"" type=""ID_399"" />
      <xs:element minOccurs=""0"" name=""XAD_6_AddressType"" type=""ID_190"" />
      <xs:element minOccurs=""0"" name=""XAD_7_OtherGeographicDesignation"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XAD_8_CountyParishCode"" type=""IS_289"" />
      <xs:element minOccurs=""0"" name=""XAD_9_CensusTract"" type=""IS_288"" />
      <xs:element minOccurs=""0"" name=""XAD_10_AddressRepresentationCode"" type=""ID_465"" />
      <xs:element minOccurs=""0"" name=""XAD_11_AddressValidityRange"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XAD_11_0_RangeStartDateTime"" type=""TS_0"" />
            <xs:element minOccurs=""0"" name=""XAD_11_1_RangeEndDateTime"" type=""TS_1"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""XCN"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""XCN_0_IdNumberSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_1_FamilyName"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_1_0_Surname"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_1_1_OwnSurnamePrefix"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_1_2_OwnSurname"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_1_3_SurnamePrefixFromPartnerSpouse"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_1_4_SurnameFromPartnerSpouse"" type=""ST"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_2_GivenName"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_3_SecondAndFurtherGivenNamesOrInitialsThereof"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_4_SuffixEGJrOrIii"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_5_PrefixEGDr"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_6_DegreeEGMd"" type=""IS_360"" />
      <xs:element minOccurs=""0"" name=""XCN_7_SourceTable"" type=""IS_297"" />
      <xs:element minOccurs=""0"" name=""XCN_8_AssigningAuthority"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_8_0_NamespaceId"" type=""IS_300"" />
            <xs:element minOccurs=""0"" name=""XCN_8_1_UniversalId"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_8_2_UniversalIdType"" type=""ID_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_9_NameTypeCode"" type=""ID_200"" />
      <xs:element minOccurs=""0"" name=""XCN_10_IdentifierCheckDigit"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_11_CodeIdentifyingTheCheckDigitSchemeEmployed"" type=""ID_61"" />
      <xs:element minOccurs=""0"" name=""XCN_12_IdentifierTypeCodeIs"" type=""IS"" />
      <xs:element minOccurs=""0"" name=""XCN_13_AssigningFacility"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_13_0_NamespaceId"" type=""IS_300"" />
            <xs:element minOccurs=""0"" name=""XCN_13_1_UniversalId"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_13_2_UniversalIdType"" type=""ID_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_14_NameRepresentationCode"" type=""ID_465"" />
      <xs:element minOccurs=""0"" name=""XCN_15_NameContext"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_15_0_IdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_15_1_Text"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_15_2_NameOfCodingSystem"" type=""IS_396"" />
            <xs:element minOccurs=""0"" name=""XCN_15_3_AlternateIdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_15_4_AlternateText"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_15_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_16_NameValidityRange"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_16_0_RangeStartDateTime"" type=""TS_0"" />
            <xs:element minOccurs=""0"" name=""XCN_16_1_RangeEndDateTime"" type=""TS_1"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_17_NameAssemblyOrder"" type=""ID_444"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""XCN_10"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""XCN_0_IdNumberSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_1_FamilyName"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_1_0_Surname"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_1_1_OwnSurnamePrefix"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_1_2_OwnSurname"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_1_3_SurnamePrefixFromPartnerSpouse"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_1_4_SurnameFromPartnerSpouse"" type=""ST"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_2_GivenName"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_3_SecondAndFurtherGivenNamesOrInitialsThereof"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_4_SuffixEGJrOrIii"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_5_PrefixEGDr"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_6_DegreeEGMd"" type=""IS_10"" />
      <xs:element minOccurs=""0"" name=""XCN_7_SourceTable"" type=""IS_297"" />
      <xs:element minOccurs=""0"" name=""XCN_8_AssigningAuthority"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_8_0_NamespaceId"" type=""IS_300"" />
            <xs:element minOccurs=""0"" name=""XCN_8_1_UniversalId"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_8_2_UniversalIdType"" type=""ID_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_9_NameTypeCode"" type=""ID_200"" />
      <xs:element minOccurs=""0"" name=""XCN_10_IdentifierCheckDigit"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_11_CodeIdentifyingTheCheckDigitSchemeEmployed"" type=""ID_61"" />
      <xs:element minOccurs=""0"" name=""XCN_12_IdentifierTypeCodeIs"" type=""IS"" />
      <xs:element minOccurs=""0"" name=""XCN_13_AssigningFacility"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_13_0_NamespaceId"" type=""IS_300"" />
            <xs:element minOccurs=""0"" name=""XCN_13_1_UniversalId"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_13_2_UniversalIdType"" type=""ID_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_14_NameRepresentationCode"" type=""ID_465"" />
      <xs:element minOccurs=""0"" name=""XCN_15_NameContext"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_15_0_IdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_15_1_Text"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_15_2_NameOfCodingSystem"" type=""IS_396"" />
            <xs:element minOccurs=""0"" name=""XCN_15_3_AlternateIdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_15_4_AlternateText"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_15_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_16_NameValidityRange"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_16_0_RangeStartDateTime"" type=""TS_0"" />
            <xs:element minOccurs=""0"" name=""XCN_16_1_RangeEndDateTime"" type=""TS_1"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_17_NameAssemblyOrder"" type=""ID_444"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""XCN_84"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""XCN_0_IdNumberSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_1_FamilyName"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_1_0_Surname"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_1_1_OwnSurnamePrefix"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_1_2_OwnSurname"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_1_3_SurnamePrefixFromPartnerSpouse"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_1_4_SurnameFromPartnerSpouse"" type=""ST"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_2_GivenName"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_3_SecondAndFurtherGivenNamesOrInitialsThereof"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_4_SuffixEGJrOrIii"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_5_PrefixEGDr"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_6_DegreeEGMd"" type=""IS_84"" />
      <xs:element minOccurs=""0"" name=""XCN_7_SourceTable"" type=""IS_297"" />
      <xs:element minOccurs=""0"" name=""XCN_8_AssigningAuthority"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_8_0_NamespaceId"" type=""IS_300"" />
            <xs:element minOccurs=""0"" name=""XCN_8_1_UniversalId"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_8_2_UniversalIdType"" type=""ID_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_9_NameTypeCode"" type=""ID_200"" />
      <xs:element minOccurs=""0"" name=""XCN_10_IdentifierCheckDigit"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_11_CodeIdentifyingTheCheckDigitSchemeEmployed"" type=""ID_61"" />
      <xs:element minOccurs=""0"" name=""XCN_12_IdentifierTypeCodeIs"" type=""IS"" />
      <xs:element minOccurs=""0"" name=""XCN_13_AssigningFacility"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_13_0_NamespaceId"" type=""IS_300"" />
            <xs:element minOccurs=""0"" name=""XCN_13_1_UniversalId"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_13_2_UniversalIdType"" type=""ID_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_14_NameRepresentationCode"" type=""ID_465"" />
      <xs:element minOccurs=""0"" name=""XCN_15_NameContext"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_15_0_IdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_15_1_Text"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_15_2_NameOfCodingSystem"" type=""IS_396"" />
            <xs:element minOccurs=""0"" name=""XCN_15_3_AlternateIdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_15_4_AlternateText"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_15_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_16_NameValidityRange"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_16_0_RangeStartDateTime"" type=""TS_0"" />
            <xs:element minOccurs=""0"" name=""XCN_16_1_RangeEndDateTime"" type=""TS_1"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_17_NameAssemblyOrder"" type=""ID_444"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""XCN_188"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""XCN_0_IdNumberSt"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_1_FamilyName"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_1_0_Surname"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_1_1_OwnSurnamePrefix"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_1_2_OwnSurname"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_1_3_SurnamePrefixFromPartnerSpouse"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_1_4_SurnameFromPartnerSpouse"" type=""ST"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_2_GivenName"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_3_SecondAndFurtherGivenNamesOrInitialsThereof"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_4_SuffixEGJrOrIii"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_5_PrefixEGDr"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_6_DegreeEGMd"" type=""IS_188"" />
      <xs:element minOccurs=""0"" name=""XCN_7_SourceTable"" type=""IS_297"" />
      <xs:element minOccurs=""0"" name=""XCN_8_AssigningAuthority"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_8_0_NamespaceId"" type=""IS_300"" />
            <xs:element minOccurs=""0"" name=""XCN_8_1_UniversalId"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_8_2_UniversalIdType"" type=""ID_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_9_NameTypeCode"" type=""ID_200"" />
      <xs:element minOccurs=""0"" name=""XCN_10_IdentifierCheckDigit"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XCN_11_CodeIdentifyingTheCheckDigitSchemeEmployed"" type=""ID_61"" />
      <xs:element minOccurs=""0"" name=""XCN_12_IdentifierTypeCodeIs"" type=""IS"" />
      <xs:element minOccurs=""0"" name=""XCN_13_AssigningFacility"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_13_0_NamespaceId"" type=""IS_300"" />
            <xs:element minOccurs=""0"" name=""XCN_13_1_UniversalId"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_13_2_UniversalIdType"" type=""ID_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_14_NameRepresentationCode"" type=""ID_465"" />
      <xs:element minOccurs=""0"" name=""XCN_15_NameContext"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_15_0_IdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_15_1_Text"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_15_2_NameOfCodingSystem"" type=""IS_396"" />
            <xs:element minOccurs=""0"" name=""XCN_15_3_AlternateIdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_15_4_AlternateText"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XCN_15_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_16_NameValidityRange"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XCN_16_0_RangeStartDateTime"" type=""TS_0"" />
            <xs:element minOccurs=""0"" name=""XCN_16_1_RangeEndDateTime"" type=""TS_1"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XCN_17_NameAssemblyOrder"" type=""ID_444"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""XON"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""XON_0_OrganizationName"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XON_1_OrganizationNameTypeCode"" type=""IS_204"" />
      <xs:element minOccurs=""0"" name=""XON_2_IdNumberNm"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""XON_3_CheckDigitNm"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""XON_4_CodeIdentifyingTheCheckDigitSchemeEmployed"" type=""ID_61"" />
      <xs:element minOccurs=""0"" name=""XON_5_AssigningAuthority"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XON_5_0_NamespaceId"" type=""IS_300"" />
            <xs:element minOccurs=""0"" name=""XON_5_1_UniversalId"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XON_5_2_UniversalIdType"" type=""ID_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XON_6_IdentifierTypeCodeIs"" type=""IS"" />
      <xs:element minOccurs=""0"" name=""XON_7_AssigningFacilityId"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XON_7_0_NamespaceId"" type=""IS_300"" />
            <xs:element minOccurs=""0"" name=""XON_7_1_UniversalId"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XON_7_2_UniversalIdType"" type=""ID_301"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XON_8_NameRepresentationCode"" type=""ID_465"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""XPN"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""XPN_0_FamilyName"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XPN_0_0_Surname"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XPN_0_1_OwnSurnamePrefix"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XPN_0_2_OwnSurname"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XPN_0_3_SurnamePrefixFromPartnerSpouse"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XPN_0_4_SurnameFromPartnerSpouse"" type=""ST"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XPN_1_GivenName"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XPN_2_SecondAndFurtherGivenNamesOrInitialsThereof"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XPN_3_SuffixEGJrOrIii"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XPN_4_PrefixEGDr"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XPN_5_DegreeEGMd"" type=""IS_360"" />
      <xs:element minOccurs=""0"" name=""XPN_6_NameTypeCode"" type=""ID_200"" />
      <xs:element minOccurs=""0"" name=""XPN_7_NameRepresentationCode"" type=""ID_465"" />
      <xs:element minOccurs=""0"" name=""XPN_8_NameContext"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XPN_8_0_IdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XPN_8_1_Text"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XPN_8_2_NameOfCodingSystem"" type=""IS_396"" />
            <xs:element minOccurs=""0"" name=""XPN_8_3_AlternateIdentifierSt"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XPN_8_4_AlternateText"" type=""ST"" />
            <xs:element minOccurs=""0"" name=""XPN_8_5_NameOfAlternateCodingSystem"" type=""IS_396"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XPN_9_NameValidityRange"">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs=""0"" name=""XPN_9_0_RangeStartDateTime"" type=""TS_0"" />
            <xs:element minOccurs=""0"" name=""XPN_9_1_RangeEndDateTime"" type=""TS_1"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element minOccurs=""0"" name=""XPN_10_NameAssemblyOrder"" type=""ID_444"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""XTN"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""XTN_0_9999999999X99999CAnyText"" type=""TN"" />
      <xs:element minOccurs=""0"" name=""XTN_1_TelecommunicationUseCode"" type=""ID_201"" />
      <xs:element minOccurs=""0"" name=""XTN_2_TelecommunicationEquipmentTypeId"" type=""ID_202"" />
      <xs:element minOccurs=""0"" name=""XTN_3_EmailAddress"" type=""ST"" />
      <xs:element minOccurs=""0"" name=""XTN_4_CountryCode"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""XTN_5_AreaCityCode"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""XTN_6_PhoneNumber"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""XTN_7_Extension"" type=""NM"" />
      <xs:element minOccurs=""0"" name=""XTN_8_AnyText"" type=""ST"" />
    </xs:sequence>
  </xs:complexType>
</xs:schema>";
        
        public datatypes_24() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "HL7DefinedDataTypes";
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
