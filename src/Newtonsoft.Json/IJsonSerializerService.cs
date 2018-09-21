using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using ErrorEventArgs = Newtonsoft.Json.Serialization.ErrorEventArgs;

namespace Jering.IocServices.Newtonsoft.Json
{
    public interface IJsonSerializerService
    {
        IReferenceResolver ReferenceResolver { get; set; }
        ISerializationBinder SerializationBinder { get; set; }
        ITraceWriter TraceWriter { get; set; }
        IEqualityComparer EqualityComparer { get; set; }
        TypeNameHandling TypeNameHandling { get; set; }
        TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling { get; set; }
        PreserveReferencesHandling PreserveReferencesHandling { get; set; }
        ReferenceLoopHandling ReferenceLoopHandling { get; set; }
        MissingMemberHandling MissingMemberHandling { get; set; }
        NullValueHandling NullValueHandling { get; set; }
        DefaultValueHandling DefaultValueHandling { get; set; }
        ObjectCreationHandling ObjectCreationHandling { get; set; }
        ConstructorHandling ConstructorHandling { get; set; }
        MetadataPropertyHandling MetadataPropertyHandling { get; set; }
        JsonConverterCollection Converters { get; }
        IContractResolver ContractResolver { get; set; }
        StreamingContext Context { get; set; }
        Formatting Formatting { get; set; }
        DateFormatHandling DateFormatHandling { get; set; }
        DateTimeZoneHandling DateTimeZoneHandling { get; set; }
        DateParseHandling DateParseHandling { get; set; }
        FloatParseHandling FloatParseHandling { get; set; }
        FloatFormatHandling FloatFormatHandling { get; set; }
        StringEscapeHandling StringEscapeHandling { get; set; }
        string DateFormatString { get; set; }
        CultureInfo Culture { get; set; }
        int? MaxDepth { get; set; }
        bool CheckAdditionalContent { get; set; }

        JsonSerializer Create();
        JsonSerializer Create(JsonSerializerSettings settings);
        JsonSerializer CreateDefault();
        JsonSerializer CreateDefault(JsonSerializerSettings settings);
        void Populate(TextReader reader, object target);
        void Populate(JsonReader reader, object target);
        object Deserialize(JsonReader reader);
        object Deserialize(TextReader reader, Type objectType);
        T Deserialize<T>(JsonReader reader);
        object Deserialize(JsonReader reader, Type objectType);
        void Serialize(TextWriter textWriter, object value);
        void Serialize(JsonWriter jsonWriter, object value, Type objectType);
        void Serialize(TextWriter textWriter, object value, Type objectType);
        void Serialize(JsonWriter jsonWriter, object value);

        event EventHandler<ErrorEventArgs> Error;
    }
}