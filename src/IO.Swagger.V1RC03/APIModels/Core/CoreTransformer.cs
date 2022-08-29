﻿using AasCore.Aas3_0_RC02;
using Extenstions;
using IO.Swagger.V1RC03.APIModels.ValueOnly;
using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using static AasCore.Aas3_0_RC02.Jsonization;
using static AasCore.Aas3_0_RC02.Visitation;

namespace IO.Swagger.V1RC03.APIModels.Core
{
    internal class CoreTransformer : ITransformerWithContext<OutputModifierContext, JsonObject>
    {
        private static readonly ValueTransformer _valueTransformer = new();
        public JsonObject Transform(Extension that, OutputModifierContext context)
        {
            var result = new JsonObject();

            if (that.SemanticId != null)
            {
                result["semanticId"] = Transform(that.SemanticId, context);
            }

            if (that.SupplementalSemanticIds != null)
            {
                var arraySupplementalSemanticIds = new JsonArray();
                foreach (Reference item in that.SupplementalSemanticIds)
                {
                    arraySupplementalSemanticIds.Add(Transform(item, context));
                }
                result["supplementalSemanticIds"] = arraySupplementalSemanticIds;
            }

            result["name"] = JsonValue.Create(that.Name);

            if (that.ValueType != null)
            {
                // We need to help the static analyzer with a null coalescing.
                DataTypeDefXsd value = that.ValueType
                    ?? throw new System.InvalidOperationException();
                result["valueType"] = Serialize.DataTypeDefXsdToJsonValue(
                    value);
            }

            if (that.Value != null)
            {
                result["value"] = JsonValue.Create(
                    that.Value);
            }

            if (that.RefersTo != null)
            {
                result["refersTo"] = Transform(
                    that.RefersTo, context);
            }

            return result;
        }

        public JsonObject Transform(AdministrativeInformation that, OutputModifierContext context)
        {
            var result = new JsonObject();

            if (that.DataSpecifications != null)
            {
                var arrayDataSpecifications = new JsonArray();
                foreach (Reference item in that.DataSpecifications)
                {
                    arrayDataSpecifications.Add(
                        Transform(
                            item, context));
                }
                result["dataSpecifications"] = arrayDataSpecifications;
            }

            if (that.Version != null)
            {
                result["version"] = JsonValue.Create(
                    that.Version);
            }

            if (that.Revision != null)
            {
                result["revision"] = JsonValue.Create(
                    that.Revision);
            }

            return result;
        }

        public JsonObject Transform(Qualifier that, OutputModifierContext context)
        {
            var result = new JsonObject();

            if (that.SemanticId != null)
            {
                result["semanticId"] = Transform(
                    that.SemanticId, context);
            }

            if (that.SupplementalSemanticIds != null)
            {
                var arraySupplementalSemanticIds = new JsonArray();
                foreach (Reference item in that.SupplementalSemanticIds)
                {
                    arraySupplementalSemanticIds.Add(
                        Transform(
                            item, context));
                }
                result["supplementalSemanticIds"] = arraySupplementalSemanticIds;
            }

            if (that.Kind != null)
            {
                // We need to help the static analyzer with a null coalescing.
                QualifierKind value = that.Kind
                    ?? throw new System.InvalidOperationException();
                result["kind"] = Serialize.QualifierKindToJsonValue(
                    value);
            }

            result["type"] = JsonValue.Create(
                that.Type);

            result["valueType"] = Serialize.DataTypeDefXsdToJsonValue(
                that.ValueType);

            if (that.Value != null)
            {
                result["value"] = JsonValue.Create(
                    that.Value);
            }

            if (that.ValueId != null)
            {
                result["valueId"] = Transform(
                    that.ValueId, context);
            }

            return result;
        }

        public JsonObject Transform(AssetAdministrationShell that, OutputModifierContext context)
        {
            if (context.Content.Equals("reference", StringComparison.OrdinalIgnoreCase))
            {
                var reference = that.GetReference();

                return Transform(reference, context);
            }
            var result = new JsonObject();

            if (that.Extensions != null)
            {
                var arrayExtensions = new JsonArray();
                foreach (Extension item in that.Extensions)
                {
                    arrayExtensions.Add(
                        Transform(
                            item, context));
                }
                result["extensions"] = arrayExtensions;
            }

            if (that.Category != null)
            {
                result["category"] = JsonValue.Create(
                    that.Category);
            }

            if (that.IdShort != null)
            {
                result["idShort"] = JsonValue.Create(
                    that.IdShort);
            }

            if (that.DisplayName != null)
            {
                result["displayName"] = Transform(
                    that.DisplayName, context);
            }

            if (that.Description != null)
            {
                result["description"] = Transform(
                    that.Description, context);
            }

            if (that.Checksum != null)
            {
                result["checksum"] = JsonValue.Create(
                    that.Checksum);
            }

            if (that.Administration != null)
            {
                result["administration"] = Transform(
                    that.Administration, context);
            }

            result["id"] = JsonValue.Create(
                that.Id);

            if (that.DataSpecifications != null)
            {
                var arrayDataSpecifications = new JsonArray();
                foreach (Reference item in that.DataSpecifications)
                {
                    arrayDataSpecifications.Add(
                        Transform(
                            item, context));
                }
                result["dataSpecifications"] = arrayDataSpecifications;
            }

            if (that.DerivedFrom != null)
            {
                result["derivedFrom"] = Transform(
                    that.DerivedFrom, context);
            }

            if (!context.Content.Equals("metadata", StringComparison.OrdinalIgnoreCase))
            {
                result["assetInformation"] = Transform(
                        that.AssetInformation, context);

                if (that.Submodels != null)
                {
                    var arraySubmodels = new JsonArray();
                    foreach (Reference item in that.Submodels)
                    {
                        arraySubmodels.Add(
                            Transform(
                                item, context));
                    }
                    result["submodels"] = arraySubmodels;
                }
            }

            result["modelType"] = "AssetAdministrationShell";

            return result;
        }

        public JsonObject Transform(AssetInformation that, OutputModifierContext context)
        {
            var result = new JsonObject();

            result["assetKind"] = Serialize.AssetKindToJsonValue(
                that.AssetKind);

            if (that.GlobalAssetId != null)
            {
                result["globalAssetId"] = Transform(
                    that.GlobalAssetId, context);
            }

            if (that.SpecificAssetIds != null)
            {
                var arraySpecificAssetIds = new JsonArray();
                foreach (SpecificAssetId item in that.SpecificAssetIds)
                {
                    arraySpecificAssetIds.Add(
                        Transform(
                            item, context));
                }
                result["specificAssetIds"] = arraySpecificAssetIds;
            }

            if (that.DefaultThumbnail != null)
            {
                result["defaultThumbnail"] = Transform(
                    that.DefaultThumbnail, context);
            }

            return result;
        }

        public JsonObject Transform(Resource that, OutputModifierContext context)
        {
            var result = new JsonObject();

            result["path"] = JsonValue.Create(
                that.Path);

            if (that.ContentType != null)
            {
                result["contentType"] = JsonValue.Create(
                    that.ContentType);
            }

            return result;
        }

        public JsonObject Transform(SpecificAssetId that, OutputModifierContext context)
        {
            var result = new JsonObject();

            if (that.SemanticId != null)
            {
                result["semanticId"] = Transform(
                    that.SemanticId, context);
            }

            if (that.SupplementalSemanticIds != null)
            {
                var arraySupplementalSemanticIds = new JsonArray();
                foreach (Reference item in that.SupplementalSemanticIds)
                {
                    arraySupplementalSemanticIds.Add(
                        Transform(
                            item, context));
                }
                result["supplementalSemanticIds"] = arraySupplementalSemanticIds;
            }

            result["name"] = JsonValue.Create(
                that.Name);

            result["value"] = JsonValue.Create(
                that.Value);

            result["externalSubjectId"] = Transform(
                that.ExternalSubjectId, context);

            return result;
        }

