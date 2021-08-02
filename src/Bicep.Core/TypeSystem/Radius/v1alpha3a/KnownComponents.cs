// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using System.Collections.Generic;

namespace Bicep.Core.TypeSystem.Radiusv1alpha3a
{
    public static class KnownComponents
    {
        public class ComponentData
        {
            public ThreePartType Type { get; set; } = default!;

            public Dictionary<string, CommonBindings.BindingData> Bindings { get; } = new Dictionary<string, CommonBindings.BindingData>();

            public List<TypeProperty> Config { get; } = new List<TypeProperty>();

            public List<TypeProperty> Run { get; } = new List<TypeProperty>();
        }

        public static ComponentData MakeContainer()
        {
            var envType = new ObjectType(
                name: "env",
                validationFlags: TypeSymbolValidationFlags.Default,
                properties: Array.Empty<TypeProperty>(),
                additionalPropertiesType: LanguageConstants.String,
                additionalPropertiesFlags: TypePropertyFlags.None,
                functions: null);
            var envProperty = new TypeProperty("env", envType, TypePropertyFlags.None);

            var portType = new ObjectType(
                name: "port",
                validationFlags: TypeSymbolValidationFlags.Default,
                properties: new TypeProperty[]
                {
                    new TypeProperty("containerPort", LanguageConstants.Int, TypePropertyFlags.Required),
                    new TypeProperty("protocol", UnionType.Create(new StringLiteralType("TCP"), new StringLiteralType("UDP")), TypePropertyFlags.None),
                    new TypeProperty("provides", LanguageConstants.String, TypePropertyFlags.None),
                },
                additionalPropertiesType: null,
                additionalPropertiesFlags: TypePropertyFlags.None,
                functions: null);
            var portsType = new ObjectType(
                name: "ports",
                validationFlags: TypeSymbolValidationFlags.Default,
                properties: Array.Empty<TypeProperty>(),
                additionalPropertiesType: portType,
                additionalPropertiesFlags: TypePropertyFlags.None,
                functions: null);
            var portsProperty = new TypeProperty("ports", portsType, TypePropertyFlags.None);

            var imageProperty = new TypeProperty("image", LanguageConstants.String, TypePropertyFlags.Required);
            var containerType = new ObjectType(
                "container",
                validationFlags: TypeSymbolValidationFlags.WarnOnTypeMismatch,
                properties: new[]
                {
                    imageProperty,
                    envProperty,
                    portsProperty,
                },
                additionalPropertiesType: LanguageConstants.Any,
                additionalPropertiesFlags: TypePropertyFlags.None);
            var containerProperty = new TypeProperty("container", containerType, TypePropertyFlags.Required);

            return new ComponentData()
            {
                Type = new ThreePartType(null, "Container"),
                Run =
                {
                    containerProperty,
                },
            };
        }

        public static ComponentData MakeDaprStateStore()
        {
            var configKindType = UnionType.Create(
                new StringLiteralType("state.azure.tablestorage"),
                new StringLiteralType("state.sqlserver"),
                new StringLiteralType("any"));

            return new ComponentData()
            {
                Type = new ThreePartType("dapr.io", "StateStore"),
                Bindings =
                {
                    { "default", CommonBindings.BindingDataDaprStateStore },
                },
                Config =
                {
                    new TypeProperty("kind", configKindType, TypePropertyFlags.Required),
                    new TypeProperty("managed", LanguageConstants.Bool, TypePropertyFlags.None),
                    new TypeProperty("resource", LanguageConstants.String, TypePropertyFlags.None),
                },
            };
        }

        public static ComponentData MakeDaprPubSubTopic()
        {
            var configKindType = UnionType.Create(new StringLiteralType("pubsub.azure.servicebus"), new StringLiteralType("any"));

            return new ComponentData()
            {
                Type = new ThreePartType("dapr.io", "PubSubTopic"),
                Bindings =
                {
                    { "default", CommonBindings.BindingDataDaprPubSubTopic },
                },
                Config =
                {
                    new TypeProperty("kind", configKindType, TypePropertyFlags.Required),
                    new TypeProperty("managed", LanguageConstants.Bool, TypePropertyFlags.None),
                    new TypeProperty("resource", LanguageConstants.String, TypePropertyFlags.None),
                    new TypeProperty("topic", LanguageConstants.String, TypePropertyFlags.None),
                },
            };
        }

        public static ComponentData MakeServiceBusQueue()
        {
            return new ComponentData()
            {
                Type = new ThreePartType("azure.com", "ServiceBusQueue"),
                Bindings =
                {
                    { "default", CommonBindings.BindingDataServiceBusQueue }
                },
                Config =
                {
                    new TypeProperty("managed", LanguageConstants.Bool, TypePropertyFlags.None),
                    new TypeProperty("resource", LanguageConstants.String, TypePropertyFlags.None),
                    new TypeProperty("queue", LanguageConstants.String, TypePropertyFlags.None),
                },
            };
        }

        public static ComponentData MakeRedis()
        {
            return new ComponentData()
            {
                Type = new ThreePartType("redislabs.com", "Redis"),
                Bindings =
                {
                    { "default", CommonBindings.BindingDataRedis },
                },
                Config =
                {
                    new TypeProperty("managed", LanguageConstants.Bool, TypePropertyFlags.None),
                    new TypeProperty("resource", LanguageConstants.String, TypePropertyFlags.None),
                },
            };
        }

        public static ComponentData MakeCosmosDBMongo()
        {
            return new ComponentData()
            {
                Type = new ThreePartType("azure.com", "CosmosDBMongo"),
                Bindings =
                {
                    { "mongo", CommonBindings.BindingDataMongo },
                    { "cosmos", CommonBindings.BindingDataCosmosMongo },
                },
                Config =
                {
                    new TypeProperty("managed", LanguageConstants.Bool, TypePropertyFlags.None),
                    new TypeProperty("resource", LanguageConstants.String, TypePropertyFlags.None),
                },
            };
        }

        public static ComponentData MakeCosmosDBSQL()
        {
            return new ComponentData()
            {
                Type = new ThreePartType("azure.com", "CosmosDBSQL"),
                Bindings =
                {
                    { "sql", CommonBindings.BindingDataSQL },
                    { "cosmos", CommonBindings.BindingDataCosmosSQL },
                },
                Config =
                {
                    new TypeProperty("managed", LanguageConstants.Bool, TypePropertyFlags.None),
                    new TypeProperty("resource", LanguageConstants.String, TypePropertyFlags.None),
                },
            };
        }

        public static ComponentData MakeKeyVault()
        {
            return new ComponentData()
            {
                Type = new ThreePartType("azure.com", "KeyVault"),
                Bindings =
                {
                    { "default", CommonBindings.BindingDataKeyVault },
                },
                Config =
                {
                    new TypeProperty("managed", LanguageConstants.Bool, TypePropertyFlags.None),
                    new TypeProperty("resource", LanguageConstants.String, TypePropertyFlags.None),
                },
            };
        }

        public static ComponentData MakeMongoDB()
        {
            return new ComponentData()
            {
                Type = new ThreePartType("mongodb.com", "Mongo"),
                Bindings =
                {
                    { "mongo", CommonBindings.BindingDataMongo },
                },
                Config =
                {
                    new TypeProperty("managed", LanguageConstants.Bool, TypePropertyFlags.None),
                    new TypeProperty("resource", LanguageConstants.String, TypePropertyFlags.None),
                },
            };
        }
    }
}
