// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/discoveryengine/v1beta/data_store.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.DiscoveryEngine.V1Beta {

  /// <summary>Holder for reflection information generated from google/cloud/discoveryengine/v1beta/data_store.proto</summary>
  public static partial class DataStoreReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/discoveryengine/v1beta/data_store.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DataStoreReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRnb29nbGUvY2xvdWQvZGlzY292ZXJ5ZW5naW5lL3YxYmV0YS9kYXRhX3N0",
            "b3JlLnByb3RvEiNnb29nbGUuY2xvdWQuZGlzY292ZXJ5ZW5naW5lLnYxYmV0",
            "YRofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2Fw",
            "aS9yZXNvdXJjZS5wcm90bxowZ29vZ2xlL2Nsb3VkL2Rpc2NvdmVyeWVuZ2lu",
            "ZS92MWJldGEvY29tbW9uLnByb3RvGh9nb29nbGUvcHJvdG9idWYvdGltZXN0",
            "YW1wLnByb3RvIsMFCglEYXRhU3RvcmUSEQoEbmFtZRgBIAEoCUID4EEFEhkK",
            "DGRpc3BsYXlfbmFtZRgCIAEoCUID4EECElUKEWluZHVzdHJ5X3ZlcnRpY2Fs",
            "GAMgASgOMjUuZ29vZ2xlLmNsb3VkLmRpc2NvdmVyeWVuZ2luZS52MWJldGEu",
            "SW5kdXN0cnlWZXJ0aWNhbEID4EEFEkkKDnNvbHV0aW9uX3R5cGVzGAUgAygO",
            "MjEuZ29vZ2xlLmNsb3VkLmRpc2NvdmVyeWVuZ2luZS52MWJldGEuU29sdXRp",
            "b25UeXBlEh4KEWRlZmF1bHRfc2NoZW1hX2lkGAcgASgJQgPgQQMSWQoOY29u",
            "dGVudF9jb25maWcYBiABKA4yPC5nb29nbGUuY2xvdWQuZGlzY292ZXJ5ZW5n",
            "aW5lLnYxYmV0YS5EYXRhU3RvcmUuQ29udGVudENvbmZpZ0ID4EEFEjQKC2Ny",
            "ZWF0ZV90aW1lGAQgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcEID",
            "4EEDImkKDUNvbnRlbnRDb25maWcSHgoaQ09OVEVOVF9DT05GSUdfVU5TUEVD",
            "SUZJRUQQABIOCgpOT19DT05URU5UEAESFAoQQ09OVEVOVF9SRVFVSVJFRBAC",
            "EhIKDlBVQkxJQ19XRUJTSVRFEAM6yQHqQcUBCihkaXNjb3ZlcnllbmdpbmUu",
            "Z29vZ2xlYXBpcy5jb20vRGF0YVN0b3JlEj9wcm9qZWN0cy97cHJvamVjdH0v",
            "bG9jYXRpb25zL3tsb2NhdGlvbn0vZGF0YVN0b3Jlcy97ZGF0YV9zdG9yZX0S",
            "WHByb2plY3RzL3twcm9qZWN0fS9sb2NhdGlvbnMve2xvY2F0aW9ufS9jb2xs",
            "ZWN0aW9ucy97Y29sbGVjdGlvbn0vZGF0YVN0b3Jlcy97ZGF0YV9zdG9yZX1C",
            "lQIKJ2NvbS5nb29nbGUuY2xvdWQuZGlzY292ZXJ5ZW5naW5lLnYxYmV0YUIO",
            "RGF0YVN0b3JlUHJvdG9QAVpRY2xvdWQuZ29vZ2xlLmNvbS9nby9kaXNjb3Zl",
            "cnllbmdpbmUvYXBpdjFiZXRhL2Rpc2NvdmVyeWVuZ2luZXBiO2Rpc2NvdmVy",
            "eWVuZ2luZXBiogIPRElTQ09WRVJZRU5HSU5FqgIjR29vZ2xlLkNsb3VkLkRp",
            "c2NvdmVyeUVuZ2luZS5WMUJldGHKAiNHb29nbGVcQ2xvdWRcRGlzY292ZXJ5",
            "RW5naW5lXFYxYmV0YeoCJkdvb2dsZTo6Q2xvdWQ6OkRpc2NvdmVyeUVuZ2lu",
            "ZTo6VjFiZXRhYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.DiscoveryEngine.V1Beta.CommonReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DiscoveryEngine.V1Beta.DataStore), global::Google.Cloud.DiscoveryEngine.V1Beta.DataStore.Parser, new[]{ "Name", "DisplayName", "IndustryVertical", "SolutionTypes", "DefaultSchemaId", "ContentConfig", "CreateTime" }, null, new[]{ typeof(global::Google.Cloud.DiscoveryEngine.V1Beta.DataStore.Types.ContentConfig) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// DataStore captures global settings and configs at the DataStore level.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DataStore : pb::IMessage<DataStore>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DataStore> _parser = new pb::MessageParser<DataStore>(() => new DataStore());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DataStore> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.DiscoveryEngine.V1Beta.DataStoreReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DataStore() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DataStore(DataStore other) : this() {
      name_ = other.name_;
      displayName_ = other.displayName_;
      industryVertical_ = other.industryVertical_;
      solutionTypes_ = other.solutionTypes_.Clone();
      defaultSchemaId_ = other.defaultSchemaId_;
      contentConfig_ = other.contentConfig_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DataStore Clone() {
      return new DataStore(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Immutable. The full resource name of the data store.
    /// Format:
    /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}`.
    ///
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 2;
    private string displayName_ = "";
    /// <summary>
    /// Required. The data store display name.
    ///
    /// This field must be a UTF-8 encoded string with a length limit of 128
    /// characters. Otherwise, an INVALID_ARGUMENT error is returned.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "industry_vertical" field.</summary>
    public const int IndustryVerticalFieldNumber = 3;
    private global::Google.Cloud.DiscoveryEngine.V1Beta.IndustryVertical industryVertical_ = global::Google.Cloud.DiscoveryEngine.V1Beta.IndustryVertical.Unspecified;
    /// <summary>
    /// Immutable. The industry vertical that the data store registers.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.DiscoveryEngine.V1Beta.IndustryVertical IndustryVertical {
      get { return industryVertical_; }
      set {
        industryVertical_ = value;
      }
    }

    /// <summary>Field number for the "solution_types" field.</summary>
    public const int SolutionTypesFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Google.Cloud.DiscoveryEngine.V1Beta.SolutionType> _repeated_solutionTypes_codec
        = pb::FieldCodec.ForEnum(42, x => (int) x, x => (global::Google.Cloud.DiscoveryEngine.V1Beta.SolutionType) x);
    private readonly pbc::RepeatedField<global::Google.Cloud.DiscoveryEngine.V1Beta.SolutionType> solutionTypes_ = new pbc::RepeatedField<global::Google.Cloud.DiscoveryEngine.V1Beta.SolutionType>();
    /// <summary>
    /// The solutions that the data store enrolls. Available solutions for each
    /// [industry_vertical][google.cloud.discoveryengine.v1beta.DataStore.industry_vertical]:
    ///
    /// * `MEDIA`: `SOLUTION_TYPE_RECOMMENDATION` and `SOLUTION_TYPE_SEARCH`.
    /// * `SITE_SEARCH`: `SOLUTION_TYPE_SEARCH` is automatically enrolled. Other
    ///   solutions cannot be enrolled.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.DiscoveryEngine.V1Beta.SolutionType> SolutionTypes {
      get { return solutionTypes_; }
    }

    /// <summary>Field number for the "default_schema_id" field.</summary>
    public const int DefaultSchemaIdFieldNumber = 7;
    private string defaultSchemaId_ = "";
    /// <summary>
    /// Output only. The id of the default
    /// [Schema][google.cloud.discoveryengine.v1beta.Schema] asscociated to this
    /// data store.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DefaultSchemaId {
      get { return defaultSchemaId_; }
      set {
        defaultSchemaId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "content_config" field.</summary>
    public const int ContentConfigFieldNumber = 6;
    private global::Google.Cloud.DiscoveryEngine.V1Beta.DataStore.Types.ContentConfig contentConfig_ = global::Google.Cloud.DiscoveryEngine.V1Beta.DataStore.Types.ContentConfig.Unspecified;
    /// <summary>
    /// Immutable. The content config of the data store. If this field is unset,
    /// the server behavior defaults to
    /// [ContentConfig.NO_CONTENT][google.cloud.discoveryengine.v1beta.DataStore.ContentConfig.NO_CONTENT].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.DiscoveryEngine.V1Beta.DataStore.Types.ContentConfig ContentConfig {
      get { return contentConfig_; }
      set {
        contentConfig_ = value;
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. Timestamp the
    /// [DataStore][google.cloud.discoveryengine.v1beta.DataStore] was created at.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DataStore);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DataStore other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (DisplayName != other.DisplayName) return false;
      if (IndustryVertical != other.IndustryVertical) return false;
      if(!solutionTypes_.Equals(other.solutionTypes_)) return false;
      if (DefaultSchemaId != other.DefaultSchemaId) return false;
      if (ContentConfig != other.ContentConfig) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (IndustryVertical != global::Google.Cloud.DiscoveryEngine.V1Beta.IndustryVertical.Unspecified) hash ^= IndustryVertical.GetHashCode();
      hash ^= solutionTypes_.GetHashCode();
      if (DefaultSchemaId.Length != 0) hash ^= DefaultSchemaId.GetHashCode();
      if (ContentConfig != global::Google.Cloud.DiscoveryEngine.V1Beta.DataStore.Types.ContentConfig.Unspecified) hash ^= ContentConfig.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (IndustryVertical != global::Google.Cloud.DiscoveryEngine.V1Beta.IndustryVertical.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) IndustryVertical);
      }
      if (createTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CreateTime);
      }
      solutionTypes_.WriteTo(output, _repeated_solutionTypes_codec);
      if (ContentConfig != global::Google.Cloud.DiscoveryEngine.V1Beta.DataStore.Types.ContentConfig.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) ContentConfig);
      }
      if (DefaultSchemaId.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(DefaultSchemaId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (IndustryVertical != global::Google.Cloud.DiscoveryEngine.V1Beta.IndustryVertical.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) IndustryVertical);
      }
      if (createTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CreateTime);
      }
      solutionTypes_.WriteTo(ref output, _repeated_solutionTypes_codec);
      if (ContentConfig != global::Google.Cloud.DiscoveryEngine.V1Beta.DataStore.Types.ContentConfig.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) ContentConfig);
      }
      if (DefaultSchemaId.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(DefaultSchemaId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (IndustryVertical != global::Google.Cloud.DiscoveryEngine.V1Beta.IndustryVertical.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) IndustryVertical);
      }
      size += solutionTypes_.CalculateSize(_repeated_solutionTypes_codec);
      if (DefaultSchemaId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DefaultSchemaId);
      }
      if (ContentConfig != global::Google.Cloud.DiscoveryEngine.V1Beta.DataStore.Types.ContentConfig.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ContentConfig);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DataStore other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.IndustryVertical != global::Google.Cloud.DiscoveryEngine.V1Beta.IndustryVertical.Unspecified) {
        IndustryVertical = other.IndustryVertical;
      }
      solutionTypes_.Add(other.solutionTypes_);
      if (other.DefaultSchemaId.Length != 0) {
        DefaultSchemaId = other.DefaultSchemaId;
      }
      if (other.ContentConfig != global::Google.Cloud.DiscoveryEngine.V1Beta.DataStore.Types.ContentConfig.Unspecified) {
        ContentConfig = other.ContentConfig;
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            DisplayName = input.ReadString();
            break;
          }
          case 24: {
            IndustryVertical = (global::Google.Cloud.DiscoveryEngine.V1Beta.IndustryVertical) input.ReadEnum();
            break;
          }
          case 34: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 42:
          case 40: {
            solutionTypes_.AddEntriesFrom(input, _repeated_solutionTypes_codec);
            break;
          }
          case 48: {
            ContentConfig = (global::Google.Cloud.DiscoveryEngine.V1Beta.DataStore.Types.ContentConfig) input.ReadEnum();
            break;
          }
          case 58: {
            DefaultSchemaId = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            DisplayName = input.ReadString();
            break;
          }
          case 24: {
            IndustryVertical = (global::Google.Cloud.DiscoveryEngine.V1Beta.IndustryVertical) input.ReadEnum();
            break;
          }
          case 34: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 42:
          case 40: {
            solutionTypes_.AddEntriesFrom(ref input, _repeated_solutionTypes_codec);
            break;
          }
          case 48: {
            ContentConfig = (global::Google.Cloud.DiscoveryEngine.V1Beta.DataStore.Types.ContentConfig) input.ReadEnum();
            break;
          }
          case 58: {
            DefaultSchemaId = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the DataStore message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Content config of the data store.
      /// </summary>
      public enum ContentConfig {
        /// <summary>
        /// Default value.
        /// </summary>
        [pbr::OriginalName("CONTENT_CONFIG_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Only contains documents without any
        /// [Document.content][google.cloud.discoveryengine.v1beta.Document.content].
        /// </summary>
        [pbr::OriginalName("NO_CONTENT")] NoContent = 1,
        /// <summary>
        /// Only contains documents with
        /// [Document.content][google.cloud.discoveryengine.v1beta.Document.content].
        /// </summary>
        [pbr::OriginalName("CONTENT_REQUIRED")] ContentRequired = 2,
        /// <summary>
        /// The data store is used for public website search.
        /// </summary>
        [pbr::OriginalName("PUBLIC_WEBSITE")] PublicWebsite = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