        public JsonObject Transform(Submodel that, OutputModifierContext context)
        {
            //if content is reference
            if (context.Content.Equals("reference", StringComparison.OrdinalIgnoreCase))
            {
                var reference = that.GetReference();
                return Transform(reference, context);
            }
            //if content is Value
            if (context.Content.Equals("value", StringComparison.OrdinalIgnoreCase))
            {
                var valueOnlyResult = new JsonObject();
                if (that.SubmodelElements != null)
                {
                    foreach (ISubmodelElement item in that.SubmodelElements)
                    {
                        if (item is Property property)
                        {
                            valueOnlyResult[item.IdShort] = JsonValue.Create(property.Value);
                        }
                        else if (item is MultiLanguageProperty multiLanguageProperty)
                        {
                            valueOnlyResult[item.IdShort] = _valueTransformer.TransformValue(multiLanguageProperty.Value, context);
                        }
                        else
                        {
                            valueOnlyResult[item.IdShort] = _valueTransformer.Transform(item, context);
                        }
                    }
                }

                return valueOnlyResult;
            }

            var result = new JsonObject();

            if (that.Extensions != null)
            {
                var arrayExtensions = new JsonArray();
                foreach (Extension item in that.Extensions)
                {
                    arrayExtensions.Add(
                        Transform(
                            item, context));
                }
                result["extensions"] = arrayExtensions;
            }

            if (that.Category != null)
            {
                result["category"] = JsonValue.Create(
                    that.Category);
            }

            if (that.IdShort != null)
            {
                result["idShort"] = JsonValue.Create(
                    that.IdShort);
            }

            if (that.DisplayName != null)
            {
                result["displayName"] = Transform(
                    that.DisplayName, context);
            }

            if (that.Description != null)
            {
                result["description"] = Transform(
                    that.Description, context);
            }

            if (that.Checksum != null)
            {
                result["checksum"] = JsonValue.Create(
                    that.Checksum);
            }

            if (that.Administration != null)
            {
                result["administration"] = Transform(
                    that.Administration, context);
            }

            result["id"] = JsonValue.Create(
                that.Id);

            if (that.Kind != null)
            {
                // We need to help the static analyzer with a null coalescing.
                ModelingKind value = that.Kind
                    ?? throw new System.InvalidOperationException();
                result["kind"] = Serialize.ModelingKindToJsonValue(
                    value);
            }

            if (that.SemanticId != null)
            {
                result["semanticId"] = Transform(
                    that.SemanticId, context);
            }

            if (that.SupplementalSemanticIds != null)
            {
                var arraySupplementalSemanticIds = new JsonArray();
                foreach (Reference item in that.SupplementalSemanticIds)
                {
                    arraySupplementalSemanticIds.Add(
                        Transform(
                            item, context));
                }
                result["supplementalSemanticIds"] = arraySupplementalSemanticIds;
            }

            if (that.Qualifiers != null)
            {
                var arrayQualifiers = new JsonArray();
                foreach (Qualifier item in that.Qualifiers)
                {
                    arrayQualifiers.Add(
                        Transform(
                            item, context));
                }
                result["qualifiers"] = arrayQualifiers;
            }

            if (that.DataSpecifications != null)
            {
                var arrayDataSpecifications = new JsonArray();
                foreach (Reference item in that.DataSpecifications)
                {
                    arrayDataSpecifications.Add(
                        Transform(
                            item, context));
                }
                result["dataSpecifications"] = arrayDataSpecifications;
            }

            if (that.SubmodelElements != null)
            {
                if (context.IncludeChildren)
                {
                    if (context.Level.Equals("core", StringComparison.OrdinalIgnoreCase))
                    {
                        context.IncludeChildren = false;    //This will be set for indirect children
                    }
                    var arraySubmodelElements = new JsonArray();
                    foreach (ISubmodelElement item in that.SubmodelElements)
                    {
                        arraySubmodelElements.Add(
                            Transform(
                                item, context));
                    }
                    result["submodelElements"] = arraySubmodelElements;
                }
            }

            result["modelType"] = "Submodel";

            return result;
        }

        public JsonObject Transform(RelationshipElement that, OutputModifierContext context)
        {
            if (context.Content.Equals("reference", StringComparison.OrdinalIgnoreCase))
            {
                var reference = that.GetModelReference();
                return Transform(reference, context);
            }

            //if content is Value
            if (context.Content.Equals("value", StringComparison.OrdinalIgnoreCase))
            {
                var valueOnlyResult = new JsonObject();

                valueOnlyResult[that.IdShort] = _valueTransformer.Transform(that, context);

                return valueOnlyResult;
            }

            var result = new JsonObject();

            if (that.Extensions != null)
            {
                var arrayExtensions = new JsonArray();
                foreach (Extension item in that.Extensions)
                {
                    arrayExtensions.Add(
                        Transform(
                            item, context));
                }
                result["extensions"] = arrayExtensions;
            }

            if (that.Category != null)
            {
                result["category"] = JsonValue.Create(
                    that.Category);
            }

            if (that.IdShort != null)
            {
                result["idShort"] = JsonValue.Create(
                    that.IdShort);
            }

            if (that.DisplayName != null)
            {
                result["displayName"] = Transform(
                    that.DisplayName, context);
            }

            if (that.Description != null)
            {
                result["description"] = Transform(
                    that.Description, context);
            }

            if (that.Checksum != null)
            {
                result["checksum"] = JsonValue.Create(
                    that.Checksum);
            }

            if (that.Kind != null)
            {
                // We need to help the static analyzer with a null coalescing.
                ModelingKind value = that.Kind
                    ?? throw new System.InvalidOperationException();
                result["kind"] = Serialize.ModelingKindToJsonValue(
                    value);
            }

            if (that.SemanticId != null)
            {
                result["semanticId"] = Transform(
                    that.SemanticId, context);
            }

            if (that.SupplementalSemanticIds != null)
            {
                var arraySupplementalSemanticIds = new JsonArray();
                foreach (Reference item in that.SupplementalSemanticIds)
                {
                    arraySupplementalSemanticIds.Add(
                        Transform(
                            item, context));
                }
                result["supplementalSemanticIds"] = arraySupplementalSemanticIds;
            }

            if (that.Qualifiers != null)
            {
                var arrayQualifiers = new JsonArray();
                foreach (Qualifier item in that.Qualifiers)
                {
                    arrayQualifiers.Add(
                        Transform(
                            item, context));
                }
                result["qualifiers"] = arrayQualifiers;
            }

            if (that.DataSpecifications != null)
            {
                var arrayDataSpecifications = new JsonArray();
                foreach (Reference item in that.DataSpecifications)
                {
                    arrayDataSpecifications.Add(
                        Transform(
                            item, context));
                }
                result["dataSpecifications"] = arrayDataSpecifications;
            }

            if (!string.IsNullOrEmpty(context.Content) && !context.Content.Equals("metadata", StringComparison.OrdinalIgnoreCase))
            {
                result["first"] = Transform(
                        that.First, context);

                result["second"] = Transform(
                    that.Second, context);
            }

            result["modelType"] = "RelationshipElement";

            return result;
        }

