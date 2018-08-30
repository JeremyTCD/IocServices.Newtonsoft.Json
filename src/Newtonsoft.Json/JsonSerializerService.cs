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
    public class JsonSerializerService : IJsonSerializerService
    {
        private JsonSerializer _jsonSerializer;

        public JsonSerializerService()
        {
            _jsonSerializer = new JsonSerializer();
            _jsonSerializer.Error += (object sender, ErrorEventArgs e) => Error?.Invoke(sender, e);
        }

        public event EventHandler<ErrorEventArgs> Error;

        public IReferenceResolver ReferenceResolver
        {
            get
            {
                return _jsonSerializer.ReferenceResolver;
            }

            set
            {
                _jsonSerializer.ReferenceResolver = value;
            }
        }

        public SerializationBinder Binder
        {
            get
            {
                return _jsonSerializer.Binder;
            }

            set
            {
                _jsonSerializer.Binder = value;
            }
        }

        public ISerializationBinder SerializationBinder
        {
            get
            {
                return _jsonSerializer.SerializationBinder;
            }

            set
            {
                _jsonSerializer.SerializationBinder = value;
            }
        }

        public ITraceWriter TraceWriter
        {
            get
            {
                return _jsonSerializer.TraceWriter;
            }

            set
            {
                _jsonSerializer.TraceWriter = value;
            }
        }

        public IEqualityComparer EqualityComparer
        {
            get
            {
                return _jsonSerializer.EqualityComparer;
            }

            set
            {
                _jsonSerializer.EqualityComparer = value;
            }
        }

        public TypeNameHandling TypeNameHandling
        {
            get
            {
                return _jsonSerializer.TypeNameHandling;
            }

            set
            {
                _jsonSerializer.TypeNameHandling = value;
            }
        }

        public FormatterAssemblyStyle TypeNameAssemblyFormat
        {
            get
            {
                return _jsonSerializer.TypeNameAssemblyFormat;
            }

            set
            {
                _jsonSerializer.TypeNameAssemblyFormat = value;
            }
        }

        public TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
        {
            get
            {
                return _jsonSerializer.TypeNameAssemblyFormatHandling;
            }

            set
            {
                _jsonSerializer.TypeNameAssemblyFormatHandling = value;
            }
        }

        public PreserveReferencesHandling PreserveReferencesHandling
        {
            get
            {
                return _jsonSerializer.PreserveReferencesHandling;
            }

            set
            {
                _jsonSerializer.PreserveReferencesHandling = value;
            }
        }

        public ReferenceLoopHandling ReferenceLoopHandling
        {
            get
            {
                return _jsonSerializer.ReferenceLoopHandling;
            }

            set
            {
                _jsonSerializer.ReferenceLoopHandling = value;
            }
        }

        public MissingMemberHandling MissingMemberHandling
        {
            get
            {
                return _jsonSerializer.MissingMemberHandling;
            }

            set
            {
                _jsonSerializer.MissingMemberHandling = value;
            }
        }

        public NullValueHandling NullValueHandling
        {
            get
            {
                return _jsonSerializer.NullValueHandling;
            }

            set
            {
                _jsonSerializer.NullValueHandling = value;
            }
        }

        public DefaultValueHandling DefaultValueHandling
        {
            get
            {
                return _jsonSerializer.DefaultValueHandling;
            }

            set
            {
                _jsonSerializer.DefaultValueHandling = value;
            }
        }

        public ObjectCreationHandling ObjectCreationHandling
        {
            get
            {
                return _jsonSerializer.ObjectCreationHandling;
            }

            set
            {
                _jsonSerializer.ObjectCreationHandling = value;
            }
        }

        public ConstructorHandling ConstructorHandling
        {
            get
            {
                return _jsonSerializer.ConstructorHandling;
            }

            set
            {
                _jsonSerializer.ConstructorHandling = value;
            }
        }

        public MetadataPropertyHandling MetadataPropertyHandling
        {
            get
            {
                return _jsonSerializer.MetadataPropertyHandling;
            }

            set
            {
                _jsonSerializer.MetadataPropertyHandling = value;
            }
        }

        public JsonConverterCollection Converters
        {
            get
            {
                return _jsonSerializer.Converters;
            }
        }

        public IContractResolver ContractResolver
        {
            get
            {
                return _jsonSerializer.ContractResolver;
            }

            set
            {
                _jsonSerializer.ContractResolver = value;
            }
        }

        public StreamingContext Context
        {
            get
            {
                return _jsonSerializer.Context;
            }

            set
            {
                _jsonSerializer.Context = value;
            }
        }

        public Formatting Formatting
        {
            get
            {
                return _jsonSerializer.Formatting;
            }

            set
            {
                _jsonSerializer.Formatting = value;
            }
        }

        public DateFormatHandling DateFormatHandling
        {
            get
            {
                return _jsonSerializer.DateFormatHandling;
            }

            set
            {
                _jsonSerializer.DateFormatHandling = value;
            }
        }

        public DateTimeZoneHandling DateTimeZoneHandling
        {
            get
            {
                return _jsonSerializer.DateTimeZoneHandling;
            }

            set
            {
                _jsonSerializer.DateTimeZoneHandling = value;
            }
        }

        public DateParseHandling DateParseHandling
        {
            get
            {
                return _jsonSerializer.DateParseHandling;
            }

            set
            {
                _jsonSerializer.DateParseHandling = value;
            }
        }

        public FloatParseHandling FloatParseHandling
        {
            get
            {
                return _jsonSerializer.FloatParseHandling;
            }

            set
            {
                _jsonSerializer.FloatParseHandling = value;
            }
        }

        public FloatFormatHandling FloatFormatHandling
        {
            get
            {
                return _jsonSerializer.FloatFormatHandling;
            }

            set
            {
                _jsonSerializer.FloatFormatHandling = value;
            }
        }

        public StringEscapeHandling StringEscapeHandling
        {
            get
            {
                return _jsonSerializer.StringEscapeHandling;
            }

            set
            {
                _jsonSerializer.StringEscapeHandling = value;
            }
        }

        public string DateFormatString
        {
            get
            {
                return _jsonSerializer.DateFormatString;
            }

            set
            {
                _jsonSerializer.DateFormatString = value;
            }
        }

        public CultureInfo Culture
        {
            get
            {
                return _jsonSerializer.Culture;
            }

            set
            {
                _jsonSerializer.Culture = value;
            }
        }

        public int? MaxDepth
        {
            get
            {
                return _jsonSerializer.MaxDepth;
            }

            set
            {
                _jsonSerializer.MaxDepth = value;
            }
        }

        public bool CheckAdditionalContent
        {
            get
            {
                return _jsonSerializer.CheckAdditionalContent;
            }

            set
            {
                _jsonSerializer.CheckAdditionalContent = value;
            }
        }

        public JsonSerializer Create()
        {
            return JsonSerializer.Create();
        }

        public JsonSerializer Create(JsonSerializerSettings settings)
        {
            return JsonSerializer.Create(settings);
        }

        public JsonSerializer CreateDefault()
        {
            return JsonSerializer.CreateDefault();
        }

        public JsonSerializer CreateDefault(JsonSerializerSettings settings)
        {
            return JsonSerializer.CreateDefault(settings);
        }

        public void Populate(TextReader reader, object target)
        {
            _jsonSerializer.Populate(reader, target);
        }

        public void Populate(JsonReader reader, object target)
        {
            _jsonSerializer.Populate(reader, target);
        }

        public object Deserialize(JsonReader reader)
        {
            return _jsonSerializer.Deserialize(reader);
        }

        public object Deserialize(TextReader reader, Type objectType)
        {
            return _jsonSerializer.Deserialize(reader, objectType);
        }

        public T Deserialize<T>(JsonReader reader)
        {
            return _jsonSerializer.Deserialize<T>(reader);
        }

        public object Deserialize(JsonReader reader, Type objectType)
        {
            return _jsonSerializer.Deserialize(reader, objectType);
        }

        public void Serialize(TextWriter textWriter, object value)
        {
            _jsonSerializer.Serialize(textWriter, value);
        }

        public void Serialize(JsonWriter jsonWriter, object value, Type objectType)
        {
            _jsonSerializer.Serialize(jsonWriter, value, objectType);
        }

        public void Serialize(TextWriter textWriter, object value, Type objectType)
        {
            _jsonSerializer.Serialize(textWriter, value, objectType);
        }

        public void Serialize(JsonWriter jsonWriter, object value)
        {
            _jsonSerializer.Serialize(jsonWriter, value);
        }
    }
}