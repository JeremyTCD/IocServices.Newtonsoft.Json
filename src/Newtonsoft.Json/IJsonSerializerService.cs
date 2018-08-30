using System;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization;
using System.Globalization;

namespace Jering.IocServices.Newtonsoft.Json
{
    public interface IJsonSerializerService
    {
        IReferenceResolver ReferenceResolver { get; set; }
        SerializationBinder Binder { get; set; }
        ISerializationBinder SerializationBinder { get; set; }
        ITraceWriter TraceWriter { get; set; }
        IEqualityComparer EqualityComparer { get; set; }
        TypeNameHandling TypeNameHandling { get; set; }
        FormatterAssemblyStyle TypeNameAssemblyFormat { get; set; }
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
        String DateFormatString { get; set; }
        CultureInfo Culture { get; set; }
        Nullable<Int32> MaxDepth { get; set; }
        Boolean CheckAdditionalContent { get; set; }

        JsonSerializer Create();
        JsonSerializer Create(JsonSerializerSettings settings);
        JsonSerializer CreateDefault();
        JsonSerializer CreateDefault(JsonSerializerSettings settings);
        void Populate(TextReader reader, Object target);
        void Populate(JsonReader reader, Object target);
        Object Deserialize(JsonReader reader);
        Object Deserialize(TextReader reader, Type objectType);
        T Deserialize<T>(JsonReader reader);
        Object Deserialize(JsonReader reader, Type objectType);
        void Serialize(TextWriter textWriter, Object value);
        void Serialize(JsonWriter jsonWriter, Object value, Type objectType);
        void Serialize(TextWriter textWriter, Object value, Type objectType);
        void Serialize(JsonWriter jsonWriter, Object value);

        event EventHandler<ErrorEventArgs> Error;
    }
}