        public JsonObject Transform(SubmodelElementList that, OutputModifierContext context)
        {
            if (context.Content.Equals("reference", StringComparison.OrdinalIgnoreCase))
            {
                var reference = that.GetModelReference();
                return Transform(reference, context);
            }

            //if content is Value
            if (context.Content.Equals("value", StringComparison.OrdinalIgnoreCase))
            {
                var valueOnlyResult = new JsonObject();
                var jsonArray = new JsonArray();
                if (that.Value != null)
                {

                    foreach (ISubmodelElement item in that.Value)
                    {
                        if (item is Property property)
                        {
                            jsonArray.Add(JsonValue.Create(property.Value));
                        }
                        else if (item is MultiLanguageProperty multiLanguageProperty)
                        {
                            jsonArray.Add(_valueTransformer.TransformValue(multiLanguageProperty.Value, context));
                        }
                        else
                        {
                            jsonArray.Add(_valueTransformer.Transform(item, context));
                        }
                    }
                }
                valueOnlyResult[that.IdShort] = jsonArray;

                return valueOnlyResult;
            }
            var result = new JsonObject();

            if (that.Extensions != null)
            {
                var arrayExtensions = new JsonArray();
                foreach (Extension item in that.Extensions)
                {
                    arrayExtensions.Add(
                        Transform(
                            item, context));
                }
                result["extensions"] = arrayExtensions;
            }

            if (that.Category != null)
            {
                result["category"] = JsonValue.Create(
                    that.Category);
            }

            if (that.IdShort != null)
            {
                result["idShort"] = JsonValue.Create(
                    that.IdShort);
            }

            if (that.DisplayName != null)
            {
                result["displayName"] = Transform(
                    that.DisplayName, context);
            }

            if (that.Description != null)
            {
                result["description"] = Transform(
                    that.Description, context);
            }

            if (that.Checksum != null)
            {
                result["checksum"] = JsonValue.Create(
                    that.Checksum);
            }

            if (that.Kind != null)
            {
                // We need to help the static analyzer with a null coalescing.
                ModelingKind value = that.Kind
                    ?? throw new System.InvalidOperationException();
                result["kind"] = Serialize.ModelingKindToJsonValue(
                    value);
            }

            if (that.SemanticId != null)
            {
                result["semanticId"] = Transform(
                    that.SemanticId, context);
            }

            if (that.SupplementalSemanticIds != null)
            {
                var arraySupplementalSemanticIds = new JsonArray();
                foreach (Reference item in that.SupplementalSemanticIds)
                {
                    arraySupplementalSemanticIds.Add(
                        Transform(
                            item, context));
                }
                result["supplementalSemanticIds"] = arraySupplementalSemanticIds;
            }

            if (that.Qualifiers != null)
            {
                var arrayQualifiers = new JsonArray();
                foreach (Qualifier item in that.Qualifiers)
                {
                    arrayQualifiers.Add(
                        Transform(
                            item, context));
                }
                result["qualifiers"] = arrayQualifiers;
            }

            if (that.DataSpecifications != null)
            {
                var arrayDataSpecifications = new JsonArray();
                foreach (Reference item in that.DataSpecifications)
                {
                    arrayDataSpecifications.Add(
                        Transform(
                            item, context));
                }
                result["dataSpecifications"] = arrayDataSpecifications;
            }

            if (that.OrderRelevant != null)
            {
                result["orderRelevant"] = JsonValue.Create(
                    that.OrderRelevant);
            }
            if (that.Value != null)
            {
                if (context.IncludeChildren)
                {
                    if (!context.Level.Equals("core", StringComparison.OrdinalIgnoreCase))
                    {
                        context.IncludeChildren = false;
                    }
                    var arrayValue = new JsonArray();
                    foreach (ISubmodelElement item in that.Value)
                    {
                        arrayValue.Add(
                            Transform(
                                item, context));
                    }
                    result["value"] = arrayValue;
                }
            }

            if (that.SemanticIdListElement != null)
            {
                result["semanticIdListElement"] = Transform(
                    that.SemanticIdListElement, context);
            }

            result["typeValueListElement"] = Serialize.AasSubmodelElementsToJsonValue(
                that.TypeValueListElement);

            if (that.ValueTypeListElement != null)
            {
                // We need to help the static analyzer with a null coalescing.
                DataTypeDefXsd value = that.ValueTypeListElement
                    ?? throw new System.InvalidOperationException();
                result["valueTypeListElement"] = Serialize.DataTypeDefXsdToJsonValue(
                    value);
            }

            result["modelType"] = "SubmodelElementList";

            return result;
        }

        public JsonObject Transform(SubmodelElementCollection that, OutputModifierContext context)
        {
            if (context.Content.Equals("reference", StringComparison.OrdinalIgnoreCase))
            {
                var reference = that.GetModelReference();
                return Transform(reference, context);
            }

            //if content is Value
            if (context.Content.Equals("value", StringComparison.OrdinalIgnoreCase))
            {
                var valueOnlyResult = new JsonObject
                {
                    [that.IdShort] = _valueTransformer.Transform(that, context)
                };
                return valueOnlyResult;
            }
            var result = new JsonObject();

            if (that.Extensions != null)
            {
                var arrayExtensions = new JsonArray();
                foreach (Extension item in that.Extensions)
                {
                    arrayExtensions.Add(
                        Transform(
                            item, context));
                }
                result["extensions"] = arrayExtensions;
            }

            if (that.Category != null)
            {
                result["category"] = JsonValue.Create(
                    that.Category);
            }

            if (that.IdShort != null)
            {
                result["idShort"] = JsonValue.Create(
                    that.IdShort);
            }

            if (that.DisplayName != null)
            {
                result["displayName"] = Transform(
                    that.DisplayName, context);
            }

            if (that.Description != null)
            {
                result["description"] = Transform(
                    that.Description, context);
            }

            if (that.Checksum != null)
            {
                result["checksum"] = JsonValue.Create(
                    that.Checksum);
            }

            if (that.Kind != null)
            {
                // We need to help the static analyzer with a null coalescing.
                ModelingKind value = that.Kind
                    ?? throw new System.InvalidOperationException();
                result["kind"] = Serialize.ModelingKindToJsonValue(
                    value);
            }

            if (that.SemanticId != null)
            {
                result["semanticId"] = Transform(
                    that.SemanticId, context);
            }

            if (that.SupplementalSemanticIds != null)
            {
                var arraySupplementalSemanticIds = new JsonArray();
                foreach (Reference item in that.SupplementalSemanticIds)
                {
                    arraySupplementalSemanticIds.Add(
                        Transform(
                            item, context));
                }
                result["supplementalSemanticIds"] = arraySupplementalSemanticIds;
            }

            if (that.Qualifiers != null)
            {
                var arrayQualifiers = new JsonArray();
                foreach (Qualifier item in that.Qualifiers)
                {
                    arrayQualifiers.Add(
                        Transform(
                            item, context));
                }
                result["qualifiers"] = arrayQualifiers;
            }

            if (that.DataSpecifications != null)
            {
                var arrayDataSpecifications = new JsonArray();
                foreach (Reference item in that.DataSpecifications)
                {
                    arrayDataSpecifications.Add(
                        Transform(
                            item, context));
                }
                result["dataSpecifications"] = arrayDataSpecifications;
            }

            if (that.Value != null)
            {
                if (context.IncludeChildren)
                {
                    if (context.Level.Equals("core", StringComparison.OrdinalIgnoreCase))
                    {
                        context.IncludeChildren = false;
                    }
                    var arrayValue = new JsonArray();
                    foreach (ISubmodelElement item in that.Value)
                    {
                        arrayValue.Add(
                            Transform(
                                item, context));
                    }
                    result["value"] = arrayValue;
                }
            }

            result["modelType"] = "SubmodelElementCollection";

            return result;
        }

        public JsonObject Transform(Property that, OutputModifierContext context)
        {
            if (context.Content.Equals("reference", StringComparison.OrdinalIgnoreCase))
            {
                var reference = that.GetModelReference();
                return Transform(reference, context);
            }
            //if content is Value
            if (context.Content.Equals("value", StringComparison.OrdinalIgnoreCase))
            {
                var valueOnlyResult = new JsonObject();

                valueOnlyResult[that.IdShort] = JsonValue.Create(that.Value);

                return valueOnlyResult;
            }

            var result = new JsonObject();

            if (that.Extensions != null)
            {
                var arrayExtensions = new JsonArray();
                foreach (Extension item in that.Extensions)
                {
                    arrayExtensions.Add(
                        Transform(
                            item, context));
                }
                result["extensions"] = arrayExtensions;
            }

            if (that.Category != null)
            {
                result["category"] = JsonValue.Create(
                    that.Category);
            }

            if (that.IdShort != null)
            {
                result["idShort"] = JsonValue.Create(
                    that.IdShort);
            }

            if (that.DisplayName != null)
            {
                result["displayName"] = Transform(
                    that.DisplayName, context);
            }

            if (that.Description != null)
            {
                result["description"] = Transform(
                    that.Description, context);
            }

            if (that.Checksum != null)
            {
                result["checksum"] = JsonValue.Create(
                    that.Checksum);
            }

            if (that.Kind != null)
            {
                // We need to help the static analyzer with a null coalescing.
                ModelingKind value = that.Kind
                    ?? throw new System.InvalidOperationException();
                result["kind"] = Serialize.ModelingKindToJsonValue(
                    value);
            }

            if (that.SemanticId != null)
            {
                result["semanticId"] = Transform(
                    that.SemanticId, context);
            }

            if (that.SupplementalSemanticIds != null)
            {
                var arraySupplementalSemanticIds = new JsonArray();
                foreach (Reference item in that.SupplementalSemanticIds)
                {
                    arraySupplementalSemanticIds.Add(
                        Transform(
                            item, context));
                }
                result["supplementalSemanticIds"] = arraySupplementalSemanticIds;
            }

            if (that.Qualifiers != null)
            {
                var arrayQualifiers = new JsonArray();
                foreach (Qualifier item in that.Qualifiers)
                {
                    arrayQualifiers.Add(
                        Transform(
                            item, context));
                }
                result["qualifiers"] = arrayQualifiers;
            }

            if (that.DataSpecifications != null)
            {
                var arrayDataSpecifications = new JsonArray();
                foreach (Reference item in that.DataSpecifications)
                {
                    arrayDataSpecifications.Add(
                        Transform(
                            item, context));
                }
                result["dataSpecifications"] = arrayDataSpecifications;
            }

            result["valueType"] = Serialize.DataTypeDefXsdToJsonValue(
                that.ValueType);

            if (!string.IsNullOrEmpty(context.Content) && !context.Content.Equals("metadata", StringComparison.OrdinalIgnoreCase))
            {
                if (that.Value != null)
                {
                    result["value"] = JsonValue.Create(
                        that.Value);
                }

                if (that.ValueId != null)
                {
                    result["valueId"] = Transform(
                        that.ValueId, context);
                }
            }

            result["modelType"] = "Property";

            return result;
        }

