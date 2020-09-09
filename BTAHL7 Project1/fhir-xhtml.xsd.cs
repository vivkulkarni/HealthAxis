namespace BTAHL7Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"div", @"p", @"h1", @"h2", @"h3", @"h4", @"h5", @"h6", @"ul", @"ol", @"li", @"dl", @"dt", @"dd", @"address", @"hr", @"pre", @"blockquote", @"a", @"span", @"bdo", @"br", @"em", @"strong", @"dfn", @"code", @"samp", @"kbd", @"var", @"cite", @"abbr", @"acronym", @"q", @"sub", @"sup", @"tt", @"i", @"b", @"big", @"small", @"img", @"map", @"area", @"table", @"caption", @"thead", @"tfoot", @"tbody", @"colgroup", @"col", @"tr", @"th", @"td"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTAHL7Schemas.xml", typeof(global::BTAHL7Schemas.xml))]
    public sealed class fhir_xhtml : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://www.w3.org/1999/xhtml"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://www.w3.org/1999/xhtml"" version=""1.0"" xml:lang=""en"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""BTAHL7Schemas.xml"" namespace=""http://www.w3.org/XML/1998/namespace"" />
  <xs:annotation>
    <xs:documentation>
    XHTML 1.0 (Second Edition) Strict in XML Schema

    This is the same as HTML 4 Strict except for
    changes due to the differences between XML and SGML.

    Namespace = http://www.w3.org/1999/xhtml

    For further information, see: http://www.w3.org/TR/xhtml1

    Copyright (c) 1998-2002 W3C (MIT, INRIA, Keio),
    All Rights Reserved. 

    The DTD version is identified by the PUBLIC and SYSTEM identifiers:

    PUBLIC ""-//W3C//DTD XHTML 1.0 Strict//EN""
    SYSTEM ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd""

    _id: xhtml1-strict.xsd,v 1.2 2002/08/28 08:05:44 mimasa Exp $
    </xs:documentation>
    <xs:appinfo>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""http://www.w3.org/XML/1998/namespace"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:annotation>
    <xs:documentation>
    ================ Character mnemonic entities =========================

    XHTML entity sets are identified by the PUBLIC and SYSTEM identifiers:
  
    PUBLIC ""-//W3C//ENTITIES Latin 1 for XHTML//EN""
    SYSTEM ""http://www.w3.org/TR/xhtml1/DTD/xhtml-lat1.ent""

    PUBLIC ""-//W3C//ENTITIES Special for XHTML//EN""
    SYSTEM ""http://www.w3.org/TR/xhtml1/DTD/xhtml-special.ent""

    PUBLIC ""-//W3C//ENTITIES Symbols for XHTML//EN""
    SYSTEM ""http://www.w3.org/TR/xhtml1/DTD/xhtml-symbol.ent""
    </xs:documentation>
  </xs:annotation>
  <xs:annotation>
    <xs:documentation>
    ================== Imported Names ====================================
    </xs:documentation>
  </xs:annotation>
  <xs:simpleType name=""ContentType"">
    <xs:annotation>
      <xs:documentation>
      media type, as per [RFC2045]
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""ContentTypes"">
    <xs:annotation>
      <xs:documentation>
      comma-separated list of media types, as per [RFC2045]
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Charset"">
    <xs:annotation>
      <xs:documentation>
      a character encoding, as per [RFC2045]
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Charsets"">
    <xs:annotation>
      <xs:documentation>
      a space separated list of character encodings, as per [RFC2045]
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""LanguageCode"">
    <xs:annotation>
      <xs:documentation>
      a language code, as per [RFC3066]
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base=""xs:language"" />
  </xs:simpleType>
  <xs:simpleType name=""Character"">
    <xs:annotation>
      <xs:documentation>
      a single character, as per section 2.2 of [XML]
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base=""xs:string"">
      <xs:length value=""1"" fixed=""true"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Number"">
    <xs:annotation>
      <xs:documentation>
      one or more digits
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base=""xs:nonNegativeInteger"">
      <xs:pattern value=""[0-9]+"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""tabindexNumber"">
    <xs:annotation>
      <xs:documentation>
      tabindex attribute specifies the position of the current element
      in the tabbing order for the current document. This value must be
      a number between 0 and 32767. User agents should ignore leading zeros. 
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base=""Number"">
      <xs:minInclusive value=""0"" />
      <xs:maxInclusive value=""32767"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""LinkTypes"">
    <xs:annotation>
      <xs:documentation>
      space-separated list of link types
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base=""xs:NMTOKENS"" />
  </xs:simpleType>
  <xs:simpleType name=""MediaDesc"">
    <xs:annotation>
      <xs:documentation>
      single or comma-separated list of media descriptors
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""[^,]+(,\s*[^,]+)*"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""URI"">
    <xs:annotation>
      <xs:documentation>
      a Uniform Resource Identifier, see [RFC2396]
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base=""xs:anyURI"" />
  </xs:simpleType>
  <xs:simpleType name=""UriList"">
    <xs:annotation>
      <xs:documentation>
      a space separated list of Uniform Resource Identifiers
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Datetime"">
    <xs:annotation>
      <xs:documentation>
      date and time information. ISO date format
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base=""xs:dateTime"" />
  </xs:simpleType>
  <xs:simpleType name=""Script"">
    <xs:annotation>
      <xs:documentation>
      script expression
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""StyleSheet"">
    <xs:annotation>
      <xs:documentation>
      style sheet data
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Text"">
    <xs:annotation>
      <xs:documentation>
      used for titles etc.
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Length"">
    <xs:annotation>
      <xs:documentation>
      nn for pixels or nn% for percentage length
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""[-+]?(\d+|\d+(\.\d+)?%)"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""MultiLength"">
    <xs:annotation>
      <xs:documentation>
      pixel, percentage, or relative
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""[-+]?(\d+|\d+(\.\d+)?%)|[1-9]?(\d+)?\*"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Pixels"">
    <xs:annotation>
      <xs:documentation>
      integer representing length in pixels
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base=""xs:nonNegativeInteger"" />
  </xs:simpleType>
  <xs:annotation>
    <xs:documentation>
    these are used for image maps
    </xs:documentation>
  </xs:annotation>
  <xs:simpleType name=""Shape"">
    <xs:restriction base=""xs:token"">
      <xs:enumeration value=""rect"" />
      <xs:enumeration value=""circle"" />
      <xs:enumeration value=""poly"" />
      <xs:enumeration value=""default"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Coords"">
    <xs:annotation>
      <xs:documentation>
      comma separated list of lengths
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""[-+]?(\d+|\d+(\.\d+)?%)(,\s*[-+]?(\d+|\d+(\.\d+)?%))*"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:annotation>
    <xs:documentation>
    =================== Generic Attributes ===============================
    </xs:documentation>
  </xs:annotation>
  <xs:attributeGroup name=""coreattrs"">
    <xs:annotation>
      <xs:documentation>
      core attributes common to most elements
      id       document-wide unique id
      class    space separated list of classes
      style    associated style info
      title    advisory title/amplification
      </xs:documentation>
    </xs:annotation>
    <xs:attribute name=""id"" type=""xs:ID"" />
    <xs:attribute name=""class"" type=""xs:NMTOKENS"" />
    <xs:attribute name=""style"" type=""StyleSheet"" />
    <xs:attribute name=""title"" type=""Text"" />
  </xs:attributeGroup>
  <xs:attributeGroup name=""i18n"">
    <xs:annotation>
      <xs:documentation>
      internationalization attributes
      lang        language code (backwards compatible)
      xml:lang    language code (as per XML 1.0 spec)
      dir         direction for weak/neutral text
      </xs:documentation>
    </xs:annotation>
    <xs:attribute name=""lang"" type=""LanguageCode"" />
    <xs:attribute ref=""xml:lang"" />
    <xs:attribute name=""dir"">
      <xs:simpleType>
        <xs:restriction base=""xs:token"">
          <xs:enumeration value=""ltr"" />
          <xs:enumeration value=""rtl"" />
        </xs:restriction>
      </xs:simpleType>
    </xs:attribute>
  </xs:attributeGroup>
  <xs:attributeGroup name=""events"">
    <xs:annotation>
      <xs:documentation>
      attributes for common UI events
      onclick     a pointer button was clicked
      ondblclick  a pointer button was double clicked
      onmousedown a pointer button was pressed down
      onmouseup   a pointer button was released
      onmousemove a pointer was moved onto the element
      onmouseout  a pointer was moved away from the element
      onkeypress  a key was pressed and released
      onkeydown   a key was pressed down
      onkeyup     a key was released
      </xs:documentation>
    </xs:annotation>
  </xs:attributeGroup>
  <xs:attributeGroup name=""focus"">
    <xs:annotation>
      <xs:documentation>
      attributes for elements that can get the focus
      accesskey   accessibility key character
      tabindex    position in tabbing order
      onfocus     the element got the focus
      onblur      the element lost the focus
      </xs:documentation>
    </xs:annotation>
    <xs:attribute name=""accesskey"" type=""Character"" />
    <xs:attribute name=""tabindex"" type=""tabindexNumber"" />
  </xs:attributeGroup>
  <xs:attributeGroup name=""attrs"">
    <xs:attributeGroup ref=""coreattrs"" />
    <xs:attributeGroup ref=""i18n"" />
    <xs:attributeGroup ref=""events"" />
  </xs:attributeGroup>
  <xs:annotation>
    <xs:documentation>
    =================== Text Elements ====================================
    </xs:documentation>
  </xs:annotation>
  <xs:group name=""special.pre"">
    <xs:choice>
      <xs:element ref=""br"" />
      <xs:element ref=""span"" />
      <xs:element ref=""bdo"" />
      <xs:element ref=""map"" />
    </xs:choice>
  </xs:group>
  <xs:group name=""special"">
    <xs:choice>
      <xs:group ref=""special.pre"" />
      <xs:element ref=""img"" />
    </xs:choice>
  </xs:group>
  <xs:group name=""fontstyle"">
    <xs:choice>
      <xs:element ref=""tt"" />
      <xs:element ref=""i"" />
      <xs:element ref=""b"" />
      <xs:element ref=""big"" />
      <xs:element ref=""small"" />
    </xs:choice>
  </xs:group>
  <xs:group name=""phrase"">
    <xs:choice>
      <xs:element ref=""em"" />
      <xs:element ref=""strong"" />
      <xs:element ref=""dfn"" />
      <xs:element ref=""code"" />
      <xs:element ref=""q"" />
      <xs:element ref=""samp"" />
      <xs:element ref=""kbd"" />
      <xs:element ref=""var"" />
      <xs:element ref=""cite"" />
      <xs:element ref=""abbr"" />
      <xs:element ref=""acronym"" />
      <xs:element ref=""sub"" />
      <xs:element ref=""sup"" />
    </xs:choice>
  </xs:group>
  <xs:group name=""inline"">
    <xs:choice>
      <xs:element ref=""a"" />
      <xs:group ref=""special"" />
      <xs:group ref=""fontstyle"" />
      <xs:group ref=""phrase"" />
    </xs:choice>
  </xs:group>
  <xs:complexType name=""Inline"" mixed=""true"">
    <xs:annotation>
      <xs:documentation>
      ""Inline"" covers inline or ""text-level"" elements
      </xs:documentation>
    </xs:annotation>
    <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
      <xs:group ref=""inline"" />
    </xs:choice>
  </xs:complexType>
  <xs:annotation>
    <xs:documentation>
    ================== Block level elements ==============================
    </xs:documentation>
  </xs:annotation>
  <xs:group name=""heading"">
    <xs:choice>
      <xs:element ref=""h1"" />
      <xs:element ref=""h2"" />
      <xs:element ref=""h3"" />
      <xs:element ref=""h4"" />
      <xs:element ref=""h5"" />
      <xs:element ref=""h6"" />
    </xs:choice>
  </xs:group>
  <xs:group name=""lists"">
    <xs:choice>
      <xs:element ref=""ul"" />
      <xs:element ref=""ol"" />
      <xs:element ref=""dl"" />
    </xs:choice>
  </xs:group>
  <xs:group name=""blocktext"">
    <xs:choice>
      <xs:element ref=""pre"" />
      <xs:element ref=""hr"" />
      <xs:element ref=""blockquote"" />
      <xs:element ref=""address"" />
    </xs:choice>
  </xs:group>
  <xs:group name=""block"">
    <xs:choice>
      <xs:element ref=""p"" />
      <xs:group ref=""heading"" />
      <xs:element ref=""div"" />
      <xs:group ref=""lists"" />
      <xs:group ref=""blocktext"" />
      <xs:element ref=""table"" />
    </xs:choice>
  </xs:group>
  <xs:complexType name=""Block"">
    <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
      <xs:group ref=""block"" />
    </xs:choice>
  </xs:complexType>
  <xs:complexType name=""Flow"" mixed=""true"">
    <xs:annotation>
      <xs:documentation>
      ""Flow"" mixes block and inline and is used for list items etc.
      </xs:documentation>
    </xs:annotation>
    <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
      <xs:group ref=""block"" />
      <xs:group ref=""inline"" />
    </xs:choice>
  </xs:complexType>
  <xs:annotation>
    <xs:documentation>
    ================== Content models for exclusions =====================
    </xs:documentation>
  </xs:annotation>
  <xs:complexType name=""a.content"" mixed=""true"">
    <xs:annotation>
      <xs:documentation>
      a elements use ""Inline"" excluding a
      </xs:documentation>
    </xs:annotation>
    <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
      <xs:group ref=""special"" />
      <xs:group ref=""fontstyle"" />
      <xs:group ref=""phrase"" />
    </xs:choice>
  </xs:complexType>
  <xs:complexType name=""pre.content"" mixed=""true"">
    <xs:annotation>
      <xs:documentation>
      pre uses ""Inline"" excluding big, small, sup or sup
      </xs:documentation>
    </xs:annotation>
    <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
      <xs:element ref=""a"" />
      <xs:group ref=""fontstyle"" />
      <xs:group ref=""phrase"" />
      <xs:group ref=""special.pre"" />
    </xs:choice>
  </xs:complexType>
  <xs:annotation>
    <xs:documentation>
    ================ Document Structure ==================================
    </xs:documentation>
  </xs:annotation>
  <xs:element name=""div"">
    <xs:annotation>
      <xs:documentation>
      generic language/style container      
      </xs:documentation>
    </xs:annotation>
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Flow"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:annotation>
    <xs:documentation>
    =================== Paragraphs =======================================
    </xs:documentation>
  </xs:annotation>
  <xs:element name=""p"">
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Inline"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:annotation>
    <xs:documentation>
    =================== Headings =========================================

    There are six levels of headings from h1 (the most important)
    to h6 (the least important).
    </xs:documentation>
  </xs:annotation>
  <xs:element name=""h1"">
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Inline"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""h2"">
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Inline"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""h3"">
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Inline"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""h4"">
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Inline"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""h5"">
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Inline"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""h6"">
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Inline"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:annotation>
    <xs:documentation>
    =================== Lists ============================================
    </xs:documentation>
  </xs:annotation>
  <xs:element name=""ul"">
    <xs:annotation>
      <xs:documentation>
      Unordered list
      </xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" ref=""li"" />
      </xs:sequence>
      <xs:attributeGroup ref=""attrs"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""ol"">
    <xs:annotation>
      <xs:documentation>
      Ordered (numbered) list
      </xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" ref=""li"" />
      </xs:sequence>
      <xs:attributeGroup ref=""attrs"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""li"">
    <xs:annotation>
      <xs:documentation>
      list item
      </xs:documentation>
    </xs:annotation>
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Flow"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:annotation>
    <xs:documentation>
    definition lists - dt for term, dd for its definition
    </xs:documentation>
  </xs:annotation>
  <xs:element name=""dl"">
    <xs:complexType>
      <xs:choice maxOccurs=""unbounded"">
        <xs:element ref=""dt"" />
        <xs:element ref=""dd"" />
      </xs:choice>
      <xs:attributeGroup ref=""attrs"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""dt"">
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Inline"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""dd"">
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Flow"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:annotation>
    <xs:documentation>
    =================== Address ==========================================
    </xs:documentation>
  </xs:annotation>
  <xs:element name=""address"">
    <xs:annotation>
      <xs:documentation>
      information on author
      </xs:documentation>
    </xs:annotation>
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Inline"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:annotation>
    <xs:documentation>
    =================== Horizontal Rule ==================================
    </xs:documentation>
  </xs:annotation>
  <xs:element name=""hr"">
    <xs:complexType>
      <xs:attributeGroup ref=""attrs"" />
    </xs:complexType>
  </xs:element>
  <xs:annotation>
    <xs:documentation>
    =================== Preformatted Text ================================
    </xs:documentation>
  </xs:annotation>
  <xs:element name=""pre"">
    <xs:annotation>
      <xs:documentation>
      content is ""Inline"" excluding ""img|object|big|small|sub|sup""
      </xs:documentation>
    </xs:annotation>
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""pre.content"">
          <xs:attributeGroup ref=""attrs"" />
          <xs:attribute fixed=""preserve"" ref=""xml:space"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:annotation>
    <xs:documentation>
    =================== Block-like Quotes ================================
    </xs:documentation>
  </xs:annotation>
  <xs:element name=""blockquote"">
    <xs:complexType>
      <xs:complexContent mixed=""false"">
        <xs:extension base=""Block"">
          <xs:attributeGroup ref=""attrs"" />
          <xs:attribute name=""cite"" type=""URI"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:annotation>
    <xs:documentation>
    ================== The Anchor Element ================================
    </xs:documentation>
  </xs:annotation>
  <xs:element name=""a"">
    <xs:annotation>
      <xs:documentation>
      content is ""Inline"" except that anchors shouldn't be nested
      </xs:documentation>
    </xs:annotation>
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""a.content"">
          <xs:attributeGroup ref=""attrs"" />
          <xs:attributeGroup ref=""focus"" />
          <xs:attribute name=""charset"" type=""Charset"" />
          <xs:attribute name=""type"" type=""ContentType"" />
          <xs:attribute name=""name"" type=""xs:NMTOKEN"" />
          <xs:attribute name=""href"" type=""URI"" />
          <xs:attribute name=""hreflang"" type=""LanguageCode"" />
          <xs:attribute name=""rel"" type=""LinkTypes"" />
          <xs:attribute name=""rev"" type=""LinkTypes"" />
          <xs:attribute default=""rect"" name=""shape"" type=""Shape"" />
          <xs:attribute name=""coords"" type=""Coords"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:annotation>
    <xs:documentation>
    ===================== Inline Elements ================================
    </xs:documentation>
  </xs:annotation>
  <xs:element name=""span"">
    <xs:annotation>
      <xs:documentation>
      generic language/style container
      </xs:documentation>
    </xs:annotation>
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Inline"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""bdo"">
    <xs:annotation>
      <xs:documentation>
      I18N BiDi over-ride
      </xs:documentation>
    </xs:annotation>
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Inline"">
          <xs:attributeGroup ref=""coreattrs"" />
          <xs:attributeGroup ref=""events"" />
          <xs:attribute name=""lang"" type=""LanguageCode"" />
          <xs:attribute ref=""xml:lang"" />
          <xs:attribute name=""dir"" use=""required"">
            <xs:simpleType>
              <xs:restriction base=""xs:token"">
                <xs:enumeration value=""ltr"" />
                <xs:enumeration value=""rtl"" />
              </xs:restriction>
            </xs:simpleType>
          </xs:attribute>
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""br"">
    <xs:annotation>
      <xs:documentation>
      forced line break
      </xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:attributeGroup ref=""coreattrs"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""em"">
    <xs:annotation>
      <xs:documentation>
      emphasis
      </xs:documentation>
    </xs:annotation>
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Inline"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""strong"">
    <xs:annotation>
      <xs:documentation>
      strong emphasis
      </xs:documentation>
    </xs:annotation>
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Inline"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""dfn"">
    <xs:annotation>
      <xs:documentation>
      definitional
      </xs:documentation>
    </xs:annotation>
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Inline"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""code"">
    <xs:annotation>
      <xs:documentation>
      program code
      </xs:documentation>
    </xs:annotation>
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Inline"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""samp"">
    <xs:annotation>
      <xs:documentation>
      sample
      </xs:documentation>
    </xs:annotation>
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Inline"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""kbd"">
    <xs:annotation>
      <xs:documentation>
      something user would type
      </xs:documentation>
    </xs:annotation>
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Inline"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""var"">
    <xs:annotation>
      <xs:documentation>
      variable
      </xs:documentation>
    </xs:annotation>
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Inline"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""cite"">
    <xs:annotation>
      <xs:documentation>
      citation
      </xs:documentation>
    </xs:annotation>
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Inline"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""abbr"">
    <xs:annotation>
      <xs:documentation>
      abbreviation
      </xs:documentation>
    </xs:annotation>
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Inline"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""acronym"">
    <xs:annotation>
      <xs:documentation>
      acronym
      </xs:documentation>
    </xs:annotation>
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Inline"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""q"">
    <xs:annotation>
      <xs:documentation>
      inlined quote
      </xs:documentation>
    </xs:annotation>
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Inline"">
          <xs:attributeGroup ref=""attrs"" />
          <xs:attribute name=""cite"" type=""URI"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""sub"">
    <xs:annotation>
      <xs:documentation>
      subscript
      </xs:documentation>
    </xs:annotation>
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Inline"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""sup"">
    <xs:annotation>
      <xs:documentation>
      superscript
      </xs:documentation>
    </xs:annotation>
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Inline"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""tt"">
    <xs:annotation>
      <xs:documentation>
      fixed pitch font
      </xs:documentation>
    </xs:annotation>
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Inline"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""i"">
    <xs:annotation>
      <xs:documentation>
      italic font
      </xs:documentation>
    </xs:annotation>
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Inline"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""b"">
    <xs:annotation>
      <xs:documentation>
      bold font
      </xs:documentation>
    </xs:annotation>
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Inline"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""big"">
    <xs:annotation>
      <xs:documentation>
      bigger font
      </xs:documentation>
    </xs:annotation>
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Inline"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""small"">
    <xs:annotation>
      <xs:documentation>
      smaller font
      </xs:documentation>
    </xs:annotation>
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Inline"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:annotation>
    <xs:documentation>
    =================== Images ===========================================

    To avoid accessibility problems for people who aren't
    able to see the image, you should provide a text
    description using the alt and longdesc attributes.
    In addition, avoid the use of server-side image maps.
    Note that in this DTD there is no name attribute. That
    is only available in the transitional and frameset DTD.
    </xs:documentation>
  </xs:annotation>
  <xs:element name=""img"">
    <xs:complexType>
      <xs:attributeGroup ref=""attrs"" />
      <xs:attribute name=""src"" type=""URI"" use=""required"" />
      <xs:attribute name=""alt"" type=""Text"" use=""required"" />
      <xs:attribute name=""longdesc"" type=""URI"" />
      <xs:attribute name=""height"" type=""Length"" />
      <xs:attribute name=""width"" type=""Length"" />
      <xs:attribute name=""usemap"" type=""URI"">
        <xs:annotation>
          <xs:documentation>
          usemap points to a map element which may be in this document
          or an external document, although the latter is not widely supported
          </xs:documentation>
        </xs:annotation>
      </xs:attribute>
      <xs:attribute name=""ismap"">
        <xs:simpleType>
          <xs:restriction base=""xs:token"">
            <xs:enumeration value=""ismap"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:attribute>
    </xs:complexType>
  </xs:element>
  <xs:annotation>
    <xs:documentation>
    ================== Client-side image maps ============================

    These can be placed in the same document or grouped in a
    separate document although this isn't yet widely supported
    </xs:documentation>
  </xs:annotation>
  <xs:element name=""map"">
    <xs:complexType>
      <xs:choice>
        <xs:choice maxOccurs=""unbounded"">
          <xs:group ref=""block"" />
        </xs:choice>
        <xs:element maxOccurs=""unbounded"" ref=""area"" />
      </xs:choice>
      <xs:attributeGroup ref=""i18n"" />
      <xs:attributeGroup ref=""events"" />
      <xs:attribute name=""id"" type=""xs:ID"" use=""required"" />
      <xs:attribute name=""class"" type=""xs:string"" />
      <xs:attribute name=""style"" type=""StyleSheet"" />
      <xs:attribute name=""title"" type=""Text"" />
      <xs:attribute name=""name"" type=""xs:NMTOKEN"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""area"">
    <xs:complexType>
      <xs:attributeGroup ref=""attrs"" />
      <xs:attributeGroup ref=""focus"" />
      <xs:attribute default=""rect"" name=""shape"" type=""Shape"" />
      <xs:attribute name=""coords"" type=""Coords"" />
      <xs:attribute name=""href"" type=""URI"" />
      <xs:attribute name=""nohref"">
        <xs:simpleType>
          <xs:restriction base=""xs:token"">
            <xs:enumeration value=""nohref"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:attribute>
      <xs:attribute name=""alt"" type=""Text"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:annotation>
    <xs:documentation>
    ======================= Tables =======================================

    Derived from IETF HTML table standard, see [RFC1942]
    </xs:documentation>
  </xs:annotation>
  <xs:simpleType name=""TFrame"">
    <xs:annotation>
      <xs:documentation>
      The border attribute sets the thickness of the frame around the
      table. The default units are screen pixels.

      The frame attribute specifies which parts of the frame around
      the table should be rendered. The values are not the same as
      CALS to avoid a name clash with the valign attribute.
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base=""xs:token"">
      <xs:enumeration value=""void"" />
      <xs:enumeration value=""above"" />
      <xs:enumeration value=""below"" />
      <xs:enumeration value=""hsides"" />
      <xs:enumeration value=""lhs"" />
      <xs:enumeration value=""rhs"" />
      <xs:enumeration value=""vsides"" />
      <xs:enumeration value=""box"" />
      <xs:enumeration value=""border"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""TRules"">
    <xs:annotation>
      <xs:documentation>
      The rules attribute defines which rules to draw between cells:

      If rules is absent then assume:
          ""none"" if border is absent or border=""0"" otherwise ""all""
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base=""xs:token"">
      <xs:enumeration value=""none"" />
      <xs:enumeration value=""groups"" />
      <xs:enumeration value=""rows"" />
      <xs:enumeration value=""cols"" />
      <xs:enumeration value=""all"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:attributeGroup name=""cellhalign"">
    <xs:annotation>
      <xs:documentation>
      horizontal alignment attributes for cell contents

      char        alignment char, e.g. char=':'
      charoff     offset for alignment char
      </xs:documentation>
    </xs:annotation>
    <xs:attribute name=""align"">
      <xs:simpleType>
        <xs:restriction base=""xs:token"">
          <xs:enumeration value=""left"" />
          <xs:enumeration value=""center"" />
          <xs:enumeration value=""right"" />
          <xs:enumeration value=""justify"" />
          <xs:enumeration value=""char"" />
        </xs:restriction>
      </xs:simpleType>
    </xs:attribute>
    <xs:attribute name=""char"" type=""Character"" />
    <xs:attribute name=""charoff"" type=""Length"" />
  </xs:attributeGroup>
  <xs:attributeGroup name=""cellvalign"">
    <xs:annotation>
      <xs:documentation>
      vertical alignment attributes for cell contents
      </xs:documentation>
    </xs:annotation>
    <xs:attribute name=""valign"">
      <xs:simpleType>
        <xs:restriction base=""xs:token"">
          <xs:enumeration value=""top"" />
          <xs:enumeration value=""middle"" />
          <xs:enumeration value=""bottom"" />
          <xs:enumeration value=""baseline"" />
        </xs:restriction>
      </xs:simpleType>
    </xs:attribute>
  </xs:attributeGroup>
  <xs:element name=""table"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" ref=""caption"" />
        <xs:choice>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""col"" />
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""colgroup"" />
        </xs:choice>
        <xs:element minOccurs=""0"" ref=""thead"" />
        <xs:element minOccurs=""0"" ref=""tfoot"" />
        <xs:choice>
          <xs:element maxOccurs=""unbounded"" ref=""tbody"" />
          <xs:element maxOccurs=""unbounded"" ref=""tr"" />
        </xs:choice>
      </xs:sequence>
      <xs:attributeGroup ref=""attrs"" />
      <xs:attribute name=""summary"" type=""Text"" />
      <xs:attribute name=""width"" type=""Length"" />
      <xs:attribute name=""border"" type=""Pixels"" />
      <xs:attribute name=""frame"" type=""TFrame"" />
      <xs:attribute name=""rules"" type=""TRules"" />
      <xs:attribute name=""cellspacing"" type=""Length"" />
      <xs:attribute name=""cellpadding"" type=""Length"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""caption"">
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Inline"">
          <xs:attributeGroup ref=""attrs"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:annotation>
    <xs:documentation>
    Use thead to duplicate headers when breaking table
    across page boundaries, or for static headers when
    tbody sections are rendered in scrolling panel.

    Use tfoot to duplicate footers when breaking table
    across page boundaries, or for static footers when
    tbody sections are rendered in scrolling panel.

    Use multiple tbody sections when rules are needed
    between groups of table rows.
    </xs:documentation>
  </xs:annotation>
  <xs:element name=""thead"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" ref=""tr"" />
      </xs:sequence>
      <xs:attributeGroup ref=""attrs"" />
      <xs:attributeGroup ref=""cellhalign"" />
      <xs:attributeGroup ref=""cellvalign"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""tfoot"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" ref=""tr"" />
      </xs:sequence>
      <xs:attributeGroup ref=""attrs"" />
      <xs:attributeGroup ref=""cellhalign"" />
      <xs:attributeGroup ref=""cellvalign"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""tbody"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" ref=""tr"" />
      </xs:sequence>
      <xs:attributeGroup ref=""attrs"" />
      <xs:attributeGroup ref=""cellhalign"" />
      <xs:attributeGroup ref=""cellvalign"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""colgroup"">
    <xs:annotation>
      <xs:documentation>
      colgroup groups a set of col elements. It allows you to group
      several semantically related columns together.
      </xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""col"" />
      </xs:sequence>
      <xs:attributeGroup ref=""attrs"" />
      <xs:attribute default=""1"" name=""span"" type=""Number"" />
      <xs:attribute name=""width"" type=""MultiLength"" />
      <xs:attributeGroup ref=""cellhalign"" />
      <xs:attributeGroup ref=""cellvalign"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""col"">
    <xs:annotation>
      <xs:documentation>
      col elements define the alignment properties for cells in
      one or more columns.

      The width attribute specifies the width of the columns, e.g.

          width=64        width in screen pixels
          width=0.5*      relative width of 0.5

      The span attribute causes the attributes of one
      col element to apply to more than one column.
      </xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:attributeGroup ref=""attrs"" />
      <xs:attribute default=""1"" name=""span"" type=""Number"" />
      <xs:attribute name=""width"" type=""MultiLength"" />
      <xs:attributeGroup ref=""cellhalign"" />
      <xs:attributeGroup ref=""cellvalign"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""tr"">
    <xs:complexType>
      <xs:choice maxOccurs=""unbounded"">
        <xs:element ref=""th"" />
        <xs:element ref=""td"" />
      </xs:choice>
      <xs:attributeGroup ref=""attrs"" />
      <xs:attributeGroup ref=""cellhalign"" />
      <xs:attributeGroup ref=""cellvalign"" />
    </xs:complexType>
  </xs:element>
  <xs:simpleType name=""Scope"">
    <xs:annotation>
      <xs:documentation>
      Scope is simpler than headers attribute for common tables
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base=""xs:token"">
      <xs:enumeration value=""row"" />
      <xs:enumeration value=""col"" />
      <xs:enumeration value=""rowgroup"" />
      <xs:enumeration value=""colgroup"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:annotation>
    <xs:documentation>
    th is for headers, td for data and for cells acting as both
    </xs:documentation>
  </xs:annotation>
  <xs:element name=""th"">
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Flow"">
          <xs:attributeGroup ref=""attrs"" />
          <xs:attribute name=""abbr"" type=""Text"" />
          <xs:attribute name=""axis"" type=""xs:string"" />
          <xs:attribute name=""headers"" type=""xs:IDREFS"" />
          <xs:attribute name=""scope"" type=""Scope"" />
          <xs:attribute default=""1"" name=""rowspan"" type=""Number"" />
          <xs:attribute default=""1"" name=""colspan"" type=""Number"" />
          <xs:attributeGroup ref=""cellhalign"" />
          <xs:attributeGroup ref=""cellvalign"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""td"">
    <xs:complexType mixed=""true"">
      <xs:complexContent mixed=""true"">
        <xs:extension base=""Flow"">
          <xs:attributeGroup ref=""attrs"" />
          <xs:attribute name=""abbr"" type=""Text"" />
          <xs:attribute name=""axis"" type=""xs:string"" />
          <xs:attribute name=""headers"" type=""xs:IDREFS"" />
          <xs:attribute name=""scope"" type=""Scope"" />
          <xs:attribute default=""1"" name=""rowspan"" type=""Number"" />
          <xs:attribute default=""1"" name=""colspan"" type=""Number"" />
          <xs:attributeGroup ref=""cellhalign"" />
          <xs:attributeGroup ref=""cellvalign"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public fhir_xhtml() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [53];
                _RootElements[0] = "div";
                _RootElements[1] = "p";
                _RootElements[2] = "h1";
                _RootElements[3] = "h2";
                _RootElements[4] = "h3";
                _RootElements[5] = "h4";
                _RootElements[6] = "h5";
                _RootElements[7] = "h6";
                _RootElements[8] = "ul";
                _RootElements[9] = "ol";
                _RootElements[10] = "li";
                _RootElements[11] = "dl";
                _RootElements[12] = "dt";
                _RootElements[13] = "dd";
                _RootElements[14] = "address";
                _RootElements[15] = "hr";
                _RootElements[16] = "pre";
                _RootElements[17] = "blockquote";
                _RootElements[18] = "a";
                _RootElements[19] = "span";
                _RootElements[20] = "bdo";
                _RootElements[21] = "br";
                _RootElements[22] = "em";
                _RootElements[23] = "strong";
                _RootElements[24] = "dfn";
                _RootElements[25] = "code";
                _RootElements[26] = "samp";
                _RootElements[27] = "kbd";
                _RootElements[28] = "var";
                _RootElements[29] = "cite";
                _RootElements[30] = "abbr";
                _RootElements[31] = "acronym";
                _RootElements[32] = "q";
                _RootElements[33] = "sub";
                _RootElements[34] = "sup";
                _RootElements[35] = "tt";
                _RootElements[36] = "i";
                _RootElements[37] = "b";
                _RootElements[38] = "big";
                _RootElements[39] = "small";
                _RootElements[40] = "img";
                _RootElements[41] = "map";
                _RootElements[42] = "area";
                _RootElements[43] = "table";
                _RootElements[44] = "caption";
                _RootElements[45] = "thead";
                _RootElements[46] = "tfoot";
                _RootElements[47] = "tbody";
                _RootElements[48] = "colgroup";
                _RootElements[49] = "col";
                _RootElements[50] = "tr";
                _RootElements[51] = "th";
                _RootElements[52] = "td";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"div")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"div"})]
        public sealed class div : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public div() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "div";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"p")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"p"})]
        public sealed class p : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public p() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "p";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"h1")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"h1"})]
        public sealed class h1 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public h1() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "h1";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"h2")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"h2"})]
        public sealed class h2 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public h2() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "h2";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"h3")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"h3"})]
        public sealed class h3 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public h3() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "h3";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"h4")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"h4"})]
        public sealed class h4 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public h4() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "h4";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"h5")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"h5"})]
        public sealed class h5 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public h5() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "h5";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"h6")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"h6"})]
        public sealed class h6 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public h6() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "h6";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"ul")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ul"})]
        public sealed class ul : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ul() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ul";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"ol")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ol"})]
        public sealed class ol : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ol() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ol";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"li")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"li"})]
        public sealed class li : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public li() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "li";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"dl")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"dl"})]
        public sealed class dl : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public dl() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "dl";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"dt")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"dt"})]
        public sealed class dt : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public dt() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "dt";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"dd")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"dd"})]
        public sealed class dd : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public dd() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "dd";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"address")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"address"})]
        public sealed class address : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public address() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "address";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"hr")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"hr"})]
        public sealed class hr : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public hr() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "hr";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"pre")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"pre"})]
        public sealed class pre : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public pre() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "pre";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"blockquote")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"blockquote"})]
        public sealed class blockquote : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public blockquote() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "blockquote";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"a")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"a"})]
        public sealed class a : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public a() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "a";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"span")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"span"})]
        public sealed class span : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public span() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "span";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"bdo")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"bdo"})]
        public sealed class bdo : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public bdo() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "bdo";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"br")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"br"})]
        public sealed class br : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public br() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "br";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"em")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"em"})]
        public sealed class em : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public em() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "em";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"strong")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"strong"})]
        public sealed class strong : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public strong() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "strong";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"dfn")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"dfn"})]
        public sealed class dfn : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public dfn() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "dfn";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"code")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"code"})]
        public sealed class code : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public code() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "code";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"samp")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"samp"})]
        public sealed class samp : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public samp() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "samp";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"kbd")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"kbd"})]
        public sealed class kbd : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public kbd() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "kbd";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"var")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"var"})]
        public sealed class var : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public var() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "var";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"cite")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"cite"})]
        public sealed class cite : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public cite() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "cite";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"abbr")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"abbr"})]
        public sealed class abbr : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public abbr() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "abbr";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"acronym")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"acronym"})]
        public sealed class acronym : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public acronym() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "acronym";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"q")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"q"})]
        public sealed class q : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public q() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "q";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"sub")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"sub"})]
        public sealed class sub : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public sub() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "sub";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"sup")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"sup"})]
        public sealed class sup : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public sup() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "sup";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"tt")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"tt"})]
        public sealed class tt : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public tt() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "tt";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"i")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"i"})]
        public sealed class i : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public i() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "i";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"b")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"b"})]
        public sealed class b : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public b() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "b";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"big")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"big"})]
        public sealed class big : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public big() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "big";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"small")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"small"})]
        public sealed class small : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public small() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "small";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"img")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"img"})]
        public sealed class img : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public img() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "img";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"map")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"map"})]
        public sealed class map : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public map() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "map";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"area")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"area"})]
        public sealed class area : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public area() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "area";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"table")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"table"})]
        public sealed class table : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public table() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "table";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"caption")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"caption"})]
        public sealed class caption : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public caption() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "caption";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"thead")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"thead"})]
        public sealed class thead : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public thead() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "thead";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"tfoot")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"tfoot"})]
        public sealed class tfoot : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public tfoot() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "tfoot";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"tbody")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"tbody"})]
        public sealed class tbody : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public tbody() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "tbody";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"colgroup")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"colgroup"})]
        public sealed class colgroup : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public colgroup() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "colgroup";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"col")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"col"})]
        public sealed class col : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public col() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "col";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"tr")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"tr"})]
        public sealed class tr : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public tr() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "tr";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"th")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"th"})]
        public sealed class th : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public th() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "th";
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
        
        [Schema(@"http://www.w3.org/1999/xhtml",@"td")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"td"})]
        public sealed class td : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public td() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "td";
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
}
