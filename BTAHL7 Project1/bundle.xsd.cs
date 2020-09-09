namespace BTAHL7Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://hl7.org/fhir",@"Bundle")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Bundle"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTAHL7Schemas.fhir_base", typeof(global::BTAHL7Schemas.fhir_base))]
    public sealed class bundle : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:xhtml=""http://www.w3.org/1999/xhtml"" xmlns=""http://hl7.org/fhir"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://hl7.org/fhir"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:include schemaLocation=""BTAHL7Schemas.fhir_base"" />
  <xs:annotation>
    <xs:appinfo>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""http://www.w3.org/1999/xhtml"" />
        <reference targetNamespace=""http://www.w3.org/XML/1998/namespace"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Bundle"" type=""Bundle"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A container for a collection of resources.</xs:documentation>
    </xs:annotation>
  </xs:element>
  <xs:complexType name=""Bundle"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A container for a collection of resources.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Resource"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""identifier"" type=""Identifier"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A persistent identifier for the bundle that won't change as a bundle is copied from server to server.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""type"" type=""BundleType"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Indicates the purpose of this bundle - how it is intended to be used.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""timestamp"" type=""instant"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The date/time that the bundle was assembled - i.e. when the resources were placed in the bundle.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""total"" type=""unsignedInt"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">If a set of search matches, this is the total number of entries of type 'match' across all pages in the search.  It does not include search.mode = 'include' or 'outcome' entries and it does not provide a count of the number of entries in the Bundle.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""link"" type=""Bundle.Link"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A series of links that provide context to this bundle.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""entry"" type=""Bundle.Entry"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">An entry in a bundle resource - will either contain a resource or information about a resource (transactions and history only).</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""signature"" type=""Signature"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Digital Signature - base64 encoded. XML-DSig or a JWT.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Bundle.Link"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A container for a collection of resources.</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""BackboneElement"">
        <xs:sequence>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""relation"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A name which details the functional use for this link - see [http://www.iana.org/assignments/link-relations/link-relations.xhtml#link-relations-1](http://www.iana.org/assignments/link-relations/link-relations.xhtml#link-relations-1).</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""url"" type=""uri"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The reference details for the link.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Bundle.Entry"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A container for a collection of resources.</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""BackboneElement"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""link"" type=""Bundle.Link"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">A series of links that provide context to this entry.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""fullUrl"" type=""uri"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The Absolute URL for the resource.  The fullUrl SHALL NOT disagree with the id in the resource - i.e. if the fullUrl is not a urn:uuid, the URL shall be version-independent URL consistent with the Resource.id. The fullUrl is a version independent reference to the resource. The fullUrl element SHALL have a value except that: 
* fullUrl can be empty on a POST (although it does not need to when specifying a temporary id for reference in the bundle)
* Results from operations might involve resources that are not identified.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""resource"" type=""ResourceContainer"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The Resource for the entry. The purpose/meaning of the resource is determined by the Bundle.type.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""search"" type=""Bundle.Search"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Information about the search process that lead to the creation of this entry.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""request"" type=""Bundle.Request"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Additional information about how this entry should be processed as part of a transaction or batch.  For history, it shows how the entry was processed to create the version contained in the entry.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""response"" type=""Bundle.Response"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Indicates the results of processing the corresponding 'request' entry in the batch or transaction being responded to or what the results of an operation where when returning history.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Bundle.Search"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A container for a collection of resources.</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""BackboneElement"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""mode"" type=""SearchEntryMode"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Why this entry is in the result set - whether it's included as a match or because of an _include requirement, or to convey information or warning information about the search process.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""score"" type=""decimal"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">When searching, the server's search ranking score for the entry.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Bundle.Request"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A container for a collection of resources.</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""BackboneElement"">
        <xs:sequence>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""method"" type=""HTTPVerb"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">In a transaction or batch, this is the HTTP action to be executed for this entry. In a history bundle, this indicates the HTTP action that occurred.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""url"" type=""uri"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The URL for this entry, relative to the root (the address to which the request is posted).</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ifNoneMatch"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">If the ETag values match, return a 304 Not Modified status. See the API documentation for [""Conditional Read""](http.html#cread).</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ifModifiedSince"" type=""instant"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Only perform the operation if the last updated date matches. See the API documentation for [""Conditional Read""](http.html#cread).</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ifMatch"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Only perform the operation if the Etag value matches. For more information, see the API section [""Managing Resource Contention""](http.html#concurrency).</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ifNoneExist"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">Instruct the server not to perform the create if a specified resource already exists. For further information, see the API documentation for [""Conditional Create""](http.html#ccreate). This is just the query portion of the URL - what follows the ""?"" (not including the ""?"").</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Bundle.Response"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">A container for a collection of resources.</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""BackboneElement"">
        <xs:sequence>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""status"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The status code returned by processing this entry. The status SHALL start with a 3 digit HTTP code (e.g. 404) and may contain the standard HTTP description associated with the status code.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""location"" type=""uri"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The location header created by processing this operation, populated if the operation returns a location.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""etag"" type=""string"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The Etag for the resource, if the operation for the entry produced a versioned resource (see [Resource Metadata and Versioning](http.html#versioning) and [Managing Resource Contention](http.html#concurrency)).</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""lastModified"" type=""instant"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">The date/time that the resource was modified on the server.</xs:documentation>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""outcome"" type=""ResourceContainer"">
            <xs:annotation>
              <xs:documentation xml:lang=""en"">An OperationOutcome containing hints and warnings produced as part of processing this entry in a batch or transaction.</xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""HTTPVerb-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""GET"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">GET</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""HEAD"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">HEAD</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""POST"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">POST</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PUT"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">PUT</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""DELETE"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">DELETE</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PATCH"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">PATCH</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""HTTPVerb"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">HTTP verbs (in the HTTP command line). See [HTTP rfc](https://tools.ietf.org/html/rfc7231) for details.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""HTTPVerb-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""BundleType-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""document"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Document</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""message"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Message</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""transaction"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Transaction</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""transaction-response"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Transaction Response</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""batch"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Batch</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""batch-response"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Batch Response</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""history"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">History List</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""searchset"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Search Results</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""collection"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Collection</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""BundleType"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Indicates the purpose of a bundle - how it is intended to be used.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""BundleType-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""SearchEntryMode-list"">
    <xs:restriction base=""code-primitive"">
      <xs:enumeration value=""match"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Match</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""include"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Include</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""outcome"">
        <xs:annotation>
          <xs:documentation xml:lang=""en"">Outcome</xs:documentation>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""SearchEntryMode"">
    <xs:annotation>
      <xs:documentation xml:lang=""en"">Why an entry is in the result set - whether it's included as a match or because of an _include requirement, or to convey information or warning information about the search process.</xs:documentation>
      <xs:documentation xml:lang=""en"">If the element is present, it must have either a @value, an @id, or extensions</xs:documentation>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Element"">
        <xs:attribute name=""value"" type=""SearchEntryMode-list"" use=""optional"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
</xs:schema>";
        
        public bundle() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Bundle";
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