        public JsonObject Transform(MultiLanguageProperty that, OutputModifierContext context)
        {
            if (context.Content.Equals("reference", StringComparison.OrdinalIgnoreCase))
            {
                var reference = that.GetModelReference();
                return Transform(reference, context);
            }
            //if content is Value
            if (context.Content.Equals("value", StringComparison.OrdinalIgnoreCase))
            {
                var valueOnlyResult = new JsonObject();

                valueOnlyResult[that.IdShort] = _valueTransformer.TransformValue(that.Value, context);

                return valueOnlyResult;
            }

            var result = new JsonObject();

            if (that.Extensions != null)
            {
                var arrayExtensions = new JsonArray();
                foreach (Extension item in that.Extensions)
                {
                    arrayExtensions.Add(
                        Transform(
                            item, context));
                }
                result["extensions"] = arrayExtensions;
            }

            if (that.Category != null)
            {
                result["category"] = JsonValue.Create(
                    that.Category);
            }

            if (that.IdShort != null)
            {
                result["idShort"] = JsonValue.Create(
                    that.IdShort);
            }

            if (that.DisplayName != null)
            {
                result["displayName"] = Transform(
                    that.DisplayName, context);
            }

            if (that.Description != null)
            {
                result["description"] = Transform(
                    that.Description, context);
            }

            if (that.Checksum != null)
            {
                result["checksum"] = JsonValue.Create(
                    that.Checksum);
            }

            if (that.Kind != null)
            {
                // We need to help the static analyzer with a null coalescing.
                ModelingKind value = that.Kind
                    ?? throw new System.InvalidOperationException();
                result["kind"] = Serialize.ModelingKindToJsonValue(
                    value);
            }

            if (that.SemanticId != null)
            {
                result["semanticId"] = Transform(
                    that.SemanticId, context);
            }

            if (that.SupplementalSemanticIds != null)
            {
                var arraySupplementalSemanticIds = new JsonArray();
                foreach (Reference item in that.SupplementalSemanticIds)
                {
                    arraySupplementalSemanticIds.Add(
                        Transform(
                            item, context));
                }
                result["supplementalSemanticIds"] = arraySupplementalSemanticIds;
            }

            if (that.Qualifiers != null)
            {
                var arrayQualifiers = new JsonArray();
                foreach (Qualifier item in that.Qualifiers)
                {
                    arrayQualifiers.Add(
                        Transform(
                            item, context));
                }
                result["qualifiers"] = arrayQualifiers;
            }

            if (that.DataSpecifications != null)
            {
                var arrayDataSpecifications = new JsonArray();
                foreach (Reference item in that.DataSpecifications)
                {
                    arrayDataSpecifications.Add(
                        Transform(
                            item, context));
                }
                result["dataSpecifications"] = arrayDataSpecifications;
            }

            if (!string.IsNullOrEmpty(context.Content) && !context.Content.Equals("metadata", StringComparison.OrdinalIgnoreCase))
            {
                if (that.Value != null)
                {
                    result["value"] = Transform(
                        that.Value, context);
                }

                if (that.ValueId != null)
                {
                    result["valueId"] = Transform(
                        that.ValueId, context);
                }
            }

            result["modelType"] = "MultiLanguageProperty";

            return result;
        }

        public JsonObject Transform(AasCore.Aas3_0_RC02.Range that, OutputModifierContext context)
        {
            if (context.Content.Equals("reference", StringComparison.OrdinalIgnoreCase))
            {
                var reference = that.GetModelReference();
                return Transform(reference, context);
            }
            //if content is Value
            if (context.Content.Equals("value", StringComparison.OrdinalIgnoreCase))
            {
                var valueOnlyResult = new JsonObject();

                valueOnlyResult[that.IdShort] = _valueTransformer.Transform(that, context);

                return valueOnlyResult;
            }

            var result = new JsonObject();

            if (that.Extensions != null)
            {
                var arrayExtensions = new JsonArray();
                foreach (Extension item in that.Extensions)
                {
                    arrayExtensions.Add(
                        Transform(
                            item, context));
                }
                result["extensions"] = arrayExtensions;
            }

            if (that.Category != null)
            {
                result["category"] = JsonValue.Create(
                    that.Category);
            }

            if (that.IdShort != null)
            {
                result["idShort"] = JsonValue.Create(
                    that.IdShort);
            }

            if (that.DisplayName != null)
            {
                result["displayName"] = Transform(
                    that.DisplayName, context);
            }

            if (that.Description != null)
            {
                result["description"] = Transform(
                    that.Description, context);
            }

            if (that.Checksum != null)
            {
                result["checksum"] = JsonValue.Create(
                    that.Checksum);
            }

            if (that.Kind != null)
            {
                // We need to help the static analyzer with a null coalescing.
                ModelingKind value = that.Kind
                    ?? throw new System.InvalidOperationException();
                result["kind"] = Serialize.ModelingKindToJsonValue(
                    value);
            }

            if (that.SemanticId != null)
            {
                result["semanticId"] = Transform(
                    that.SemanticId, context);
            }

            if (that.SupplementalSemanticIds != null)
            {
                var arraySupplementalSemanticIds = new JsonArray();
                foreach (Reference item in that.SupplementalSemanticIds)
                {
                    arraySupplementalSemanticIds.Add(
                        Transform(
                            item, context));
                }
                result["supplementalSemanticIds"] = arraySupplementalSemanticIds;
            }

            if (that.Qualifiers != null)
            {
                var arrayQualifiers = new JsonArray();
                foreach (Qualifier item in that.Qualifiers)
                {
                    arrayQualifiers.Add(
                        Transform(
                            item, context));
                }
                result["qualifiers"] = arrayQualifiers;
            }

            if (that.DataSpecifications != null)
            {
                var arrayDataSpecifications = new JsonArray();
                foreach (Reference item in that.DataSpecifications)
                {
                    arrayDataSpecifications.Add(
                        Transform(
                            item, context));
                }
                result["dataSpecifications"] = arrayDataSpecifications;
            }

            result["valueType"] = Serialize.DataTypeDefXsdToJsonValue(
                that.ValueType);

            if (!string.IsNullOrEmpty(context.Content) && !context.Content.Equals("metadata", StringComparison.OrdinalIgnoreCase))
            {
                if (that.Min != null)
                {
                    result["min"] = JsonValue.Create(
                        that.Min);
                }

                if (that.Max != null)
                {
                    result["max"] = JsonValue.Create(
                        that.Max);
                }
            }

            result["modelType"] = "Range";

            return result;
        }

        public JsonObject Transform(ReferenceElement that, OutputModifierContext context)
        {
            if (context.Content.Equals("reference", StringComparison.OrdinalIgnoreCase))
            {
                var reference = that.GetModelReference();
                return Transform(reference, context);
            }
            //if content is Value
            if (context.Content.Equals("value", StringComparison.OrdinalIgnoreCase))
            {
                var valueOnlyResult = new JsonObject();

                valueOnlyResult[that.IdShort] = _valueTransformer.Transform(that, context);

                return valueOnlyResult;
            }

            var result = new JsonObject();

            if (that.Extensions != null)
            {
                var arrayExtensions = new JsonArray();
                foreach (Extension item in that.Extensions)
                {
                    arrayExtensions.Add(
                        Transform(
                            item, context));
                }
                result["extensions"] = arrayExtensions;
            }

            if (that.Category != null)
            {
                result["category"] = JsonValue.Create(
                    that.Category);
            }

            if (that.IdShort != null)
            {
                result["idShort"] = JsonValue.Create(
                    that.IdShort);
            }

            if (that.DisplayName != null)
            {
                result["displayName"] = Transform(
                    that.DisplayName, context);
            }

            if (that.Description != null)
            {
                result["description"] = Transform(
                    that.Description, context);
            }

            if (that.Checksum != null)
            {
                result["checksum"] = JsonValue.Create(
                    that.Checksum);
            }

            if (that.Kind != null)
            {
                // We need to help the static analyzer with a null coalescing.
                ModelingKind value = that.Kind
                    ?? throw new System.InvalidOperationException();
                result["kind"] = Serialize.ModelingKindToJsonValue(
                    value);
            }

            if (that.SemanticId != null)
            {
                result["semanticId"] = Transform(
                    that.SemanticId, context);
            }

            if (that.SupplementalSemanticIds != null)
            {
                var arraySupplementalSemanticIds = new JsonArray();
                foreach (Reference item in that.SupplementalSemanticIds)
                {
                    arraySupplementalSemanticIds.Add(
                        Transform(
                            item, context));
                }
                result["supplementalSemanticIds"] = arraySupplementalSemanticIds;
            }

            if (that.Qualifiers != null)
            {
                var arrayQualifiers = new JsonArray();
                foreach (Qualifier item in that.Qualifiers)
                {
                    arrayQualifiers.Add(
                        Transform(
                            item, context));
                }
                result["qualifiers"] = arrayQualifiers;
            }

            if (that.DataSpecifications != null)
            {
                var arrayDataSpecifications = new JsonArray();
                foreach (Reference item in that.DataSpecifications)
                {
                    arrayDataSpecifications.Add(
                        Transform(
                            item, context));
                }
                result["dataSpecifications"] = arrayDataSpecifications;
            }

            if (that.Value != null)
            {
                result["value"] = Transform(
                    that.Value, context);
            }

            result["modelType"] = "ReferenceElement";

            return result;
        }

        public JsonObject Transform(Blob that, OutputModifierContext context)
        {
            if (context.Content.Equals("reference", StringComparison.OrdinalIgnoreCase))
            {
                var reference = that.GetModelReference();
                return Transform(reference, context);
            }
            //if content is Value
            if (context.Content.Equals("value", StringComparison.OrdinalIgnoreCase))
            {
                var valueOnlyResult = new JsonObject();

                valueOnlyResult[that.IdShort] = _valueTransformer.Transform(that, context);

                return valueOnlyResult;
            }

            var result = new JsonObject();

            if (that.Extensions != null)
            {
                var arrayExtensions = new JsonArray();
                foreach (Extension item in that.Extensions)
                {
                    arrayExtensions.Add(
                        Transform(
                            item, context));
                }
                result["extensions"] = arrayExtensions;
            }

            if (that.Category != null)
            {
                result["category"] = JsonValue.Create(
                    that.Category);
            }

            if (that.IdShort != null)
            {
                result["idShort"] = JsonValue.Create(
                    that.IdShort);
            }

            if (that.DisplayName != null)
            {
                result["displayName"] = Transform(
                    that.DisplayName, context);
            }

            if (that.Description != null)
            {
                result["description"] = Transform(
                    that.Description, context);
            }

            if (that.Checksum != null)
            {
                result["checksum"] = JsonValue.Create(
                    that.Checksum);
            }

            if (that.Kind != null)
            {
                // We need to help the static analyzer with a null coalescing.
                ModelingKind value = that.Kind
                    ?? throw new System.InvalidOperationException();
                result["kind"] = Serialize.ModelingKindToJsonValue(
                    value);
            }

            if (that.SemanticId != null)
            {
                result["semanticId"] = Transform(
                    that.SemanticId, context);
            }

            if (that.SupplementalSemanticIds != null)
            {
                var arraySupplementalSemanticIds = new JsonArray();
                foreach (Reference item in that.SupplementalSemanticIds)
                {
                    arraySupplementalSemanticIds.Add(
                        Transform(
                            item, context));
                }
                result["supplementalSemanticIds"] = arraySupplementalSemanticIds;
            }

            if (that.Qualifiers != null)
            {
                var arrayQualifiers = new JsonArray();
                foreach (Qualifier item in that.Qualifiers)
                {
                    arrayQualifiers.Add(
                        Transform(
                            item, context));
                }
                result["qualifiers"] = arrayQualifiers;
            }

            if (that.DataSpecifications != null)
            {
                var arrayDataSpecifications = new JsonArray();
                foreach (Reference item in that.DataSpecifications)
                {
                    arrayDataSpecifications.Add(
                        Transform(
                            item, context));
                }
                result["dataSpecifications"] = arrayDataSpecifications;
            }

            if (!string.IsNullOrEmpty(context.Content) && !context.Content.Equals("metadata", StringComparison.OrdinalIgnoreCase))
            {
                if (that.Value != null)
                {
                    if (context.Extent.Equals("withBlobValue", StringComparison.OrdinalIgnoreCase))
                    {
                        result["value"] = JsonValue.Create(
                                       System.Convert.ToBase64String(
                                           that.Value));
                    }
                }

                result["contentType"] = JsonValue.Create(
                    that.ContentType);
            }

            result["modelType"] = "Blob";

            return result;
        }

        public JsonObject Transform(File that, OutputModifierContext context)
        {
            if (context.Content.Equals("reference", StringComparison.OrdinalIgnoreCase))
            {
                var reference = that.GetModelReference();
                return Transform(reference, context);
            }
            //if content is Value
            if (context.Content.Equals("value", StringComparison.OrdinalIgnoreCase))
            {
                var valueOnlyResult = new JsonObject();

                valueOnlyResult[that.IdShort] = _valueTransformer.Transform(that, context);

                return valueOnlyResult;
            }

            var result = new JsonObject();

            if (that.Extensions != null)
            {
                var arrayExtensions = new JsonArray();
                foreach (Extension item in that.Extensions)
                {
                    arrayExtensions.Add(
                        Transform(
                            item, context));
                }
                result["extensions"] = arrayExtensions;
            }

            if (that.Category != null)
            {
                result["category"] = JsonValue.Create(
                    that.Category);
            }

            if (that.IdShort != null)
            {
                result["idShort"] = JsonValue.Create(
                    that.IdShort);
            }

            if (that.DisplayName != null)
            {
                result["displayName"] = Transform(
                    that.DisplayName, context);
            }

            if (that.Description != null)
            {
                result["description"] = Transform(
                    that.Description, context);
            }

            if (that.Checksum != null)
            {
                result["checksum"] = JsonValue.Create(
                    that.Checksum);
            }

            if (that.Kind != null)
            {
                // We need to help the static analyzer with a null coalescing.
                ModelingKind value = that.Kind
                    ?? throw new System.InvalidOperationException();
                result["kind"] = Serialize.ModelingKindToJsonValue(
                    value);
            }

            if (that.SemanticId != null)
            {
                result["semanticId"] = Transform(
                    that.SemanticId, context);
            }

            if (that.SupplementalSemanticIds != null)
            {
                var arraySupplementalSemanticIds = new JsonArray();
                foreach (Reference item in that.SupplementalSemanticIds)
                {
                    arraySupplementalSemanticIds.Add(
                        Transform(
                            item, context));
                }
                result["supplementalSemanticIds"] = arraySupplementalSemanticIds;
            }

            if (that.Qualifiers != null)
            {
                var arrayQualifiers = new JsonArray();
                foreach (Qualifier item in that.Qualifiers)
                {
                    arrayQualifiers.Add(
                        Transform(
                            item, context));
                }
                result["qualifiers"] = arrayQualifiers;
            }

            if (that.DataSpecifications != null)
            {
                var arrayDataSpecifications = new JsonArray();
                foreach (Reference item in that.DataSpecifications)
                {
                    arrayDataSpecifications.Add(
                        Transform(
                            item, context));
                }
                result["dataSpecifications"] = arrayDataSpecifications;
            }

            if (!string.IsNullOrEmpty(context.Content) && !context.Content.Equals("metadata", StringComparison.OrdinalIgnoreCase))
            {
                if (that.Value != null)
                {
                    result["value"] = JsonValue.Create(
                        that.Value);
                }

                result["contentType"] = JsonValue.Create(
                    that.ContentType);
            }

            result["modelType"] = "File";

            return result;
        }

        public JsonObject Transform(AnnotatedRelationshipElement that, OutputModifierContext context)
        {
            if (context.Content.Equals("reference", StringComparison.OrdinalIgnoreCase))
            {
                var reference = that.GetModelReference();
                return Transform(reference, context);
            }
            //if content is Value
            if (context.Content.Equals("value", StringComparison.OrdinalIgnoreCase))
            {
                var valueOnlyResult = new JsonObject();

                valueOnlyResult[that.IdShort] = _valueTransformer.Transform(that, context);

                return valueOnlyResult;
            }

            var result = new JsonObject();

            if (that.Extensions != null)
            {
                var arrayExtensions = new JsonArray();
                foreach (Extension item in that.Extensions)
                {
                    arrayExtensions.Add(
                        Transform(
                            item, context));
                }
                result["extensions"] = arrayExtensions;
            }

            if (that.Category != null)
            {
                result["category"] = JsonValue.Create(
                    that.Category);
            }

            if (that.IdShort != null)
            {
                result["idShort"] = JsonValue.Create(
                    that.IdShort);
            }

            if (that.DisplayName != null)
            {
                result["displayName"] = Transform(
                    that.DisplayName, context);
            }

            if (that.Description != null)
            {
                result["description"] = Transform(
                    that.Description, context);
            }

            if (that.Checksum != null)
            {
                result["checksum"] = JsonValue.Create(
                    that.Checksum);
            }

            if (that.Kind != null)
            {
                // We need to help the static analyzer with a null coalescing.
                ModelingKind value = that.Kind
                    ?? throw new System.InvalidOperationException();
                result["kind"] = Serialize.ModelingKindToJsonValue(
                    value);
            }

            if (that.SemanticId != null)
            {
                result["semanticId"] = Transform(
                    that.SemanticId, context);
            }

            if (that.SupplementalSemanticIds != null)
            {
                var arraySupplementalSemanticIds = new JsonArray();
                foreach (Reference item in that.SupplementalSemanticIds)
                {
                    arraySupplementalSemanticIds.Add(
                        Transform(
                            item, context));
                }
                result["supplementalSemanticIds"] = arraySupplementalSemanticIds;
            }

            if (that.Qualifiers != null)
            {
                var arrayQualifiers = new JsonArray();
                foreach (Qualifier item in that.Qualifiers)
                {
                    arrayQualifiers.Add(
                        Transform(
                            item, context));
                }
                result["qualifiers"] = arrayQualifiers;
            }

            if (that.DataSpecifications != null)
            {
                var arrayDataSpecifications = new JsonArray();
                foreach (Reference item in that.DataSpecifications)
                {
                    arrayDataSpecifications.Add(
                        Transform(
                            item, context));
                }
                result["dataSpecifications"] = arrayDataSpecifications;
            }

            if (!string.IsNullOrEmpty(context.Content) && !context.Content.Equals("metadata", StringComparison.OrdinalIgnoreCase))
            {
                result["first"] = Transform(
                        that.First, context);

                result["second"] = Transform(
                    that.Second, context);

                if (that.Annotations != null)
                {
                    var arrayAnnotations = new JsonArray();
                    foreach (IDataElement item in that.Annotations)
                    {
                        arrayAnnotations.Add(
                            Transform(
                                item, context));
                    }
                    result["annotations"] = arrayAnnotations;
                }
            }

            result["modelType"] = "AnnotatedRelationshipElement";

            return result;
        }

        public JsonObject Transform(Entity that, OutputModifierContext context)
        {
            if (context.Content.Equals("reference", StringComparison.OrdinalIgnoreCase))
            {
                var reference = that.GetModelReference();
                return Transform(reference, context);
            }
            //if content is Value
            if (context.Content.Equals("value", StringComparison.OrdinalIgnoreCase))
            {
                var valueOnlyResult = new JsonObject();

                valueOnlyResult[that.IdShort] = _valueTransformer.Transform(that, context);

                return valueOnlyResult;
            }

            var result = new JsonObject();

            if (that.Extensions != null)
            {
                var arrayExtensions = new JsonArray();
                foreach (Extension item in that.Extensions)
                {
                    arrayExtensions.Add(
                        Transform(
                            item, context));
                }
                result["extensions"] = arrayExtensions;
            }

            if (that.Category != null)
            {
                result["category"] = JsonValue.Create(
                    that.Category);
            }

            if (that.IdShort != null)
            {
                result["idShort"] = JsonValue.Create(
                    that.IdShort);
            }

            if (that.DisplayName != null)
            {
                result["displayName"] = Transform(
                    that.DisplayName, context);
            }

            if (that.Description != null)
            {
                result["description"] = Transform(
                    that.Description, context);
            }

            if (that.Checksum != null)
            {
                result["checksum"] = JsonValue.Create(
                    that.Checksum);
            }

            if (that.Kind != null)
            {
                // We need to help the static analyzer with a null coalescing.
                ModelingKind value = that.Kind
                    ?? throw new System.InvalidOperationException();
                result["kind"] = Serialize.ModelingKindToJsonValue(
                    value);
            }

            if (that.SemanticId != null)
            {
                result["semanticId"] = Transform(
                    that.SemanticId, context);
            }

            if (that.SupplementalSemanticIds != null)
            {
                var arraySupplementalSemanticIds = new JsonArray();
                foreach (Reference item in that.SupplementalSemanticIds)
                {
                    arraySupplementalSemanticIds.Add(
                        Transform(
                            item, context));
                }
                result["supplementalSemanticIds"] = arraySupplementalSemanticIds;
            }

            if (that.Qualifiers != null)
            {
                var arrayQualifiers = new JsonArray();
                foreach (Qualifier item in that.Qualifiers)
                {
                    arrayQualifiers.Add(
                        Transform(
                            item, context));
                }
                result["qualifiers"] = arrayQualifiers;
            }

            if (that.DataSpecifications != null)
            {
                var arrayDataSpecifications = new JsonArray();
                foreach (Reference item in that.DataSpecifications)
                {
                    arrayDataSpecifications.Add(
                        Transform(
                            item, context));
                }
                result["dataSpecifications"] = arrayDataSpecifications;
            }

            if (that.Statements != null)
            {
                if (context.IncludeChildren)  //Include only direct children
                {
                    if (context.Level.Equals("core", StringComparison.OrdinalIgnoreCase))
                    {
                        context.IncludeChildren = false;
                    }
                    var arrayStatements = new JsonArray();
                    foreach (ISubmodelElement item in that.Statements)
                    {
                        arrayStatements.Add(
                            Transform(
                                item, context));
                    }
                    result["statements"] = arrayStatements;
                }
            }

            if (!context.Content.Equals("metadata", StringComparison.OrdinalIgnoreCase))
            {
                if (that.GlobalAssetId != null)
                {
                    result["globalAssetId"] = Transform(
                        that.GlobalAssetId, context);
                }

                if (that.SpecificAssetId != null)
                {
                    result["specificAssetId"] = Transform(
                        that.SpecificAssetId, context);
                }
            }

            result["entityType"] = Serialize.EntityTypeToJsonValue(
                that.EntityType);

            result["modelType"] = "Entity";

            return result;
        }

        public JsonObject Transform(EventPayload that, OutputModifierContext context)
        {
            var result = new JsonObject();

            result["source"] = Transform(
                that.Source, context);

            if (that.SourceSemanticId != null)
            {
                result["sourceSemanticId"] = Transform(
                    that.SourceSemanticId, context);
            }

            result["observableReference"] = Transform(
                that.ObservableReference, context);

            if (that.ObservableSemanticId != null)
            {
                result["observableSemanticId"] = Transform(
                    that.ObservableSemanticId, context);
            }

            if (that.Topic != null)
            {
                result["topic"] = JsonValue.Create(
                    that.Topic);
            }

            if (that.SubjectId != null)
            {
                result["subjectId"] = Transform(
                    that.SubjectId, context);
            }

            result["timeStamp"] = JsonValue.Create(
                that.TimeStamp);

            if (that.Payload != null)
            {
                result["payload"] = JsonValue.Create(
                    that.Payload);
            }

            return result;
        }

        public JsonObject Transform(BasicEventElement that, OutputModifierContext context)
        {
            if (context.Content.Equals("reference", StringComparison.OrdinalIgnoreCase))
            {
                var reference = that.GetModelReference();
                return Transform(reference, context);
            }
            //if content is Value
            if (context.Content.Equals("value", StringComparison.OrdinalIgnoreCase))
            {
                var valueOnlyResult = new JsonObject();

                valueOnlyResult[that.IdShort] = _valueTransformer.Transform(that, context);

                return valueOnlyResult;
            }

            var result = new JsonObject();

            if (that.Extensions != null)
            {
                var arrayExtensions = new JsonArray();
                foreach (Extension item in that.Extensions)
                {
                    arrayExtensions.Add(
                        Transform(
                            item, context));
                }
                result["extensions"] = arrayExtensions;
            }

            if (that.Category != null)
            {
                result["category"] = JsonValue.Create(
                    that.Category);
            }

            if (that.IdShort != null)
            {
                result["idShort"] = JsonValue.Create(
                    that.IdShort);
            }

            if (that.DisplayName != null)
            {
                result["displayName"] = Transform(
                    that.DisplayName, context);
            }

            if (that.Description != null)
            {
                result["description"] = Transform(
                    that.Description, context);
            }

            if (that.Checksum != null)
            {
                result["checksum"] = JsonValue.Create(
                    that.Checksum);
            }

            if (that.Kind != null)
            {
                // We need to help the static analyzer with a null coalescing.
                ModelingKind value = that.Kind
                    ?? throw new System.InvalidOperationException();
                result["kind"] = Serialize.ModelingKindToJsonValue(
                    value);
            }

            if (that.SemanticId != null)
            {
                result["semanticId"] = Transform(
                    that.SemanticId, context);
            }

            if (that.SupplementalSemanticIds != null)
            {
                var arraySupplementalSemanticIds = new JsonArray();
                foreach (Reference item in that.SupplementalSemanticIds)
                {
                    arraySupplementalSemanticIds.Add(
                        Transform(
                            item, context));
                }
                result["supplementalSemanticIds"] = arraySupplementalSemanticIds;
            }

            if (that.Qualifiers != null)
            {
                var arrayQualifiers = new JsonArray();
                foreach (Qualifier item in that.Qualifiers)
                {
                    arrayQualifiers.Add(
                        Transform(
                            item, context));
                }
                result["qualifiers"] = arrayQualifiers;
            }

            if (that.DataSpecifications != null)
            {
                var arrayDataSpecifications = new JsonArray();
                foreach (Reference item in that.DataSpecifications)
                {
                    arrayDataSpecifications.Add(
                        Transform(
                            item, context));
                }
                result["dataSpecifications"] = arrayDataSpecifications;
            }

            if (!string.IsNullOrEmpty(context.Content) && !context.Content.Equals("metadata", StringComparison.OrdinalIgnoreCase))
            {
                result["observed"] = Transform(
                        that.Observed, context);
            }

            result["direction"] = Serialize.DirectionToJsonValue(
                that.Direction);

            result["state"] = Serialize.StateOfEventToJsonValue(
                that.State);

            if (that.MessageTopic != null)
            {
                result["messageTopic"] = JsonValue.Create(
                    that.MessageTopic);
            }

            if (that.MessageBroker != null)
            {
                result["messageBroker"] = Transform(
                    that.MessageBroker, context);
            }

            if (that.LastUpdate != null)
            {
                result["lastUpdate"] = JsonValue.Create(
                    that.LastUpdate);
            }

            if (that.MinInterval != null)
            {
                result["minInterval"] = JsonValue.Create(
                    that.MinInterval);
            }

            if (that.MaxInterval != null)
            {
                result["maxInterval"] = JsonValue.Create(
                    that.MaxInterval);
            }

            result["modelType"] = "BasicEventElement";

            return result;
        }

        public JsonObject Transform(Operation that, OutputModifierContext context)
        {
            if (context.Content.Equals("reference", StringComparison.OrdinalIgnoreCase))
            {
                var reference = that.GetModelReference();
                return Transform(reference, context);
            }
            var result = new JsonObject();

            if (that.Extensions != null)
            {
                var arrayExtensions = new JsonArray();
                foreach (Extension item in that.Extensions)
                {
                    arrayExtensions.Add(
                        Transform(
                            item, context));
                }
                result["extensions"] = arrayExtensions;
            }

            if (that.Category != null)
            {
                result["category"] = JsonValue.Create(
                    that.Category);
            }

            if (that.IdShort != null)
            {
                result["idShort"] = JsonValue.Create(
                    that.IdShort);
            }

            if (that.DisplayName != null)
            {
                result["displayName"] = Transform(
                    that.DisplayName, context);
            }

            if (that.Description != null)
            {
                result["description"] = Transform(
                    that.Description, context);
            }

            if (that.Checksum != null)
            {
                result["checksum"] = JsonValue.Create(
                    that.Checksum);
            }

            if (that.Kind != null)
            {
                // We need to help the static analyzer with a null coalescing.
                ModelingKind value = that.Kind
                    ?? throw new System.InvalidOperationException();
                result["kind"] = Serialize.ModelingKindToJsonValue(
                    value);
            }

            if (that.SemanticId != null)
            {
                result["semanticId"] = Transform(
                    that.SemanticId, context);
            }

            if (that.SupplementalSemanticIds != null)
            {
                var arraySupplementalSemanticIds = new JsonArray();
                foreach (Reference item in that.SupplementalSemanticIds)
                {
                    arraySupplementalSemanticIds.Add(
                        Transform(
                            item, context));
                }
                result["supplementalSemanticIds"] = arraySupplementalSemanticIds;
            }

            if (that.Qualifiers != null)
            {
                var arrayQualifiers = new JsonArray();
                foreach (Qualifier item in that.Qualifiers)
                {
                    arrayQualifiers.Add(
                        Transform(
                            item, context));
                }
                result["qualifiers"] = arrayQualifiers;
            }

            if (that.DataSpecifications != null)
            {
                var arrayDataSpecifications = new JsonArray();
                foreach (Reference item in that.DataSpecifications)
                {
                    arrayDataSpecifications.Add(
                        Transform(
                            item, context));
                }
                result["dataSpecifications"] = arrayDataSpecifications;
            }

            if (that.InputVariables != null)
            {
                var arrayInputVariables = new JsonArray();
                foreach (OperationVariable item in that.InputVariables)
                {
                    arrayInputVariables.Add(
                        Transform(
                            item, context));
                }
                result["inputVariables"] = arrayInputVariables;
            }

            if (that.OutputVariables != null)
            {
                var arrayOutputVariables = new JsonArray();
                foreach (OperationVariable item in that.OutputVariables)
                {
                    arrayOutputVariables.Add(
                        Transform(
                            item, context));
                }
                result["outputVariables"] = arrayOutputVariables;
            }

            if (that.InoutputVariables != null)
            {
                var arrayInoutputVariables = new JsonArray();
                foreach (OperationVariable item in that.InoutputVariables)
                {
                    arrayInoutputVariables.Add(
                        Transform(
                            item, context));
                }
                result["inoutputVariables"] = arrayInoutputVariables;
            }

            result["modelType"] = "Operation";

            return result;
        }

        public JsonObject Transform(OperationVariable that, OutputModifierContext context)
        {
            var result = new JsonObject();

            result["value"] = Transform(
                that.Value, context);

            return result;
        }

        public JsonObject Transform(Capability that, OutputModifierContext context)
        {
            if (context.Content.Equals("reference", StringComparison.OrdinalIgnoreCase))
            {
                var reference = that.GetModelReference();
                return Transform(reference, context);
            }
            var result = new JsonObject();

            if (that.Extensions != null)
            {
                var arrayExtensions = new JsonArray();
                foreach (Extension item in that.Extensions)
                {
                    arrayExtensions.Add(
                        Transform(
                            item, context));
                }
                result["extensions"] = arrayExtensions;
            }

            if (that.Category != null)
            {
                result["category"] = JsonValue.Create(
                    that.Category);
            }

            if (that.IdShort != null)
            {
                result["idShort"] = JsonValue.Create(
                    that.IdShort);
            }

            if (that.DisplayName != null)
            {
                result["displayName"] = Transform(
                    that.DisplayName, context);
            }

            if (that.Description != null)
            {
                result["description"] = Transform(
                    that.Description, context);
            }

            if (that.Checksum != null)
            {
                result["checksum"] = JsonValue.Create(
                    that.Checksum);
            }

            if (that.Kind != null)
            {
                // We need to help the static analyzer with a null coalescing.
                ModelingKind value = that.Kind
                    ?? throw new System.InvalidOperationException();
                result["kind"] = Serialize.ModelingKindToJsonValue(
                    value);
            }

            if (that.SemanticId != null)
            {
                result["semanticId"] = Transform(
                    that.SemanticId, context);
            }

            if (that.SupplementalSemanticIds != null)
            {
                var arraySupplementalSemanticIds = new JsonArray();
                foreach (Reference item in that.SupplementalSemanticIds)
                {
                    arraySupplementalSemanticIds.Add(
                        Transform(
                            item, context));
                }
                result["supplementalSemanticIds"] = arraySupplementalSemanticIds;
            }

            if (that.Qualifiers != null)
            {
                var arrayQualifiers = new JsonArray();
                foreach (Qualifier item in that.Qualifiers)
                {
                    arrayQualifiers.Add(
                        Transform(
                            item, context));
                }
                result["qualifiers"] = arrayQualifiers;
            }

            if (that.DataSpecifications != null)
            {
                var arrayDataSpecifications = new JsonArray();
                foreach (Reference item in that.DataSpecifications)
                {
                    arrayDataSpecifications.Add(
                        Transform(
                            item, context));
                }
                result["dataSpecifications"] = arrayDataSpecifications;
            }

            result["modelType"] = "Capability";

            return result;
        }

        public JsonObject Transform(ConceptDescription that, OutputModifierContext context)
        {
            var result = new JsonObject();

            if (that.Extensions != null)
            {
                var arrayExtensions = new JsonArray();
                foreach (Extension item in that.Extensions)
                {
                    arrayExtensions.Add(
                        Transform(
                            item, context));
                }
                result["extensions"] = arrayExtensions;
            }

            if (that.Category != null)
            {
                result["category"] = JsonValue.Create(
                    that.Category);
            }

            if (that.IdShort != null)
            {
                result["idShort"] = JsonValue.Create(
                    that.IdShort);
            }

            if (that.DisplayName != null)
            {
                result["displayName"] = Transform(
                    that.DisplayName, context);
            }

            if (that.Description != null)
            {
                result["description"] = Transform(
                    that.Description, context);
            }

            if (that.Checksum != null)
            {
                result["checksum"] = JsonValue.Create(
                    that.Checksum);
            }

            if (that.Administration != null)
            {
                result["administration"] = Transform(
                    that.Administration, context);
            }

            result["id"] = JsonValue.Create(
                that.Id);

            if (that.DataSpecifications != null)
            {
                var arrayDataSpecifications = new JsonArray();
                foreach (Reference item in that.DataSpecifications)
                {
                    arrayDataSpecifications.Add(
                        Transform(
                            item, context));
                }
                result["dataSpecifications"] = arrayDataSpecifications;
            }

            if (that.IsCaseOf != null)
            {
                var arrayIsCaseOf = new JsonArray();
                foreach (Reference item in that.IsCaseOf)
                {
                    arrayIsCaseOf.Add(
                        Transform(
                            item, context));
                }
                result["isCaseOf"] = arrayIsCaseOf;
            }

            result["modelType"] = "ConceptDescription";

            return result;
        }

        public JsonObject Transform(Reference that, OutputModifierContext context)
        {

            var result = new JsonObject();

            result["type"] = Serialize.ReferenceTypesToJsonValue(
                that.Type);

            if (that.ReferredSemanticId != null)
            {
                result["referredSemanticId"] = Transform(
                    that.ReferredSemanticId, context);
            }

            var arrayKeys = new JsonArray();
            foreach (Key item in that.Keys)
            {
                arrayKeys.Add(
                    Transform(
                        item, context));
            }
            result["keys"] = arrayKeys;

            return result;
        }

        public JsonObject Transform(Key that, OutputModifierContext context)
        {
            var result = new JsonObject();

            result["type"] = Serialize.KeyTypesToJsonValue(
                that.Type);

            result["value"] = JsonValue.Create(
                that.Value);

            return result;
        }

        public JsonObject Transform(LangString that, OutputModifierContext context)
        {
            var result = new JsonObject();

            result["language"] = JsonValue.Create(
                that.Language);

            result["text"] = JsonValue.Create(
                that.Text);

            return result;
        }

        public JsonObject Transform(LangStringSet that, OutputModifierContext context)
        {
            var result = new JsonObject();

            var arrayLangStrings = new JsonArray();
            foreach (LangString item in that.LangStrings)
            {
                arrayLangStrings.Add(
                    Transform(
                        item, context));
            }
            result["langStrings"] = arrayLangStrings;

            return result;
        }

        public JsonObject Transform(DataSpecificationContent that, OutputModifierContext context)
        {
            var result = new JsonObject();

            return result;
        }

        public JsonObject Transform(DataSpecification that, OutputModifierContext context)
        {
            var result = new JsonObject();

            result["id"] = JsonValue.Create(
                that.Id);

            result["dataSpecificationContent"] = Transform(
                that.DataSpecificationContent, context);

            if (that.Administration != null)
            {
                result["administration"] = Transform(
                    that.Administration, context);
            }

            if (that.Description != null)
            {
                result["description"] = Transform(
                    that.Description, context);
            }

            return result;
        }

        public JsonObject Transform(AasCore.Aas3_0_RC02.Environment that, OutputModifierContext context)
        {
            var result = new JsonObject();

            if (that.AssetAdministrationShells != null)
            {
                var arrayAssetAdministrationShells = new JsonArray();
                foreach (AssetAdministrationShell item in that.AssetAdministrationShells)
                {
                    arrayAssetAdministrationShells.Add(
                        Transform(
                            item, context));
                }
                result["assetAdministrationShells"] = arrayAssetAdministrationShells;
            }

            if (that.Submodels != null)
            {
                var arraySubmodels = new JsonArray();
                foreach (Submodel item in that.Submodels)
                {
                    arraySubmodels.Add(
                        Transform(
                            item, context));
                }
                result["submodels"] = arraySubmodels;
            }

            if (that.ConceptDescriptions != null)
            {
                var arrayConceptDescriptions = new JsonArray();
                foreach (ConceptDescription item in that.ConceptDescriptions)
                {
                    arrayConceptDescriptions.Add(
                        Transform(
                            item, context));
                }
                result["conceptDescriptions"] = arrayConceptDescriptions;
            }

            if (that.DataSpecifications != null)
            {
                var arrayDataSpecifications = new JsonArray();
                foreach (DataSpecification item in that.DataSpecifications)
                {
                    arrayDataSpecifications.Add(
                        Transform(
                            item, context));
                }
                result["dataSpecifications"] = arrayDataSpecifications;
            }

            return result;
        }

        public JsonObject Transform(IClass that, OutputModifierContext context)
        {
            return that.Transform(this, context);
        }
    }
}
